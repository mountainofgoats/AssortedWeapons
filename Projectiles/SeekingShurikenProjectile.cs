using AssortedWeapons.Items.Weapons.ThrowingWeapons;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace AssortedWeapons.Projectiles
{
    public class SeekingShurikenProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Seeking Shuriken");
        }

        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 26;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.aiStyle = 0;
            projectile.timeLeft = 100;
            projectile.hostile = true;
            projectile.CloneDefaults(ProjectileID.Shuriken);
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 1; i++)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 4);
                Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            }
        }

        public override void AI()
        {
            projectile.netUpdate = true;

            for (int i = 0; i < 200; i++)
            {
                projectile.penetrate = 10;
                projectile.maxPenetrate = 10;
                projectile.ignoreWater = true;

                NPC target = Main.npc[i];
                if (!target.friendly)
                {
                    float shootToX = target.position.X - projectile.Center.X;
                    float shootToY = target.position.Y - projectile.Center.Y;
                    float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                    if (distance < 450f && !target.active && !target.friendly)
                    {
                        distance = 2f / distance;

                        shootToX *= distance * 4;
                        shootToY *= distance * 4;

                        projectile.velocity.X = shootToX;
                        projectile.velocity.Y = shootToY;
                    }
                }
            }
            projectile.ai[0] += 1f;
        }
    }
}