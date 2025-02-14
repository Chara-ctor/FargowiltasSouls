﻿using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FargowiltasSouls.Projectiles.Minions
{
    public class DestroyerBody : ModProjectile
    {
        public int attackTimer;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Destroyer Body");
            ProjectileID.Sets.Homing[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 24;
            projectile.penetrate = -1;
            projectile.timeLeft = 300;
            projectile.minion = true;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.alpha = 255;
            projectile.netImportant = true;
            projectile.hide = true;
        }

        public override void SendExtraAI(BinaryWriter writer)
        {
            writer.Write(projectile.localAI[0]);
            writer.Write(projectile.localAI[1]);
        }

        public override void ReceiveExtraAI(BinaryReader reader)
        {
            projectile.localAI[0] = reader.ReadSingle();
            projectile.localAI[1] = reader.ReadSingle();
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }

        public override void DrawBehind(int index, List<int> drawCacheProjsBehindNPCsAndTiles, List<int> drawCacheProjsBehindNPCs, List<int> drawCacheProjsBehindProjectiles,
            List<int> drawCacheProjsOverWiresUI)
        {
            drawCacheProjsBehindProjectiles.Add(index);
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Texture2D texture2D13 = Main.projectileTexture[projectile.type];
            Texture2D glow = mod.GetTexture("Projectiles/Minions/DestroyerBody_glow");
            int num214 = Main.projectileTexture[projectile.type].Height / Main.projFrames[projectile.type];
            int y6 = num214 * projectile.frame;
            Microsoft.Xna.Framework.Color color25 = Lighting.GetColor((int)(projectile.Center.X / 16), (int)(projectile.Center.Y / 16));
            Main.spriteBatch.Draw(texture2D13, projectile.Center - Main.screenPosition + new Vector2(0f, projectile.gfxOffY), new Rectangle(0, y6, texture2D13.Width, num214),
                color25, projectile.rotation, new Vector2(texture2D13.Width / 2f, num214 / 2f), projectile.scale,
                projectile.spriteDirection == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally, 0f);
            Main.spriteBatch.Draw(glow, projectile.Center - Main.screenPosition + new Vector2(0f, projectile.gfxOffY), new Rectangle(0, y6, texture2D13.Width, num214),
                Color.White, projectile.rotation, new Vector2(texture2D13.Width / 2f, num214 / 2f), projectile.scale,
                projectile.spriteDirection == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally, 0f);
            return false;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>();

            if ((int)Main.time % 120 == 0) projectile.netUpdate = true;

            int num1038 = 30;

            bool flag67 = false;
            Vector2 value67 = Vector2.Zero;
            Vector2 arg_2D865_0 = Vector2.Zero;
            float num1052 = 0f;
            if (projectile.ai[1] == 1f)
            {
                projectile.ai[1] = 0f;
                projectile.netUpdate = true;
            }

            int byUUID = FargoSoulsUtil.GetByUUIDReal(projectile.owner, (int)projectile.ai[0], projectile.type, ModContent.ProjectileType<DestroyerHead>());
            if (byUUID >= 0 && Main.projectile[byUUID].active)
            {
                flag67 = true;
                value67 = Main.projectile[byUUID].Center;
                Vector2 arg_2D957_0 = Main.projectile[byUUID].velocity;
                num1052 = Main.projectile[byUUID].rotation;
                float num1053 = MathHelper.Clamp(Main.projectile[byUUID].scale, 0f, 50f);
                int arg_2D9AD_0 = Main.projectile[byUUID].alpha;
                Main.projectile[byUUID].localAI[0] = projectile.localAI[0] + 1f;
                if (Main.projectile[byUUID].type != mod.ProjectileType("DestroyerHead")) Main.projectile[byUUID].localAI[1] = projectile.identity;
            }

            if (!flag67) return;

            projectile.alpha -= 42;
            if (projectile.alpha < 0) projectile.alpha = 0;
            projectile.velocity = Vector2.Zero;
            Vector2 vector134 = value67 - projectile.Center;
            if (num1052 != projectile.rotation)
            {
                float num1056 = MathHelper.WrapAngle(num1052 - projectile.rotation);
                vector134 = vector134.RotatedBy(num1056 * 0.1f, default(Vector2));
            }

            projectile.rotation = vector134.ToRotation() + 1.57079637f;
            projectile.position = projectile.Center;
            projectile.width = projectile.height = (int)(num1038 * projectile.scale);
            projectile.Center = projectile.position;
            if (vector134 != Vector2.Zero) projectile.Center = value67 - Vector2.Normalize(vector134) * 36;
            projectile.spriteDirection = vector134.X > 0f ? 1 : -1;

            if (--attackTimer <= 0)
            {
                attackTimer = Main.rand.Next(150) + 150;
            }

            if (attackTimer == 1)
            {
                if (projectile.owner == Main.myPlayer)
                {
                    int selectedTarget = -1; //pick target
                    const float maxRange = 750f;
                    for (int i = 0; i < Main.maxNPCs; i++)
                    {
                        if (Main.npc[i].CanBeChasedBy(projectile) && Collision.CanHit(projectile.Center, 0, 0, Main.npc[i].Center, 0, 0))
                        {
                            if (projectile.Distance(Main.npc[i].Center) <= maxRange && Main.rand.NextBool()) //random because destroyer
                                selectedTarget = i;
                        }
                    }

                    if (selectedTarget != -1) //shoot
                    {
                        Projectile.NewProjectile(projectile.Center, 10f * projectile.DirectionTo(Main.npc[selectedTarget].Center),
                            ProjectileID.MiniRetinaLaser, projectile.damage, projectile.knockBack, projectile.owner);
                        Main.PlaySound(SoundID.Item12, projectile.Center);
                    }
                }
            }
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 20; i++)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, -projectile.velocity.X * 0.2f,
                    -projectile.velocity.Y * 0.2f, 100, default(Color), 2f);
                Main.dust[dust].noGravity = true;
                Main.dust[dust].velocity *= 2f;
                dust = Dust.NewDust(new Vector2(projectile.Center.X, projectile.Center.Y), projectile.width, projectile.height, 60, -projectile.velocity.X * 0.2f,
                    -projectile.velocity.Y * 0.2f, 100);
                Main.dust[dust].velocity *= 2f;
            }
            int g = Gore.NewGore(projectile.Center, projectile.velocity/2, mod.GetGoreSlot("Gores/DestroyerGun/DestroyerBody"), projectile.scale);
            Main.gore[g].timeLeft = 20;
        }
    }
}