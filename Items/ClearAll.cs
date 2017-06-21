using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace ClearEvents.Items
{
    class ClearAll : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ankh of Cleansing");
            Tooltip.SetDefault("Clear invasions and events.");
        }

        public override void SetDefaults()
        {
            item.useTime = 10;
            item.width = 18;
            item.height = 18;
            item.maxStack = 99;
            item.useAnimation = 30;
            item.useStyle = 3;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 7, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item29;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            if (Main.bloodMoon)
            {
                return true;
            }
            if (Main.eclipse)
            {
                return true;
            }
            if (Main.slimeRain)
            {
                return true;
            }
            if (Main.invasionType == 1 || Main.invasionType == 3)
            {
                return true;
            }
            return false;
        }

        public override bool UseItem(Player player)
        {
            Main.invasionType = 0;
            Main.eclipse = false;
            Main.bloodMoon = false;
            Main.slimeRain = false;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBar, 5);
            recipe.AddIngredient(ItemID.SpikyBall, 20);
            recipe.AddIngredient(ItemID.SilverBullet, 99);
            recipe.AddIngredient(ItemID.Gel, 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 5);
            recipe.AddIngredient(ItemID.SpikyBall, 20);
            recipe.AddIngredient(ItemID.SilverBullet, 99);
            recipe.AddIngredient(ItemID.Gel, 30);
            recipe.AddTile(TileID.Anvils);
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
