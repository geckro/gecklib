using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace gecklib.RecipeGroups
{
	public class furniture : ModSystem
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Any Table"), new int[] {
				32, // Wooden
				1714, // Banquet
				1715, // Bar
				4064, // Picnic Table
				4065, // Fancy ^^
				829, // Living Wood
				677, // Boreal
				2743, // Cactus
				2532, // Palm
				2259, // Dynasty
				1816, // Spooky
				639, // Rich Mahogany
				4583, // Bamboo
				640, // Pearlwood
				1794, // Pumpkin
				1926, // Pine
				4314, // Sandstone
				917, // Shadewood
				3948, // Spider
				2550, // Mushroom
				3153, // Meteorite
				2824, // Martian
				3154, // Marble
				3155, // Granite
				3920, // Crystal
				638, // Ebonwood
				4204, // Nebula
				4162, // Solar
				4225, // Stardust
				4183, // Vortex
				827, // Bone
				3974, // Lesion
				828, // Flesh
				1713, // Glass
				2248, // Frozen
				1144, // Lihzahrd
				8330, // Skyware
				2583, // Slime
				1718, // Steampunk
				1510, // Gothic
				1397, // Blue Dungeon
				1400, // Green Dungeon
				1403, // Pink Dungeon
				1460, // Obsidian
				1716 // Golden
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Bookcases"), new int[] {
				354, // Wooden
				2135, // Living Wood
				2554, // Boreal
				2020, // Cactus
				2536, // Palm
				2233, // Dynasty
				2028, // Spooky
				2026, // Rich Mahogany
				4568, // Bamboo
				2027, // Pearlwood
				2670, // Pumpkin
				4300, // Sandstone
				2136, // Shadewood
				3933, // Spider
				2540, // Mushroom
				3165, // Meteorite
				2817, // Martian
				3166, // Marble
				3167, // Granite
				3917, // Crystal
				2021, // Ebonwood
				4189, // Nebula
				4147, // Solar
				4210, // Stardust
				4168, // Vortex
				2138, // Bone
				3960, // Lesion
				2022, // Flesh
				2025, // Glass
				2031, // Frozen
				2030, // Lihzahrd
				2029, // Skyware
				2569, // Slime
				2024, // Steampunk
				1512, // Gothic
				1414, // Blue Dungeon
				1415, // Green Dungeon
				1416, // Pink Dungeon
				1463, // Obsidian
				2137, // Golden
			});
		}
	}
}