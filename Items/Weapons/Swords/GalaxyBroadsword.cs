using AssortedWeapons.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Items.Weapons.Swords
{
    public class GalaxyBroadsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The world shudders at your might!");
        }

        public override void SetDefaults()
        {
			item.shootSpeed = 10f;
		    item.shoot = mod.ProjectileType("GalaxyBroadswordProjectile");
			item.damage = 130;
			item.knockBack = 6f;
			item.useStyle = 1;
			item.useAnimation = 10;
			item.useTime = 10;
			item.width = 50;
			item.height = 50;
			item.maxStack = 1;
			item.rare = 10;
			item.consumable = false;
			item.noUseGraphic = false;
			item.noMelee = false;
			item.autoReuse = true;
			item.melee = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddIngredient(ItemID.FragmentNebula, 10);
			recipe.AddIngredient(ItemID.FragmentStardust, 10);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
				target.AddBuff(BuffID.Ichor, 300);
				target.AddBuff(BuffID.CursedInferno, 300);
				target.AddBuff(BuffID.Frostburn, 300);
				target.AddBuff(BuffID.OnFire, 300);
		}	
	}
}