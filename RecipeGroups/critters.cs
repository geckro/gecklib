using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace gecklib.RecipeGroups
{
	public class critters : ModSystem
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Any Bunnies"), new int[] {
				2019, // Bunny
				2890, // Gold
				4838, // Gem Bunnies
				4839,
				4840,
				4841,
				4842,
				4843
				4844
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Squirrels"), new int[] {
				2018, // Brown	
				3563, // Red
				3564, // Gold
				4831, // Gem Squirrels
				4832,
				4833,
				4834,
				4835,
				4836,
				4837
			});
		}
	}
}