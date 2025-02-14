﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using FargowiltasSouls.Items.Accessories.Enchantments;

namespace FargowiltasSouls.Items.Accessories.Forces
{
    public class TimberForce : SoulsItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Force of Timber");

            Tooltip.SetDefault(
$"[i:{ModContent.ItemType<WoodEnchant>()}] Turns certain critters into weapons\n" +
$"[i:{ModContent.ItemType<BorealWoodEnchant>()}] Attacks will periodically be accompanied by several snowballs\n" +
$"[i:{ModContent.ItemType<RichMahoganyEnchant>()}] All grappling hooks shoot, pull, and retract 2.5x as fast\n" +
$"[i:{ModContent.ItemType<EbonwoodEnchant>()}] You have an aura of Shadowflame, Cursed Flames, and Bleeding\n" +
$"[i:{ModContent.ItemType<PalmWoodEnchant>()}] Double tap down to spawn a palm tree sentry that throws nuts at enemies\n" +
$"[i:{ModContent.ItemType<PearlwoodEnchant>()}] Projectiles may spawn a star when they hit something\n" +
"'Extremely rigid'");
            DisplayName.AddTranslation(GameCulture.Chinese, "森林之力");
            Tooltip.AddTranslation(GameCulture.Chinese,
@"小动物在释放出去1秒后会爆炸
50%几率不消耗弹药
攻击时定期释放雪球
所有钩爪的抛出速度、牵引速度和回收速度x2.5
一圈暗影焰、诅咒焰和流血光环环绕着你
双击'下'键会召唤一个会向敌人扔橡子的棕榈树哨兵
弹幕在击中敌人或物块时有几率生成一颗星星
'很刚'");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            item.rare = ItemRarityID.Purple;
            item.value = 600000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>();
            modPlayer.WoodForce = true;
            //wood
            modPlayer.WoodEnchant = true;
            //boreal
            modPlayer.BorealEnchant = true;
            modPlayer.AdditionalAttacks = true;
            //mahogany
            modPlayer.MahoganyEnchant = true;

            //ebon
            modPlayer.EbonEffect();
            //shade
            modPlayer.ShadewoodEffect();

            //shade
            modPlayer.ShadeEnchant = true;
            //palm
            modPlayer.PalmEffect();
            //pearl
            modPlayer.PearlEnchant = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "WoodEnchant");
            recipe.AddIngredient(null, "BorealWoodEnchant");
            recipe.AddIngredient(null, "RichMahoganyEnchant");
            recipe.AddIngredient(null, "EbonwoodEnchant");
            recipe.AddIngredient(null, "ShadewoodEnchant");
            recipe.AddIngredient(null, "PalmWoodEnchant");
            recipe.AddIngredient(null, "PearlwoodEnchant");

            recipe.AddTile(ModLoader.GetMod("Fargowiltas").TileType("CrucibleCosmosSheet"));

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
