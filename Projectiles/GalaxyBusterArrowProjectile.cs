using AssortedWeapons.Items.Weapons.RangedWeapons;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace AssortedWeapons.Projectiles
{
    public class GalaxyBusterArrowProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Galaxy Buster Arrow");
        }

        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.aiStyle = 1;
            projectile.timeLeft = 150;
            projectile.hostile = false;
			aiType = ProjectileID.JestersArrow;
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
                projectile.penetrate = 10;
                projectile.maxPenetrate = 10;
                projectile.ignoreWater = true;
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 234, projectile.velocity.X * -0.5f, projectile.velocity.Y * -0.5f);
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