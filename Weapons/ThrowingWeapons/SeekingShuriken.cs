using AssortedWeapons.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Weapons.ThrowingWeapons
{
    public class SeekingShuriken : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Pop!");
        }

        public override void SetDefaults()
        {
			item.shootSpeed = 10f;
		    item.shoot = mod.ProjectileType("SeekingShurikenProjectile");
			item.damage = 50;
			item.knockBack = 1f;
			item.useStyle = 1;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 26;
			item.height = 26;
			item.maxStack = 9999;
			item.rare = 5;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
        
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
			recipe.AddIngredient(ItemID.Shuriken, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
