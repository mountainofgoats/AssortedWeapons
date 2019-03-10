using AssortedWeapons.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Items.Weapons.RangedWeapons
{
    public class Starlight : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It envelops your hands in a bright pink light.");
        }

        public override void SetDefaults()
        {
			item.shootSpeed = 10f;
			item.shoot = mod.ProjectileType("GalaxyBusterArrowProjectile");
			item.damage = 30;
			item.knockBack = 1f;
			item.useStyle = 5;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 20;
			item.height = 43;
			item.maxStack = 1;
			item.rare = 4;
			item.useAmmo = AmmoID.Arrow;
			item.consumable = false;
			item.noUseGraphic = false;
			item.noMelee = true;
			item.autoReuse = true;
			item.ranged = true;

			item.UseSound = SoundID.Item5
			item.value = Item.sellPrice(silver: 5);
        
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.CrystalShard, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
