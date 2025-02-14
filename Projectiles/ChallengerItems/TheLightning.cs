using Terraria;

namespace FargowiltasSouls.Projectiles.ChallengerItems
{
    public class TheLightning : LightningArc
    {
        public override string Texture => "Terraria/Projectile_466";

        public override void SetDefaults()
        {
            base.SetDefaults();
            projectile.tileCollide = false;
            projectile.ranged = false;
            projectile.melee = true;

            projectile.usesIDStaticNPCImmunity = false;
            projectile.idStaticNPCHitCooldown = 0;
            projectile.GetGlobalProjectile<FargoGlobalProjectile>().noInteractionWithNPCImmunityFrames = false;
        }

        float collideHeight;

        public override bool PreAI()
        {
            if (collideHeight == 0)
            {
                collideHeight = projectile.ai[1];
                projectile.ai[1] = Main.rand.Next(80);
                projectile.netUpdate = true;
            }
            return base.PreAI();
        }

        public override void AI()
        {
            base.AI();

            if (projectile.Center.Y > collideHeight)
                projectile.tileCollide = true;
        }
    }
}