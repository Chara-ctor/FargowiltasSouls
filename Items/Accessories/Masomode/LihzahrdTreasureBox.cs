using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FargowiltasSouls.Items.Accessories.Masomode
{
    public class LihzahrdTreasureBox : ModItem
    {
        public override string Texture => "FargowiltasSouls/Items/Placeholder";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lihzahrd Treasure Box");
            Tooltip.SetDefault(@"'Too many booby traps to open'
Grants immunity to Burning and Fused
You erupt into spiky balls when injured
Press down in the air to fastfall
Fastfall will create a fiery eruption on impact after falling a certain distance");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            item.rare = 8;
            item.value = Item.sellPrice(0, 6);
            item.defense = 8;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[mod.BuffType("Fused")] = true;
            player.GetModPlayer<FargoPlayer>().LihzahrdTreasureBox = true;
        }
    }
}
