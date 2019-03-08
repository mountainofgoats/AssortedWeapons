using AssortedWeapons.Weapons;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace AssortedWeapons.Projectiles
{
    public class WoefulProjectile : ModProjectile
    {
		public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("WoefulProjectile");
	}

        public override void SetDefaults()
        {
		projectile.CloneDefaults(ProjectileID.VampireKnife);
		aiType = ProjectileID.VampireKnife;
		projectile.width = 10;
		projectile.height = 12;
		projectile.aiStyle = 1;
		projectile.friendly = true;
		projectile.melee = true;
		projectile.penetrate = 10;
        }
    }
}