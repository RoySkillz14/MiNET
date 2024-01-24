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
using MiNET.Utils;

#pragma warning disable 1522

namespace MiNET.Blocks
{
	public partial class StoneBlockSlab // 44 typeof=StoneBlockSlab
	{
		public string StoneSlabType { get; set; } = "smooth_stone";
		public string verticalHalf { get; set; } = "bottom";

		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
					case BlockStateString s when s.Name == "minecraft:vertical_half":
						verticalHalf = s.Value;
						break;
					case BlockStateString s when s.Name == "stone_slab_type":
						StoneSlabType = s.Value;
						break;
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = "minecraft:stone_block_slab";
			record.Id = 44;
			record.States.Add(new BlockStateString { Name = "minecraft:vertical_half", Value = verticalHalf });
			record.States.Add(new BlockStateString { Name = "stone_slab_type", Value = StoneSlabType });
			return record;
		} // method
	} // class

	public partial class StoneBlockSlab2 // 182 typeof=StoneBlockSlab2
	{
		public string StoneSlabType2 { get; set; } = "mossy_cobblestone";
		public string verticalHalf { get; set; } = "bottom";

		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
					case BlockStateString s when s.Name == "minecraft:vertical_half":
						verticalHalf = s.Value;
						break;
					case BlockStateString s when s.Name == "stone_slab_type_2":
						StoneSlabType2 = s.Value;
						break;
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = "minecraft:stone_block_slab2";
			record.Id = 182;
			record.States.Add(new BlockStateString { Name = "minecraft:vertical_half", Value = verticalHalf });
			record.States.Add(new BlockStateString { Name = "stone_slab_type_2", Value = StoneSlabType2 });
			return record;
		} // method
	} // class

	public partial class StoneBlockSlab3 // 417 typeof=StoneBlockSlab3
	{
	public string StoneSlabType3 { get; set; } = "smooth_red_sandstone";
	public string verticalHalf { get; set; } = "bottom";

		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
					case BlockStateString s when s.Name == "minecraft:vertical_half":
						verticalHalf = s.Value;
						break;
					case BlockStateString s when s.Name == "stone_slab_type_3":
						StoneSlabType3 = s.Value;
						break;
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = "minecraft:stone_block_slab3";
			record.Id = 417;
			record.States.Add(new BlockStateString { Name = "minecraft:vertical_half", Value = verticalHalf });
			record.States.Add(new BlockStateString { Name = "stone_slab_type_3", Value = StoneSlabType3 });
			return record;
		} // method
	} // class

	public partial class StoneBlockSlab4 // 421 typeof=StoneBlockSlab4
	{
		public string StoneSlabType4 { get; set; } = "stone";
		public string verticalHalf { get; set; } = "bottom";

		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
					case BlockStateString s when s.Name == "minecraft:vertical_half":
						verticalHalf = s.Value;
						break;
					case BlockStateString s when s.Name == "stone_slab_type_4":
						StoneSlabType4 = s.Value;
						break;
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = "minecraft:stone_block_slab4";
			record.Id = 421;
			record.States.Add(new BlockStateString { Name = "minecraft:vertical_half", Value = verticalHalf });
			record.States.Add(new BlockStateString { Name = "stone_slab_type_4", Value = StoneSlabType4 });
			return record;
		} // method
	} // class

	public partial class Fence // 85 typeof=Fence
    {
		public string blockName { get; set; } = "minecraft:oak_fence";
		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = blockName;
            record.Id = 85;
            return record;
        } // method
    } // class

	public partial class Concrete // 236 typeof=Concrete
	{
		public string blockName { get; set; } = "minecraft:white_concrete";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 236;
			return record;
		} // method
	} // class

	public partial class ConcretePowder // 237 typeof=ConcretePowder
	{
		public string blockName { get; set; } = "minecraft:white_concrete_powder";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 237;
			return record;
		} // method
	} // class

	public partial class Wool // 35 typeof=Wool
	{
		public string blockName { get; set; } = "minecraft:white_wool";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 35;
			return record;
		} // method
	} // class

	public partial class StainedGlass // 241 typeof=StainedGlass
	{
		public string blockName { get; set; } = "minecraft:white_stained_glass";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 241;
			return record;
		} // method
	} // class

	public partial class StainedGlassPane // 160 typeof=StainedGlassPane
	{
		public string blockName { get; set; } = "minecraft:white_stained_glass_pane";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 160;
			return record;
		} // method
	} // class

	public partial class Carpet // 171 typeof=Carpet
	{
		public string blockName { get; set; } = "minecraft:white_carpet";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 171;
			return record;
		} // method
	} // class

	public partial class StainedHardenedClay // 159 typeof=Terracotta
	{
		public string blockName { get; set; } = "minecraft:white_terracotta";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 159;
			return record;
		} // method
	} // class

	public partial class Wood // 467 typeof=Wood
	{
		public string woodType { get; set; } = "oak";
		public string PillarAxis { get; set; } = "y";
		public bool StrippedBit { get; set; } = false;
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
					case BlockStateString s when s.Name == "wood_type":
						woodType = s.Value;
						break;
					case BlockStateString s when s.Name == "pillar_axis":
						PillarAxis = s.Value;
						break;
					case BlockStateByte s when s.Name == "stripped_bit":
						StrippedBit = Convert.ToBoolean(s.Value);
						break;
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = "minecraft:wood";
			record.Id = 467;
			record.States.Add(new BlockStateString { Name = "pillar_axis", Value = PillarAxis });
			record.States.Add(new BlockStateByte { Name = "stripped_bit", Value = Convert.ToByte(StrippedBit) });
			record.States.Add(new BlockStateString { Name = "wood_type", Value = woodType });
			return record;
		} // method
	} // class

	public partial class Log // 17 typeof=Log
	{
		public string blockName { get; set; } = "minecraft:oak_log";
		public string PillarAxis { get; set; } = "y";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
					case BlockStateString s when s.Name == "pillar_axis":
						PillarAxis = s.Value;
						break;
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 17; 
			record.States.Add(new BlockStateString { Name = "pillar_axis", Value = PillarAxis });
			return record;
		} // method
	} // class

	public partial class Log2 // 162 typeof=Log2
	{
		public string blockName { get; set; } = "minecraft:acacia_log";
		public string PillarAxis { get; set; } = "y";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
					case BlockStateString s when s.Name == "pillar_axis":
						PillarAxis = s.Value;
						break;
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 162;
			record.States.Add(new BlockStateString { Name = "pillar_axis", Value = PillarAxis });
			return record;
		} // method
	} // class

	public partial class ShulkerBox // 218 typeof=ShulkerBox
	{
		public string blockName { get; set; } = "minecraft:white_shulker_box";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 218;
			return record;
		} // method
	} // class

	public partial class UndyedShulkerBox // 205 typeof=UndyedShulkerBox
	{
		public string blockName { get; set; } = "minecraft:undyed_shulker_box";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 205;
			return record;
		} // method
	} // class


	public partial class AcaciaButton  // 395 typeof=AcaciaButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_button";
            record.Id = 395;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class AcaciaDoor  // 196 typeof=AcaciaDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_door";
            record.Id = 196;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class AcaciaFenceGate  // 187 typeof=AcaciaFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_fence_gate";
            record.Id = 187;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class AcaciaPressurePlate : PressurePlateBase // 405 typeof=AcaciaPressurePlate
	{
        public override int RedstoneSignal { get; set; } = 0;
        
        public AcaciaPressurePlate() : base(405)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_pressure_plate";
            record.Id = 405;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class AcaciaStairs  // 163 typeof=AcaciaStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_stairs";
            record.Id = 163;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class AcaciaStandingSign  // 445 typeof=AcaciaStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_standing_sign";
            record.Id = 445;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class AcaciaTrapdoor  // 400 typeof=AcaciaTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_trapdoor";
            record.Id = 400;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class AcaciaWallSign  // 446 typeof=AcaciaWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_wall_sign";
            record.Id = 446;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class ActivatorRail  // 126 typeof=ActivatorRail
    {
        [StateBit] public  bool RailDataBit { get; set; } = false;
        [StateRange(0, 5)] public  int RailDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "rail_data_bit":
                        RailDataBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "rail_direction":
                        RailDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:activator_rail";
            record.Id = 126;
            record.States.Add(new BlockStateByte {Name = "rail_data_bit", Value = Convert.ToByte(RailDataBit)});
            record.States.Add(new BlockStateInt {Name = "rail_direction", Value = RailDirection});
            return record;
        } // method
    } // class

    public partial class Air  // 0 typeof=Air
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:air";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Allow : Block // 0 typeof=Air
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:allow";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class AndesiteStairs  // 426 typeof=AndesiteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:andesite_stairs";
            record.Id = 426;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Anvil  // 145 typeof=Anvil
    {
		public  string Damage { get; set; } = "undamaged";
        public  string cardinalDirection { get; set; } = "south";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "damage":
                        Damage = s.Value;
                        break;
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:anvil";
            record.Id = 145;
            record.States.Add(new BlockStateString {Name = "damage", Value = Damage});
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class Bamboo : Block // 418 typeof=Bamboo
    {
        [StateBit] public  bool AgeBit { get; set; } = false;
        [StateEnum("small_leaves","large_leaves","no_leaves")]
        public  string BambooLeafSize { get; set; } = "";
        [StateEnum("thin","thick")]
        public  string BambooStalkThickness { get; set; } = "";
        
        public Bamboo() : base(418)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "age_bit":
                        AgeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "bamboo_leaf_size":
                        BambooLeafSize = s.Value;
                        break;
                    case BlockStateString s when s.Name == "bamboo_stalk_thickness":
                        BambooStalkThickness = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo";
            record.Id = 418;
            record.States.Add(new BlockStateByte {Name = "age_bit", Value = Convert.ToByte(AgeBit)});
            record.States.Add(new BlockStateString {Name = "bamboo_leaf_size", Value = BambooLeafSize});
            record.States.Add(new BlockStateString {Name = "bamboo_stalk_thickness", Value = BambooStalkThickness});
            return record;
        } // method
    } // class

    public partial class BambooSapling : Block // 419 typeof=BambooSapling
    {
        [StateBit] public  bool AgeBit { get; set; } = false;
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string SaplingType { get; set; } = "";
        
        public BambooSapling() : base(419)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "age_bit":
                        AgeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "sapling_type":
                        SaplingType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_sapling";
            record.Id = 419;
            record.States.Add(new BlockStateByte {Name = "age_bit", Value = Convert.ToByte(AgeBit)});
            record.States.Add(new BlockStateString {Name = "sapling_type", Value = SaplingType});
            return record;
        } // method
    } // class

    public partial class Barrel : Block // 458 typeof=Barrel
    {
        public int FacingDirection { get; set; } = 2;
        public bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateInt s when s.Name == "facing_direction":
						FacingDirection = s.Value;
						break;
					case BlockStateByte s when s.Name == "open_bit":
						OpenBit = Convert.ToBoolean(s.Value);
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:barrel";
            record.Id = 458;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class Barrier : Block // 416 typeof=Barrier
    {
        
        public Barrier() : base(416)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:barrier";
            record.Id = 416;
            return record;
        } // method
    } // class

    public partial class Beacon  // 138 typeof=Beacon
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:beacon";
            record.Id = 138;
            return record;
        } // method
    } // class

    public partial class Bed  // 26 typeof=Bed
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool HeadPieceBit { get; set; } = false;
        [StateBit] public  bool OccupiedBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "head_piece_bit":
                        HeadPieceBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "occupied_bit":
                        OccupiedBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bed";
            record.Id = 26;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "head_piece_bit", Value = Convert.ToByte(HeadPieceBit)});
            record.States.Add(new BlockStateByte {Name = "occupied_bit", Value = Convert.ToByte(OccupiedBit)});
            return record;
        } // method
    } // class

    public partial class Bedrock  // 7 typeof=Bedrock
    {
        [StateBit] public  bool InfiniburnBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "infiniburn_bit":
                        InfiniburnBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bedrock";
            record.Id = 7;
            record.States.Add(new BlockStateByte {Name = "infiniburn_bit", Value = Convert.ToByte(InfiniburnBit)});
            return record;
        } // method
    } // class

    public partial class BeeNest  // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateRange(0, 5)] public  int HoneyLevel { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "honey_level":
                        HoneyLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bee_nest";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateInt {Name = "honey_level", Value = HoneyLevel});
            return record;
        } // method
    } // class

    public partial class Beehive  // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateRange(0, 5)] public  int HoneyLevel { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "honey_level":
                        HoneyLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:beehive";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateInt {Name = "honey_level", Value = HoneyLevel});
            return record;
        } // method
    } // class

    public partial class Beetroot  // 244 typeof=Beetroot
    {
        [StateRange(0, 7)] public override int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:beetroot";
            record.Id = 244;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class Bell : Block // 461 typeof=Bell
    {
        [StateEnum("standing","hanging","side","multiple")]
        public  string Attachment { get; set; } = "standing";
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool ToggleBit { get; set; } = false;
        
        public Bell() : base(461)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "attachment":
                        Attachment = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "toggle_bit":
                        ToggleBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bell";
            record.Id = 461;
            record.States.Add(new BlockStateString {Name = "attachment", Value = Attachment});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "toggle_bit", Value = Convert.ToByte(ToggleBit)});
            return record;
        } // method
    } // class

    public partial class BirchButton  // 396 typeof=BirchButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_button";
            record.Id = 396;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BirchDoor  // 194 typeof=BirchDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_door";
            record.Id = 194;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class BirchFenceGate  // 184 typeof=BirchFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_fence_gate";
            record.Id = 184;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class BirchPressurePlate : PressurePlateBase // 406 typeof=BirchPressurePlate
	{
        public override int RedstoneSignal { get; set; } = 0;
        
        public BirchPressurePlate() : base(406)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_pressure_plate";
            record.Id = 406;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class BirchStairs  // 135 typeof=BirchStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_stairs";
            record.Id = 135;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class BirchStandingSign  // 441 typeof=BirchStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_standing_sign";
            record.Id = 441;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class BirchTrapdoor  // 401 typeof=BirchTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_trapdoor";
            record.Id = 401;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class BirchWallSign  // 442 typeof=BirchWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_wall_sign";
            record.Id = 442;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BlackGlazedTerracotta  // 235 typeof=BlackGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:black_glazed_terracotta";
            record.Id = 235;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BlastFurnace  // 451 typeof=BlastFurnace
    {
		public string cardinalDirection { get; set; } = "north";

		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blast_furnace";
            record.Id = 451;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class BlueGlazedTerracotta  // 231 typeof=BlueGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blue_glazed_terracotta";
            record.Id = 231;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BlueIce : Block // 266 typeof=BlueIce
    {
        
        public BlueIce() : base(266)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blue_ice";
            record.Id = 266;
            return record;
        } // method
    } // class

    public partial class BoneBlock : Block // 216 typeof=BoneBlock
    {
        [StateRange(0, 3)] public  int Deprecated { get; set; } = 0;
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "x";
        
        public BoneBlock() : base(216)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "deprecated":
                        Deprecated = s.Value;
                        break;
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bone_block";
            record.Id = 216;
            record.States.Add(new BlockStateInt {Name = "deprecated", Value = Deprecated});
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class Bookshelf  // 47 typeof=Bookshelf
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bookshelf";
            record.Id = 47;
            return record;
        } // method
    } // class

    public partial class BorderBlock  // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:border_block";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class BrewingStand  // 379 typeof=BrewingStand
	{
        [StateBit] public  bool BrewingStandSlotABit { get; set; } = false;
        [StateBit] public  bool BrewingStandSlotBBit { get; set; } = false;
        [StateBit] public  bool BrewingStandSlotCBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "brewing_stand_slot_a_bit":
                        BrewingStandSlotABit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "brewing_stand_slot_b_bit":
                        BrewingStandSlotBBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "brewing_stand_slot_c_bit":
                        BrewingStandSlotCBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brewing_stand";
            record.Id = 117;
            record.States.Add(new BlockStateByte {Name = "brewing_stand_slot_a_bit", Value = Convert.ToByte(BrewingStandSlotABit)});
            record.States.Add(new BlockStateByte {Name = "brewing_stand_slot_b_bit", Value = Convert.ToByte(BrewingStandSlotBBit)});
            record.States.Add(new BlockStateByte {Name = "brewing_stand_slot_c_bit", Value = Convert.ToByte(BrewingStandSlotCBit)});
            return record;
        } // method
    } // class

    public partial class BrickBlock  // 45 typeof=BrickBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brick_block";
            record.Id = 45;
            return record;
        } // method
    } // class

    public partial class BrickStairs  // 108 typeof=BrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brick_stairs";
            record.Id = 108;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class BrownGlazedTerracotta  // 232 typeof=BrownGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_glazed_terracotta";
            record.Id = 232;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BrownMushroom  // 39 typeof=BrownMushroom
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_mushroom";
            record.Id = 39;
            return record;
        } // method
    } // class

    public partial class BrownMushroomBlock  // 99 typeof=BrownMushroomBlock
    {
        [StateRange(0, 15)] public  int HugeMushroomBits { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "huge_mushroom_bits":
                        HugeMushroomBits = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_mushroom_block";
            record.Id = 99;
            record.States.Add(new BlockStateInt {Name = "huge_mushroom_bits", Value = HugeMushroomBits});
            return record;
        } // method
    } // class

    public partial class BubbleColumn : Block // 415 typeof=BubbleColumn
    {
        [StateBit] public  bool DragDown { get; set; } = false;
        
        public BubbleColumn() : base(415)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "drag_down":
                        DragDown = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bubble_column";
            record.Id = 415;
            record.States.Add(new BlockStateByte {Name = "drag_down", Value = Convert.ToByte(DragDown)});
            return record;
        } // method
    } // class

    public partial class Cactus  // 81 typeof=Cactus
    {
        [StateRange(0, 15)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cactus";
            record.Id = 81;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class Cake  // 92 typeof=Cake
    {
        [StateRange(0, 6)] public  int BiteCounter { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "bite_counter":
                        BiteCounter = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cake";
            record.Id = 92;
            record.States.Add(new BlockStateInt {Name = "bite_counter", Value = BiteCounter});
            return record;
        } // method
    } // class

    public partial class Camera  // 0 typeof=Air
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:camera";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Campfire : Block // 464 typeof=Campfire
    {
        [StateBit] public  bool Extinguished { get; set; } = false;
        [StateEnum("south","west","north","east")]
        public  string cardinalDirection { get; set; } = "south";
        
        public Campfire() : base(464)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "extinguished":
                        Extinguished = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:campfire";
            record.Id = 464;
            record.States.Add(new BlockStateByte {Name = "extinguished", Value = Convert.ToByte(Extinguished)});
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class Carrots  // 141 typeof=Carrots
    {
        [StateRange(0, 7)] public override int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:carrots";
            record.Id = 141;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class CartographyTable : Block // 455 typeof=CartographyTable
    {
        
        public CartographyTable() : base(455)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cartography_table";
            record.Id = 455;
            return record;
        } // method
    } // class

    public partial class CarvedPumpkin : Block // 410 typeof=CarvedPumpkin
    {
        [StateEnum("south","west","north","east")]
        public  string cardinalDirection { get; set; } = "south";
        
        public CarvedPumpkin() : base(410)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:carved_pumpkin";
            record.Id = 410;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class Cauldron : Block // 465 typeof=Block
    {
        [StateEnum("water","powder_snow","lava")]
        public  string CauldronLiquid { get; set; } = "water";
        [StateRange(0, 6)] public  int FillLevel { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "cauldron_liquid":
                        CauldronLiquid = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "fill_level":
                        FillLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cauldron";
            record.Id = 465;
            record.States.Add(new BlockStateString {Name = "cauldron_liquid", Value = CauldronLiquid});
            record.States.Add(new BlockStateInt {Name = "fill_level", Value = FillLevel});
            return record;
        } // method
    } // class

    public partial class Chain  // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chain";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class ChainCommandBlock : Block // 189 typeof=ChainCommandBlock
    {
        [StateBit] public  bool ConditionalBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public ChainCommandBlock() : base(189)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "conditional_bit":
                        ConditionalBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chain_command_block";
            record.Id = 189;
            record.States.Add(new BlockStateByte {Name = "conditional_bit", Value = Convert.ToByte(ConditionalBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class ChemicalHeat : Block // 192 typeof=ChemicalHeat
    {
        
        public ChemicalHeat() : base(192)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chemical_heat";
            record.Id = 192;
            return record;
        } // method
    } // class

    public partial class ChemistryTable : Block // 238 typeof=ChemistryTable
    {
        [StateEnum("compound_creator","material_reducer","element_constructor","lab_table")]
        public  string ChemistryTableType { get; set; } = "compound_creator";
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        
        public ChemistryTable() : base(238)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "chemistry_table_type":
                        ChemistryTableType = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chemistry_table";
            record.Id = 238;
            record.States.Add(new BlockStateString {Name = "chemistry_table_type", Value = ChemistryTableType});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class Chest  // 54 typeof=Chest
    {
		public string cardinalDirection { get; set; } = "north";

		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chest";
            record.Id = 54;
			record.States.Add(new BlockStateString { Name = "minecraft:cardinal_direction", Value = cardinalDirection });
			return record;
        } // method
    } // class


    public partial class ChorusFlower  // 200 typeof=ChorusFlower
    {
        [StateRange(0, 5)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chorus_flower";
            record.Id = 200;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class ChorusPlant  // 240 typeof=ChorusPlant
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chorus_plant";
            record.Id = 240;
            return record;
        } // method
    } // class

    public partial class Clay  // 82 typeof=Clay
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:clay";
            record.Id = 82;
            return record;
        } // method
    } // class

    public partial class CoalBlock  // 173 typeof=CoalBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coal_block";
            record.Id = 173;
            return record;
        } // method
    } // class

    public partial class CoalOre  // 16 typeof=CoalOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coal_ore";
            record.Id = 16;
            return record;
        } // method
    } // class

    public partial class Cobblestone  // 4 typeof=Cobblestone
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobblestone";
            record.Id = 4;
            return record;
        } // method
    } // class

	public partial class CobblestoneWall  // 139 typeof=CobblestoneWall
	{
		public string[] nameValues = { "cobblestone", "mossy_cobblestone", "granite", "diorite", "andesite", "sandstone", "brick", "stone_brick", "mossy_stone_brick", "nether_brick", "end_brick", "prismarine", "red_sandstone", "red_nether_brick" };
		public string blockType { get; set; } = "cobblestone";

		[StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public bool WallPostBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobblestone_wall";
            record.Id = 139;
            record.States.Add(new BlockStateString {Name = "wall_block_type", Value = blockType});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class Cocoa  // 127 typeof=Cocoa
    {
        [StateRange(0, 2)] public  int Age { get; set; } = 0;
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cocoa";
            record.Id = 127;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class ColoredTorchBp : Block // 204 typeof=ColoredTorchBp
    {
        [StateBit] public  bool ColorBit { get; set; } = false;
        [StateEnum("west","east","north","south","top","unknown")]
        public  string TorchFacingDirection { get; set; } = "";
        
        public ColoredTorchBp() : base(204)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "color_bit":
                        ColorBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:colored_torch_bp";
            record.Id = 204;
            record.States.Add(new BlockStateByte {Name = "color_bit", Value = Convert.ToByte(ColorBit)});
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class ColoredTorchRg : Block // 202 typeof=ColoredTorchRg
    {
        [StateBit] public  bool ColorBit { get; set; } = false;
        [StateEnum("west","east","north","south","top","unknown")]
        public  string TorchFacingDirection { get; set; } = "";
        
        public ColoredTorchRg() : base(202)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "color_bit":
                        ColorBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:colored_torch_rg";
            record.Id = 202;
            record.States.Add(new BlockStateByte {Name = "color_bit", Value = Convert.ToByte(ColorBit)});
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class CommandBlock : Block // 137 typeof=CommandBlock
    {
        [StateBit] public  bool ConditionalBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public CommandBlock() : base(137)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "conditional_bit":
                        ConditionalBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:command_block";
            record.Id = 137;
            record.States.Add(new BlockStateByte {Name = "conditional_bit", Value = Convert.ToByte(ConditionalBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Composter : Block // 468 typeof=Composter
    {
        [StateRange(0, 8)] public  int ComposterFillLevel { get; set; } = 0;
        
        public Composter() : base(468)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "composter_fill_level":
                        ComposterFillLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:composter";
            record.Id = 468;
            record.States.Add(new BlockStateInt {Name = "composter_fill_level", Value = ComposterFillLevel});
            return record;
        } // method
    } // class

    public partial class Conduit : Block // 412 typeof=Conduit
    {
        
        public Conduit() : base(412)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:conduit";
            record.Id = 412;
            return record;
        } // method
    } // class

    public partial class CoralBlock : Block // 387 typeof=CoralBlock
    {
        [StateEnum("pink","purple","red","yellow","blue")]
        public  string CoralColor { get; set; } = "";
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public CoralBlock() : base(387)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "coral_color":
                        CoralColor = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_block";
            record.Id = 387;
            record.States.Add(new BlockStateString {Name = "coral_color", Value = CoralColor});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class CoralFan : Block // 388 typeof=CoralFan
    {
        [StateEnum("pink","purple","red","yellow","blue")]
        public  string CoralColor { get; set; } = "";
        [StateRange(0, 1)] public  int CoralFanDirection { get; set; } = 0;
        
        public CoralFan() : base(388)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "coral_color":
                        CoralColor = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "coral_fan_direction":
                        CoralFanDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan";
            record.Id = 388;
            record.States.Add(new BlockStateString {Name = "coral_color", Value = CoralColor});
            record.States.Add(new BlockStateInt {Name = "coral_fan_direction", Value = CoralFanDirection});
            return record;
        } // method
    } // class

    public partial class CoralFanDead : Block // 389 typeof=CoralFanDead
    {
        [StateEnum("pink","purple","red","yellow","blue")]
        public  string CoralColor { get; set; } = "";
        [StateRange(0, 1)] public  int CoralFanDirection { get; set; } = 0;
        
        public CoralFanDead() : base(389)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "coral_color":
                        CoralColor = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "coral_fan_direction":
                        CoralFanDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan_dead";
            record.Id = 389;
            record.States.Add(new BlockStateString {Name = "coral_color", Value = CoralColor});
            record.States.Add(new BlockStateInt {Name = "coral_fan_direction", Value = CoralFanDirection});
            return record;
        } // method
    } // class

    public partial class CoralFanHang : Block // 390 typeof=CoralFanHang
    {
        [StateRange(0, 3)] public  int CoralDirection { get; set; } = 0;
        [StateBit] public  bool CoralHangTypeBit { get; set; } = false;
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public CoralFanHang() : base(390)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "coral_direction":
                        CoralDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "coral_hang_type_bit":
                        CoralHangTypeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan_hang";
            record.Id = 390;
            record.States.Add(new BlockStateInt {Name = "coral_direction", Value = CoralDirection});
            record.States.Add(new BlockStateByte {Name = "coral_hang_type_bit", Value = Convert.ToByte(CoralHangTypeBit)});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class CoralFanHang2 : Block // 391 typeof=CoralFanHang2
    {
        [StateRange(0, 3)] public  int CoralDirection { get; set; } = 0;
        [StateBit] public  bool CoralHangTypeBit { get; set; } = false;
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public CoralFanHang2() : base(391)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "coral_direction":
                        CoralDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "coral_hang_type_bit":
                        CoralHangTypeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan_hang2";
            record.Id = 391;
            record.States.Add(new BlockStateInt {Name = "coral_direction", Value = CoralDirection});
            record.States.Add(new BlockStateByte {Name = "coral_hang_type_bit", Value = Convert.ToByte(CoralHangTypeBit)});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class CoralFanHang3 : Block // 392 typeof=CoralFanHang3
    {
        [StateRange(0, 3)] public  int CoralDirection { get; set; } = 0;
        [StateBit] public  bool CoralHangTypeBit { get; set; } = false;
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public CoralFanHang3() : base(392)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "coral_direction":
                        CoralDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "coral_hang_type_bit":
                        CoralHangTypeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan_hang3";
            record.Id = 392;
            record.States.Add(new BlockStateInt {Name = "coral_direction", Value = CoralDirection});
            record.States.Add(new BlockStateByte {Name = "coral_hang_type_bit", Value = Convert.ToByte(CoralHangTypeBit)});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class


    public partial class CraftingTable  // 58 typeof=CraftingTable
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crafting_table";
            record.Id = 58;
            return record;
        } // method
    } // class

    public partial class CyanGlazedTerracotta  // 229 typeof=CyanGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cyan_glazed_terracotta";
            record.Id = 229;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class DarkOakButton  // 397 typeof=DarkOakButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_button";
            record.Id = 397;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class DarkOakDoor  // 197 typeof=DarkOakDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_door";
            record.Id = 197;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class DarkOakFenceGate  // 186 typeof=DarkOakFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_fence_gate";
            record.Id = 186;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class DarkOakPressurePlate : PressurePlateBase // 407 typeof=DarkOakPressurePlate
	{
        public override int RedstoneSignal { get; set; } = 0;
        
        public DarkOakPressurePlate() : base(407)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_pressure_plate";
            record.Id = 407;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class DarkOakStairs  // 164 typeof=DarkOakStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_stairs";
            record.Id = 164;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class DarkOakTrapdoor  // 402 typeof=DarkOakTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_trapdoor";
            record.Id = 402;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class DarkPrismarineStairs  // 258 typeof=DarkPrismarineStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_prismarine_stairs";
            record.Id = 258;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class DarkoakStandingSign  // 447 typeof=DarkoakStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:darkoak_standing_sign";
            record.Id = 447;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class DarkoakWallSign  // 448 typeof=DarkoakWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:darkoak_wall_sign";
            record.Id = 448;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class DaylightDetector  // 151 typeof=DaylightDetector
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:daylight_detector";
            record.Id = 151;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class DaylightDetectorInverted  // 178 typeof=DaylightDetectorInverted
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:daylight_detector_inverted";
            record.Id = 178;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class Deadbush  // 32 typeof=Deadbush
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deadbush";
            record.Id = 32;
            return record;
        } // method
    } // class

    public partial class Deny  // 0 typeof=Air
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deny";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DetectorRail  // 28 typeof=DetectorRail
    {
        [StateBit] public  bool RailDataBit { get; set; } = false;
        [StateRange(0, 5)] public  int RailDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "rail_data_bit":
                        RailDataBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "rail_direction":
                        RailDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:detector_rail";
            record.Id = 28;
            record.States.Add(new BlockStateByte {Name = "rail_data_bit", Value = Convert.ToByte(RailDataBit)});
            record.States.Add(new BlockStateInt {Name = "rail_direction", Value = RailDirection});
            return record;
        } // method
    } // class

    public partial class DiamondBlock  // 57 typeof=DiamondBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:diamond_block";
            record.Id = 57;
            return record;
        } // method
    } // class

    public partial class DiamondOre  // 56 typeof=DiamondOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:diamond_ore";
            record.Id = 56;
            return record;
        } // method
    } // class

    public partial class DioriteStairs  // 425 typeof=DioriteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:diorite_stairs";
            record.Id = 425;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Dirt  // 3 typeof=Dirt
    {
        [StateEnum("normal","coarse")]
        public  string DirtType { get; set; } = "normal";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "dirt_type":
                        DirtType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dirt";
            record.Id = 3;
            record.States.Add(new BlockStateString {Name = "dirt_type", Value = DirtType});
            return record;
        } // method
    } // class

    public partial class Dispenser  // 23 typeof=Dispenser
    {
        public int FacingDirection { get; set; } = 0;
        public bool TriggeredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "triggered_bit":
                        TriggeredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dispenser";
            record.Id = 23;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "triggered_bit", Value = Convert.ToByte(TriggeredBit)});
            return record;
        } // method
    } // class

    public partial class DoublePlant  // 175 typeof=DoublePlant
    {
        [StateEnum("syringa","grass","fern","rose","paeonia","sunflower")]
        public  string DoublePlantType { get; set; } = "grass";
        [StateBit] public bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "double_plant_type":
                        DoublePlantType = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_plant";
            record.Id = 175;
            record.States.Add(new BlockStateString {Name = "double_plant_type", Value = DoublePlantType});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class DoubleWoodenSlab  // 157 typeof=DoubleWoodenSlab
    {
        [StateEnum("bottom","top")]
        public  string verticalHalf { get; set; } = "";
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string WoodType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:vertical_half":
                        verticalHalf = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wood_type":
                        WoodType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_wooden_slab";
            record.Id = 157;
            record.States.Add(new BlockStateString {Name = "minecraft:vertical_half", Value = verticalHalf});
            record.States.Add(new BlockStateString {Name = "wood_type", Value = WoodType});
            return record;
        } // method
    } // class

    public partial class DragonEgg  // 122 typeof=DragonEgg
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dragon_egg";
            record.Id = 122;
            return record;
        } // method
    } // class

    public partial class DriedKelpBlock : Block // 394 typeof=DriedKelpBlock
    {
        
        public DriedKelpBlock() : base(394)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dried_kelp_block";
            record.Id = 394;
            return record;
        } // method
    } // class

    public partial class Dropper  // 125 typeof=Dropper
    {
        public int FacingDirection { get; set; } = 0;
        public bool TriggeredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "triggered_bit":
                        TriggeredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dropper";
            record.Id = 125;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "triggered_bit", Value = Convert.ToByte(TriggeredBit)});
            return record;
        } // method
    } // class

	public partial class Chalkboard : Block // 230 typeof=Chalkboard
	{

		public Chalkboard() : base(230)
		{
			IsGenerated = true;
		}

		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = "minecraft:chalkboard";
			record.Id = 230;
			return record;
		} // method
	} // class

	public partial class EmeraldBlock  // 133 typeof=EmeraldBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:emerald_block";
            record.Id = 133;
            return record;
        } // method
    } // class

    public partial class EmeraldOre  // 129 typeof=EmeraldOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:emerald_ore";
            record.Id = 129;
            return record;
        } // method
    } // class

    public partial class EnchantingTable  // 116 typeof=EnchantingTable
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:enchanting_table";
            record.Id = 116;
            return record;
        } // method
    } // class

    public partial class EndBrickStairs  // 433 typeof=EndBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_brick_stairs";
            record.Id = 433;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class EndBricks  // 206 typeof=EndBricks
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_bricks";
            record.Id = 206;
            return record;
        } // method
    } // class

    public partial class EndGateway  // 209 typeof=EndGateway
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_gateway";
            record.Id = 209;
            return record;
        } // method
    } // class

    public partial class EndPortal  // 119 typeof=EndPortal
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_portal";
            record.Id = 119;
            return record;
        } // method
    } // class

    public partial class EndPortalFrame  // 120 typeof=EndPortalFrame
    {
        public  bool EndPortalEyeBit { get; set; } = false;
		public string cardinalDirection { get; set; } = "north";

		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateByte s when s.Name == "end_portal_eye_bit":
						EndPortalEyeBit = Convert.ToBoolean(s.Value);
						break;
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_portal_frame";
            record.Id = 120;
            record.States.Add(new BlockStateByte {Name = "end_portal_eye_bit", Value = Convert.ToByte(EndPortalEyeBit)});
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class EndRod  // 208 typeof=EndRod
    {
        public int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_rod";
            record.Id = 208;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class EndStone  // 121 typeof=EndStone
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_stone";
            record.Id = 121;
            return record;
        } // method
    } // class

    public partial class EnderChest  // 130 typeof=EnderChest
    {
		public string cardinalDirection { get; set; } = "north";

		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:ender_chest";
            record.Id = 130;
			record.States.Add(new BlockStateString { Name = "minecraft:cardinal_direction", Value = cardinalDirection });
			return record;
        } // method
    } // class

    public partial class Farmland  // 60 typeof=Farmland
    {
        [StateRange(0, 7)] public  int MoisturizedAmount { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "moisturized_amount":
                        MoisturizedAmount = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:farmland";
            record.Id = 60;
            record.States.Add(new BlockStateInt {Name = "moisturized_amount", Value = MoisturizedAmount});
            return record;
        } // method
    } // class

    public partial class FenceGate  // 107 typeof=FenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:fence_gate";
            record.Id = 107;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class Fire  // 51 typeof=Fire
    {
        [StateRange(0, 15)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:fire";
            record.Id = 51;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class FletchingTable : Block // 456 typeof=FletchingTable
    {
        
        public FletchingTable() : base(456)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:fletching_table";
            record.Id = 456;
            return record;
        } // method
    } // class

    public partial class FlowerPot  // 140 typeof=FlowerPot
    {
        [StateBit] public  bool UpdateBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:flower_pot";
            record.Id = 140;
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class FlowingLava  // 10 typeof=FlowingLava
    {
        [StateRange(0, 15)] public override int LiquidDepth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "liquid_depth":
                        LiquidDepth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:flowing_lava";
            record.Id = 10;
            record.States.Add(new BlockStateInt {Name = "liquid_depth", Value = LiquidDepth});
            return record;
        } // method
    } // class

    public partial class FlowingWater  // 8 typeof=FlowingWater
    {
        [StateRange(0, 15)] public override int LiquidDepth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "liquid_depth":
                        LiquidDepth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:flowing_water";
            record.Id = 8;
            record.States.Add(new BlockStateInt {Name = "liquid_depth", Value = LiquidDepth});
            return record;
        } // method
    } // class

    public partial class Frame  // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool ItemFrameMapBit { get; set; } = false;
        [StateBit] public  bool ItemFramePhotoBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "item_frame_map_bit":
                        ItemFrameMapBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "item_frame_photo_bit":
                        ItemFramePhotoBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:frame";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "item_frame_map_bit", Value = Convert.ToByte(ItemFrameMapBit)});
            record.States.Add(new BlockStateByte {Name = "item_frame_photo_bit", Value = Convert.ToByte(ItemFramePhotoBit)});
            return record;
        } // method
    } // class

    public partial class FrostedIce  // 207 typeof=FrostedIce
    {
        [StateRange(0, 3)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:frosted_ice";
            record.Id = 207;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class Furnace  // 61 typeof=Furnace
    {
        public string cardinalDirection { get; set; } = "north";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:furnace";
            record.Id = 61;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class Glass  // 20 typeof=Glass
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glass";
            record.Id = 20;
            return record;
        } // method
    } // class

    public partial class GlassPane  // 102 typeof=GlassPane
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glass_pane";
            record.Id = 102;
            return record;
        } // method
    } // class

    public partial class Glowingobsidian  // 246 typeof=Glowingobsidian
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glowingobsidian";
            record.Id = 246;
            return record;
        } // method
    } // class

    public partial class Glowstone  // 89 typeof=Glowstone
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glowstone";
            record.Id = 89;
            return record;
        } // method
    } // class

    public partial class GoldBlock  // 41 typeof=GoldBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gold_block";
            record.Id = 41;
            return record;
        } // method
    } // class

    public partial class GoldOre  // 14 typeof=GoldOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gold_ore";
            record.Id = 14;
            return record;
        } // method
    } // class

    public partial class GoldenRail  // 27 typeof=GoldenRail
    {
        [StateBit] public  bool RailDataBit { get; set; } = false;
        [StateRange(0, 5)] public  int RailDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "rail_data_bit":
                        RailDataBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "rail_direction":
                        RailDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:golden_rail";
            record.Id = 27;
            record.States.Add(new BlockStateByte {Name = "rail_data_bit", Value = Convert.ToByte(RailDataBit)});
            record.States.Add(new BlockStateInt {Name = "rail_direction", Value = RailDirection});
            return record;
        } // method
    } // class

    public partial class GraniteStairs  // 424 typeof=GraniteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:granite_stairs";
            record.Id = 424;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Grass  // 2 typeof=Grass
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:grass";
            record.Id = 2;
            return record;
        } // method
    } // class

    public partial class GrassPath  // 198 typeof=GrassPath
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:grass_path";
            record.Id = 198;
            return record;
        } // method
    } // class

    public partial class Gravel  // 13 typeof=Gravel
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gravel";
            record.Id = 13;
            return record;
        } // method
    } // class

    public partial class GrayGlazedTerracotta  // 227 typeof=GrayGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gray_glazed_terracotta";
            record.Id = 227;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class GreenGlazedTerracotta  // 233 typeof=GreenGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:green_glazed_terracotta";
            record.Id = 233;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Grindstone : Block // 450 typeof=Grindstone
    {
        [StateEnum("standing","hanging","side","multiple")]
        public  string Attachment { get; set; } = "standing";
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        
        public Grindstone() : base(450)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "attachment":
                        Attachment = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:grindstone";
            record.Id = 450;
            record.States.Add(new BlockStateString {Name = "attachment", Value = Attachment});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class HardGlass : Block // 253 typeof=HardGlass
    {
        
        public HardGlass() : base(253)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hard_glass";
            record.Id = 253;
            return record;
        } // method
    } // class

    public partial class HardGlassPane : Block // 190 typeof=HardGlassPane
    {
        
        public HardGlassPane() : base(190)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hard_glass_pane";
            record.Id = 190;
            return record;
        } // method
    } // class

    public partial class HardStainedGlass : Block // 254 typeof=HardStainedGlass
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";
        
        public HardStainedGlass() : base(254)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hard_stained_glass";
            record.Id = 254;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class HardStainedGlassPane : Block // 191 typeof=HardStainedGlassPane
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";
        
        public HardStainedGlassPane() : base(191)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hard_stained_glass_pane";
            record.Id = 191;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class HardenedClay  // 172 typeof=HardenedClay
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hardened_clay";
            record.Id = 172;
            return record;
        } // method
    } // class

    public partial class HayBlock  // 170 typeof=HayBlock
    {
        [StateRange(0, 3)] public  int Deprecated { get; set; } = 0;
        [StateEnum("x","z","y")]
        public string PillarAxis { get; set; } = "x";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "deprecated":
                        Deprecated = s.Value;
                        break;
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hay_block";
            record.Id = 170;
            record.States.Add(new BlockStateInt {Name = "deprecated", Value = Deprecated});
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class HeavyWeightedPressurePlate  // 148 typeof=HeavyWeightedPressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:heavy_weighted_pressure_plate";
            record.Id = 148;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class HoneyBlock  // 0 typeof=Air
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:honey_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class HoneycombBlock  // 0 typeof=Air
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:honeycomb_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Hopper  // 154 typeof=Hopper
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool ToggleBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "toggle_bit":
                        ToggleBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hopper";
            record.Id = 154;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "toggle_bit", Value = Convert.ToByte(ToggleBit)});
            return record;
        } // method
    } // class

    public partial class Ice  // 79 typeof=Ice
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:ice";
            record.Id = 79;
            return record;
        } // method
    } // class

    public partial class InfoUpdate : Block // 248 typeof=InfoUpdate
    {
        
        public InfoUpdate() : base(248)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:info_update";
            record.Id = 248;
            return record;
        } // method
    } // class

    public partial class InfoUpdate2 : Block // 249 typeof=InfoUpdate2
    {
        
        public InfoUpdate2() : base(249)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:info_update2";
            record.Id = 249;
            return record;
        } // method
    } // class

    public partial class InvisibleBedrock  // 95 typeof=InvisibleBedrock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:invisible_bedrock";
            record.Id = 95;
            return record;
        } // method
    } // class

    public partial class IronBars  // 101 typeof=IronBars
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_bars";
            record.Id = 101;
            return record;
        } // method
    } // class

    public partial class IronBlock  // 42 typeof=IronBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_block";
            record.Id = 42;
            return record;
        } // method
    } // class

    public partial class IronDoor  // 71 typeof=IronDoor
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool DoorHingeBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_door";
            record.Id = 71;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class IronOre  // 15 typeof=IronOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_ore";
            record.Id = 15;
            return record;
        } // method
    } // class

    public partial class IronTrapdoor  // 167 typeof=IronTrapdoor
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_trapdoor";
            record.Id = 167;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class Jigsaw  // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 3)] public  int Rotation { get; set; } = 1;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "rotation":
                        Rotation = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jigsaw";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "rotation", Value = Rotation});
            return record;
        } // method
    } // class

    public partial class Jukebox  // 84 typeof=Jukebox
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jukebox";
            record.Id = 84;
            return record;
        } // method
    } // class

    public partial class JungleButton  // 398 typeof=JungleButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_button";
            record.Id = 398;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class JungleDoor  // 195 typeof=JungleDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_door";
            record.Id = 195;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class JungleFenceGate  // 185 typeof=JungleFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_fence_gate";
            record.Id = 185;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class JunglePressurePlate : PressurePlateBase // 408 typeof=JunglePressurePlate
	{
        public override int RedstoneSignal { get; set; } = 0;
        
        public JunglePressurePlate() : base(408)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_pressure_plate";
            record.Id = 408;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class JungleStairs  // 136 typeof=JungleStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_stairs";
            record.Id = 136;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class JungleStandingSign  // 443 typeof=JungleStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_standing_sign";
            record.Id = 443;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class JungleTrapdoor  // 403 typeof=JungleTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_trapdoor";
            record.Id = 403;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class JungleWallSign  // 444 typeof=JungleWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_wall_sign";
            record.Id = 444;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Kelp : Block // 393 typeof=Kelp
    {
        [StateRange(0, 25)] public  int KelpAge { get; set; } = 0;
        
        public Kelp() : base(393)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "kelp_age":
                        KelpAge = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:kelp";
            record.Id = 393;
            record.States.Add(new BlockStateInt {Name = "kelp_age", Value = KelpAge});
            return record;
        } // method
    } // class

    public partial class Ladder  // 65 typeof=Ladder
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:ladder";
            record.Id = 65;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Lantern : Block // 463 typeof=Lantern
    {
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public Lantern() : base(463)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lantern";
            record.Id = 463;
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class LapisBlock  // 22 typeof=LapisBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lapis_block";
            record.Id = 22;
            return record;
        } // method
    } // class

    public partial class LapisOre  // 21 typeof=LapisOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lapis_ore";
            record.Id = 21;
            return record;
        } // method
    } // class

    public partial class Lava  // 11 typeof=Lava
    {
        [StateRange(0, 15)] public override int LiquidDepth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "liquid_depth":
                        LiquidDepth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lava";
            record.Id = 11;
            record.States.Add(new BlockStateInt {Name = "liquid_depth", Value = LiquidDepth});
            return record;
        } // method
    } // class

    public partial class Leaves  // 18 typeof=Leaves
    {
        [StateEnum("oak","spruce","birch","jungle")]
        public  string OldLeafType { get; set; } = "oak";
        [StateBit] public  bool PersistentBit { get; set; } = false;
        [StateBit] public  bool UpdateBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "old_leaf_type":
                        OldLeafType = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "persistent_bit":
                        PersistentBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:leaves";
            record.Id = 18;
            record.States.Add(new BlockStateString {Name = "old_leaf_type", Value = OldLeafType});
            record.States.Add(new BlockStateByte {Name = "persistent_bit", Value = Convert.ToByte(PersistentBit)});
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class Leaves2  // 161 typeof=Leaves2
    {
        [StateEnum("dark_oak","acacia")]
        public  string NewLeafType { get; set; } = "acacia";
        [StateBit] public  bool PersistentBit { get; set; } = false;
        [StateBit] public  bool UpdateBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "new_leaf_type":
                        NewLeafType = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "persistent_bit":
                        PersistentBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:leaves2";
            record.Id = 161;
            record.States.Add(new BlockStateString {Name = "new_leaf_type", Value = NewLeafType});
            record.States.Add(new BlockStateByte {Name = "persistent_bit", Value = Convert.ToByte(PersistentBit)});
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class Lectern : Block // 449 typeof=Lectern
    {
		public string cardinalDirection { get; set; } = "north";
		public  bool PoweredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lectern";
            record.Id = 449;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            return record;
        } // method
    } // class

    public partial class Lever  // 69 typeof=Lever
    {
        public string LeverDirection { get; set; } = "down_east_west";
		public bool OpenBit { get; set; } = false;

		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "lever_direction":
                        LeverDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lever";
            record.Id = 69;
            record.States.Add(new BlockStateString {Name = "lever_direction", Value = LeverDirection});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class LightBlock  // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int BlockLightLevel { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "block_light_level":
                        BlockLightLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_block";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "block_light_level", Value = BlockLightLevel});
            return record;
        } // method
    } // class

    public partial class LightBlueGlazedTerracotta  // 223 typeof=LightBlueGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_blue_glazed_terracotta";
            record.Id = 223;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class LightWeightedPressurePlate  // 147 typeof=LightWeightedPressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_weighted_pressure_plate";
            record.Id = 147;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class LimeGlazedTerracotta  // 225 typeof=LimeGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lime_glazed_terracotta";
            record.Id = 225;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class LitBlastFurnace  // 469 typeof=LitBlastFurnace
    {
        [StateEnum("north","west","east","south")]
        public  string cardinalDirection { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_blast_furnace";
            record.Id = 469;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class LitFurnace  // 62 typeof=LitFurnace
    {
        [StateEnum("north","west","east","south")]
        public  string cardinalDirection { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_furnace";
            record.Id = 62;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class LitPumpkin  // 91 typeof=LitPumpkin
    {
        [StateEnum("south","west","north","east")]
        public  string cardinalDirection { get; set; } = "south";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_pumpkin";
            record.Id = 91;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class LitRedstoneLamp  // 124 typeof=LitRedstoneLamp
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_redstone_lamp";
            record.Id = 124;
            return record;
        } // method
    } // class

    public partial class LitRedstoneOre  // 74 typeof=LitRedstoneOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_redstone_ore";
            record.Id = 74;
            return record;
        } // method
    } // class

    public partial class LitSmoker : Block // 454 typeof=LitSmoker
    {
        [StateEnum("north","west","east","south")]
        public  string cardinalDirection { get; set; } = "";
        
        public LitSmoker() : base(454)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_smoker";
            record.Id = 454;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class Loom  // 459 typeof=Loom
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:loom";
            record.Id = 459;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class MagentaGlazedTerracotta  // 222 typeof=MagentaGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:magenta_glazed_terracotta";
            record.Id = 222;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Magma : Block // 213 typeof=Magma
    {
        
        public Magma() : base(213)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:magma";
            record.Id = 213;
            return record;
        } // method
    } // class

    public partial class MelonBlock  // 103 typeof=MelonBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:melon_block";
            record.Id = 103;
            return record;
        } // method
    } // class

    public partial class MelonStem  // 105 typeof=MelonStem
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 7)] public  int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:melon_stem";
            record.Id = 105;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class MobSpawner  // 52 typeof=MobSpawner
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mob_spawner";
            record.Id = 52;
            return record;
        } // method
    } // class

    public partial class MonsterEgg  // 97 typeof=MonsterEgg
    {
        [StateEnum("cobblestone","stone_brick","mossy_stone_brick","cracked_stone_brick","chiseled_stone_brick","stone")]
        public  string MonsterEggStoneType { get; set; } = "stone";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "monster_egg_stone_type":
                        MonsterEggStoneType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:monster_egg";
            record.Id = 97;
            record.States.Add(new BlockStateString {Name = "monster_egg_stone_type", Value = MonsterEggStoneType});
            return record;
        } // method
    } // class

    public partial class MossyCobblestone  // 48 typeof=MossyCobblestone
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mossy_cobblestone";
            record.Id = 48;
            return record;
        } // method
    } // class

    public partial class MossyCobblestoneStairs  // 434 typeof=MossyCobblestoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mossy_cobblestone_stairs";
            record.Id = 434;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class MossyStoneBrickStairs  // 430 typeof=MossyStoneBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mossy_stone_brick_stairs";
            record.Id = 430;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class MovingBlock : Block // 250 typeof=MovingBlock
    {
        
        public MovingBlock() : base(250)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:moving_block";
            record.Id = 250;
            return record;
        } // method
    } // class

    public partial class Mycelium  // 110 typeof=Mycelium
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mycelium";
            record.Id = 110;
            return record;
        } // method
    } // class

    public partial class NetherBrick  // 112 typeof=NetherBrick
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_brick";
            record.Id = 112;
            return record;
        } // method
    } // class

    public partial class NetherBrickFence  // 113 typeof=NetherBrickFence
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_brick_fence";
            record.Id = 113;
            return record;
        } // method
    } // class

    public partial class NetherBrickStairs  // 114 typeof=NetherBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_brick_stairs";
            record.Id = 114;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class


    public partial class NetherWart  // 115 typeof=NetherWart
    {
        [StateRange(0, 3)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_wart";
            record.Id = 115;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class NetherWartBlock : Block // 214 typeof=NetherWartBlock
    {
        
        public NetherWartBlock() : base(214)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_wart_block";
            record.Id = 214;
            return record;
        } // method
    } // class


    public partial class Netherrack  // 87 typeof=Netherrack
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:netherrack";
            record.Id = 87;
            return record;
        } // method
    } // class

    public partial class Netherreactor  // 247 typeof=Netherreactor
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:netherreactor";
            record.Id = 247;
            return record;
        } // method
    } // class

    public partial class NormalStoneStairs  // 435 typeof=NormalStoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:normal_stone_stairs";
            record.Id = 435;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Noteblock  // 25 typeof=Noteblock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:noteblock";
            record.Id = 25;
            return record;
        } // method
    } // class

    public partial class OakStairs  // 53 typeof=OakStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oak_stairs";
            record.Id = 53;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Observer  // 251 typeof=Observer
    {
        [StateEnum("up","north","south","west","east","down")]
        public  string ffacingDirection { get; set; } = "north";
        [StateBit] public  bool PoweredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:facing_direction":
                        ffacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:observer";
            record.Id = 251;
            record.States.Add(new BlockStateString {Name = "minecraft:facing_direction", Value = ffacingDirection});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            return record;
        } // method
    } // class

    public partial class Obsidian  // 49 typeof=Obsidian
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:obsidian";
            record.Id = 49;
            return record;
        } // method
    } // class

    public partial class OrangeGlazedTerracotta  // 221 typeof=OrangeGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:orange_glazed_terracotta";
            record.Id = 221;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class PackedIce  // 174 typeof=PackedIce
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:packed_ice";
            record.Id = 174;
            return record;
        } // method
    } // class

    public partial class PinkGlazedTerracotta  // 226 typeof=PinkGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pink_glazed_terracotta";
            record.Id = 226;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Piston  // 33 typeof=Piston
    {
        public int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:piston";
            record.Id = 33;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class PistonArmCollision  // 34 typeof=PistonArmCollision
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:piston_arm_collision";
            record.Id = 34;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Planks  // 5 typeof=Planks
    {
		public string blockName { get; set; } = "minecraft:oak_planks";
		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = blockName;
            record.Id = 5;
            return record;
        } // method
    } // class

    public partial class Podzol  // 243 typeof=Podzol
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:podzol";
            record.Id = 243;
            return record;
        } // method
    } // class

    public partial class PolishedAndesiteStairs  // 429 typeof=PolishedAndesiteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_andesite_stairs";
            record.Id = 429;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class


    public partial class PolishedDioriteStairs  // 428 typeof=PolishedDioriteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_diorite_stairs";
            record.Id = 428;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class PolishedGraniteStairs  // 427 typeof=PolishedGraniteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_granite_stairs";
            record.Id = 427;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Portal  // 90 typeof=Portal
    {
        [StateEnum("x","z","unknown")]
        public  string PortalAxis { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "portal_axis":
                        PortalAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:portal";
            record.Id = 90;
            record.States.Add(new BlockStateString {Name = "portal_axis", Value = PortalAxis});
            return record;
        } // method
    } // class

    public partial class Potatoes  // 142 typeof=Potatoes
    {
        [StateRange(0, 7)] public override int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:potatoes";
            record.Id = 142;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class PoweredComparator  // 150 typeof=PoweredComparator
    {
        [StateEnum("south","west","north","east")]
        public  string cardinalDirection { get; set; } = "south";
        [StateBit] public  bool OutputLitBit { get; set; } = false;
        [StateBit] public  bool OutputSubtractBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "output_lit_bit":
                        OutputLitBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "output_subtract_bit":
                        OutputSubtractBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:powered_comparator";
            record.Id = 150;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            record.States.Add(new BlockStateByte {Name = "output_lit_bit", Value = Convert.ToByte(OutputLitBit)});
            record.States.Add(new BlockStateByte {Name = "output_subtract_bit", Value = Convert.ToByte(OutputSubtractBit)});
            return record;
        } // method
    } // class

    public partial class PoweredRepeater  // 94 typeof=PoweredRepeater
    {
        [StateEnum("south","west","north","east")]
        public  string cardinalDirection { get; set; } = "south";
        [StateRange(0, 3)] public  int RepeaterDelay { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "repeater_delay":
                        RepeaterDelay = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:powered_repeater";
            record.Id = 94;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            record.States.Add(new BlockStateInt {Name = "repeater_delay", Value = RepeaterDelay});
            return record;
        } // method
    } // class

    public partial class Prismarine  // 168 typeof=Prismarine
    {
        [StateEnum("dark","bricks","default")]
        public  string PrismarineBlockType { get; set; } = "default";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "prismarine_block_type":
                        PrismarineBlockType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:prismarine";
            record.Id = 168;
            record.States.Add(new BlockStateString {Name = "prismarine_block_type", Value = PrismarineBlockType});
            return record;
        } // method
    } // class

    public partial class PrismarineBricksStairs  // 259 typeof=PrismarineBricksStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:prismarine_bricks_stairs";
            record.Id = 259;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class PrismarineStairs  // 257 typeof=PrismarineStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:prismarine_stairs";
            record.Id = 257;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Pumpkin  // 86 typeof=Pumpkin
    {
        [StateEnum("south","west","north","east")]
        public  string cardinalDirection { get; set; } = "south";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pumpkin";
            record.Id = 86;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class PumpkinStem  // 104 typeof=PumpkinStem
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 7)] public  int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pumpkin_stem";
            record.Id = 104;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class PurpleGlazedTerracotta  // 219 typeof=PurpleGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purple_glazed_terracotta";
            record.Id = 219;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class PurpurBlock  // 201 typeof=PurpurBlock
    {
        [StateEnum("default","chiseled","lines","smooth")]
        public  string ChiselType { get; set; } = "";
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "chisel_type":
                        ChiselType = s.Value;
                        break;
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purpur_block";
            record.Id = 201;
            record.States.Add(new BlockStateString {Name = "chisel_type", Value = ChiselType});
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class PurpurStairs  // 203 typeof=PurpurStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purpur_stairs";
            record.Id = 203;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class QuartzBlock  // 155 typeof=QuartzBlock
    {
        [StateEnum("default","chiseled","lines","smooth")]
        public string ChiselType { get; set; } = "default";
        [StateEnum("x","z","y")]
        public string PillarAxis { get; set; } = "x";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "chisel_type":
                        ChiselType = s.Value;
                        break;
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:quartz_block";
            record.Id = 155;
            record.States.Add(new BlockStateString {Name = "chisel_type", Value = ChiselType});
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class


    public partial class QuartzOre  // 153 typeof=QuartzOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:quartz_ore";
            record.Id = 153;
            return record;
        } // method
    } // class

    public partial class QuartzStairs  // 156 typeof=QuartzStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:quartz_stairs";
            record.Id = 156;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Rail  // 66 typeof=Rail
    {
        [StateRange(0, 9)] public  int RailDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "rail_direction":
                        RailDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:rail";
            record.Id = 66;
            record.States.Add(new BlockStateInt {Name = "rail_direction", Value = RailDirection});
            return record;
        } // method
    } // class

    public partial class RedFlower  // 38 typeof=RedFlower
    {
        [StateEnum("orchid","allium","houstonia","tulip_red","tulip_orange","tulip_white","tulip_pink","oxeye","cornflower","lily_of_the_valley","poppy")]
        public  string FlowerType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "flower_type":
                        FlowerType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_flower";
            record.Id = 38;
            record.States.Add(new BlockStateString {Name = "flower_type", Value = FlowerType});
            return record;
        } // method
    } // class

    public partial class RedGlazedTerracotta  // 234 typeof=RedGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_glazed_terracotta";
            record.Id = 234;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class RedMushroom  // 40 typeof=RedMushroom
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_mushroom";
            record.Id = 40;
            return record;
        } // method
    } // class

    public partial class RedMushroomBlock  // 100 typeof=RedMushroomBlock
    {
        [StateRange(0, 15)] public  int HugeMushroomBits { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "huge_mushroom_bits":
                        HugeMushroomBits = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_mushroom_block";
            record.Id = 100;
            record.States.Add(new BlockStateInt {Name = "huge_mushroom_bits", Value = HugeMushroomBits});
            return record;
        } // method
    } // class

    public partial class RedNetherBrick : Block // 215 typeof=RedNetherBrick
    {
        
        public RedNetherBrick() : base(215)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_nether_brick";
            record.Id = 215;
            return record;
        } // method
    } // class

    public partial class RedNetherBrickStairs  // 439 typeof=RedNetherBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_nether_brick_stairs";
            record.Id = 439;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class RedSandstone  // 179 typeof=RedSandstone
    {
        [StateEnum("default","heiroglyphs","cut","smooth")]
        public  string SandStoneType { get; set; } = "default";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sand_stone_type":
                        SandStoneType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_sandstone";
            record.Id = 179;
            record.States.Add(new BlockStateString {Name = "sand_stone_type", Value = SandStoneType});
            return record;
        } // method
    } // class

    public partial class RedSandstoneStairs  // 180 typeof=RedSandstoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_sandstone_stairs";
            record.Id = 180;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class RedstoneBlock  // 152 typeof=RedstoneBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_block";
            record.Id = 152;
            return record;
        } // method
    } // class

    public partial class RedstoneLamp  // 123 typeof=RedstoneLamp
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_lamp";
            record.Id = 123;
            return record;
        } // method
    } // class

    public partial class RedstoneOre  // 73 typeof=RedstoneOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_ore";
            record.Id = 73;
            return record;
        } // method
    } // class

    public partial class RedstoneTorch  // 76 typeof=RedstoneTorch
    {
        public string TorchFacingDirection { get; set; } = "top";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_torch";
            record.Id = 76;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class RedstoneWire  // 55 typeof=RedstoneWire
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_wire";
            record.Id = 55;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class Reeds  // 83 typeof=Reeds
    {
        [StateRange(0, 15)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:reeds";
            record.Id = 83;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class RepeatingCommandBlock : Block // 188 typeof=RepeatingCommandBlock
    {
        [StateBit] public  bool ConditionalBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public RepeatingCommandBlock() : base(188)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "conditional_bit":
                        ConditionalBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:repeating_command_block";
            record.Id = 188;
            record.States.Add(new BlockStateByte {Name = "conditional_bit", Value = Convert.ToByte(ConditionalBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Reserved6 : Block // 255 typeof=Reserved6
    {
        
        public Reserved6() : base(255)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:reserved6";
            record.Id = 255;
            return record;
        } // method
    } // class


    public partial class Sand  // 12 typeof=Sand
    {
        [StateEnum("normal","red")]
        public  string SandType { get; set; } = "normal";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sand_type":
                        SandType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sand";
            record.Id = 12;
            record.States.Add(new BlockStateString {Name = "sand_type", Value = SandType});
            return record;
        } // method
    } // class

    public partial class Sandstone  // 24 typeof=Sandstone
    {
        [StateEnum("default","heiroglyphs","cut","smooth")]
        public  string SandStoneType { get; set; } = "default";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sand_stone_type":
                        SandStoneType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sandstone";
            record.Id = 24;
            record.States.Add(new BlockStateString {Name = "sand_stone_type", Value = SandStoneType});
            return record;
        } // method
    } // class

    public partial class SandstoneStairs  // 128 typeof=SandstoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sandstone_stairs";
            record.Id = 128;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Sapling  // 6 typeof=Sapling
    {
        [StateBit] public  bool AgeBit { get; set; } = false;
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string SaplingType { get; set; } = "oak";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "age_bit":
                        AgeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "sapling_type":
                        SaplingType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sapling";
            record.Id = 6;
            record.States.Add(new BlockStateByte {Name = "age_bit", Value = Convert.ToByte(AgeBit)});
            record.States.Add(new BlockStateString {Name = "sapling_type", Value = SaplingType});
            return record;
        } // method
    } // class

    public partial class Scaffolding : Block // 420 typeof=Scaffolding
    {
        [StateRange(0, 7)] public  int Stability { get; set; } = 0;
        [StateBit] public  bool StabilityCheck { get; set; } = false;
        
        public Scaffolding() : base(420)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "stability":
                        Stability = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "stability_check":
                        StabilityCheck = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:scaffolding";
            record.Id = 420;
            record.States.Add(new BlockStateInt {Name = "stability", Value = Stability});
            record.States.Add(new BlockStateByte {Name = "stability_check", Value = Convert.ToByte(StabilityCheck)});
            return record;
        } // method
    } // class

    public partial class SeaLantern  // 169 typeof=SeaLantern
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sea_lantern";
            record.Id = 169;
            return record;
        } // method
    } // class

    public partial class SeaPickle : Block // 411 typeof=SeaPickle
    {
        [StateRange(0, 3)] public  int ClusterCount { get; set; } = 0;
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public SeaPickle() : base(411)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "cluster_count":
                        ClusterCount = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sea_pickle";
            record.Id = 411;
            record.States.Add(new BlockStateInt {Name = "cluster_count", Value = ClusterCount});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class Seagrass : Block // 385 typeof=Seagrass
    {
        [StateEnum("double_top","double_bot","default")]
        public  string SeaGrassType { get; set; } = "default";
        
        public Seagrass() : base(385)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sea_grass_type":
                        SeaGrassType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:seagrass";
            record.Id = 385;
            record.States.Add(new BlockStateString {Name = "sea_grass_type", Value = SeaGrassType});
            return record;
        } // method
    } // class


    public partial class SilverGlazedTerracotta  // 228 typeof=SilverGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:silver_glazed_terracotta";
            record.Id = 228;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Skull  // 144 typeof=Skull
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:skull";
            record.Id = 144;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Slime  // 165 typeof=Slime
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:slime";
            record.Id = 165;
            return record;
        } // method
    } // class

    public partial class SmithingTable : Block // 457 typeof=SmithingTable
    {
        
        public SmithingTable() : base(457)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smithing_table";
            record.Id = 457;
            return record;
        } // method
    } // class

    public partial class Smoker : Block // 453 typeof=Smoker
    {
		public string cardinalDirection { get; set; } = "north";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smoker";
            record.Id = 453;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            return record;
        } // method
    } // class

    public partial class SmoothQuartzStairs  // 440 typeof=SmoothQuartzStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_quartz_stairs";
            record.Id = 440;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class SmoothRedSandstoneStairs  // 431 typeof=SmoothRedSandstoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_red_sandstone_stairs";
            record.Id = 431;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class SmoothSandstoneStairs  // 432 typeof=SmoothSandstoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_sandstone_stairs";
            record.Id = 432;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class SmoothStone : Block // 438 typeof=SmoothStone
    {
        
        public SmoothStone() : base(438)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_stone";
            record.Id = 438;
            return record;
        } // method
    } // class

    public partial class Snow  // 80 typeof=Snow
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:snow";
            record.Id = 80;
            return record;
        } // method
    } // class

    public partial class SnowLayer  // 78 typeof=SnowLayer
    {
        [StateBit] public  bool CoveredBit { get; set; } = false;
        [StateRange(0, 7)] public  int Height { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "covered_bit":
                        CoveredBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "height":
                        Height = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:snow_layer";
            record.Id = 78;
            record.States.Add(new BlockStateByte {Name = "covered_bit", Value = Convert.ToByte(CoveredBit)});
            record.States.Add(new BlockStateInt {Name = "height", Value = Height});
            return record;
        } // method
    } // class


    public partial class SoulSand  // 88 typeof=SoulSand
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:soul_sand";
            record.Id = 88;
            return record;
        } // method
    } // class


    public partial class Sponge  // 19 typeof=Sponge
    {
        [StateEnum("dry","wet")]
        public  string SpongeType { get; set; } = "dry";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sponge_type":
                        SpongeType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sponge";
            record.Id = 19;
            record.States.Add(new BlockStateString {Name = "sponge_type", Value = SpongeType});
            return record;
        } // method
    } // class

    public partial class SpruceButton  // 399 typeof=SpruceButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_button";
            record.Id = 399;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class SpruceDoor  // 193 typeof=SpruceDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_door";
            record.Id = 193;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class SpruceFenceGate  // 183 typeof=SpruceFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_fence_gate";
            record.Id = 183;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class SprucePressurePlate : PressurePlateBase // 409 typeof=SprucePressurePlate
	{
        public override int RedstoneSignal { get; set; } = 0;
        
        public SprucePressurePlate() : base(409)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_pressure_plate";
            record.Id = 409;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class SpruceStairs  // 134 typeof=SpruceStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_stairs";
            record.Id = 134;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class SpruceStandingSign  // 436 typeof=SpruceStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_standing_sign";
            record.Id = 436;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class SpruceTrapdoor  // 404 typeof=SpruceTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_trapdoor";
            record.Id = 404;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class SpruceWallSign  // 437 typeof=SpruceWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_wall_sign";
            record.Id = 437;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class StandingBanner  // 176 typeof=StandingBanner
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:standing_banner";
            record.Id = 176;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class StandingSign  // 63 typeof=StandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:standing_sign";
            record.Id = 63;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class StickyPiston  // 29 typeof=StickyPiston
    {
        public int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sticky_piston";
            record.Id = 29;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class StickyPistonArmCollision  // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sticky_piston_arm_collision";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Stone  // 1 typeof=Stone
    {
		public string blockName { get; set; } = "minecraft:stone";

		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 1;
            return record;
        } // method
    } // class

    public partial class StoneBrickStairs  // 109 typeof=StoneBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_brick_stairs";
            record.Id = 109;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class StoneButton  // 77 typeof=StoneButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_button";
            record.Id = 77;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class StonePressurePlate  // 70 typeof=StonePressurePlate
    {
        public int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_pressure_plate";
            record.Id = 70;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class StoneStairs  // 67 typeof=StoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_stairs";
            record.Id = 67;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Stonebrick  // 98 typeof=Stonebrick
    {
        [StateEnum("mossy","cracked","chiseled","smooth","default")]
        public  string StoneBrickType { get; set; } = "default";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_brick_type":
                        StoneBrickType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stonebrick";
            record.Id = 98;
            record.States.Add(new BlockStateString {Name = "stone_brick_type", Value = StoneBrickType});
            return record;
        } // method
    } // class

    public partial class Stonecutter  // 245 typeof=Stonecutter
    {
		public string cardinalDirection { get; set; } = "north";
		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stonecutter";
            record.Id = 245;
            return record;
        } // method
    } // class

    public partial class StonecutterBlock : Block // 452 typeof=StonecutterBlock
    {
		public string cardinalDirection { get; set; } = "north";

		public StonecutterBlock() : base(452)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stonecutter_block";
            record.Id = 452;
			record.States.Add(new BlockStateString { Name = "minecraft:cardinal_direction", Value = cardinalDirection });
			return record;
        } // method
    } // class

    public partial class StrippedAcaciaLog : Block // 263 typeof=StrippedAcaciaLog
    {
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";
        
        public StrippedAcaciaLog() : base(263)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_acacia_log";
            record.Id = 263;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedBirchLog : Block // 261 typeof=StrippedBirchLog
    {
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";
        
        public StrippedBirchLog() : base(261)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_birch_log";
            record.Id = 261;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class


    public partial class StrippedDarkOakLog : Block // 264 typeof=StrippedDarkOakLog
    {
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";
        
        public StrippedDarkOakLog() : base(264)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_dark_oak_log";
            record.Id = 264;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedJungleLog : Block // 262 typeof=StrippedJungleLog
    {
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";
        
        public StrippedJungleLog() : base(262)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_jungle_log";
            record.Id = 262;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedOakLog : Block // 265 typeof=StrippedOakLog
    {
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";
        
        public StrippedOakLog() : base(265)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_oak_log";
            record.Id = 265;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedSpruceLog : Block // 260 typeof=StrippedSpruceLog
    {
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";
        
        public StrippedSpruceLog() : base(260)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_spruce_log";
            record.Id = 260;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StructureBlock  // 252 typeof=StructureBlock
    {
        [StateEnum("save","load","corner","invalid","export","data")]
        public  string StructureBlockType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "structure_block_type":
                        StructureBlockType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:structure_block";
            record.Id = 252;
            record.States.Add(new BlockStateString {Name = "structure_block_type", Value = StructureBlockType});
            return record;
        } // method
    } // class

    public partial class StructureVoid  // 0 typeof=Air
    {
        [StateEnum("void","air")]
        public  string StructureVoidType { get; set; } = "void";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "structure_void_type":
                        StructureVoidType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:structure_void";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "structure_void_type", Value = StructureVoidType});
            return record;
        } // method
    } // class

    public partial class SweetBerryBush : Block // 462 typeof=SweetBerryBush
    {
        [StateRange(0, 7)] public  int Growth { get; set; } = 0;
        
        public SweetBerryBush() : base(462)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sweet_berry_bush";
            record.Id = 462;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class Tallgrass  // 31 typeof=Tallgrass
    {
        [StateEnum("default","tall","fern","snow")]
        public  string TallGrassType { get; set; } = "default";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "tall_grass_type":
                        TallGrassType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:tallgrass";
            record.Id = 31;
            record.States.Add(new BlockStateString {Name = "tall_grass_type", Value = TallGrassType});
            return record;
        } // method
    } // class


    public partial class Tnt  // 46 typeof=Tnt
    {
        [StateBit] public  bool AllowUnderwaterBit { get; set; } = false;
        [StateBit] public  bool ExplodeBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "allow_underwater_bit":
                        AllowUnderwaterBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "explode_bit":
                        ExplodeBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:tnt";
            record.Id = 46;
            record.States.Add(new BlockStateByte {Name = "allow_underwater_bit", Value = Convert.ToByte(AllowUnderwaterBit)});
            record.States.Add(new BlockStateByte {Name = "explode_bit", Value = Convert.ToByte(ExplodeBit)});
            return record;
        } // method
    } // class

    public partial class Torch  // 50 typeof=Torch
    {
        [StateEnum("west","east","north","south","top","unknown")]
        public  string TorchFacingDirection { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:torch";
            record.Id = 50;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class Trapdoor  // 96 typeof=Trapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:trapdoor";
            record.Id = 96;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class TrappedChest  // 146 typeof=TrappedChest
    {
		public string cardinalDirection { get; set; } = "north";

		public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
					case BlockStateString s when s.Name == "minecraft:cardinal_direction":
						cardinalDirection = s.Value;
						break;
				} // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:trapped_chest";
            record.Id = 146;
			record.States.Add(new BlockStateString { Name = "minecraft:cardinal_direction", Value = cardinalDirection });
			return record;
        } // method
    } // class

    public partial class TripWire  // 132 typeof=TripWire
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateBit] public  bool DisarmedBit { get; set; } = false;
        [StateBit] public  bool PoweredBit { get; set; } = false;
        [StateBit] public  bool SuspendedBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "disarmed_bit":
                        DisarmedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "suspended_bit":
                        SuspendedBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:trip_wire";
            record.Id = 132;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateByte {Name = "disarmed_bit", Value = Convert.ToByte(DisarmedBit)});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            record.States.Add(new BlockStateByte {Name = "suspended_bit", Value = Convert.ToByte(SuspendedBit)});
            return record;
        } // method
    } // class

    public partial class TripwireHook  // 131 typeof=TripwireHook
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool PoweredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:tripwire_hook";
            record.Id = 131;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            return record;
        } // method
    } // class

    public partial class TurtleEgg : Block // 414 typeof=TurtleEgg
    {
        [StateEnum("cracked","max_cracked","no_cracks")]
        public  string CrackedState { get; set; } = "";
        [StateEnum("one_egg","two_egg","three_egg","four_egg")]
        public  string TurtleEggCount { get; set; } = "";
        
        public TurtleEgg() : base(414)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "cracked_state":
                        CrackedState = s.Value;
                        break;
                    case BlockStateString s when s.Name == "turtle_egg_count":
                        TurtleEggCount = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:turtle_egg";
            record.Id = 414;
            record.States.Add(new BlockStateString {Name = "cracked_state", Value = CrackedState});
            record.States.Add(new BlockStateString {Name = "turtle_egg_count", Value = TurtleEggCount});
            return record;
        } // method
    } // class


    public partial class UnderwaterTorch : Block // 239 typeof=UnderwaterTorch
    {
        [StateEnum("west","east","north","south","top","unknown")]
        public  string TorchFacingDirection { get; set; } = "";
        
        public UnderwaterTorch() : base(239)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:underwater_torch";
            record.Id = 239;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class UnlitRedstoneTorch  // 75 typeof=UnlitRedstoneTorch
    {
        public string TorchFacingDirection { get; set; } = "top";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:unlit_redstone_torch";
            record.Id = 75;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class UnpoweredComparator  // 149 typeof=UnpoweredComparator
    {
        [StateEnum("south","west","north","east")]
        public  string cardinalDirection { get; set; } = "south";
        [StateBit] public  bool OutputLitBit { get; set; } = false;
        [StateBit] public  bool OutputSubtractBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "output_lit_bit":
                        OutputLitBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "output_subtract_bit":
                        OutputSubtractBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:unpowered_comparator";
            record.Id = 149;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            record.States.Add(new BlockStateByte {Name = "output_lit_bit", Value = Convert.ToByte(OutputLitBit)});
            record.States.Add(new BlockStateByte {Name = "output_subtract_bit", Value = Convert.ToByte(OutputSubtractBit)});
            return record;
        } // method
    } // class

    public partial class UnpoweredRepeater  // 93 typeof=UnpoweredRepeater
    {
        [StateEnum("south","west","north","east")]
        public  string cardinalDirection { get; set; } = "south";
        [StateRange(0, 3)] public  int RepeaterDelay { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:cardinal_direction":
                        cardinalDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "repeater_delay":
                        RepeaterDelay = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:unpowered_repeater";
            record.Id = 93;
            record.States.Add(new BlockStateString {Name = "minecraft:cardinal_direction", Value = cardinalDirection});
            record.States.Add(new BlockStateInt {Name = "repeater_delay", Value = RepeaterDelay});
            return record;
        } // method
    } // class

    public partial class Vine  // 106 typeof=Vine
    {
        [StateRange(0, 15)] public  int VineDirectionBits { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "vine_direction_bits":
                        VineDirectionBits = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:vine";
            record.Id = 106;
            record.States.Add(new BlockStateInt {Name = "vine_direction_bits", Value = VineDirectionBits});
            return record;
        } // method
    } // class

    public partial class WallBanner  // 177 typeof=WallBanner
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wall_banner";
            record.Id = 177;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WallSign  // 68 typeof=WallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wall_sign";
            record.Id = 68;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Water  // 9 typeof=Water
    {
        [StateRange(0, 15)] public override int LiquidDepth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "liquid_depth":
                        LiquidDepth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:water";
            record.Id = 9;
            record.States.Add(new BlockStateInt {Name = "liquid_depth", Value = LiquidDepth});
            return record;
        } // method
    } // class

    public partial class Waterlily  // 111 typeof=Waterlily
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waterlily";
            record.Id = 111;
            return record;
        } // method
    } // class

    public partial class Web  // 30 typeof=Web
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:web";
            record.Id = 30;
            return record;
        } // method
    } // class


    public partial class Wheat  // 59 typeof=Wheat
    {
        [StateRange(0, 7)] public override int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wheat";
            record.Id = 59;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class WhiteGlazedTerracotta  // 220 typeof=WhiteGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:white_glazed_terracotta";
            record.Id = 220;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WitherRose  // 471 typeof=WitherRose
	{

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wither_rose";
            record.Id = 471;
            return record;
        } // method
    } // class


    public partial class WoodenButton  // 143 typeof=WoodenButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wooden_button";
            record.Id = 143;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WoodenDoor  // 64 typeof=WoodenDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wooden_door";
            record.Id = 64;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class WoodenPressurePlate  // 72 typeof=WoodenPressurePlate
    {
        public int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wooden_pressure_plate";
            record.Id = 72;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class WoodenSlab  // 158 typeof=WoodenSlab
    {
        [StateEnum("bottom","top")]
        public  string verticalHalf { get; set; } = "";
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string WoodType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "minecraft:vertical_half":
                        verticalHalf = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wood_type":
                        WoodType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wooden_slab";
            record.Id = 158;
            record.States.Add(new BlockStateString {Name = "minecraft:vertical_half", Value = verticalHalf});
            record.States.Add(new BlockStateString {Name = "wood_type", Value = WoodType});
            return record;
        } // method
    } // class

    public partial class YellowFlower  // 37 typeof=YellowFlower
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:yellow_flower";
            record.Id = 37;
            return record;
        } // method
    } // class

    public partial class YellowGlazedTerracotta  // 224 typeof=YellowGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:yellow_glazed_terracotta";
            record.Id = 224;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

	public partial class Coral // 386 typeof=Coral
	{
		public string blockName { get; set; } = "minecraft:fire_coral";
		public override void SetState(List<IBlockState> states)
		{
			foreach (var state in states)
			{
				switch (state)
				{
				} // switch
			} // foreach
		} // method

		public override BlockStateContainer GetState()
		{
			var record = new BlockStateContainer();
			record.Name = blockName;
			record.Id = 386;
			return record;
		} // method
	} // class

	public partial class Allow : Block { public Allow() : base(210) { IsGenerated = true; } }
	public partial class Deny : Block { public Deny() : base(211) { IsGenerated = true; } }
	public partial class StructureVoid : Block { public StructureVoid() : base(217) { IsGenerated = true; } }
	public partial class BorderBlock : Block { public BorderBlock() : base(212) { IsGenerated = true; } }
	public partial class Camera : Block { public Camera() : base(242) { IsGenerated = true; } }
	public partial class Jigsaw : Block { public Jigsaw() : base(466) { IsGenerated = true; } }
	public partial class LightBlock : Block { public LightBlock() : base(470) { IsGenerated = true; } }
	public partial class StickyPistonArmCollision : Block { public StickyPistonArmCollision() : base(472) { IsGenerated = true; } }
	public partial class BeeNest : Block { public BeeNest() : base(473) { IsGenerated = true; } }
	public partial class Beehive : Block { public Beehive() : base(474) { IsGenerated = true; } }
	public partial class HoneyBlock : Block { public HoneyBlock() : base(475) { IsGenerated = true; } }
	public partial class HoneycombBlock : Block { public HoneycombBlock() : base(476) { IsGenerated = true; } }
	public partial class Chain : Block { public Chain() : base(541) { IsGenerated = true; } }

}

