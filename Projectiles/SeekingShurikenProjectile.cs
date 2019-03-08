using AssortedWeapons.Weapons;
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
			DisplayName.SetDefault("SeekingShurikenProjectile");
		}

	    public override void SetDefaults()
	    {
		projectile.width = 26;
		projectile.height = 26;
		projectile.friendly = true;
		projectile.melee = true;
		projectile.aiStyle = 0;
		projectile.timeLeft = 100;
		projectile.CloneDefaults(ProjectileID.Shuriken);
		}

		public override void AI()

		{
		projectile.penetrate = 10;
		projectile.maxPenetrate = 10;
		}
	}
}