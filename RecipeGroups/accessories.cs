using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace gecklib.RecipeGroups
{
	public class accessories : ModSystem
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Any Sprint Boots"), new int[] {
				54, // Hermes
				1579, // Flurry
				3200, // Sailfish
				4055 // Dunerider
			});
		}
	}
}