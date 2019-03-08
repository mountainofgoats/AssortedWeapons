using AssortedWeapons.Weapons;
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
            DisplayName.SetDefault("GalaxyBroadswordProjectile");
        }

        public override void SetDefaults()
        {
        projectile.CloneDefaults(ProjectileID.TerraBeam);
        }

        public override void AI()
        {
            projectile.penetrate = 10;
            projectile.timeLeft = 100;
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
            Main.PlaySound(27, (int)projectile.position.X, (int)projectile.position.Y);
        }
        {
                target.AddBuff(BuffID.Ichor, 300);
                target.AddBuff(BuffID.CursedInferno, 300);
                target.AddBuff(BuffID.Frostburn, 300);
                target.AddBuff(BuffID.OnFire, 300);
        }
    }
}
