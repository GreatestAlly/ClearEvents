using Terraria.ModLoader;
using Terraria.ID;

namespace ClearEvents
{
	class ClearEvents : Mod
	{
		public ClearEvents()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void AddRecipes()
        {
            /*
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(ItemID.GoblinBattleStandard, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(ItemID.SolarTablet, 1);
            recipe.AddRecipe();
            */
        }
    }
}
