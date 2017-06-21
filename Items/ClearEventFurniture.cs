using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace ClearEvents.Items
{
    class ClearEventFurniture :ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Invasion Clearer");
            Tooltip.SetDefault("Dispels invasions and events. ");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 10;
            item.consumable = true;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 7;
            item.value = 150000;
            item.createTile = mod.TileType("ClearEventTile");
            item.maxStack = 99;
            item.width = 18;
            item.height = 34;
            item.stack = 1;
        }

        public override void AddRecipes()
        {

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 5);
            recipe.AddIngredient(ItemID.BrokenHeroSword);
            recipe.AddIngredient(ItemID.Cutlass);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 5);
            recipe.AddIngredient(ItemID.BrokenHeroSword);
            recipe.AddIngredient(ItemID.Cutlass);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            // for testing purposes
            /*
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            */
        }
    }
}
