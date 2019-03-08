using AssortedWeapons.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Items.Ammo
{
    public class GalaxyBusterArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("To be added.");
        }

        public override void SetDefaults()
        {
			item.damage = 16;
			item.ranged = true;
			item.width = 14;
			item.height = 30;
			item.maxStack = 9999;
			item.consumable = true;
			item.knockBack = 4f;
			item.value = 100;
			item.rare = 6;
			item.shoot = mod.ProjectileType("GalaxyBusterArrowProjectile");
			item.shootSpeed = 16f;
			item.ammo = AmmoID.Arrow;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 1);
			recipe.AddIngredient(ItemID.LunarBar, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
