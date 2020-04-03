﻿#region LICENSE

// The contents of this file are subject to the Common Public Attribution
// License Version 1.0. (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
// https://github.com/NiclasOlofsson/MiNET/blob/master/LICENSE.
// The License is based on the Mozilla Public License Version 1.1, but Sections 14
// and 15 have been added to cover use of software over a computer network and
// provide for limited attribution for the Original Developer. In addition, Exhibit A has
// been modified to be consistent with Exhibit B.
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
// the specific language governing rights and limitations under the License.
// 
// The Original Code is MiNET.
// 
// The Original Developer is the Initial Developer.  The Initial Developer of
// the Original Code is Niclas Olofsson.
// 
// All portions of the code written by Niclas Olofsson are Copyright (c) 2014-2020 Niclas Olofsson.
// All Rights Reserved.

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using log4net;
using MiNET.Net.RakNet;
using MiNET.Utils;

namespace MiNET.Net
{
	public class BedrockClientMessageHandler : ICustomMessageHandler
	{
		private static readonly ILog Log = LogManager.GetLogger(typeof(BedrockMessageHandler));

		private readonly RakSession _session;

		public McpeClientMessageDispatcher MessageDispatcher { get; set; }
		public CryptoContext CryptoContext { get; set; }

		public Action ConnectionAction { get; set; }

		public BedrockClientMessageHandler(RakSession session, IMcpeClientMessageHandler handler)
		{
			_session = session;
			MessageDispatcher = new McpeClientMessageDispatcher(handler);
		}


		public void Connected()
		{
			ConnectionAction?.Invoke();
		}

		public void Disconnect(string reason, bool sendDisconnect = true)
		{
		}

		public void HandlePacket(Packet message)
		{
			if (message is McpeWrapper wrapper)
			{

				var messages = new List<Packet>();

				// Get bytes to process
				ReadOnlyMemory<byte> payload = wrapper.payload;

				// Decrypt bytes

				if (CryptoContext != null && CryptoContext.UseEncryption)
				{
					// This call copies the entire buffer, but what can we do? It is kind of compensated by not
					// creating a new buffer when parsing the packet (only a mem-slice)
					payload = CryptoUtils.Decrypt(payload, CryptoContext);
				}

				// Decompress bytes

				var stream = new MemoryStreamReader(payload.Slice(0, payload.Length - 4)); // slice away adler
				if (stream.ReadByte() != 0x78)
				{
					if (Log.IsDebugEnabled) Log.Error($"Incorrect ZLib header. Expected 0x78 0x9C 0x{wrapper.Id:X2}\n{Packet.HexDump(wrapper.payload)}");
					if (Log.IsDebugEnabled) Log.Error($"Incorrect ZLib header. Decrypted 0x{wrapper.Id:X2}\n{Packet.HexDump(payload)}");
					throw new InvalidDataException("Incorrect ZLib header. Expected 0x78 0x9C");
				}
				stream.ReadByte();
				using (var deflateStream = new DeflateStream(stream, CompressionMode.Decompress, false))
				{
					using var s = new MemoryStream();
					deflateStream.CopyTo(s);
					s.Position = 0;

					// Get actual packet out of bytes
					while (s.Position < s.Length)
					{
						int len = (int) VarInt.ReadUInt32(s);
						Memory<byte> internalBuffer = new byte[len];
						s.Read(internalBuffer.Span);
						int id = internalBuffer.Span[0];
						internalBuffer = internalBuffer.Slice(id > 127 ? 2 : 1); //TODO: This is stupid. Get rid of the id slicing

						//if (Log.IsDebugEnabled)
						//	Log.Debug($"0x{internalBuffer[0]:x2}\n{Packet.HexDump(internalBuffer)}");

						try
						{
							messages.Add(PacketFactory.Create((byte) id, internalBuffer, "mcpe") ??
										new UnknownPacket((byte) id, internalBuffer));
						}
						catch (Exception)
						{
							if (Log.IsDebugEnabled) Log.Warn($"Error parsing packet 0x{wrapper.Id:X2}\n{Packet.HexDump(internalBuffer)}");
							throw;
						}
					}

					if (s.Length > s.Position) throw new Exception("Have more data");
				}

				foreach (Packet msg in messages)
				{
					// Temp fix for performance, take 1.
					//var interact = msg as McpeInteract;
					//if (interact?.actionId == 4 && interact.targetRuntimeEntityId == 0) continue;

					msg.ReliabilityHeader = new ReliabilityHeader()
					{
						Reliability = wrapper.ReliabilityHeader.Reliability,
						ReliableMessageNumber = wrapper.ReliabilityHeader.ReliableMessageNumber,
						OrderingChannel = wrapper.ReliabilityHeader.OrderingChannel,
						OrderingIndex = wrapper.ReliabilityHeader.OrderingIndex,
					};

					RakProcessor.TraceReceive(msg);
					MessageDispatcher.HandlePacket(msg);
				}

				wrapper.PutPool();
			}
			else if (message is UnknownPacket unknownPacket)
			{
				if (Log.IsDebugEnabled) Log.Warn($"Received unknown packet 0x{unknownPacket.Id:X2}\n{Packet.HexDump(unknownPacket.Message)}");

				unknownPacket.PutPool();
			}
			else
			{
				Log.Error($"Unhandled packet: {message.GetType().Name} 0x{message.Id:X2} for user: {_session.Username}, IP {_session.EndPoint.Address}");
				if (Log.IsDebugEnabled) Log.Warn($"Unknown packet 0x{message.Id:X2}\n{Packet.HexDump(message.Bytes)}");
			}
		}
	}
}