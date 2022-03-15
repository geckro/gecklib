using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace gecklib.RecipeGroups
{
	public class banners : ModSystem
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Any Slime Banners"), new int[] {
				1683, // Blue
				2928, // Green
				2964, // Purple
				1690, // Umbrella
				2968, // Red
				2992, // Yellow
				2899, // Black
				2955, // Mother
				2916, // Dungeon
				2960, // Pinky
				2940, // Jungle
				2981, // SpikedJungle
				2935, // Ice
				2980, // SpikedIce
				3593, // Sand
				2944, // Lava
				1689, // ToxicSludge
				2908, // Corrupt
				2976, // Slimer
				2910, // Crimslime
				1651, // Gastropod
				2938, // Illuminant
				2966 // Rainbow
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Demon Eye Banners"), new int[] {
				1639, // Demon Eye
				4977 // Wandering Eye
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Zombie Banners"), new int[] {
				1701, // Zombie
				1678 // Raincoat Zombie
			});
            group = new RecipeGroup(() => Language.GetTextValue("Any Goblin Banners"), new int[] {
				2927, // Archer
				1654, // Peon
				1653, // Sorcerer
				1652, // Thief
				1656, // Warrior
				3390 // Summoner
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Bat Banners"), new int[] {
				1621, // Cave Bat
				2923, // Giant Bat
				4968, // Spore Bat
				2933, // Ice Bat
				2939, // Jungle Bat
				2925, // Giant Flying Fox
				1659, // Hellbat
				2943, // Lava Bat
				2937 // Illuminant Bat
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Corrupt Banner"), new int[] {
				2913, // Devourer
				1641, // Eater of Souls
				2905, // Clinger
				2909, // Corruptor
				1697 // World Feeder
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Hornet Banner"), new int[] {
				1661, // Hornet
				4976 // Moss
			});
			group = new RecipeGroup(() => Language.GetTextValue("Any Jellyfish Banner"), new int[] {
				3447, // Pink
				1665, // Blue
				3448 // Green
			});
		}
	}
}