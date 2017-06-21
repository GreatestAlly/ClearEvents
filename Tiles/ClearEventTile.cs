using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;
using Microsoft.Xna.Framework;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace ClearEvents.Tiles
{
    class ClearEventTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Clear Event Furniture");
            AddMapEntry(new Color(144, 148, 144), name);
            dustType = 11;
            disableSmartCursor = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("ClearEventFurniture"));
        }

        public override void HitWire(int i, int j)
        {
            if (Main.invasionType == 1 || Main.invasionType == 3)
            {
                Main.invasionType = 0;
            }
            Main.eclipse = false;
            Main.bloodMoon = false;
            Main.slimeRain = false;
        }
    }
}
