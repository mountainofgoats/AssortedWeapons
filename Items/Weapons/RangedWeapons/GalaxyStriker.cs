using AssortedWeapons.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Items.Weapons.RangedWeapons
{
    public class GalaxyStriker : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("To be added.");
        }

        public override void SetDefaults()
        {
			item.shootSpeed = 10f;
		    item.shoot = mod.ProjectileType("GalaxyBusterArrowProjectile");
			item.damage = 100;
			item.knockBack = 1f;
			item.useStyle = 5;
			item.useAnimation = 20;
			item.useTime = 20;
			item.width = 26;
			item.height = 26;
			item.maxStack = 1;
			item.rare = 5;
			item.useAmmo = AmmoID.Arrow;
			item.consumable = false;
			item.noUseGraphic = false;
			item.noMelee = true;
			item.autoReuse = true;
			item.ranged = true;

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
	}
}
