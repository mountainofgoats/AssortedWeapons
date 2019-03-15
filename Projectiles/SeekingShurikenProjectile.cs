using AssortedWeapons.Items.Weapons.ThrowingWeapons;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
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
            projectile.penetrate = 1;
            projectile.ignoreWater = true;
            projectile.width = 18;
            projectile.height = 24;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = 2;
            projectile.timeLeft = 600;
        }

        public override void AI()
        {

            for (int i = 0; i < 200; i++)
            {

                NPC target = Main.npc[i];
                float distancelimit = 650f;

                if (!target.friendly)
                {

                    float XCoords = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
                    float YCoords = target.position.Y - projectile.Center.Y;
                    float distance = (float)Math.Sqrt(Math.Pow(XCoords, 2) + Math.Pow(YCoords, 2));

                    if (distance < distancelimit && target.active && Collision.CanHitLine(projectile.Center, 0, 0, target.Center, 0, 0) && !target.immortal && projectile.timeLeft < 595) //note for Cat: projectile attacks only active targets; target is hostile; prevents the projectile from homing through tiles; prevents the projectile from aiming at dummies
                    {
                        distance = 3f / distance;

                        XCoords *= distance * 3;
                        YCoords *= distance * 3;

                        projectile.velocity.X = XCoords;
                        projectile.velocity.Y = YCoords;
                    }
                }
            }
            projectile.ai[0] += 1f;
        }

        public override void Kill(int timeLeft)
        {

            for (int i = 0; i < 1; i++)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 4);
                Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            }
        }
    }
}