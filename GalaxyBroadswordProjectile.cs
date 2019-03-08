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