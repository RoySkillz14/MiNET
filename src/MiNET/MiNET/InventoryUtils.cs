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
// All portions of the code written by Niclas Olofsson are Copyright (c) 2014-2018 Niclas Olofsson. 
// All Rights Reserved.

#endregion

using System.Collections.Generic;
using fNbt;
using MiNET.Items;
using MiNET.Utils;

namespace MiNET
{
	// ReSharper disable RedundantArgumentDefaultValue
	public static class InventoryUtils
	{
		public static CreativeItemStacks GetCreativeMetadataSlots()
		{
			CreativeItemStacks slotData = new CreativeItemStacks();
			for (int i = 0; i < CreativeInventoryItems.Count; i++)
			{
				slotData.Add(CreativeInventoryItems[i]);
			}

			return slotData;
		}

		// GENERATED CODE. DON'T EDIT BY HAND
		public static List<Item> CreativeInventoryItems = new List<Item>()
		{
			new Item(5, 0, 1){ RuntimeId=10426, NetworkId=1, ExtraData = null },  /*oak_planks*/  
            new Item(5, 1, 1){ RuntimeId=10427, NetworkId=2, ExtraData = null },  /*spruce_planks*/  
            new Item(5, 2, 1){ RuntimeId=10428, NetworkId=3, ExtraData = null },  /*birch_planks*/  
            new Item(5, 3, 1){ RuntimeId=10429, NetworkId=4, ExtraData = null },  /*jungle_planks*/  
            new Item(5, 4, 1){ RuntimeId=10430, NetworkId=5, ExtraData = null },  /*acacia_planks*/  
            new Item(5, 5, 1){ RuntimeId=10431, NetworkId=6, ExtraData = null },  /*dark_oak_planks*/  
            new Item(139, 0, 1){ RuntimeId=2282, NetworkId=9, ExtraData = null },  /*cobblestone_wall*/  
            new Item(139, 1, 1){ RuntimeId=2283, NetworkId=10, ExtraData = null },  /*mossy_cobblestone_wall*/  
            new Item(139, 2, 1){ RuntimeId=2284, NetworkId=11, ExtraData = null },  /*granite_wall*/  
            new Item(139, 3, 1){ RuntimeId=2285, NetworkId=12, ExtraData = null },  /*diorite_wall*/  
            new Item(139, 4, 1){ RuntimeId=2286, NetworkId=13, ExtraData = null },  /*andesite_wall*/  
            new Item(139, 5, 1){ RuntimeId=2287, NetworkId=14, ExtraData = null },  /*sandstone_wall*/  
            new Item(139, 6, 1){ RuntimeId=2294, NetworkId=15, ExtraData = null },  /*red_sandstone_wall*/  
            new Item(139, 7, 1){ RuntimeId=2289, NetworkId=16, ExtraData = null },  /*stone_brick_wall*/  
            new Item(139, 8, 1){ RuntimeId=2290, NetworkId=17, ExtraData = null },  /*mossy_stone_brick_wall*/  
            new Item(139, 9, 1){ RuntimeId=2288, NetworkId=18, ExtraData = null },  /*brick_wall*/  
            new Item(139, 10, 1){ RuntimeId=2291, NetworkId=19, ExtraData = null },  /*nether_brick_wall*/  
            new Item(139, 11, 1){ RuntimeId=2295, NetworkId=20, ExtraData = null },  /*red_nether_brick_wall*/  
            new Item(139, 12, 1){ RuntimeId=2292, NetworkId=21, ExtraData = null },  /*end_stone_wall*/  
            new Item(139, 13, 1){ RuntimeId=2293, NetworkId=22, ExtraData = null },  /*prismarine_wall*/  
            new Item(85, 0, 1){ RuntimeId=8896, NetworkId=26, ExtraData = null },  /*oak_fence*/  
            new Item(85, 1, 1){ RuntimeId=1127, NetworkId=27, ExtraData = null },  /*spruce_fence*/  
            new Item(85, 2, 1){ RuntimeId=12887, NetworkId=28, ExtraData = null },  /*birch_fence*/  
            new Item(85, 3, 1){ RuntimeId=1120, NetworkId=29, ExtraData = null },  /*jungle_fence*/  
            new Item(85, 4, 1){ RuntimeId=12891, NetworkId=30, ExtraData = null },  /*acacia_fence*/  
            new Item(85, 5, 1){ RuntimeId=11458, NetworkId=31, ExtraData = null },  /*dark_oak_fence*/  
            new Item(113, 0, 1){ RuntimeId=6554, NetworkId=32, ExtraData = null },  /*nether_brick_fence*/  
            new Item(107, 0, 1){ RuntimeId=82, NetworkId=35, ExtraData = null },  /*oak_fence_gate*/  
            new Item(183, 0, 1){ RuntimeId=10947, NetworkId=36, ExtraData = null },  /*spruce_fence_gate*/  
            new Item(184, 0, 1){ RuntimeId=5650, NetworkId=37, ExtraData = null },  /*birch_fence_gate*/  
            new Item(185, 0, 1){ RuntimeId=8511, NetworkId=38, ExtraData = null },  /*jungle_fence_gate*/  
            new Item(187, 0, 1){ RuntimeId=12384, NetworkId=39, ExtraData = null },  /*acacia_fence_gate*/  
            new Item(186, 0, 1){ RuntimeId=6427, NetworkId=40, ExtraData = null },  /*dark_oak_fence_gate*/  
            new Item(-180, 0, 1){ RuntimeId=1352, NetworkId=43, ExtraData = null },  /*stone_stairs*/  
            new Item(67, 0, 1){ RuntimeId=5574, NetworkId=44, ExtraData = null },  /*cobblestone_stairs*/  
            new Item(-179, 0, 1){ RuntimeId=6344, NetworkId=45, ExtraData = null },  /*mossy_cobblestone_stairs*/  
            new Item(53, 0, 1){ RuntimeId=709, NetworkId=46, ExtraData = null },  /*oak_stairs*/  
            new Item(134, 0, 1){ RuntimeId=137, NetworkId=47, ExtraData = null },  /*spruce_stairs*/  
            new Item(135, 0, 1){ RuntimeId=11374, NetworkId=48, ExtraData = null },  /*birch_stairs*/  
            new Item(136, 0, 1){ RuntimeId=11335, NetworkId=49, ExtraData = null },  /*jungle_stairs*/  
            new Item(163, 0, 1){ RuntimeId=10556, NetworkId=50, ExtraData = null },  /*acacia_stairs*/  
            new Item(164, 0, 1){ RuntimeId=8206, NetworkId=51, ExtraData = null },  /*dark_oak_stairs*/  
            new Item(109, 0, 1){ RuntimeId=2050, NetworkId=52, ExtraData = null },  /*stone_brick_stairs*/  
            new Item(-175, 0, 1){ RuntimeId=9834, NetworkId=53, ExtraData = null },  /*mossy_stone_brick_stairs*/  
            new Item(128, 0, 1){ RuntimeId=5446, NetworkId=54, ExtraData = null },  /*sandstone_stairs*/  
            new Item(-177, 0, 1){ RuntimeId=5492, NetworkId=55, ExtraData = null },  /*smooth_sandstone_stairs*/  
            new Item(180, 0, 1){ RuntimeId=8496, NetworkId=56, ExtraData = null },  /*red_sandstone_stairs*/  
            new Item(-176, 0, 1){ RuntimeId=8694, NetworkId=57, ExtraData = null },  /*smooth_red_sandstone_stairs*/  
            new Item(-169, 0, 1){ RuntimeId=5010, NetworkId=58, ExtraData = null },  /*granite_stairs*/  
            new Item(-172, 0, 1){ RuntimeId=6403, NetworkId=59, ExtraData = null },  /*polished_granite_stairs*/  
            new Item(-170, 0, 1){ RuntimeId=6695, NetworkId=60, ExtraData = null },  /*diorite_stairs*/  
            new Item(-173, 0, 1){ RuntimeId=11066, NetworkId=61, ExtraData = null },  /*polished_diorite_stairs*/  
            new Item(-171, 0, 1){ RuntimeId=8468, NetworkId=62, ExtraData = null },  /*andesite_stairs*/  
            new Item(-174, 0, 1){ RuntimeId=11401, NetworkId=63, ExtraData = null },  /*polished_andesite_stairs*/  
            new Item(108, 0, 1){ RuntimeId=10892, NetworkId=64, ExtraData = null },  /*brick_stairs*/  
            new Item(114, 0, 1){ RuntimeId=112, NetworkId=65, ExtraData = null },  /*nether_brick_stairs*/  
            new Item(-184, 0, 1){ RuntimeId=10965, NetworkId=66, ExtraData = null },  /*red_nether_brick_stairs*/  
            new Item(-178, 0, 1){ RuntimeId=10737, NetworkId=67, ExtraData = null },  /*end_stone_brick_stairs*/  
            new Item(156, 0, 1){ RuntimeId=7517, NetworkId=68, ExtraData = null },  /*quartz_stairs*/  
            new Item(-185, 0, 1){ RuntimeId=12498, NetworkId=69, ExtraData = null },  /*smooth_quartz_stairs*/  
            new Item(203, 0, 1){ RuntimeId=12561, NetworkId=70, ExtraData = null },  /*purpur_stairs*/  
            new Item(-2, 0, 1){ RuntimeId=12059, NetworkId=71, ExtraData = null },  /*prismarine_stairs*/  
            new Item(-3, 0, 1){ RuntimeId=12227, NetworkId=72, ExtraData = null },  /*dark_prismarine_stairs*/  
            new Item(-4, 0, 1){ RuntimeId=618, NetworkId=73, ExtraData = null },  /*prismarine_brick_stairs*/  
            new Item(324, 0, 1){ RuntimeId=0, NetworkId=79, ExtraData = null },  /*oak_door*/  
            new Item(427, 0, 1){ RuntimeId=0, NetworkId=80, ExtraData = null },  /*minecraft:spruce_door*/  
            new Item(428, 0, 1){ RuntimeId=0, NetworkId=81, ExtraData = null },  /*minecraft:birch_door*/  
            new Item(429, 0, 1){ RuntimeId=0, NetworkId=82, ExtraData = null },  /*minecraft:jungle_door*/  
            new Item(430, 0, 1){ RuntimeId=0, NetworkId=83, ExtraData = null },  /*minecraft:acacia_door*/  
            new Item(431, 0, 1){ RuntimeId=0, NetworkId=84, ExtraData = null },  /*minecraft:dark_oak_door*/  
            new Item(330, 0, 1){ RuntimeId=0, NetworkId=85, ExtraData = null },  /*minecraft:iron_door*/  
            new Item(96, 0, 1){ RuntimeId=647, NetworkId=88, ExtraData = null },  /*oak_trapdoor*/  
            new Item(-149, 0, 1){ RuntimeId=10915, NetworkId=89, ExtraData = null },  /*spruce_trapdoor*/  
            new Item(-146, 0, 1){ RuntimeId=11013, NetworkId=90, ExtraData = null },  /*birch_trapdoor*/  
            new Item(-148, 0, 1){ RuntimeId=8527, NetworkId=91, ExtraData = null },  /*jungle_trapdoor*/  
            new Item(-145, 0, 1){ RuntimeId=8735, NetworkId=92, ExtraData = null },  /*acacia_trapdoor*/  
            new Item(-147, 0, 1){ RuntimeId=12300, NetworkId=93, ExtraData = null },  /*dark_oak_trapdoor*/  
            new Item(167, 0, 1){ RuntimeId=1051, NetworkId=94, ExtraData = null },  /*iron_trapdoor*/  
            new Item(101, 0, 1){ RuntimeId=7552, NetworkId=97, ExtraData = null },  /*iron_bars*/  
            new Item(20, 0, 1){ RuntimeId=10536, NetworkId=98, ExtraData = null },  /*glass*/  
            new Item(241, 0, 1){ RuntimeId=7990, NetworkId=99, ExtraData = null },  /**/  
            new Item(241, 1, 1){ RuntimeId=1165, NetworkId=100, ExtraData = null },  /**/  
            new Item(241, 2, 1){ RuntimeId=5582, NetworkId=101, ExtraData = null },  /**/  
            new Item(241, 3, 1){ RuntimeId=9869, NetworkId=102, ExtraData = null },  /**/  
            new Item(241, 4, 1){ RuntimeId=1755, NetworkId=103, ExtraData = null },  /**/  
            new Item(241, 5, 1){ RuntimeId=8390, NetworkId=104, ExtraData = null },  /**/  
            new Item(241, 6, 1){ RuntimeId=6861, NetworkId=105, ExtraData = null },  /**/  
            new Item(241, 7, 1){ RuntimeId=12382, NetworkId=106, ExtraData = null },  /**/  
            new Item(241, 8, 1){ RuntimeId=123, NetworkId=107, ExtraData = null },  /**/  
            new Item(241, 9, 1){ RuntimeId=6553, NetworkId=108, ExtraData = null },  /**/  
            new Item(241, 10, 1){ RuntimeId=9868, NetworkId=109, ExtraData = null },  /**/  
            new Item(241, 11, 1){ RuntimeId=8937, NetworkId=110, ExtraData = null },  /**/  
            new Item(241, 12, 1){ RuntimeId=8901, NetworkId=111, ExtraData = null },  /**/  
            new Item(241, 13, 1){ RuntimeId=2274, NetworkId=112, ExtraData = null },  /**/  
            new Item(241, 14, 1){ RuntimeId=12020, NetworkId=113, ExtraData = null },  /**/  
            new Item(241, 15, 1){ RuntimeId=6619, NetworkId=114, ExtraData = null },  /**/  
            new Item(102, 0, 1){ RuntimeId=8376, NetworkId=115, ExtraData = null },  /*glass_pane*/  
            new Item(160, 0, 1){ RuntimeId=6862, NetworkId=116, ExtraData = null },  /**/  
            new Item(160, 1, 1){ RuntimeId=1167, NetworkId=117, ExtraData = null },  /**/  
            new Item(160, 2, 1){ RuntimeId=11262, NetworkId=118, ExtraData = null },  /**/  
            new Item(160, 3, 1){ RuntimeId=2281, NetworkId=119, ExtraData = null },  /**/  
            new Item(160, 4, 1){ RuntimeId=720, NetworkId=120, ExtraData = null },  /**/  
            new Item(160, 5, 1){ RuntimeId=11450, NetworkId=121, ExtraData = null },  /**/  
            new Item(160, 6, 1){ RuntimeId=639, NetworkId=122, ExtraData = null },  /**/  
            new Item(160, 7, 1){ RuntimeId=554, NetworkId=123, ExtraData = null },  /**/  
            new Item(160, 8, 1){ RuntimeId=12380, NetworkId=124, ExtraData = null },  /**/  
            new Item(160, 9, 1){ RuntimeId=6402, NetworkId=125, ExtraData = null },  /**/  
            new Item(160, 10, 1){ RuntimeId=10849, NetworkId=126, ExtraData = null },  /**/  
            new Item(160, 11, 1){ RuntimeId=6136, NetworkId=127, ExtraData = null },  /**/  
            new Item(160, 12, 1){ RuntimeId=81, NetworkId=128, ExtraData = null },  /**/  
            new Item(160, 13, 1){ RuntimeId=7991, NetworkId=129, ExtraData = null },  /**/  
            new Item(160, 14, 1){ RuntimeId=7551, NetworkId=130, ExtraData = null },  /**/  
            new Item(160, 15, 1){ RuntimeId=11455, NetworkId=131, ExtraData = null },  /**/  
            new Item(65, 0, 1){ RuntimeId=13094, NetworkId=132, ExtraData = null },  /*ladder*/  
            new Item(-165, 0, 1){ RuntimeId=5430, NetworkId=133, ExtraData = null },  /*scaffolding*/  
            new Item(44, 0, 1){ RuntimeId=6531, NetworkId=134, ExtraData = null },  /*smooth_stone_slab*/  
            new Item(-166, 0, 1){ RuntimeId=8972, NetworkId=135, ExtraData = null },  /*stone_slab*/  
            new Item(44, 1, 1){ RuntimeId=6534, NetworkId=136, ExtraData = null },  /*cobblestone_slab*/  
            new Item(182, 0, 1){ RuntimeId=8943, NetworkId=137, ExtraData = null },  /*mossy_cobblestone_slab*/  
            new Item(158, 0, 1){ RuntimeId=8430, NetworkId=138, ExtraData = null },  /*oak_slab*/  
            new Item(158, 1, 1){ RuntimeId=8431, NetworkId=139, ExtraData = null },  /*spruce_slab*/  
            new Item(158, 2, 1){ RuntimeId=8432, NetworkId=140, ExtraData = null },  /*birch_slab*/  
            new Item(158, 3, 1){ RuntimeId=8433, NetworkId=141, ExtraData = null },  /*jungle_slab*/  
            new Item(158, 4, 1){ RuntimeId=8434, NetworkId=142, ExtraData = null },  /*acacia_slab*/  
            new Item(158, 5, 1){ RuntimeId=8435, NetworkId=143, ExtraData = null },  /*dark_oak_slab*/  
            new Item(44, 2, 1){ RuntimeId=6536, NetworkId=144, ExtraData = null },  /*stone_brick_slab*/  
            new Item(-166, 1, 1){ RuntimeId=8970, NetworkId=145, ExtraData = null },  /*mossy_stone_brick_slab*/  
            new Item(44, 3, 1){ RuntimeId=6532, NetworkId=146, ExtraData = null },  /*sandstone_slab*/  
            new Item(-166, 2, 1){ RuntimeId=8973, NetworkId=147, ExtraData = null },  /*cut_sandstone_slab*/  
            new Item(182, 1, 1){ RuntimeId=8944, NetworkId=148, ExtraData = null },  /*smooth_sandstone_slab*/  
            new Item(182, 2, 1){ RuntimeId=8938, NetworkId=149, ExtraData = null },  /*red_sandstone_slab*/  
            new Item(-166, 3, 1){ RuntimeId=8974, NetworkId=150, ExtraData = null },  /*cut_red_sandstone_slab*/  
            new Item(-162, 0, 1){ RuntimeId=8955, NetworkId=151, ExtraData = null },  /*smooth_red_sandstone_slab*/  
            new Item(-162, 1, 1){ RuntimeId=8960, NetworkId=152, ExtraData = null },  /*granite_slab*/  
            new Item(-162, 2, 1){ RuntimeId=8961, NetworkId=153, ExtraData = null },  /*polished_granite_slab*/  
            new Item(-162, 3, 1){ RuntimeId=8958, NetworkId=154, ExtraData = null },  /*diorite_slab*/  
            new Item(-162, 4, 1){ RuntimeId=8959, NetworkId=155, ExtraData = null },  /*polished_diorite_slab*/  
            new Item(-162, 5, 1){ RuntimeId=8957, NetworkId=156, ExtraData = null },  /*andesite_slab*/  
            new Item(-162, 6, 1){ RuntimeId=8956, NetworkId=157, ExtraData = null },  /*polished_andesite_slab*/  
            new Item(44, 4, 1){ RuntimeId=6535, NetworkId=158, ExtraData = null },  /*bricks_slab*/  
            new Item(44, 5, 1){ RuntimeId=6538, NetworkId=159, ExtraData = null },  /*nether_brick_slab*/  
            new Item(182, 3, 1){ RuntimeId=8945, NetworkId=160, ExtraData = null },  /*red_nether_brick_slab*/  
            new Item(-162, 7, 1){ RuntimeId=8954, NetworkId=161, ExtraData = null },  /*end_stone_brick_slab*/  
            new Item(44, 6, 1){ RuntimeId=6537, NetworkId=162, ExtraData = null },  /*quartz_slab*/  
            new Item(-166, 4, 1){ RuntimeId=8971, NetworkId=163, ExtraData = null },  /*smooth_quartz_slab*/  
            new Item(182, 4, 1){ RuntimeId=8939, NetworkId=164, ExtraData = null },  /*purpur_slab*/  
            new Item(182, 5, 1){ RuntimeId=8940, NetworkId=165, ExtraData = null },  /*prismarine_slab*/  
            new Item(182, 6, 1){ RuntimeId=8941, NetworkId=166, ExtraData = null },  /*dark_prismarine_slab*/  
            new Item(182, 7, 1){ RuntimeId=8942, NetworkId=167, ExtraData = null },  /*prismarine_bricks_slab*/  
            new Item(45, 0, 1){ RuntimeId=7515, NetworkId=173, ExtraData = null },  /*brick_block*/  
            new Item(-304, 0, 1){ RuntimeId=10706, NetworkId=176, ExtraData = null },  /*quartz_bricks*/  
            new Item(98, 0, 1){ RuntimeId=10910, NetworkId=177, ExtraData = null },  /*stone_bricks*/  
            new Item(98, 1, 1){ RuntimeId=10911, NetworkId=178, ExtraData = null },  /*mossy_stone_bricks*/  
            new Item(98, 2, 1){ RuntimeId=10912, NetworkId=179, ExtraData = null },  /*cracked_stone_bricks*/  
            new Item(98, 3, 1){ RuntimeId=10913, NetworkId=180, ExtraData = null },  /*chiseled_stone_bricks*/  
            new Item(206, 0, 1){ RuntimeId=721, NetworkId=181, ExtraData = null },  /*end_stone_bricks*/  
            new Item(168, 0, 1){ RuntimeId=10458, NetworkId=182, ExtraData = null },  /*prismarine_bricks*/  
            new Item(4, 0, 1){ RuntimeId=5477, NetworkId=187, ExtraData = null },  /*cobblestone*/  
            new Item(48, 0, 1){ RuntimeId=670, NetworkId=188, ExtraData = null },  /*mossy_cobblestone*/  
            new Item(-183, 0, 1){ RuntimeId=6893, NetworkId=189, ExtraData = null },  /*smooth_stone*/  
            new Item(24, 0, 1){ RuntimeId=5519, NetworkId=190, ExtraData = null },  /*sandstone*/  
            new Item(24, 1, 1){ RuntimeId=5520, NetworkId=191, ExtraData = null },  /*chiseled_sandstone*/  
            new Item(24, 2, 1){ RuntimeId=5521, NetworkId=192, ExtraData = null },  /*cut_sandstone*/  
            new Item(24, 3, 1){ RuntimeId=5522, NetworkId=193, ExtraData = null },  /*smooth_sandstone*/  
            new Item(179, 0, 1){ RuntimeId=10943, NetworkId=194, ExtraData = null },  /*red_sandstone*/  
            new Item(179, 1, 1){ RuntimeId=10944, NetworkId=195, ExtraData = null },  /*chiseled_red_sandstone*/  
            new Item(179, 2, 1){ RuntimeId=10945, NetworkId=196, ExtraData = null },  /*cut_red_sandstone*/  
            new Item(179, 3, 1){ RuntimeId=10946, NetworkId=197, ExtraData = null },  /*smooth_red_sandstone*/  
            new Item(173, 0, 1){ RuntimeId=8544, NetworkId=198, ExtraData = null },  /*coal_block*/  
            new Item(-139, 0, 1){ RuntimeId=12784, NetworkId=199, ExtraData = null },  /*dried_kelp_block*/  
            new Item(41, 0, 1){ RuntimeId=764, NetworkId=200, ExtraData = null },  /*gold_block*/  
            new Item(42, 0, 1){ RuntimeId=13093, NetworkId=201, ExtraData = null },  /*iron_block*/  
            new Item(133, 0, 1){ RuntimeId=2249, NetworkId=202, ExtraData = null },  /*emerald_block*/  
            new Item(57, 0, 1){ RuntimeId=708, NetworkId=203, ExtraData = null },  /*diamond_block*/  
            new Item(22, 0, 1){ RuntimeId=6547, NetworkId=204, ExtraData = null },  /*lapis_lazuli_block*/  
            new Item(155, 0, 1){ RuntimeId=5562, NetworkId=205, ExtraData = null },  /*quartz_block*/  
            new Item(155, 1, 1){ RuntimeId=5564, NetworkId=206, ExtraData = null },  /*pillar_quartz_block*/  
            new Item(155, 2, 1){ RuntimeId=5563, NetworkId=207, ExtraData = null },  /*chiseled_quartz_block*/  
            new Item(155, 3, 1){ RuntimeId=5565, NetworkId=208, ExtraData = null },  /*smooth_quartz_block*/  
            new Item(168, 0, 1){ RuntimeId=10456, NetworkId=209, ExtraData = null },  /*prismarine*/  
            new Item(168, 1, 1){ RuntimeId=10457, NetworkId=210, ExtraData = null },  /*dark_prismarine*/  
            new Item(165, 0, 1){ RuntimeId=6491, NetworkId=211, ExtraData = null },  /*slime_block*/  
            new Item(170, 0, 1){ RuntimeId=1789, NetworkId=214, ExtraData = null },  /*haybale*/  
            new Item(216, 0, 1){ RuntimeId=6492, NetworkId=215, ExtraData = null },  /*bone_block*/  
            new Item(112, 0, 1){ RuntimeId=12071, NetworkId=216, ExtraData = null },  /*nether_brick_block*/  
            new Item(215, 0, 1){ RuntimeId=557, NetworkId=217, ExtraData = null },  /*red_nether_brick*/  
            new Item(35, 0, 1){ RuntimeId=8545, NetworkId=220, ExtraData = null },  /*white_wool*/  
            new Item(35, 1, 1){ RuntimeId=12862, NetworkId=221, ExtraData = null },  /**/  
            new Item(35, 2, 1){ RuntimeId=638, NetworkId=222, ExtraData = null },  /**/  
            new Item(35, 3, 1){ RuntimeId=1095, NetworkId=223, ExtraData = null },  /**/  
            new Item(35, 4, 1){ RuntimeId=691, NetworkId=224, ExtraData = null },  /**/  
            new Item(35, 5, 1){ RuntimeId=124, NetworkId=225, ExtraData = null },  /**/  
            new Item(35, 6, 1){ RuntimeId=1769, NetworkId=226, ExtraData = null },  /**/  
            new Item(35, 7, 1){ RuntimeId=547, NetworkId=227, ExtraData = null },  /**/  
            new Item(35, 8, 1){ RuntimeId=10349, NetworkId=228, ExtraData = null },  /**/  
            new Item(35, 9, 1){ RuntimeId=5595, NetworkId=229, ExtraData = null },  /**/  
            new Item(35, 10, 1){ RuntimeId=8488, NetworkId=230, ExtraData = null },  /**/  
            new Item(35, 11, 1){ RuntimeId=11456, NetworkId=231, ExtraData = null },  /**/  
            new Item(35, 12, 1){ RuntimeId=8626, NetworkId=232, ExtraData = null },  /**/  
            new Item(35, 13, 1){ RuntimeId=13092, NetworkId=233, ExtraData = null },  /**/  
            new Item(35, 14, 1){ RuntimeId=2070, NetworkId=234, ExtraData = null },  /**/  
            new Item(35, 15, 1){ RuntimeId=5648, NetworkId=235, ExtraData = null },  /**/  
            new Item(171, 0, 1){ RuntimeId=12067, NetworkId=236, ExtraData = null },  /*white_carpet*/  
            new Item(171, 1, 1){ RuntimeId=13091, NetworkId=237, ExtraData = null },  /**/  
            new Item(171, 2, 1){ RuntimeId=640, NetworkId=238, ExtraData = null },  /**/  
            new Item(171, 3, 1){ RuntimeId=10388, NetworkId=239, ExtraData = null },  /**/  
            new Item(171, 4, 1){ RuntimeId=2045, NetworkId=240, ExtraData = null },  /**/  
            new Item(171, 5, 1){ RuntimeId=12217, NetworkId=241, ExtraData = null },  /**/  
            new Item(171, 6, 1){ RuntimeId=11447, NetworkId=242, ExtraData = null },  /**/  
            new Item(171, 7, 1){ RuntimeId=9867, NetworkId=243, ExtraData = null },  /**/  
            new Item(171, 8, 1){ RuntimeId=11077, NetworkId=244, ExtraData = null },  /**/  
            new Item(171, 9, 1){ RuntimeId=5596, NetworkId=245, ExtraData = null },  /**/  
            new Item(171, 10, 1){ RuntimeId=5480, NetworkId=246, ExtraData = null },  /**/  
            new Item(171, 11, 1){ RuntimeId=7554, NetworkId=247, ExtraData = null },  /**/  
            new Item(171, 12, 1){ RuntimeId=590, NetworkId=248, ExtraData = null },  /**/  
            new Item(171, 13, 1){ RuntimeId=12555, NetworkId=249, ExtraData = null },  /**/  
            new Item(171, 14, 1){ RuntimeId=674, NetworkId=250, ExtraData = null },  /**/  
            new Item(171, 15, 1){ RuntimeId=12497, NetworkId=251, ExtraData = null },  /**/  
            new Item(237, 0, 1){ RuntimeId=7939, NetworkId=252, ExtraData = null },  /*white_concrete_powder*/  
            new Item(237, 1, 1){ RuntimeId=12051, NetworkId=253, ExtraData = null },  /**/  
            new Item(237, 2, 1){ RuntimeId=12163, NetworkId=254, ExtraData = null },  /**/  
            new Item(237, 3, 1){ RuntimeId=1129, NetworkId=255, ExtraData = null },  /**/  
            new Item(237, 4, 1){ RuntimeId=9441, NetworkId=256, ExtraData = null },  /**/  
            new Item(237, 5, 1){ RuntimeId=12050, NetworkId=257, ExtraData = null },  /**/  
            new Item(237, 6, 1){ RuntimeId=13055, NetworkId=258, ExtraData = null },  /**/  
            new Item(237, 7, 1){ RuntimeId=12375, NetworkId=259, ExtraData = null },  /**/  
            new Item(237, 8, 1){ RuntimeId=12802, NetworkId=260, ExtraData = null },  /**/  
            new Item(237, 9, 1){ RuntimeId=11388, NetworkId=261, ExtraData = null },  /**/  
            new Item(237, 10, 1){ RuntimeId=5405, NetworkId=262, ExtraData = null },  /**/  
            new Item(237, 11, 1){ RuntimeId=61, NetworkId=263, ExtraData = null },  /**/  
            new Item(237, 12, 1){ RuntimeId=11074, NetworkId=264, ExtraData = null },  /**/  
            new Item(237, 13, 1){ RuntimeId=10901, NetworkId=265, ExtraData = null },  /**/  
            new Item(237, 14, 1){ RuntimeId=6752, NetworkId=266, ExtraData = null },  /**/  
            new Item(237, 15, 1){ RuntimeId=6557, NetworkId=267, ExtraData = null },  /**/  
            new Item(236, 0, 1){ RuntimeId=12890, NetworkId=268, ExtraData = null },  /*white_concrete*/  
            new Item(236, 1, 1){ RuntimeId=1779, NetworkId=269, ExtraData = null },  /**/  
            new Item(236, 2, 1){ RuntimeId=12164, NetworkId=270, ExtraData = null },  /**/  
            new Item(236, 3, 1){ RuntimeId=11058, NetworkId=271, ExtraData = null },  /**/  
            new Item(236, 4, 1){ RuntimeId=10572, NetworkId=272, ExtraData = null },  /**/  
            new Item(236, 5, 1){ RuntimeId=12496, NetworkId=273, ExtraData = null },  /**/  
            new Item(236, 6, 1){ RuntimeId=11075, NetworkId=274, ExtraData = null },  /**/  
            new Item(236, 7, 1){ RuntimeId=5479, NetworkId=275, ExtraData = null },  /**/  
            new Item(236, 8, 1){ RuntimeId=6895, NetworkId=276, ExtraData = null },  /**/  
            new Item(236, 9, 1){ RuntimeId=9851, NetworkId=277, ExtraData = null },  /**/  
            new Item(236, 10, 1){ RuntimeId=12068, NetworkId=278, ExtraData = null },  /**/  
            new Item(236, 11, 1){ RuntimeId=12235, NetworkId=279, ExtraData = null },  /**/  
            new Item(236, 12, 1){ RuntimeId=12070, NetworkId=280, ExtraData = null },  /**/  
            new Item(236, 13, 1){ RuntimeId=6448, NetworkId=281, ExtraData = null },  /**/  
            new Item(236, 14, 1){ RuntimeId=6666, NetworkId=282, ExtraData = null },  /**/  
            new Item(236, 15, 1){ RuntimeId=5018, NetworkId=283, ExtraData = null },  /**/  
            new Item(82, 0, 1){ RuntimeId=11504, NetworkId=284, ExtraData = null },  /*clay_block*/  
            new Item(172, 0, 1){ RuntimeId=1360, NetworkId=285, ExtraData = null },  /*terracotta*/  
            new Item(159, 0, 1){ RuntimeId=7553, NetworkId=286, ExtraData = null },  /*white_terracotta*/  
            new Item(159, 1, 1){ RuntimeId=1750, NetworkId=287, ExtraData = null },  /**/  
            new Item(159, 2, 1){ RuntimeId=6894, NetworkId=288, ExtraData = null },  /**/  
            new Item(159, 3, 1){ RuntimeId=10461, NetworkId=289, ExtraData = null },  /**/  
            new Item(159, 4, 1){ RuntimeId=12828, NetworkId=290, ExtraData = null },  /**/  
            new Item(159, 5, 1){ RuntimeId=2069, NetworkId=291, ExtraData = null },  /**/  
            new Item(159, 6, 1){ RuntimeId=12340, NetworkId=292, ExtraData = null },  /**/  
            new Item(159, 7, 1){ RuntimeId=6451, NetworkId=293, ExtraData = null },  /**/  
            new Item(159, 8, 1){ RuntimeId=13065, NetworkId=294, ExtraData = null },  /**/  
            new Item(159, 9, 1){ RuntimeId=5583, NetworkId=295, ExtraData = null },  /**/  
            new Item(159, 10, 1){ RuntimeId=0, NetworkId=296, ExtraData = null },  /**/  
            new Item(159, 11, 1){ RuntimeId=6654, NetworkId=297, ExtraData = null },  /**/  
            new Item(159, 12, 1){ RuntimeId=5518, NetworkId=298, ExtraData = null },  /**/  
            new Item(159, 13, 1){ RuntimeId=10745, NetworkId=299, ExtraData = null },  /**/  
            new Item(159, 14, 1){ RuntimeId=6900, NetworkId=300, ExtraData = null },  /**/  
            new Item(159, 15, 1){ RuntimeId=6411, NetworkId=301, ExtraData = null },  /**/  
            new Item(220, 0, 1){ RuntimeId=8721, NetworkId=302, ExtraData = null },  /*white_glazed_terracotta*/  
            new Item(228, 0, 1){ RuntimeId=5004, NetworkId=303, ExtraData = null },  /**/  
            new Item(227, 0, 1){ RuntimeId=13082, NetworkId=304, ExtraData = null },  /**/  
            new Item(235, 0, 1){ RuntimeId=9372, NetworkId=305, ExtraData = null },  /**/  
            new Item(232, 0, 1){ RuntimeId=5406, NetworkId=306, ExtraData = null },  /**/  
            new Item(234, 0, 1){ RuntimeId=6421, NetworkId=307, ExtraData = null },  /**/  
            new Item(221, 0, 1){ RuntimeId=2241, NetworkId=308, ExtraData = null },  /**/  
            new Item(224, 0, 1){ RuntimeId=2031, NetworkId=309, ExtraData = null },  /**/  
            new Item(225, 0, 1){ RuntimeId=641, NetworkId=310, ExtraData = null },  /**/  
            new Item(233, 0, 1){ RuntimeId=10973, NetworkId=311, ExtraData = null },  /**/  
            new Item(229, 0, 1){ RuntimeId=8504, NetworkId=312, ExtraData = null },  /*cyan_glazed_terracotta*/  
            new Item(223, 0, 1){ RuntimeId=8618, NetworkId=313, ExtraData = null },  /*light_blue_glazed_terracotta*/  
            new Item(231, 0, 1){ RuntimeId=8612, NetworkId=314, ExtraData = null },  /*_glazed_terracotta*/  
            new Item(219, 0, 1){ RuntimeId=11382, NetworkId=315, ExtraData = null },  /*_glazed_terracotta*/  
            new Item(222, 0, 1){ RuntimeId=2071, NetworkId=316, ExtraData = null },  /*_glazed_terracotta*/  
            new Item(226, 0, 1){ RuntimeId=10902, NetworkId=317, ExtraData = null },  /*pink_glazed_terracotta*/  
            new Item(201, 0, 1){ RuntimeId=12512, NetworkId=318, ExtraData = null },  /*purpur_block*/  
            new Item(201, 1, 1){ RuntimeId=12514, NetworkId=319, ExtraData = null },  /*purpur_pillar*/  
            new Item(214, 0, 1){ RuntimeId=6559, NetworkId=320, ExtraData = null },  /*nether_wart_block*/  
            new Item(-230, 0, 1){ RuntimeId=8188, NetworkId=322, ExtraData = null },  /*shroomlight*/  
            new Item(87, 0, 1){ RuntimeId=11410, NetworkId=325, ExtraData = null },  /*netherrack*/  
            new Item(3, 0, 1){ RuntimeId=8899, NetworkId=329, ExtraData = null },  /*dirt*/  
            new Item(3, 0, 1){ RuntimeId=8900, NetworkId=330, ExtraData = null },  /*coarse_dirt*/  
            new Item(60, 0, 1){ RuntimeId=6164, NetworkId=331, ExtraData = null },  /*farmland*/  
            new Item(2, 0, 1){ RuntimeId=11343, NetworkId=332, ExtraData = null },  /*grass_block*/  
            new Item(198, 0, 1){ RuntimeId=12892, NetworkId=333, ExtraData = null },  /*dirt_path*/  
            new Item(243, 0, 1){ RuntimeId=7392, NetworkId=334, ExtraData = null },  /*podzol*/  
            new Item(110, 0, 1){ RuntimeId=5549, NetworkId=335, ExtraData = null },  /*mycelium*/  
            new Item(1, 0, 1){ RuntimeId=1757, NetworkId=336, ExtraData = null },  /*stone*/  
            new Item(15, 0, 1){ RuntimeId=7432, NetworkId=337, ExtraData = null },  /*iron_ore*/  
            new Item(14, 0, 1){ RuntimeId=2030, NetworkId=338, ExtraData = null },  /*gold_ore*/  
            new Item(56, 0, 1){ RuntimeId=6664, NetworkId=339, ExtraData = null },  /*diamond_ore*/  
            new Item(21, 0, 1){ RuntimeId=12495, NetworkId=340, ExtraData = null },  /*lapis_lazuli_ore*/  
            new Item(73, 0, 1){ RuntimeId=6550, NetworkId=341, ExtraData = null },  /*redstone_ore*/  
            new Item(16, 0, 1){ RuntimeId=6548, NetworkId=342, ExtraData = null },  /*coal_ore*/  
            new Item(129, 0, 1){ RuntimeId=12146, NetworkId=343, ExtraData = null },  /*emerald_ore*/  
            new Item(153, 0, 1){ RuntimeId=6810, NetworkId=344, ExtraData = null },  /*nether_quartz_ore*/  
            new Item(13, 0, 1){ RuntimeId=13119, NetworkId=347, ExtraData = null },  /*gravel*/  
            new Item(1, 1, 1){ RuntimeId=1758, NetworkId=348, ExtraData = null },  /*granite*/  
            new Item(1, 2, 1){ RuntimeId=1760, NetworkId=349, ExtraData = null },  /*diorite*/  
            new Item(1, 3, 1){ RuntimeId=1762, NetworkId=350, ExtraData = null },  /*andesite*/  
            new Item(1, 4, 1){ RuntimeId=1759, NetworkId=352, ExtraData = null },  /*polished_granite*/  
            new Item(1, 5, 1){ RuntimeId=1761, NetworkId=353, ExtraData = null },  /*polished_diorite*/  
            new Item(1, 6, 1){ RuntimeId=1763, NetworkId=354, ExtraData = null },  /*polished_andesite*/  
            new Item(12, 0, 1){ RuntimeId=6453, NetworkId=356, ExtraData = null },  /*sand*/  
            new Item(12, 1, 1){ RuntimeId=6454, NetworkId=357, ExtraData = null },  /*red_sand*/  
            new Item(81, 0, 1){ RuntimeId=11354, NetworkId=358, ExtraData = null },  /*cactus*/  
            new Item(17, 0, 1){ RuntimeId=717, NetworkId=359, ExtraData = null },  /*oak_log*/  
            new Item(-10, 0, 1){ RuntimeId=12342, NetworkId=360, ExtraData = null },  /*stripped_oak_log*/  
            new Item(17, 1, 1){ RuntimeId=6528, NetworkId=361, ExtraData = null },  /*spruce_log*/  
            new Item(-5, 0, 1){ RuntimeId=10643, NetworkId=362, ExtraData = null },  /*stripped_spruce_log*/  
            new Item(17, 2, 1){ RuntimeId=1764, NetworkId=363, ExtraData = null },  /*birch_log*/  
            new Item(-6, 0, 1){ RuntimeId=9929, NetworkId=364, ExtraData = null },  /*stripped_birch_log*/  
            new Item(17, 3, 1){ RuntimeId=631, NetworkId=365, ExtraData = null },  /*jungle_log*/  
            new Item(-7, 0, 1){ RuntimeId=1745, NetworkId=366, ExtraData = null },  /*stripped_jungle_log*/  
            new Item(162, 0, 1){ RuntimeId=6632, NetworkId=367, ExtraData = null },  /*acacia_log*/  
            new Item(-8, 0, 1){ RuntimeId=9398, NetworkId=368, ExtraData = null },  /*stripped_acacia_log*/  
            new Item(162, 1, 1){ RuntimeId=4560, NetworkId=369, ExtraData = null },  /*dark_oak_log*/  
            new Item(-9, 0, 1){ RuntimeId=628, NetworkId=370, ExtraData = null },  /*stripped_dark_oak_log*/  
            new Item(-212, 0, 1){ RuntimeId=4563, NetworkId=375, ExtraData = null },  /*oak_wood*/  
            new Item(-212, 1, 1){ RuntimeId=4569, NetworkId=376, ExtraData = null },  /*stripped_oak_wood*/  
            new Item(-212, 2, 1){ RuntimeId=4564, NetworkId=377, ExtraData = null },  /*spruce_wood*/  
            new Item(-212, 3, 1){ RuntimeId=4570, NetworkId=378, ExtraData = null },  /*stripped_spruce_wood*/  
            new Item(-212, 4, 1){ RuntimeId=4565, NetworkId=379, ExtraData = null },  /*birch_wood*/  
            new Item(-212, 5, 1){ RuntimeId=4571, NetworkId=380, ExtraData = null },  /*stripped_birch_wood*/  
            new Item(-212, 6, 1){ RuntimeId=4566, NetworkId=381, ExtraData = null },  /*jungle_wood*/  
            new Item(-212, 7, 1){ RuntimeId=4572, NetworkId=382, ExtraData = null },  /*stripped_jungle_wood*/  
            new Item(-212, 8, 1){ RuntimeId=4567, NetworkId=383, ExtraData = null },  /*acacia_wood*/  
            new Item(-212, 9, 1){ RuntimeId=4573, NetworkId=384, ExtraData = null },  /*stripped_acacia_wood*/  
            new Item(-212, 10, 1){ RuntimeId=4568, NetworkId=385, ExtraData = null },  /*dark_oak_wood*/  
            new Item(-212, 11, 1){ RuntimeId=4574, NetworkId=386, ExtraData = null },  /*stripped_dark_oak_wood*/  
            new Item(18, 0, 1){ RuntimeId=10462, NetworkId=391, ExtraData = null },  /*oak_leaves*/  
            new Item(18, 1, 1){ RuntimeId=10463, NetworkId=392, ExtraData = null },  /*spruce_leaves*/  
            new Item(18, 2, 1){ RuntimeId=10464, NetworkId=393, ExtraData = null },  /*birch_leaves*/  
            new Item(18, 3, 1){ RuntimeId=10465, NetworkId=394, ExtraData = null },  /*jungle_leaves*/  
            new Item(161, 0, 1){ RuntimeId=6656, NetworkId=395, ExtraData = null },  /*acacia_leaves*/  
            new Item(161, 1, 1){ RuntimeId=6657, NetworkId=396, ExtraData = null },  /*dark_oak_leaves*/  
            new Item(6, 0, 1){ RuntimeId=1806, NetworkId=397, ExtraData = null },  /*oak_sapling*/  
            new Item(6, 1, 1){ RuntimeId=1807, NetworkId=398, ExtraData = null },  /*spruce_sapling*/  
            new Item(6, 2, 1){ RuntimeId=1808, NetworkId=399, ExtraData = null },  /*birch_sapling*/  
            new Item(6, 3, 1){ RuntimeId=1809, NetworkId=400, ExtraData = null },  /*jungle_sapling*/  
            new Item(6, 4, 1){ RuntimeId=1810, NetworkId=401, ExtraData = null },  /*acacia_sapling*/  
            new Item(6, 5, 1){ RuntimeId=1811, NetworkId=402, ExtraData = null },  /*dark_oak_sapling*/  
            new Item(-299, 0, 1){ RuntimeId=6592, NetworkId=387, ExtraData = null },  /*bee_nest*/  
            new Item(295, 0, 1){ RuntimeId=0, NetworkId=403, ExtraData = null },  /*minecraft:wheat_seeds*/  
            new Item(361, 0, 1){ RuntimeId=0, NetworkId=404, ExtraData = null },  /*minecraft:pumpkin_seeds*/  
            new Item(362, 0, 1){ RuntimeId=0, NetworkId=405, ExtraData = null },  /*minecraft:melon_seeds*/  
            new Item(458, 0, 1){ RuntimeId=0, NetworkId=406, ExtraData = null },  /*minecraft:beetroot_seeds*/  
            new Item(296, 0, 1){ RuntimeId=0, NetworkId=407, ExtraData = null },  /*minecraft:wheat*/  
            new Item(457, 0, 1){ RuntimeId=0, NetworkId=408, ExtraData = null },  /*minecraft:beetroot*/  
            new Item(392, 0, 1){ RuntimeId=0, NetworkId=409, ExtraData = null },  /*minecraft:potato*/  
            new Item(394, 0, 1){ RuntimeId=0, NetworkId=410, ExtraData = null },  /*minecraft:poisonous_potato*/  
            new Item(391, 0, 1){ RuntimeId=0, NetworkId=411, ExtraData = null },  /*minecraft:carrot*/  
            new Item(396, 0, 1){ RuntimeId=0, NetworkId=412, ExtraData = null },  /*minecraft:golden_carrot*/  
            new Item(260, 0, 1){ RuntimeId=0, NetworkId=413, ExtraData = null },  /*minecraft:apple*/  
            new Item(322, 0, 1){ RuntimeId=0, NetworkId=414, ExtraData = null },  /*minecraft:golden_apple*/  
            new Item(466, 0, 1){ RuntimeId=0, NetworkId=415, ExtraData = null },  /*minecraft:enchanted_golden_apple*/  
            new Item(103, 0, 1){ RuntimeId=1128, NetworkId=416, ExtraData = null },  /*melon*/  
            new Item(360, 0, 1){ RuntimeId=0, NetworkId=417, ExtraData = null },  /*minecraft:melon_slice*/  
            new Item(382, 0, 1){ RuntimeId=0, NetworkId=418, ExtraData = null },  /*minecraft:glistering_melon_slice*/  
            new Item(477, 0, 1){ RuntimeId=0, NetworkId=419, ExtraData = null },  /*minecraft:sweet_berries*/  
            new Item(86, 0, 1){ RuntimeId=6888, NetworkId=421, ExtraData = null },  /*pumpkin*/  
            new Item(-155, 0, 1){ RuntimeId=12174, NetworkId=422, ExtraData = null },  /*carved_pumpkin*/  
            new Item(91, 0, 1){ RuntimeId=11036, NetworkId=423, ExtraData = null },  /*lit_pumpkin*/  
            new Item(31, 0, 1){ RuntimeId=2048, NetworkId=425, ExtraData = null },  /*fern*/  
            new Item(175, 0, 1){ RuntimeId=8602, NetworkId=426, ExtraData = null },  /*large_fern*/  
            new Item(31, 1, 1){ RuntimeId=2047, NetworkId=427, ExtraData = null },  /*grass*/  
            new Item(175, 1, 1){ RuntimeId=8601, NetworkId=428, ExtraData = null },  /*tall_grass*/  
            new Item(-131, 0, 1){ RuntimeId=1756, NetworkId=430, ExtraData = null },  /*fire_coral*/  
            new Item(-131, 1, 1){ RuntimeId=1768, NetworkId=431, ExtraData = null },  /*brain_coral*/  
            new Item(-131, 2, 1){ RuntimeId=10591, NetworkId=432, ExtraData = null },  /*bubble_coral*/  
            new Item(-131, 3, 1){ RuntimeId=12569, NetworkId=433, ExtraData = null },  /*tube_coral*/  
            new Item(-131, 4, 1){ RuntimeId=5478, NetworkId=434, ExtraData = null },  /*horn_coral*/  
            new Item(-131, 5, 1){ RuntimeId=1756, NetworkId=435, ExtraData = null },  /*dead_fire_coral*/  
            new Item(-131, 6, 1){ RuntimeId=12569, NetworkId=436, ExtraData = null },  /*dead_brain_coral*/  
            new Item(-131, 7, 1){ RuntimeId=12569, NetworkId=437, ExtraData = null },  /*dead_bubble_coral*/  
            new Item(-131, 8, 1){ RuntimeId=12569, NetworkId=438, ExtraData = null },  /*dead_tube_coral*/  
            new Item(-131, 9, 1){ RuntimeId=5478, NetworkId=439, ExtraData = null },  /*dead_horn_coral*/  
            new Item(-133, 10, 1){ RuntimeId=6930, NetworkId=440, ExtraData = null },  /*fire_coral_fan*/  
            new Item(-133, 11, 1){ RuntimeId=6928, NetworkId=441, ExtraData = null },  /*brain_coral_fan*/  
            new Item(-133, 12, 1){ RuntimeId=6929, NetworkId=442, ExtraData = null },  /*bubble_coral_fan*/  
            new Item(-133, 13, 1){ RuntimeId=6927, NetworkId=443, ExtraData = null },  /*tube_coral_fan*/  
            new Item(-133, 14, 1){ RuntimeId=6931, NetworkId=444, ExtraData = null },  /*horn_coral_fan*/  
            new Item(-134, 0, 1){ RuntimeId=74, NetworkId=445, ExtraData = null },  /*dead_fire_coral_fan*/  
            new Item(-134, 1, 1){ RuntimeId=72, NetworkId=446, ExtraData = null },  /*dead_brain_coral_fan*/  
            new Item(-134, 2, 1){ RuntimeId=73, NetworkId=447, ExtraData = null },  /*dead_bubble_coral_fan*/  
            new Item(-134, 3, 1){ RuntimeId=71, NetworkId=448, ExtraData = null },  /*dead_tube_coral_fan*/  
            new Item(-134, 4, 1){ RuntimeId=75, NetworkId=449, ExtraData = null },  /*dead_horn_coral_fan*/  
            new Item(37, 0, 1){ RuntimeId=1031, NetworkId=452, ExtraData = null },  /*dandelion*/  
            new Item(38, 0, 1){ RuntimeId=5481, NetworkId=453, ExtraData = null },  /*poppy*/  
            new Item(38, 1, 1){ RuntimeId=5482, NetworkId=454, ExtraData = null },  /*blue_orchid*/  
            new Item(38, 2, 1){ RuntimeId=5483, NetworkId=455, ExtraData = null },  /*allium*/  
            new Item(38, 3, 1){ RuntimeId=5484, NetworkId=456, ExtraData = null },  /*azure_bluet*/  
            new Item(38, 4, 1){ RuntimeId=5485, NetworkId=457, ExtraData = null },  /*red_tulip*/  
            new Item(38, 5, 1){ RuntimeId=5486, NetworkId=458, ExtraData = null },  /*orange_tulip*/  
            new Item(38, 6, 1){ RuntimeId=5487, NetworkId=459, ExtraData = null },  /*white_tulip*/  
            new Item(38, 7, 1){ RuntimeId=5488, NetworkId=460, ExtraData = null },  /*pink_tulip*/  
            new Item(38, 8, 1){ RuntimeId=5489, NetworkId=461, ExtraData = null },  /*oxeye_daisy*/  
            new Item(38, 9, 1){ RuntimeId=5490, NetworkId=462, ExtraData = null },  /*cornflower*/  
            new Item(38, 10, 1){ RuntimeId=5491, NetworkId=463, ExtraData = null },  /*lily_of_the_valley*/  
            new Item(175, 0, 1){ RuntimeId=8599, NetworkId=464, ExtraData = null },  /*sunflower*/  
            new Item(175, 1, 1){ RuntimeId=8600, NetworkId=465, ExtraData = null },  /*lilac*/  
            new Item(175, 2, 1){ RuntimeId=8603, NetworkId=466, ExtraData = null },  /*rose_bush*/  
            new Item(175, 3, 1){ RuntimeId=8604, NetworkId=467, ExtraData = null },  /*peony*/  
            new Item(-216, 0, 1){ RuntimeId=10537, NetworkId=468, ExtraData = null },  /*wither_rose*/  
            new Item(351, 0, 1){ RuntimeId=0, NetworkId=469, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 1, 1){ RuntimeId=0, NetworkId=470, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 2, 1){ RuntimeId=0, NetworkId=471, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 3, 1){ RuntimeId=0, NetworkId=472, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 4, 1){ RuntimeId=0, NetworkId=473, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 5, 1){ RuntimeId=0, NetworkId=474, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 6, 1){ RuntimeId=0, NetworkId=475, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 7, 1){ RuntimeId=0, NetworkId=476, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 8, 1){ RuntimeId=0, NetworkId=477, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 9, 1){ RuntimeId=0, NetworkId=478, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 10, 1){ RuntimeId=0, NetworkId=479, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 11, 1){ RuntimeId=0, NetworkId=480, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 12, 1){ RuntimeId=0, NetworkId=481, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 13, 1){ RuntimeId=0, NetworkId=482, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 14, 1){ RuntimeId=0, NetworkId=483, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 15, 1){ RuntimeId=0, NetworkId=484, ExtraData = null },  /*minecraft:dye*/  
            new Item(351, 16, 1){ RuntimeId=0, NetworkId=485, ExtraData = null },  /*ink_sac*/  
            new Item(351, 17, 1){ RuntimeId=0, NetworkId=487, ExtraData = null },  /*cocoa_beans*/  
            new Item(351, 18, 1){ RuntimeId=0, NetworkId=488, ExtraData = null },  /*lapis_lazuli*/  
            new Item(351, 19, 1){ RuntimeId=0, NetworkId=489, ExtraData = null },  /*bone_meal*/  
            new Item(106, 0, 1){ RuntimeId=1996, NetworkId=490, ExtraData = null },  /*vines*/  
            new Item(-231, 0, 1){ RuntimeId=8627, NetworkId=491, ExtraData = null },  /*weeping_vines*/  
            new Item(111, 0, 1){ RuntimeId=2248, NetworkId=493, ExtraData = null },  /*lilypad*/  
            new Item(-130, 0, 1){ RuntimeId=664, NetworkId=494, ExtraData = null },  /*seagrass*/  
            new Item(335, 0, 1){ RuntimeId=0, NetworkId=495, ExtraData = null },  /*minecraft:kelp*/  
            new Item(32, 0, 1){ RuntimeId=7419, NetworkId=496, ExtraData = null },  /*dead_bush*/  
            new Item(-163, 0, 1){ RuntimeId=5550, NetworkId=497, ExtraData = null },  /*bamboo*/  
            new Item(80, 0, 1){ RuntimeId=6452, NetworkId=498, ExtraData = null },  /*snow*/  
            new Item(79, 0, 1){ RuntimeId=11040, NetworkId=499, ExtraData = null },  /*ice*/  
            new Item(174, 0, 1){ RuntimeId=723, NetworkId=500, ExtraData = null },  /*packed_ice*/  
            new Item(-11, 0, 1){ RuntimeId=11399, NetworkId=501, ExtraData = null },  /*blue_ice*/  
            new Item(78, 0, 1){ RuntimeId=566, NetworkId=502, ExtraData = null },  /*top_snow*/  
            new Item(365, 0, 1){ RuntimeId=0, NetworkId=503, ExtraData = null },  /*minecraft:chicken*/  
            new Item(319, 0, 1){ RuntimeId=0, NetworkId=504, ExtraData = null },  /*minecraft:porkchop*/  
            new Item(363, 0, 1){ RuntimeId=0, NetworkId=505, ExtraData = null },  /*minecraft:beef*/  
            new Item(423, 0, 1){ RuntimeId=0, NetworkId=506, ExtraData = null },  /*minecraft:mutton*/  
            new Item(411, 0, 1){ RuntimeId=0, NetworkId=507, ExtraData = null },  /*minecraft:rabbit*/  
            new Item(349, 0, 1){ RuntimeId=0, NetworkId=508, ExtraData = null },  /*minecraft:cod*/  
            new Item(460, 0, 1){ RuntimeId=0, NetworkId=509, ExtraData = null },  /*minecraft:salmon*/  
            new Item(461, 0, 1){ RuntimeId=0, NetworkId=510, ExtraData = null },  /*minecraft:tropical_fish*/  
            new Item(462, 0, 1){ RuntimeId=0, NetworkId=511, ExtraData = null },  /*minecraft:pufferfish*/  
            new Item(39, 0, 1){ RuntimeId=5404, NetworkId=512, ExtraData = null },  /*brown_mushroom*/  
            new Item(40, 0, 1){ RuntimeId=6898, NetworkId=513, ExtraData = null },  /*red_mushroom*/  
            new Item(99, 0, 1){ RuntimeId=12161, NetworkId=516, ExtraData = null },  /*brown_mushroom_block*/  
            new Item(100, 0, 1){ RuntimeId=5473, NetworkId=517, ExtraData = null },  /*red_mushroom_block*/  
            new Item(99, 1, 1){ RuntimeId=12162, NetworkId=518, ExtraData = null },  /*mushroom_stem*/  
            new Item(99, 2, 1){ RuntimeId=12147, NetworkId=519, ExtraData = null },  /*mushroom*/  
            new Item(344, 0, 1){ RuntimeId=0, NetworkId=520, ExtraData = null },  /*minecraft:egg*/  
            new Item(338, 0, 1){ RuntimeId=0, NetworkId=521, ExtraData = null },  /*sugar_canes*/  
            new Item(353, 0, 1){ RuntimeId=0, NetworkId=522, ExtraData = null },  /*minecraft:sugar*/  
            new Item(367, 0, 1){ RuntimeId=0, NetworkId=523, ExtraData = null },  /*minecraft:rotten_flesh*/  
            new Item(352, 0, 1){ RuntimeId=0, NetworkId=524, ExtraData = null },  /*minecraft:bone*/  
            new Item(30, 0, 1){ RuntimeId=11065, NetworkId=525, ExtraData = null },  /*cobweb*/  
            new Item(375, 0, 1){ RuntimeId=0, NetworkId=526, ExtraData = null },  /*minecraft:spider_eye*/  
            new Item(52, 0, 1){ RuntimeId=1138, NetworkId=527, ExtraData = null },  /*monster_spawner*/  
            new Item(97, 0, 1){ RuntimeId=6396, NetworkId=528, ExtraData = null },  /*infested_stone*/  
            new Item(97, 1, 1){ RuntimeId=6397, NetworkId=529, ExtraData = null },  /*infested_cobblestone*/  
            new Item(97, 2, 1){ RuntimeId=6398, NetworkId=530, ExtraData = null },  /*infested_stone_brick*/  
            new Item(97, 3, 1){ RuntimeId=6399, NetworkId=531, ExtraData = null },  /*infested_mossy_stone_brick*/  
            new Item(97, 4, 1){ RuntimeId=6400, NetworkId=532, ExtraData = null },  /*infested_chiseled_stone_brick*/  
            new Item(97, 5, 1){ RuntimeId=6401, NetworkId=533, ExtraData = null },  /*dragon_egg*/  
            new Item(122, 0, 1){ RuntimeId=12069, NetworkId=534, ExtraData = null },  /*sea_turtle_egg*/  
            new Item(383, 10, 1){ RuntimeId=0, NetworkId=536, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 122, 1){ RuntimeId=0, NetworkId=537, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 11, 1){ RuntimeId=0, NetworkId=538, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 12, 1){ RuntimeId=0, NetworkId=539, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 13, 1){ RuntimeId=0, NetworkId=540, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 14, 1){ RuntimeId=0, NetworkId=541, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 28, 1){ RuntimeId=0, NetworkId=542, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 22, 1){ RuntimeId=0, NetworkId=543, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 75, 1){ RuntimeId=0, NetworkId=544, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 16, 1){ RuntimeId=0, NetworkId=545, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 19, 1){ RuntimeId=0, NetworkId=546, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 30, 1){ RuntimeId=0, NetworkId=547, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 18, 1){ RuntimeId=0, NetworkId=548, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 29, 1){ RuntimeId=0, NetworkId=549, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 23, 1){ RuntimeId=0, NetworkId=550, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 24, 1){ RuntimeId=0, NetworkId=551, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 25, 1){ RuntimeId=0, NetworkId=552, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 26, 1){ RuntimeId=0, NetworkId=553, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 27, 1){ RuntimeId=0, NetworkId=554, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 111, 1){ RuntimeId=0, NetworkId=555, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 112, 1){ RuntimeId=0, NetworkId=556, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 108, 1){ RuntimeId=0, NetworkId=557, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 109, 1){ RuntimeId=0, NetworkId=558, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 31, 1){ RuntimeId=0, NetworkId=559, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 74, 1){ RuntimeId=0, NetworkId=560, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 113, 1){ RuntimeId=0, NetworkId=561, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 121, 1){ RuntimeId=0, NetworkId=562, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 33, 1){ RuntimeId=0, NetworkId=563, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 38, 1){ RuntimeId=0, NetworkId=564, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 39, 1){ RuntimeId=0, NetworkId=565, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 34, 1){ RuntimeId=0, NetworkId=566, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 48, 1){ RuntimeId=0, NetworkId=567, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 46, 1){ RuntimeId=0, NetworkId=568, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 37, 1){ RuntimeId=0, NetworkId=569, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 35, 1){ RuntimeId=0, NetworkId=570, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 32, 1){ RuntimeId=0, NetworkId=571, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 36, 1){ RuntimeId=0, NetworkId=572, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 47, 1){ RuntimeId=0, NetworkId=573, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 110, 1){ RuntimeId=0, NetworkId=574, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 17, 1){ RuntimeId=0, NetworkId=575, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 129, 1){ RuntimeId=0, NetworkId=576, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 40, 1){ RuntimeId=0, NetworkId=577, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 45, 1){ RuntimeId=0, NetworkId=578, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 49, 1){ RuntimeId=0, NetworkId=579, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 50, 1){ RuntimeId=0, NetworkId=580, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 55, 1){ RuntimeId=0, NetworkId=581, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 42, 1){ RuntimeId=0, NetworkId=582, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 125, 1){ RuntimeId=0, NetworkId=583, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 124, 1){ RuntimeId=0, NetworkId=584, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 123, 1){ RuntimeId=0, NetworkId=585, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 126, 1){ RuntimeId=0, NetworkId=586, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 127, 1){ RuntimeId=0, NetworkId=587, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 128, 1){ RuntimeId=0, NetworkId=588, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 131, 1){ RuntimeId=0, NetworkId=590, ExtraData = null },  /*minecraft:spawn_egg_warden*/  
            new Item(383, 134, 1){ RuntimeId=0, NetworkId=591, ExtraData = null },  /*minecraft:spawn_egg_allay*/  
            new Item(383, 132, 1){ RuntimeId=0, NetworkId=592, ExtraData = null },  /*minecraft:spawn_egg_frog*/  
            new Item(383, 133, 1){ RuntimeId=0, NetworkId=593, ExtraData = null },  /*minecraft:spawn_egg_tadpole*/  
            new Item(383, 41, 1){ RuntimeId=0, NetworkId=594, ExtraData = null },  /*minecraft:spawn_egg_ghast*/  
            new Item(383, 43, 1){ RuntimeId=0, NetworkId=595, ExtraData = null },  /*minecraft:spawn_egg_blaze*/  
            new Item(383, 54, 1){ RuntimeId=0, NetworkId=596, ExtraData = null },  /*minecraft:spawn_egg_shulker*/  
            new Item(383, 57, 1){ RuntimeId=0, NetworkId=597, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 104, 1){ RuntimeId=0, NetworkId=598, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 105, 1){ RuntimeId=0, NetworkId=599, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 115, 1){ RuntimeId=0, NetworkId=600, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 118, 1){ RuntimeId=0, NetworkId=601, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 116, 1){ RuntimeId=0, NetworkId=602, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 58, 1){ RuntimeId=0, NetworkId=603, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 114, 1){ RuntimeId=0, NetworkId=604, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 59, 1){ RuntimeId=0, NetworkId=605, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 20, 1){ RuntimeId=0, NetworkId=606, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(383, 21, 1){ RuntimeId=0, NetworkId=607, ExtraData = null },  /*minecraft:spawn_egg*/  
            new Item(49, 0, 1){ RuntimeId=1166, NetworkId=608, ExtraData = null },  /*obsidian*/  
            new Item(7, 0, 1){ RuntimeId=11389, NetworkId=610, ExtraData = null },  /*bedrock*/  
            new Item(88, 0, 1){ RuntimeId=8981, NetworkId=611, ExtraData = null },  /*soul_sand*/  
            new Item(213, 0, 1){ RuntimeId=12815, NetworkId=612, ExtraData = null },  /*magma_block*/  
            new Item(372, 0, 1){ RuntimeId=0, NetworkId=613, ExtraData = null },  /*minecraft:nether_wart*/  
            new Item(121, 0, 1){ RuntimeId=6087, NetworkId=614, ExtraData = null },  /*end_stone*/  
            new Item(200, 0, 1){ RuntimeId=6839, NetworkId=615, ExtraData = null },  /*chorus_flower*/  
            new Item(240, 0, 1){ RuntimeId=8653, NetworkId=616, ExtraData = null },  /*chorus_plant*/  
            new Item(432, 0, 1){ RuntimeId=0, NetworkId=617, ExtraData = null },  /*minecraft:chorus_fruit*/  
            new Item(433, 0, 1){ RuntimeId=0, NetworkId=618, ExtraData = null },  /*minecraft:popped_chorus_fruit*/  
            new Item(19, 0, 1){ RuntimeId=1347, NetworkId=619, ExtraData = null },  /*sponge*/  
            new Item(19, 0, 1){ RuntimeId=1348, NetworkId=620, ExtraData = null },  /*wet_sponge*/  
            new Item(-132, 0, 1){ RuntimeId=8380, NetworkId=621, ExtraData = null },  /*tube_coral_block*/  
            new Item(-132, 1, 1){ RuntimeId=8381, NetworkId=622, ExtraData = null },  /*brain_coral_block*/  
            new Item(-132, 2, 1){ RuntimeId=8382, NetworkId=623, ExtraData = null },  /*bubble_coral_block*/  
            new Item(-132, 3, 1){ RuntimeId=8383, NetworkId=624, ExtraData = null },  /*fire_coral_block*/  
            new Item(-132, 4, 1){ RuntimeId=8384, NetworkId=625, ExtraData = null },  /*horn_coral_block*/  
            new Item(-132, 5, 1){ RuntimeId=8385, NetworkId=626, ExtraData = null },  /*dead_tube_coral_block*/  
            new Item(-132, 6, 1){ RuntimeId=8386, NetworkId=627, ExtraData = null },  /*dead_brain_coral_block*/  
            new Item(-132, 7, 1){ RuntimeId=8387, NetworkId=628, ExtraData = null },  /*dead_bubble_coral_block*/  
            new Item(-132, 8, 1){ RuntimeId=8388, NetworkId=629, ExtraData = null },  /*dead_brain_coral_block*/  
            new Item(-132, 9, 1){ RuntimeId=8389, NetworkId=630, ExtraData = null },  /*dead_horn_coral_block*/  
            new Item(298, 0, 1){ RuntimeId=0, NetworkId=631, ExtraData = null },  /*leather_cap*/  
            new Item(302, 0, 1){ RuntimeId=0, NetworkId=632, ExtraData = null },  /*minecraft:chainmail_helmet*/  
            new Item(306, 0, 1){ RuntimeId=0, NetworkId=633, ExtraData = null },  /*minecraft:iron_helmet*/  
            new Item(314, 0, 1){ RuntimeId=0, NetworkId=634, ExtraData = null },  /*minecraft:golden_helmet*/  
            new Item(310, 0, 1){ RuntimeId=0, NetworkId=635, ExtraData = null },  /*minecraft:diamond_helmet*/  
            new Item(299, 0, 1){ RuntimeId=0, NetworkId=637, ExtraData = null },  /*leather_tunic*/  
            new Item(303, 0, 1){ RuntimeId=0, NetworkId=638, ExtraData = null },  /*minecraft:chainmail_chestplate*/  
            new Item(307, 0, 1){ RuntimeId=0, NetworkId=639, ExtraData = null },  /*minecraft:iron_chestplate*/  
            new Item(315, 0, 1){ RuntimeId=0, NetworkId=640, ExtraData = null },  /*minecraft:golden_chestplate*/  
            new Item(311, 0, 1){ RuntimeId=0, NetworkId=641, ExtraData = null },  /*minecraft:diamond_chestplate*/  
            new Item(300, 0, 1){ RuntimeId=0, NetworkId=643, ExtraData = null },  /*leather_pants*/  
            new Item(304, 0, 1){ RuntimeId=0, NetworkId=644, ExtraData = null },  /*minecraft:chainmail_leggings*/  
            new Item(308, 0, 1){ RuntimeId=0, NetworkId=645, ExtraData = null },  /*minecraft:iron_leggings*/  
            new Item(316, 0, 1){ RuntimeId=0, NetworkId=646, ExtraData = null },  /*minecraft:golden_leggings*/  
            new Item(312, 0, 1){ RuntimeId=0, NetworkId=647, ExtraData = null },  /*minecraft:diamond_leggings*/  
            new Item(301, 0, 1){ RuntimeId=0, NetworkId=649, ExtraData = null },  /*minecraft:leather_boots*/  
            new Item(305, 0, 1){ RuntimeId=0, NetworkId=650, ExtraData = null },  /*minecraft:chainmail_boots*/  
            new Item(309, 0, 1){ RuntimeId=0, NetworkId=651, ExtraData = null },  /*minecraft:iron_boots*/  
            new Item(317, 0, 1){ RuntimeId=0, NetworkId=652, ExtraData = null },  /*minecraft:golden_boots*/  
            new Item(313, 0, 1){ RuntimeId=0, NetworkId=653, ExtraData = null },  /*minecraft:diamond_boots*/  
            new Item(268, 0, 1){ RuntimeId=0, NetworkId=655, ExtraData = null },  /*minecraft:wooden_sword*/  
            new Item(272, 0, 1){ RuntimeId=0, NetworkId=656, ExtraData = null },  /*minecraft:stone_sword*/  
            new Item(267, 0, 1){ RuntimeId=0, NetworkId=657, ExtraData = null },  /*minecraft:iron_sword*/  
            new Item(283, 0, 1){ RuntimeId=0, NetworkId=658, ExtraData = null },  /*minecraft:golden_sword*/  
            new Item(276, 0, 1){ RuntimeId=0, NetworkId=659, ExtraData = null },  /*minecraft:diamond_sword*/  
            new Item(271, 0, 1){ RuntimeId=0, NetworkId=661, ExtraData = null },  /*minecraft:wooden_axe*/  
            new Item(275, 0, 1){ RuntimeId=0, NetworkId=662, ExtraData = null },  /*minecraft:stone_axe*/  
            new Item(258, 0, 1){ RuntimeId=0, NetworkId=663, ExtraData = null },  /*minecraft:iron_axe*/  
            new Item(286, 0, 1){ RuntimeId=0, NetworkId=664, ExtraData = null },  /*minecraft:golden_axe*/  
            new Item(279, 0, 1){ RuntimeId=0, NetworkId=665, ExtraData = null },  /*minecraft:diamond_axe*/  
            new Item(270, 0, 1){ RuntimeId=0, NetworkId=667, ExtraData = null },  /*minecraft:wooden_pickaxe*/  
            new Item(274, 0, 1){ RuntimeId=0, NetworkId=668, ExtraData = null },  /*minecraft:stone_pickaxe*/  
            new Item(257, 0, 1){ RuntimeId=0, NetworkId=669, ExtraData = null },  /*minecraft:iron_pickaxe*/  
            new Item(285, 0, 1){ RuntimeId=0, NetworkId=670, ExtraData = null },  /*minecraft:golden_pickaxe*/  
            new Item(278, 0, 1){ RuntimeId=0, NetworkId=671, ExtraData = null },  /*minecraft:diamond_pickaxe*/  
            new Item(269, 0, 1){ RuntimeId=0, NetworkId=673, ExtraData = null },  /*minecraft:wooden_shovel*/  
            new Item(273, 0, 1){ RuntimeId=0, NetworkId=674, ExtraData = null },  /*minecraft:stone_shovel*/  
            new Item(256, 0, 1){ RuntimeId=0, NetworkId=675, ExtraData = null },  /*minecraft:iron_shovel*/  
            new Item(284, 0, 1){ RuntimeId=0, NetworkId=676, ExtraData = null },  /*minecraft:golden_shovel*/  
            new Item(277, 0, 1){ RuntimeId=0, NetworkId=677, ExtraData = null },  /*minecraft:diamond_shovel*/  
            new Item(290, 0, 1){ RuntimeId=0, NetworkId=679, ExtraData = null },  /*minecraft:wooden_hoe*/  
            new Item(291, 0, 1){ RuntimeId=0, NetworkId=680, ExtraData = null },  /*minecraft:stone_hoe*/  
            new Item(292, 0, 1){ RuntimeId=0, NetworkId=681, ExtraData = null },  /*minecraft:iron_hoe*/  
            new Item(294, 0, 1){ RuntimeId=0, NetworkId=682, ExtraData = null },  /*minecraft:golden_hoe*/  
            new Item(293, 0, 1){ RuntimeId=0, NetworkId=683, ExtraData = null },  /*minecraft:diamond_hoe*/  
            new Item(261, 0, 1){ RuntimeId=0, NetworkId=685, ExtraData = null },  /*minecraft:bow*/  
            new Item(471, 0, 1){ RuntimeId=0, NetworkId=686, ExtraData = null },  /*minecraft:crossbow*/  
            new Item(262, 0, 1){ RuntimeId=0, NetworkId=687, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 1, 1){ RuntimeId=0, NetworkId=688, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 2, 1){ RuntimeId=0, NetworkId=689, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 3, 1){ RuntimeId=0, NetworkId=690, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 4, 1){ RuntimeId=0, NetworkId=691, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 5, 1){ RuntimeId=0, NetworkId=692, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 6, 1){ RuntimeId=0, NetworkId=693, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 7, 1){ RuntimeId=0, NetworkId=694, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 8, 1){ RuntimeId=0, NetworkId=695, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 9, 1){ RuntimeId=0, NetworkId=696, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 10, 1){ RuntimeId=0, NetworkId=697, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 11, 1){ RuntimeId=0, NetworkId=698, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 12, 1){ RuntimeId=0, NetworkId=699, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 13, 1){ RuntimeId=0, NetworkId=700, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 14, 1){ RuntimeId=0, NetworkId=701, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 15, 1){ RuntimeId=0, NetworkId=702, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 16, 1){ RuntimeId=0, NetworkId=703, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 17, 1){ RuntimeId=0, NetworkId=704, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 18, 1){ RuntimeId=0, NetworkId=705, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 19, 1){ RuntimeId=0, NetworkId=706, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 20, 1){ RuntimeId=0, NetworkId=707, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 21, 1){ RuntimeId=0, NetworkId=708, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 22, 1){ RuntimeId=0, NetworkId=709, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 23, 1){ RuntimeId=0, NetworkId=710, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 24, 1){ RuntimeId=0, NetworkId=711, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 25, 1){ RuntimeId=0, NetworkId=712, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 26, 1){ RuntimeId=0, NetworkId=713, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 27, 1){ RuntimeId=0, NetworkId=714, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 28, 1){ RuntimeId=0, NetworkId=715, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 29, 1){ RuntimeId=0, NetworkId=716, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 30, 1){ RuntimeId=0, NetworkId=717, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 31, 1){ RuntimeId=0, NetworkId=718, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 32, 1){ RuntimeId=0, NetworkId=719, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 33, 1){ RuntimeId=0, NetworkId=720, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 34, 1){ RuntimeId=0, NetworkId=721, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 35, 1){ RuntimeId=0, NetworkId=722, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 36, 1){ RuntimeId=0, NetworkId=723, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 37, 1){ RuntimeId=0, NetworkId=724, ExtraData = null },  /*minecraft:arrow*/  
            new Item(262, 38, 1){ RuntimeId=0, NetworkId=725, ExtraData = null },  /*minecraft:arrow*/  
            new Item(513, 0, 1){ RuntimeId=0, NetworkId=726, ExtraData = null },  /*minecraft:shield*/  
            new Item(366, 0, 1){ RuntimeId=0, NetworkId=727, ExtraData = null },  /*minecraft:cooked_chicken*/  
            new Item(320, 0, 1){ RuntimeId=0, NetworkId=728, ExtraData = null },  /*minecraft:cooked_porkchop*/  
            new Item(364, 0, 1){ RuntimeId=0, NetworkId=729, ExtraData = null },  /*minecraft:cooked_beef*/  
            new Item(424, 0, 1){ RuntimeId=0, NetworkId=730, ExtraData = null },  /*minecraft:cooked_mutton*/  
            new Item(412, 0, 1){ RuntimeId=0, NetworkId=731, ExtraData = null },  /*minecraft:cooked_rabbit*/  
            new Item(350, 0, 1){ RuntimeId=0, NetworkId=732, ExtraData = null },  /*minecraft:cooked_cod*/  
            new Item(463, 0, 1){ RuntimeId=0, NetworkId=733, ExtraData = null },  /*minecraft:cooked_salmon*/  
            new Item(297, 0, 1){ RuntimeId=0, NetworkId=734, ExtraData = null },  /*minecraft:bread*/  
            new Item(282, 0, 1){ RuntimeId=0, NetworkId=735, ExtraData = null },  /*minecraft:mushroom_stew*/  
            new Item(459, 0, 1){ RuntimeId=0, NetworkId=736, ExtraData = null },  /*minecraft:beetroot_soup*/  
            new Item(413, 0, 1){ RuntimeId=0, NetworkId=737, ExtraData = null },  /*minecraft:rabbit_stew*/  
            new Item(393, 0, 1){ RuntimeId=0, NetworkId=738, ExtraData = null },  /*minecraft:baked_potato*/  
            new Item(357, 0, 1){ RuntimeId=0, NetworkId=739, ExtraData = null },  /*minecraft:cookie*/  
            new Item(400, 0, 1){ RuntimeId=0, NetworkId=740, ExtraData = null },  /*minecraft:pumpkin_pie*/  
            new Item(354, 0, 1){ RuntimeId=0, NetworkId=741, ExtraData = null },  /*minecraft:cake*/  
            new Item(464, 0, 1){ RuntimeId=0, NetworkId=742, ExtraData = null },  /*minecraft:dried_kelp*/  
            new Item(346, 0, 1){ RuntimeId=0, NetworkId=743, ExtraData = null },  /*minecraft:fishing_rod*/  
            new Item(398, 0, 1){ RuntimeId=0, NetworkId=744, ExtraData = null },  /*minecraft:carrot_on_a_stick*/  
            new Item(332, 0, 1){ RuntimeId=0, NetworkId=746, ExtraData = null },  /*minecraft:snowball*/  
            new Item(359, 0, 1){ RuntimeId=0, NetworkId=747, ExtraData = null },  /*minecraft:shears*/  
            new Item(259, 0, 1){ RuntimeId=0, NetworkId=748, ExtraData = null },  /*minecraft:flint_and_steel*/  
            new Item(420, 0, 1){ RuntimeId=0, NetworkId=749, ExtraData = null },  /*minecraft:lead*/  
            new Item(347, 0, 1){ RuntimeId=0, NetworkId=750, ExtraData = null },  /*minecraft:clock*/  
            new Item(345, 0, 1){ RuntimeId=0, NetworkId=751, ExtraData = null },  /*minecraft:compass*/  
            new Item(395, 0, 1){ RuntimeId=0, NetworkId=760, ExtraData = null },  /*minecraft:empty_map*/  
            new Item(395, 2, 1){ RuntimeId=0, NetworkId=761, ExtraData = null },  /*empty_locator_map*/  
            new Item(329, 0, 1){ RuntimeId=0, NetworkId=762, ExtraData = null },  /*minecraft:saddle*/  
            new Item(416, 0, 1){ RuntimeId=0, NetworkId=763, ExtraData = null },  /*minecraft:leather_horse_armor*/  
            new Item(417, 0, 1){ RuntimeId=0, NetworkId=764, ExtraData = null },  /*minecraft:iron_horse_armor*/  
            new Item(418, 0, 1){ RuntimeId=0, NetworkId=765, ExtraData = null },  /*minecraft:golden_horse_armor*/  
            new Item(419, 0, 1){ RuntimeId=0, NetworkId=766, ExtraData = null },  /*minecraft:diamond_horse_armor*/  
            new Item(455, 0, 1){ RuntimeId=0, NetworkId=767, ExtraData = null },  /*minecraft:trident*/  
            new Item(469, 0, 1){ RuntimeId=0, NetworkId=768, ExtraData = null },  /*minecraft:turtle_helmet*/  
            new Item(444, 0, 1){ RuntimeId=0, NetworkId=769, ExtraData = null },  /*minecraft:elytra*/  
            new Item(450, 0, 1){ RuntimeId=0, NetworkId=770, ExtraData = null },  /*minecraft:totem_of_undying*/  
            new Item(374, 0, 1){ RuntimeId=0, NetworkId=771, ExtraData = null },  /*minecraft:glass_bottle*/  
            new Item(384, 0, 1){ RuntimeId=0, NetworkId=772, ExtraData = null },  /*minecraft:experience_bottle*/  
            new Item(373, 0, 1){ RuntimeId=0, NetworkId=773, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 1, 1){ RuntimeId=0, NetworkId=774, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 2, 1){ RuntimeId=0, NetworkId=775, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 3, 1){ RuntimeId=0, NetworkId=776, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 4, 1){ RuntimeId=0, NetworkId=777, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 5, 1){ RuntimeId=0, NetworkId=778, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 6, 1){ RuntimeId=0, NetworkId=779, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 7, 1){ RuntimeId=0, NetworkId=780, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 8, 1){ RuntimeId=0, NetworkId=781, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 9, 1){ RuntimeId=0, NetworkId=782, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 10, 1){ RuntimeId=0, NetworkId=783, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 11, 1){ RuntimeId=0, NetworkId=784, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 12, 1){ RuntimeId=0, NetworkId=785, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 13, 1){ RuntimeId=0, NetworkId=786, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 14, 1){ RuntimeId=0, NetworkId=787, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 15, 1){ RuntimeId=0, NetworkId=788, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 16, 1){ RuntimeId=0, NetworkId=789, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 17, 1){ RuntimeId=0, NetworkId=790, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 18, 1){ RuntimeId=0, NetworkId=791, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 19, 1){ RuntimeId=0, NetworkId=792, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 20, 1){ RuntimeId=0, NetworkId=793, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 21, 1){ RuntimeId=0, NetworkId=794, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 22, 1){ RuntimeId=0, NetworkId=795, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 23, 1){ RuntimeId=0, NetworkId=796, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 24, 1){ RuntimeId=0, NetworkId=797, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 25, 1){ RuntimeId=0, NetworkId=798, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 26, 1){ RuntimeId=0, NetworkId=799, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 27, 1){ RuntimeId=0, NetworkId=800, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 28, 1){ RuntimeId=0, NetworkId=801, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 29, 1){ RuntimeId=0, NetworkId=802, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 30, 1){ RuntimeId=0, NetworkId=803, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 31, 1){ RuntimeId=0, NetworkId=804, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 32, 1){ RuntimeId=0, NetworkId=805, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 33, 1){ RuntimeId=0, NetworkId=806, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 34, 1){ RuntimeId=0, NetworkId=807, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 35, 1){ RuntimeId=0, NetworkId=808, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 36, 1){ RuntimeId=0, NetworkId=809, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 37, 1){ RuntimeId=0, NetworkId=810, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 38, 1){ RuntimeId=0, NetworkId=811, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 39, 1){ RuntimeId=0, NetworkId=812, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 40, 1){ RuntimeId=0, NetworkId=813, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 41, 1){ RuntimeId=0, NetworkId=814, ExtraData = null },  /*minecraft:potion*/  
            new Item(373, 42, 1){ RuntimeId=0, NetworkId=815, ExtraData = null },  /*minecraft:potion*/  
            new Item(438, 0, 1){ RuntimeId=0, NetworkId=816, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 1, 1){ RuntimeId=0, NetworkId=817, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 2, 1){ RuntimeId=0, NetworkId=818, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 3, 1){ RuntimeId=0, NetworkId=819, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 4, 1){ RuntimeId=0, NetworkId=820, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 5, 1){ RuntimeId=0, NetworkId=821, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 6, 1){ RuntimeId=0, NetworkId=822, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 7, 1){ RuntimeId=0, NetworkId=823, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 8, 1){ RuntimeId=0, NetworkId=824, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 9, 1){ RuntimeId=0, NetworkId=825, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 10, 1){ RuntimeId=0, NetworkId=826, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 11, 1){ RuntimeId=0, NetworkId=827, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 12, 1){ RuntimeId=0, NetworkId=828, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 13, 1){ RuntimeId=0, NetworkId=829, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 14, 1){ RuntimeId=0, NetworkId=830, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 15, 1){ RuntimeId=0, NetworkId=831, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 16, 1){ RuntimeId=0, NetworkId=832, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 17, 1){ RuntimeId=0, NetworkId=833, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 18, 1){ RuntimeId=0, NetworkId=834, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 19, 1){ RuntimeId=0, NetworkId=835, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 20, 1){ RuntimeId=0, NetworkId=836, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 21, 1){ RuntimeId=0, NetworkId=837, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 22, 1){ RuntimeId=0, NetworkId=838, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 23, 1){ RuntimeId=0, NetworkId=839, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 24, 1){ RuntimeId=0, NetworkId=840, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 25, 1){ RuntimeId=0, NetworkId=841, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 26, 1){ RuntimeId=0, NetworkId=842, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 27, 1){ RuntimeId=0, NetworkId=843, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 28, 1){ RuntimeId=0, NetworkId=844, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 29, 1){ RuntimeId=0, NetworkId=845, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 30, 1){ RuntimeId=0, NetworkId=846, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 31, 1){ RuntimeId=0, NetworkId=847, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 32, 1){ RuntimeId=0, NetworkId=848, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 33, 1){ RuntimeId=0, NetworkId=849, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 34, 1){ RuntimeId=0, NetworkId=850, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 35, 1){ RuntimeId=0, NetworkId=851, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 36, 1){ RuntimeId=0, NetworkId=852, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 37, 1){ RuntimeId=0, NetworkId=853, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 38, 1){ RuntimeId=0, NetworkId=854, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 39, 1){ RuntimeId=0, NetworkId=855, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 40, 1){ RuntimeId=0, NetworkId=856, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 41, 1){ RuntimeId=0, NetworkId=857, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(438, 42, 1){ RuntimeId=0, NetworkId=858, ExtraData = null },  /*minecraft:splash_potion*/  
            new Item(441, 0, 1){ RuntimeId=0, NetworkId=859, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 1, 1){ RuntimeId=0, NetworkId=860, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 2, 1){ RuntimeId=0, NetworkId=861, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 3, 1){ RuntimeId=0, NetworkId=862, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 4, 1){ RuntimeId=0, NetworkId=863, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 5, 1){ RuntimeId=0, NetworkId=864, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 6, 1){ RuntimeId=0, NetworkId=865, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 7, 1){ RuntimeId=0, NetworkId=866, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 8, 1){ RuntimeId=0, NetworkId=867, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 9, 1){ RuntimeId=0, NetworkId=868, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 10, 1){ RuntimeId=0, NetworkId=869, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 11, 1){ RuntimeId=0, NetworkId=870, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 12, 1){ RuntimeId=0, NetworkId=871, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 13, 1){ RuntimeId=0, NetworkId=872, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 14, 1){ RuntimeId=0, NetworkId=873, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 15, 1){ RuntimeId=0, NetworkId=874, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 16, 1){ RuntimeId=0, NetworkId=875, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 17, 1){ RuntimeId=0, NetworkId=876, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 18, 1){ RuntimeId=0, NetworkId=877, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 19, 1){ RuntimeId=0, NetworkId=878, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 20, 1){ RuntimeId=0, NetworkId=879, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 21, 1){ RuntimeId=0, NetworkId=880, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 22, 1){ RuntimeId=0, NetworkId=881, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 23, 1){ RuntimeId=0, NetworkId=882, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 24, 1){ RuntimeId=0, NetworkId=883, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 25, 1){ RuntimeId=0, NetworkId=884, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 26, 1){ RuntimeId=0, NetworkId=885, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 27, 1){ RuntimeId=0, NetworkId=886, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 28, 1){ RuntimeId=0, NetworkId=887, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 29, 1){ RuntimeId=0, NetworkId=888, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 30, 1){ RuntimeId=0, NetworkId=889, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 31, 1){ RuntimeId=0, NetworkId=890, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 32, 1){ RuntimeId=0, NetworkId=891, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 33, 1){ RuntimeId=0, NetworkId=892, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 34, 1){ RuntimeId=0, NetworkId=893, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 35, 1){ RuntimeId=0, NetworkId=894, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 36, 1){ RuntimeId=0, NetworkId=895, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 37, 1){ RuntimeId=0, NetworkId=896, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 38, 1){ RuntimeId=0, NetworkId=897, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 39, 1){ RuntimeId=0, NetworkId=898, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 40, 1){ RuntimeId=0, NetworkId=899, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 41, 1){ RuntimeId=0, NetworkId=900, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(441, 42, 1){ RuntimeId=0, NetworkId=901, ExtraData = null },  /*minecraft:lingering_potion*/  
            new Item(280, 0, 1){ RuntimeId=0, NetworkId=903, ExtraData = null },  /*minecraft:stick*/  
            new Item(355, 0, 1){ RuntimeId=0, NetworkId=904, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 1, 1){ RuntimeId=0, NetworkId=905, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 2, 1){ RuntimeId=0, NetworkId=906, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 3, 1){ RuntimeId=0, NetworkId=907, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 4, 1){ RuntimeId=0, NetworkId=908, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 5, 1){ RuntimeId=0, NetworkId=909, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 6, 1){ RuntimeId=0, NetworkId=910, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 7, 1){ RuntimeId=0, NetworkId=911, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 8, 1){ RuntimeId=0, NetworkId=912, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 9, 1){ RuntimeId=0, NetworkId=913, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 10, 1){ RuntimeId=0, NetworkId=914, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 11, 1){ RuntimeId=0, NetworkId=915, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 12, 1){ RuntimeId=0, NetworkId=916, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 13, 1){ RuntimeId=0, NetworkId=917, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 14, 1){ RuntimeId=0, NetworkId=918, ExtraData = null },  /*minecraft:bed*/  
            new Item(355, 15, 1){ RuntimeId=0, NetworkId=919, ExtraData = null },  /*minecraft:bed*/  
            new Item(50, 0, 1){ RuntimeId=1826, NetworkId=920, ExtraData = null },  /*torch*/  
            new Item(-156, 0, 1){ RuntimeId=9405, NetworkId=922, ExtraData = null },  /*sea_pickle*/  
            new Item(-208, 0, 1){ RuntimeId=11448, NetworkId=923, ExtraData = null },  /*lantern*/  
            new Item(58, 0, 1){ RuntimeId=9404, NetworkId=925, ExtraData = null },  /*crafting_table*/  
            new Item(-200, 0, 1){ RuntimeId=13120, NetworkId=926, ExtraData = null },  /*cartography_table*/  
            new Item(-201, 0, 1){ RuntimeId=9367, NetworkId=927, ExtraData = null },  /*fletching_table*/  
            new Item(-202, 0, 1){ RuntimeId=5594, NetworkId=928, ExtraData = null },  /*smithing_table*/  
            new Item(801, 0, 1){ RuntimeId=0, NetworkId=930, ExtraData = null },  /*beehive*/  
            new Item(720, 0, 1){ RuntimeId=0, NetworkId=929, ExtraData = null },  /*minecraft:campfire*/  
            new Item(61, 0, 1){ RuntimeId=12609, NetworkId=931, ExtraData = null },  /*furnace*/  
            new Item(-196, 0, 1){ RuntimeId=12366, NetworkId=932, ExtraData = null },  /*blast_furnace*/  
            new Item(-198, 0, 1){ RuntimeId=1751, NetworkId=933, ExtraData = null },  /*smoker*/  
            new Item(379, 0, 1){ RuntimeId=0, NetworkId=935, ExtraData = null },  /*minecraft:brewing_stand*/  
            new Item(145, 0, 1){ RuntimeId=10997, NetworkId=936, ExtraData = null },  /*anvil*/  
            new Item(145, 0, 1){ RuntimeId=11001, NetworkId=937, ExtraData = null },  /*slightly_damaged_anvil*/  
            new Item(145, 0, 1){ RuntimeId=11005, NetworkId=938, ExtraData = null },  /*very_damaged_anvil*/  
            new Item(-195, 0, 1){ RuntimeId=12846, NetworkId=939, ExtraData = null },  /*grindstone*/  
            new Item(116, 0, 1){ RuntimeId=11082, NetworkId=940, ExtraData = null },  /*enchantment_table*/  
            new Item(47, 0, 1){ RuntimeId=11034, NetworkId=941, ExtraData = null },  /*bookshelf*/  
            new Item(-194, 0, 1){ RuntimeId=11307, NetworkId=942, ExtraData = null },  /*lectern*/  
            new Item(380, 0, 1){ RuntimeId=0, NetworkId=943, ExtraData = null },  /*minecraft:cauldron*/  
            new Item(-213, 0, 1){ RuntimeId=8562, NetworkId=944, ExtraData = null },  /*composter*/  
            new Item(54, 0, 1){ RuntimeId=11493, NetworkId=945, ExtraData = null },  /*chest*/  
            new Item(146, 0, 1){ RuntimeId=8733, NetworkId=946, ExtraData = null },  /*trapped_chest*/  
            new Item(130, 0, 1){ RuntimeId=6675, NetworkId=947, ExtraData = null },  /*ender_chest*/  
            new Item(-203, 0, 1){ RuntimeId=6827, NetworkId=948, ExtraData = null },  /*barrel*/  
            new Item(205, 0, 1){ RuntimeId=5547, NetworkId=949, ExtraData = null },  /*shulker_box*/  
            new Item(218, 0, 1){ RuntimeId=1094, NetworkId=950, ExtraData = null },  /*white_shulker_box*/  
            new Item(218, 1, 1){ RuntimeId=9858, NetworkId=951, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 2, 1){ RuntimeId=8495, NetworkId=952, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 3, 1){ RuntimeId=10378, NetworkId=953, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 4, 1){ RuntimeId=11247, NetworkId=954, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 5, 1){ RuntimeId=6736, NetworkId=955, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 6, 1){ RuntimeId=10592, NetworkId=956, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 7, 1){ RuntimeId=120, NetworkId=957, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 8, 1){ RuntimeId=1032, NetworkId=958, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 9, 1){ RuntimeId=10858, NetworkId=959, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 10, 1){ RuntimeId=11400, NetworkId=960, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 11, 1){ RuntimeId=11334, NetworkId=961, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 12, 1){ RuntimeId=10633, NetworkId=962, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 13, 1){ RuntimeId=12173, NetworkId=963, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 14, 1){ RuntimeId=722, NetworkId=964, ExtraData = null },  /*_shulker_box*/  
            new Item(218, 15, 1){ RuntimeId=6683, NetworkId=965, ExtraData = null },  /*_shulker_box*/  
            new Item(425, 0, 1){ RuntimeId=0, NetworkId=966, ExtraData = null },  /*minecraft:armor_stand*/  
            new Item(25, 0, 1){ RuntimeId=1078, NetworkId=967, ExtraData = null },  /*note_block*/  
            new Item(84, 0, 1){ RuntimeId=7998, NetworkId=968, ExtraData = null },  /*jukebox*/  
            new Item(500, 0, 1){ RuntimeId=0, NetworkId=969, ExtraData = null },  /*minecraft:music_disc_13*/  
            new Item(501, 0, 1){ RuntimeId=0, NetworkId=970, ExtraData = null },  /*minecraft:music_disc_cat*/  
            new Item(502, 0, 1){ RuntimeId=0, NetworkId=971, ExtraData = null },  /*minecraft:music_disc_blocks*/  
            new Item(503, 0, 1){ RuntimeId=0, NetworkId=972, ExtraData = null },  /*minecraft:music_disc_chirp*/  
            new Item(504, 0, 1){ RuntimeId=0, NetworkId=973, ExtraData = null },  /*minecraft:music_disc_far*/  
            new Item(505, 0, 1){ RuntimeId=0, NetworkId=974, ExtraData = null },  /*minecraft:music_disc_mall*/  
            new Item(506, 0, 1){ RuntimeId=0, NetworkId=975, ExtraData = null },  /*minecraft:music_disc_mellohi*/  
            new Item(507, 0, 1){ RuntimeId=0, NetworkId=976, ExtraData = null },  /*minecraft:music_disc_stal*/  
            new Item(508, 0, 1){ RuntimeId=0, NetworkId=977, ExtraData = null },  /*minecraft:music_disc_strad*/  
            new Item(509, 0, 1){ RuntimeId=0, NetworkId=978, ExtraData = null },  /*minecraft:music_disc_ward*/  
            new Item(510, 0, 1){ RuntimeId=0, NetworkId=979, ExtraData = null },  /*minecraft:music_disc_11*/  
            new Item(511, 0, 1){ RuntimeId=0, NetworkId=980, ExtraData = null },  /*minecraft:music_disc_wait*/  
            new Item(348, 0, 1){ RuntimeId=0, NetworkId=986, ExtraData = null },  /*minecraft:glowstone_dust*/  
            new Item(89, 0, 1){ RuntimeId=6137, NetworkId=987, ExtraData = null },  /*glowstone*/  
            new Item(123, 0, 1){ RuntimeId=669, NetworkId=988, ExtraData = null },  /*redstone_lamp*/  
            new Item(169, 0, 1){ RuntimeId=12345, NetworkId=989, ExtraData = null },  /*sea_lantern*/  
            new Item(323, 0, 1){ RuntimeId=0, NetworkId=990, ExtraData = null },  /*minecraft:oak_sign*/  
            new Item(472, 0, 1){ RuntimeId=0, NetworkId=991, ExtraData = null },  /*minecraft:spruce_sign*/  
            new Item(473, 0, 1){ RuntimeId=0, NetworkId=992, ExtraData = null },  /*minecraft:birch_sign*/  
            new Item(474, 0, 1){ RuntimeId=0, NetworkId=993, ExtraData = null },  /*minecraft:jungle_sign*/  
            new Item(475, 0, 1){ RuntimeId=0, NetworkId=994, ExtraData = null },  /*minecraft:acacia_sign*/  
            new Item(476, 0, 1){ RuntimeId=0, NetworkId=995, ExtraData = null },  /*minecraft:dark_oak_sign*/  
            new Item(321, 0, 1){ RuntimeId=0, NetworkId=998, ExtraData = null },  /*minecraft:painting*/  
            new Item(389, 0, 1){ RuntimeId=0, NetworkId=999, ExtraData = null },  /*item_frame*/  
            new Item(390, 0, 1){ RuntimeId=0, NetworkId=1001, ExtraData = null },  /*minecraft:flower_pot*/  
            new Item(281, 0, 1){ RuntimeId=0, NetworkId=1002, ExtraData = null },  /*minecraft:bowl*/  
            new Item(325, 0, 1){ RuntimeId=0, NetworkId=1003, ExtraData = null },  /*minecraft:bucket*/  
            new Item(325, 1, 1){ RuntimeId=0, NetworkId=1004, ExtraData = null },  /*milk*/  
            new Item(325, 2, 1){ RuntimeId=0, NetworkId=1005, ExtraData = null },  /*water_bucket*/  
            new Item(325, 3, 1){ RuntimeId=0, NetworkId=1006, ExtraData = null },  /*lava_bucket*/  
            new Item(325, 4, 1){ RuntimeId=0, NetworkId=1007, ExtraData = null },  /*bucket_of_cod*/  
            new Item(325, 5, 1){ RuntimeId=0, NetworkId=1008, ExtraData = null },  /*bucket_of_salmon*/  
            new Item(325, 6, 1){ RuntimeId=0, NetworkId=1009, ExtraData = null },  /*bucket_of_tropical_fish*/  
            new Item(325, 7, 1){ RuntimeId=0, NetworkId=1010, ExtraData = null },  /*bucket_of_pufferfish*/  
            new Item(325, 8, 1){ RuntimeId=0, NetworkId=1011, ExtraData = null },  /*powder_snow_bucket*/  
            new Item(325, 9, 1){ RuntimeId=0, NetworkId=1012, ExtraData = null },  /*bucket_of_axolotl*/  
            new Item(325, 10, 1){ RuntimeId=0, NetworkId=1013, ExtraData = null },  /*bucket_of_tadpoles*/  
            new Item(397, 0, 1){ RuntimeId=0, NetworkId=1014, ExtraData = null },  /*head*/  
            new Item(397, 1, 1){ RuntimeId=0, NetworkId=1015, ExtraData = null },  /*zombie_head*/  
            new Item(397, 2, 1){ RuntimeId=0, NetworkId=1016, ExtraData = null },  /*creeper_head*/  
            new Item(397, 3, 1){ RuntimeId=0, NetworkId=1017, ExtraData = null },  /*dragon_head*/  
            new Item(397, 4, 1){ RuntimeId=0, NetworkId=1018, ExtraData = null },  /*skeleton_skull*/  
            new Item(397, 5, 1){ RuntimeId=0, NetworkId=1019, ExtraData = null },  /*wither_skeleton_skull*/  
            new Item(397, 6, 1){ RuntimeId=0, NetworkId=1020, ExtraData = null },  /*piglin_head*/  
            new Item(138, 0, 1){ RuntimeId=556, NetworkId=1021, ExtraData = null },  /*beacon*/  
            new Item(-206, 0, 1){ RuntimeId=11275, NetworkId=1022, ExtraData = null },  /*bell*/  
            new Item(-157, 0, 1){ RuntimeId=6490, NetworkId=1023, ExtraData = null },  /*conduit*/  
            new Item(-197, 0, 1){ RuntimeId=12373, NetworkId=1024, ExtraData = null },  /*stonecutter*/  
            new Item(120, 0, 1){ RuntimeId=10432, NetworkId=1025, ExtraData = null },  /*end_portal_frame*/  
            new Item(263, 0, 1){ RuntimeId=0, NetworkId=1026, ExtraData = null },  /*minecraft:coal*/  
            new Item(263, 1, 1){ RuntimeId=0, NetworkId=1027, ExtraData = null },  /*charcoal*/  
            new Item(264, 0, 1){ RuntimeId=0, NetworkId=1028, ExtraData = null },  /*minecraft:diamond*/  
            new Item(452, 0, 1){ RuntimeId=0, NetworkId=1029, ExtraData = null },  /*minecraft:iron_nugget*/  
            new Item(265, 0, 1){ RuntimeId=0, NetworkId=1033, ExtraData = null },  /*minecraft:iron_ingot*/  
            new Item(371, 0, 1){ RuntimeId=0, NetworkId=1036, ExtraData = null },  /*minecraft:gold_nugget*/  
            new Item(266, 0, 1){ RuntimeId=0, NetworkId=1037, ExtraData = null },  /*minecraft:gold_ingot*/  
            new Item(388, 0, 1){ RuntimeId=0, NetworkId=1038, ExtraData = null },  /*minecraft:emerald*/  
            new Item(406, 0, 1){ RuntimeId=0, NetworkId=1039, ExtraData = null },  /*minecraft:quartz*/  
            new Item(337, 0, 1){ RuntimeId=0, NetworkId=1040, ExtraData = null },  /*minecraft:clay_ball*/  
            new Item(336, 0, 1){ RuntimeId=0, NetworkId=1041, ExtraData = null },  /*minecraft:brick*/  
            new Item(405, 0, 1){ RuntimeId=0, NetworkId=1042, ExtraData = null },  /*minecraft:netherbrick*/  
            new Item(409, 0, 1){ RuntimeId=0, NetworkId=1043, ExtraData = null },  /*minecraft:prismarine_shard*/  
            new Item(422, 0, 1){ RuntimeId=0, NetworkId=1045, ExtraData = null },  /*minecraft:prismarine_crystals*/  
            new Item(465, 0, 1){ RuntimeId=0, NetworkId=1046, ExtraData = null },  /*minecraft:nautilus_shell*/  
            new Item(467, 0, 1){ RuntimeId=0, NetworkId=1047, ExtraData = null },  /*minecraft:heart_of_the_sea*/  
            new Item(468, 0, 1){ RuntimeId=0, NetworkId=1048, ExtraData = null },  /*minecraft:scute*/  
            new Item(470, 0, 1){ RuntimeId=0, NetworkId=1049, ExtraData = null },  /*minecraft:phantom_membrane*/  
            new Item(287, 0, 1){ RuntimeId=0, NetworkId=1050, ExtraData = null },  /*minecraft:string*/  
            new Item(288, 0, 1){ RuntimeId=0, NetworkId=1051, ExtraData = null },  /*minecraft:feather*/  
            new Item(318, 0, 1){ RuntimeId=0, NetworkId=1052, ExtraData = null },  /*minecraft:flint*/  
            new Item(289, 0, 1){ RuntimeId=0, NetworkId=1053, ExtraData = null },  /*minecraft:gunpowder*/  
            new Item(334, 0, 1){ RuntimeId=0, NetworkId=1054, ExtraData = null },  /*minecraft:leather*/  
            new Item(415, 0, 1){ RuntimeId=0, NetworkId=1055, ExtraData = null },  /*minecraft:rabbit_hide*/  
            new Item(414, 0, 1){ RuntimeId=0, NetworkId=1056, ExtraData = null },  /*minecraft:rabbits_foot*/  
            new Item(385, 0, 1){ RuntimeId=0, NetworkId=1057, ExtraData = null },  /*minecraft:fire_charge*/  
            new Item(369, 0, 1){ RuntimeId=0, NetworkId=1058, ExtraData = null },  /*minecraft:blaze_rod*/  
            new Item(377, 0, 1){ RuntimeId=0, NetworkId=1059, ExtraData = null },  /*minecraft:blaze_powder*/  
            new Item(378, 0, 1){ RuntimeId=0, NetworkId=1060, ExtraData = null },  /*minecraft:magma_cream*/  
            new Item(376, 0, 1){ RuntimeId=0, NetworkId=1061, ExtraData = null },  /*minecraft:fermented_spider_eye*/  
            new Item(437, 0, 1){ RuntimeId=0, NetworkId=1063, ExtraData = null },  /*minecraft:dragon_breath*/  
            new Item(445, 0, 1){ RuntimeId=0, NetworkId=1064, ExtraData = null },  /*minecraft:shulker_shell*/  
            new Item(370, 0, 1){ RuntimeId=0, NetworkId=1065, ExtraData = null },  /*minecraft:ghast_tear*/  
            new Item(341, 0, 1){ RuntimeId=0, NetworkId=1066, ExtraData = null },  /*minecraft:slime_ball*/  
            new Item(368, 0, 1){ RuntimeId=0, NetworkId=1067, ExtraData = null },  /*minecraft:ender_pearl*/  
            new Item(381, 0, 1){ RuntimeId=0, NetworkId=1068, ExtraData = null },  /*minecraft:ender_eye*/  
            new Item(399, 0, 1){ RuntimeId=0, NetworkId=1069, ExtraData = null },  /*minecraft:nether_star*/  
            new Item(208, 0, 1){ RuntimeId=9842, NetworkId=1070, ExtraData = null },  /*end_rod*/  
            new Item(426, 0, 1){ RuntimeId=0, NetworkId=1071, ExtraData = null },  /*minecraft:end_crystal*/  
            new Item(339, 0, 1){ RuntimeId=0, NetworkId=1072, ExtraData = null },  /*minecraft:paper*/  
            new Item(340, 0, 1){ RuntimeId=0, NetworkId=1073, ExtraData = null },  /*minecraft:book*/  
            new Item(386, 0, 1){ RuntimeId=0, NetworkId=1074, ExtraData = null },  /*book_and_quill*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1075, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 0), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1076, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 0), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1077, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 0), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1078, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 0), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1079, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 1), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1080, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 1), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1081, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 1), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1082, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 1), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1083, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 2), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1084, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 2), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1085, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 2), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1086, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 2), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1087, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 3), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1088, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 3), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1089, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 3), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1090, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 3), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1091, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 4), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1092, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 4), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1093, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 4), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1094, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 4), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1095, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 5), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1096, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 5), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1097, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 5), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1098, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 6), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1099, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 6), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1100, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 6), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1101, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 7), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1102, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 7), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1103, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 7), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1104, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 8), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1105, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 9), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1106, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 9), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1107, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 9), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1108, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 9), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1109, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 9), new NbtShort("lvl", 5) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1110, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 10), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1111, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 10), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1112, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 10), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1113, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 10), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1114, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 10), new NbtShort("lvl", 5) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1115, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 11), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1116, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 11), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1117, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 11), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1118, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 11), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1119, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 11), new NbtShort("lvl", 5) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1120, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 12), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1121, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 12), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1122, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 13), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1123, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 13), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1124, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 14), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1125, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 14), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1126, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 14), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1127, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 15), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1128, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 15), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1129, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 15), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1130, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 15), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1131, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 15), new NbtShort("lvl", 5) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1132, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 16), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1133, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 17), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1134, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 17), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1135, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 17), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1136, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 18), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1137, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 18), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1138, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 18), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1139, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 19), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1140, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 19), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1141, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 19), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1142, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 19), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1143, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 19), new NbtShort("lvl", 5) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1144, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 20), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1145, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 20), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1146, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 21), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1147, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 22), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1148, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 23), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1149, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 23), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1150, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 23), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1151, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 24), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1152, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 24), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1153, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 24), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1154, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 25), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1155, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 25), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1156, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 26), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1157, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 27), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1158, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 28), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1159, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 29), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1160, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 29), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1161, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 29), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1162, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 29), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1163, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 29), new NbtShort("lvl", 5) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1164, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 30), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1165, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 30), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1166, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 30), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1167, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 31), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1168, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 31), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1169, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 31), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1170, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 32), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1171, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 33), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1172, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 34), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1173, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 34), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1174, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 34), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1175, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 34), new NbtShort("lvl", 4) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1176, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 35), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1177, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 35), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1178, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 35), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1179, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 36), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1180, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 36), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1181, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 36), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1182, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 37), new NbtShort("lvl", 1) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1183, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 37), new NbtShort("lvl", 2) } } } },  /*minecraft:enchanted_book*/  
            new Item(403, 0, 1){ RuntimeId=0, NetworkId=1184, ExtraData = new NbtCompound { new NbtList("ench", (NbtTagType)10) { new NbtCompound { new NbtShort("id", 37), new NbtShort("lvl", 3) } } } },  /*minecraft:enchanted_book*/  
            new Item(333, 0, 1){ RuntimeId=0, NetworkId=1185, ExtraData = null },  /*minecraft:boat*/  
            new Item(333, 1, 1){ RuntimeId=0, NetworkId=1186, ExtraData = null },  /*minecraft:boat*/  
            new Item(333, 2, 1){ RuntimeId=0, NetworkId=1187, ExtraData = null },  /*minecraft:boat*/  
            new Item(333, 3, 1){ RuntimeId=0, NetworkId=1188, ExtraData = null },  /*minecraft:boat*/  
            new Item(333, 4, 1){ RuntimeId=0, NetworkId=1189, ExtraData = null },  /*minecraft:boat*/  
            new Item(333, 5, 1){ RuntimeId=0, NetworkId=1190, ExtraData = null },  /*minecraft:boat*/  
            new Item(66, 0, 1){ RuntimeId=6172, NetworkId=1199, ExtraData = null },  /*rail*/  
            new Item(27, 0, 1){ RuntimeId=8476, NetworkId=1200, ExtraData = null },  /*powered_rail*/  
            new Item(28, 0, 1){ RuntimeId=6384, NetworkId=1201, ExtraData = null },  /*detector_rail*/  
            new Item(126, 0, 1){ RuntimeId=1039, NetworkId=1202, ExtraData = null },  /*activator_rail*/  
            new Item(328, 0, 1){ RuntimeId=0, NetworkId=1203, ExtraData = null },  /*minecraft:minecart*/  
            new Item(342, 0, 1){ RuntimeId=0, NetworkId=1204, ExtraData = null },  /*minecraft:chest_minecart*/  
            new Item(408, 0, 1){ RuntimeId=0, NetworkId=1205, ExtraData = null },  /*minecraft:hopper_minecart*/  
            new Item(407, 0, 1){ RuntimeId=0, NetworkId=1206, ExtraData = null },  /*minecraft:tnt_minecart*/  
            new Item(331, 0, 1){ RuntimeId=0, NetworkId=1207, ExtraData = null },  /*minecraft:redstone*/  
            new Item(152, 0, 1){ RuntimeId=5649, NetworkId=1208, ExtraData = null },  /*redstone_block*/  
            new Item(76, 0, 1){ RuntimeId=4998, NetworkId=1209, ExtraData = null },  /*redstone_torch*/  
            new Item(69, 0, 1){ RuntimeId=10874, NetworkId=1210, ExtraData = null },  /*lever*/  
            new Item(143, 0, 1){ RuntimeId=10747, NetworkId=1211, ExtraData = null },  /*oak_button*/  
            new Item(-144, 0, 1){ RuntimeId=6620, NetworkId=1212, ExtraData = null },  /*spruce_button*/  
            new Item(-141, 0, 1){ RuntimeId=12573, NetworkId=1213, ExtraData = null },  /*birch_button*/  
            new Item(-143, 0, 1){ RuntimeId=125, NetworkId=1214, ExtraData = null },  /*jungle_button*/  
            new Item(-140, 0, 1){ RuntimeId=12021, NetworkId=1215, ExtraData = null },  /*acacia_button*/  
            new Item(-142, 0, 1){ RuntimeId=99, NetworkId=1216, ExtraData = null },  /*dark_oak_button*/  
            new Item(77, 0, 1){ RuntimeId=1335, NetworkId=1217, ExtraData = null },  /*stone_button*/  
            new Item(131, 0, 1){ RuntimeId=9871, NetworkId=1221, ExtraData = null },  /*tripwire_hook*/  
            new Item(72, 0, 1){ RuntimeId=12871, NetworkId=1222, ExtraData = null },  /*oak_pressure_plate*/  
            new Item(-154, 0, 1){ RuntimeId=5631, NetworkId=1223, ExtraData = null },  /*spruce_pressure_plate*/  
            new Item(-151, 0, 1){ RuntimeId=5414, NetworkId=1224, ExtraData = null },  /*birch_pressure_plate*/  
            new Item(-153, 0, 1){ RuntimeId=5500, NetworkId=1225, ExtraData = null },  /*jungle_pressure_plate*/  
            new Item(-150, 0, 1){ RuntimeId=8391, NetworkId=1226, ExtraData = null },  /*acacia_pressure_plate*/  
            new Item(-152, 0, 1){ RuntimeId=9913, NetworkId=1227, ExtraData = null },  /*dark_oak_pressure_plate*/  
            new Item(70, 0, 1){ RuntimeId=6138, NetworkId=1230, ExtraData = null },  /*stone_pressure_plate*/  
            new Item(147, 0, 1){ RuntimeId=5531, NetworkId=1231, ExtraData = null },  /*light_weight_pressure_plate*/  
            new Item(148, 0, 1){ RuntimeId=2258, NetworkId=1232, ExtraData = null },  /*heavy_weight_pressure_plate*/  
            new Item(251, 0, 1){ RuntimeId=4986, NetworkId=1234, ExtraData = null },  /*observer*/  
            new Item(151, 0, 1){ RuntimeId=6455, NetworkId=1235, ExtraData = null },  /*daylight_sensor*/  
            new Item(356, 0, 1){ RuntimeId=0, NetworkId=1236, ExtraData = null },  /*minecraft:repeater*/  
            new Item(404, 0, 1){ RuntimeId=0, NetworkId=1237, ExtraData = null },  /*minecraft:comparator*/  
            new Item(410, 0, 1){ RuntimeId=0, NetworkId=1238, ExtraData = null },  /*minecraft:hopper*/  
            new Item(125, 0, 1){ RuntimeId=12181, NetworkId=1239, ExtraData = null },  /*dropper*/  
            new Item(23, 0, 1){ RuntimeId=12819, NetworkId=1240, ExtraData = null },  /*dispenser*/  
            new Item(33, 0, 1){ RuntimeId=2040, NetworkId=1241, ExtraData = null },  /*piston*/  
            new Item(29, 0, 1){ RuntimeId=6668, NetworkId=1242, ExtraData = null },  /*sticky_piston*/  
            new Item(46, 0, 1){ RuntimeId=11059, NetworkId=1243, ExtraData = null },  /*tnt*/  
            new Item(421, 0, 1){ RuntimeId=0, NetworkId=1244, ExtraData = null },  /*minecraft:name_tag*/  
            new Item(-204, 0, 1){ RuntimeId=6083, NetworkId=1245, ExtraData = null },  /*loom*/  
            new Item(446, 0, 1){ RuntimeId=0, NetworkId=1246, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 1, 1){ RuntimeId=0, NetworkId=1247, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 2, 1){ RuntimeId=0, NetworkId=1248, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 3, 1){ RuntimeId=0, NetworkId=1249, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 4, 1){ RuntimeId=0, NetworkId=1250, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 5, 1){ RuntimeId=0, NetworkId=1251, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 6, 1){ RuntimeId=0, NetworkId=1252, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 7, 1){ RuntimeId=0, NetworkId=1253, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 8, 1){ RuntimeId=0, NetworkId=1254, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 9, 1){ RuntimeId=0, NetworkId=1255, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 10, 1){ RuntimeId=0, NetworkId=1256, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 11, 1){ RuntimeId=0, NetworkId=1257, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 12, 1){ RuntimeId=0, NetworkId=1258, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 13, 1){ RuntimeId=0, NetworkId=1259, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 14, 1){ RuntimeId=0, NetworkId=1260, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 15, 1){ RuntimeId=0, NetworkId=1261, ExtraData = null },  /*minecraft:banner*/  
            new Item(446, 16, 1){ RuntimeId=0, NetworkId=1262, ExtraData = new NbtCompound { new NbtInt("Type", 1) } },  /*illager_banner*/  
            new Item(434, 0, 1){ RuntimeId=0, NetworkId=1263, ExtraData = null },  /*minecraft:banner_pattern*/  
            new Item(434, 1, 1){ RuntimeId=0, NetworkId=1264, ExtraData = null },  /*minecraft:banner_pattern*/  
            new Item(434, 2, 1){ RuntimeId=0, NetworkId=1265, ExtraData = null },  /*minecraft:banner_pattern*/  
            new Item(434, 3, 1){ RuntimeId=0, NetworkId=1266, ExtraData = null },  /*minecraft:banner_pattern*/  
            new Item(434, 4, 1){ RuntimeId=0, NetworkId=1267, ExtraData = null },  /*minecraft:banner_pattern*/  
            new Item(434, 5, 1){ RuntimeId=0, NetworkId=1268, ExtraData = null },  /*minecraft:banner_pattern*/  
            new Item(434, 6, 1){ RuntimeId=0, NetworkId=1269, ExtraData = null },  /*minecraft:banner_pattern*/  
            new Item(434, 7, 1){ RuntimeId=0, NetworkId=1270, ExtraData = null },  /*minecraft:banner_pattern*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1271, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)0), new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1272, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{0}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1273, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{8}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1274, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{7}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1275, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{15}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1276, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{12}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1277, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{14}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1278, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{1}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1279, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{4}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1280, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{5}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1281, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{13}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1282, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{9}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1283, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{3}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1284, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{11}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1285, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{10}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1286, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{2}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(401, 0, 1){ RuntimeId=0, NetworkId=1287, ExtraData = new NbtCompound { new NbtCompound("Fireworks") { new NbtList("Explosions", (NbtTagType)10) { new NbtCompound { new NbtByteArray("FireworkColor", new byte[1]{6}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) } }, new NbtByte("Flight", 1) } } },  /*minecraft:firework_rocket*/  
            new Item(402, 0, 1){ RuntimeId=0, NetworkId=1288, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{0}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -14869215) } },  /*minecraft:firework_star*/  
            new Item(402, 8, 1){ RuntimeId=0, NetworkId=1289, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{8}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -12103854) } },  /*minecraft:firework_star*/  
            new Item(402, 7, 1){ RuntimeId=0, NetworkId=1290, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{7}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -6447721) } },  /*minecraft:firework_star*/  
            new Item(402, 15, 1){ RuntimeId=0, NetworkId=1291, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{15}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -986896) } },  /*minecraft:firework_star*/  
            new Item(402, 12, 1){ RuntimeId=0, NetworkId=1292, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{12}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -12930086) } },  /*minecraft:firework_star*/  
            new Item(402, 14, 1){ RuntimeId=0, NetworkId=1293, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{14}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -425955) } },  /*minecraft:firework_star*/  
            new Item(402, 1, 1){ RuntimeId=0, NetworkId=1294, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{1}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -5231066) } },  /*minecraft:firework_star*/  
            new Item(402, 4, 1){ RuntimeId=0, NetworkId=1295, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{4}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -12827478) } },  /*minecraft:firework_star*/  
            new Item(402, 5, 1){ RuntimeId=0, NetworkId=1296, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{5}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -7785800) } },  /*minecraft:firework_star*/  
            new Item(402, 13, 1){ RuntimeId=0, NetworkId=1297, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{13}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -3715395) } },  /*minecraft:firework_star*/  
            new Item(402, 9, 1){ RuntimeId=0, NetworkId=1298, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{9}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -816214) } },  /*minecraft:firework_star*/  
            new Item(402, 3, 1){ RuntimeId=0, NetworkId=1299, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{3}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -8170446) } },  /*minecraft:firework_star*/  
            new Item(402, 11, 1){ RuntimeId=0, NetworkId=1300, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{11}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -75715) } },  /*minecraft:firework_star*/  
            new Item(402, 10, 1){ RuntimeId=0, NetworkId=1301, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{10}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -8337633) } },  /*minecraft:firework_star*/  
            new Item(402, 2, 1){ RuntimeId=0, NetworkId=1302, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{2}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -10585066) } },  /*minecraft:firework_star*/  
            new Item(402, 6, 1){ RuntimeId=0, NetworkId=1303, ExtraData = new NbtCompound { new NbtCompound("FireworksItem") { new NbtByteArray("FireworkColor", new byte[1]{6}), new NbtByteArray("FireworkFade", new byte[0]{}), new NbtByte("FireworkFlicker", 0), new NbtByte("FireworkTrail", 0), new NbtByte("FireworkType", 0) }, new NbtInt("customColor", -15295332) } },  /*minecraft:firework_star*/   
        };
	}
}