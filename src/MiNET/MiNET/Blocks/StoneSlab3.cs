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

using MiNET.Utils.Vectors;
using MiNET.Worlds;
using System.Numerics;
using System;

namespace MiNET.Blocks
{
	public partial class StoneBlockSlab3 : Block
	{
		public StoneBlockSlab3() : base(417)
		{
			BlastResistance = 30;
			Hardness = 2;
			IsTransparent = true; // Partial - blocks light.
			IsBlockingSkylight = false; // Partial - blocks light.
		}

		public override bool PlaceBlock(Level world, Player player, BlockCoordinates blockCoordinates, BlockFace face, Vector3 faceCoords)
		{
			var itemInHand = player.Inventory.GetItemInHand();
			StoneSlabType3 = itemInHand.Metadata switch
			{
				0 => "smooth_red_sandstone",
				1 => "granite",
				2 => "polished_granite",
				3 => "diorite",
				4 => "polished_diorite",
				5 => "andesite",
				6 => "polished_andesite",
				7 => "end_stone_brick",
				_ => throw new ArgumentOutOfRangeException()
			};

			verticalHalf = (faceCoords.Y > 0.5 && face != BlockFace.Up) switch
			{
				true => "top",
				false => "bottom"
			};
			return false;
		}
	}
}