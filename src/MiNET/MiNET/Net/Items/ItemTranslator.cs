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
// All portions of the code written by Niclas Olofsson are Copyright (c) 2014-2023 Niclas Olofsson.
// All Rights Reserved.
#endregion

using System;
using System.Collections.Generic;
using log4net;
using MiNET.Items;
using MiNET.Utils;

namespace MiNET.Net.Items
{
	public class ItemTranslator
	{
		private static readonly ILog Log = LogManager.GetLogger(typeof(ItemTranslator));
		
		private IDictionary<int, TranslatedItem> _networkIdToInternal;
		private IDictionary<int, int> _simpleNetworkIdToInternal;

		private Dictionary<int, ComplexMappingEntry> _internalIdToNetwork;
		private Dictionary<int, int> _simpleInternalIdToNetwork;

		private Dictionary<string, string> _internalNameToNetworkName;
		private metaToName<string, int, string> _metaToName;
		private Dictionary<string, int> _metaList;
		private Dictionary<string, string> _metaMapList;

		public ItemTranslator(Itemstates itemstates)
		{
			var internalNameToNetworkName = new Dictionary<string, string>(StringComparer.Ordinal);
			var legacyTranslations = ResourceUtil.ReadResource<Dictionary<string, short>>("item_id_map.json", typeof(Item));
			var metaMapRes = ResourceUtil.ReadResource<Dictionary<string, Dictionary<string, string>>>("block_meta_map.json", typeof(Item));

			var simpleMappings = new Dictionary<string, short>();
			var metaToNameList = new metaToName<string, int, string>();
			var metaList = new Dictionary<string, int>();
			var metaMapList = new Dictionary<string, string>();

			foreach (var entry in legacyTranslations)
			{
				var stringId = entry.Key;
				var integerId = entry.Value;
				
				simpleMappings[stringId] = integerId;
				internalNameToNetworkName[stringId] = stringId;
			}

			var complexMapping = new Dictionary<string, TranslatedItem>();
			foreach (var entry in metaMapRes)
			{
				string oldId = entry.Key;
				if (!legacyTranslations.ContainsKey(oldId))
					continue;
				metaToNameList[entry.Key] = new metaToName<int, string>();
				var legacyIntegerId = legacyTranslations[oldId];
				foreach (var mappingEntry in entry.Value)
				{
					metaToNameList[entry.Key].TryAdd(int.Parse(mappingEntry.Key), mappingEntry.Value);
					metaList.TryAdd(mappingEntry.Value, int.Parse(mappingEntry.Key));
					metaMapList.TryAdd(mappingEntry.Value, entry.Key);
					var newId = mappingEntry.Value;
					if (short.TryParse(mappingEntry.Key, out var meta))
					{
						if (!complexMapping.TryAdd(newId, new TranslatedItem(legacyIntegerId, meta)))
						{
							Log.Debug($"Duplicate complex... OldId={oldId} NewId={newId} (IntegerID={legacyIntegerId} Meta={meta})");
						}
					}
				}
			}
			
			var internalToNetwork = new Dictionary<int, ComplexMappingEntry>();
			var simpleInternalToNetwork = new Dictionary<int, int>();
			var networkIdToInternal = new Dictionary<int, TranslatedItem>();
			var simpleNetworkIdToInternal = new Dictionary<int, int>();
			foreach (var state in itemstates)
			{
				var stringId = state.Name;
				var netId = state.Id;

				if (complexMapping.TryGetValue(stringId, out var translatedItem))
				{
					var internalId = translatedItem.Id;
					var internalMeta = translatedItem.Meta;
					
					ComplexMappingEntry mappingEntry;

					if (!internalToNetwork.TryGetValue(internalId, out mappingEntry))
					{
						mappingEntry = new ComplexMappingEntry();
						internalToNetwork.Add(internalId, mappingEntry);
					}

					mappingEntry.Add(internalMeta, netId);
					
					internalToNetwork[internalId] = mappingEntry;
					networkIdToInternal.Add(netId, translatedItem);
				}
				else if (simpleMappings.TryGetValue(stringId, out var legacyId))
				{
					simpleNetworkIdToInternal.Add(netId, legacyId);
					simpleInternalToNetwork.Add(legacyId, netId);
				}
			}

			_internalIdToNetwork = internalToNetwork;
			_simpleInternalIdToNetwork = simpleInternalToNetwork;
			_networkIdToInternal = networkIdToInternal;
			_simpleNetworkIdToInternal = simpleNetworkIdToInternal;
			_internalNameToNetworkName = internalNameToNetworkName;
			_metaToName = metaToNameList;
			_metaList = metaList;
			_metaMapList = metaMapList;
		}

		public string GetNameByMeta(string cname, int meta)
		{
			if (_metaToName[cname].TryGetValue(meta, out var name))
			{
				return name;
			}
			return null;
		}

		public byte GetMetaByName(string name)
		{
			if (_metaList.TryGetValue(name, out var meta))
			{
				return (byte)meta;
			}
			return 255;
		}

		public string GetMetaMapByName(string name)
		{
			if (_metaMapList.TryGetValue(name, out var mapName))
			{
				return mapName;
			}
			return null;
		}

		internal bool TryGetNetworkId(int id, short meta, out TranslatedItem item)
		{
			int netId;
			if (_internalIdToNetwork.TryGetValue(id, out var complex) && complex.TryGet(meta, out netId))
			{
				item = new TranslatedItem(netId, 0);
				return true;
			}
			else if (_simpleInternalIdToNetwork.TryGetValue(id, out netId))
			{
				item = new TranslatedItem(netId, meta);
				return true;
			}

			item = default;
			return false;
		}
		
		internal TranslatedItem ToNetworkId(int id, short meta)
		{
			int netId;
			if (_internalIdToNetwork.TryGetValue(id, out var complex) && complex.TryGet(meta, out netId))
			{
				id = netId;
				meta = 0;
			}
			else if (_simpleInternalIdToNetwork.TryGetValue(id, out netId))
			{
				id = netId;
			}

			return new TranslatedItem(id, meta);
		}
		
		internal TranslatedItem FromNetworkId(int id, short meta)
		{
			if (_networkIdToInternal.TryGetValue(id, out var value))
			{
				id = value.Id;
				meta = value.Meta;
			}
			else if (_simpleNetworkIdToInternal.TryGetValue(id, out var simpleValue))
			{
				id = simpleValue;
			}

			return new TranslatedItem(id, meta);
		}

		public bool TryGetName(string input, out string output)
		{
			return _internalNameToNetworkName.TryGetValue(input, out output);
		}
	}

	public class metaToName<metaId, name> :
		Dictionary<metaId, name>
	{
	}

	public class metaToName<map, meta, name> :
		Dictionary<map, metaToName<meta, name>>
	{
	}

	internal class TranslatedItem : IEquatable<TranslatedItem>
	{
		public int Id { get; }
		public short Meta { get; }

		public TranslatedItem(int id, short meta)
		{
			Id = id;
			Meta = meta;
		}

		/// <inheritdoc />
		public bool Equals(TranslatedItem other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return Id == other.Id && Meta == other.Meta;
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;

			return Equals((TranslatedItem)obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Meta);
		}
	}

	internal class ComplexMappingEntry
	{
		private Dictionary<short, int> _mapping = new Dictionary<short, int>();
		public void Add(short meta, short translatedItem)
		{
			_mapping.Add(meta, translatedItem);
		}

		public bool TryGet(short meta, out int result)
		{
			return _mapping.TryGetValue(meta, out result);
		}
	}
}