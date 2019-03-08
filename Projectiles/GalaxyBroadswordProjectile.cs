using AssortedWeapons.Items.Weapons.Swords;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace AssortedWeapons.Projectiles
{
    public class GalaxyBroadswordProjectile : ModProjectile
    {
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Galaxy Broadsword");
        }

        public override void SetDefaults()
        {
        projectile.CloneDefaults(ProjectileID.TerraBeam);
        }

        public override void AI()
        {
            projectile.penetrate = 10;
            projectile.timeLeft = 150;
            projectile.ignoreWater = true;
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 234, projectile.velocity.X * -0.5f, projectile.velocity.Y * -0.5f);
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 5; i++)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 234);
                Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            }
        }

        public override void OnHitNPC (NPC target, int damage, float knockback, bool crit)
        {
                target.AddBuff(BuffID.Ichor, 300);
                target.AddBuff(BuffID.CursedInferno, 300);
                target.AddBuff(BuffID.Frostburn, 300);
                target.AddBuff(BuffID.OnFire, 300);
        }
    }
}