using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace gecklib.RecipeGroups
{
	public class wood : ModSystem
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Any Wood"), new int[] {
				9, // Wood
				2503, // Boreal
				620, // Rich Mahogany
				619, // Ebon
				911, // Shade
				2504, // Palm
				621, // Pearl
				1729 // Spooky
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Evil Wood"), new int[] {
				619, // Ebon
				911, // Shade
			});
		}
	}
}