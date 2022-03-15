using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace gecklib.RecipeGroups
{
	public class metals : ModSystem
	{
		public override void AddRecipeGroups()
		{
			// Ores

			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Copper or Tin Ore"), new int[] {
				12, // CopperOre
				699, // TinOre
			});
			group = new RecipeGroup(() => Language.GetTextValue("Iron or Lead Ore"), new int[] {
				11, // IronOre
				700 // LeadOre
			});
			group = new RecipeGroup(() => Language.GetTextValue("Silver or Tungsten Ore"), new int[] {
				14, // SilverOre
				701 // TungstenOre
			});
            group = new RecipeGroup(() => Language.GetTextValue("Gold or Platinum Ore"), new int[] {
				13, // GoldOre
				702 // PlatinumOre
			});
			group = new RecipeGroup(() => Language.GetTextValue("Demonite or Crimtane Ore"), new int[] {
				56, // DemoniteOre
				880 // CrimtaneOre
			});

			group = new RecipeGroup(() => Language.GetTextValue("Cobalt or Palladium Ore"), new int[] {
				364, // CobaltOre
				1104 // PalladiumOre
			});
			group = new RecipeGroup(() => Language.GetTextValue("Mythril or Orichalcum Ore"), new int[] {
				365, // MythrilOre
				1105 // OrichalcumOre
			});
			group = new RecipeGroup(() => Language.GetTextValue("Adamantite or Titanium Ore"), new int[] {
				366, // AdamantiteOre
				1106 // OrichalcumOre
			});

			// Bars

			group = new RecipeGroup(() => Language.GetTextValue("Copper or Tin Bar"), new int[] {
				20, // CopperBar
				703 // TinBar
			});
			group = new RecipeGroup(() => Language.GetTextValue("Iron or Lead Bar"), new int[] {
				22, // IronBar
				704 // LeadBar
			});
			group = new RecipeGroup(() => Language.GetTextValue("Silver or Tungsten Bar"), new int[] {
				21, // SilverBar
				705 // TungstenBar
			});
            group = new RecipeGroup(() => Language.GetTextValue("Gold or Platinum Bar"), new int[] {
				19, // GoldBar
				706 // PlatinumBar
			});
			group = new RecipeGroup(() => Language.GetTextValue("Demonite or Crimtane Bar"), new int[] {
				57, // DemoniteBar
				1257 // CrimtaneBar
			});

			group = new RecipeGroup(() => Language.GetTextValue("Cobalt or Palladium Bar"), new int[] {
				381, // CobaltBar
				1184 // PalladiumBar
			});
			group = new RecipeGroup(() => Language.GetTextValue("Mythril or Orichalcum Bar"), new int[] {
				382, // MythrilBar
				1191 // OrichalcumBar
			});
			group = new RecipeGroup(() => Language.GetTextValue("Adamantite or Titanium Bar"), new int[] {
				391, // AdamantiteBar
				1198 // TitaniumBar
			});
		}
	}
}