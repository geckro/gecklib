using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace gecklib.RecipeGroups
{
	public class consumables : ModSystem
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Any Bombs"), new int[] {
				166, // Bomb
				235, // Sticky
				3115, // Bouncy
				4908, // Dirt
				4423 // Scarab
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Grenades"), new int[] {
				168, // Grenade
				2586, // Sticky
				3116, // Bouncy
				1130 // Beenade
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Dynamite"), new int[] {
				167, // Dynamite
				2896, // Sticky
				3547, // Bouncy
				580 // Explosives
			});
		}
	}
}