using AssortedWeapons.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AssortedWeapons.Items.Weapons.ThrowingWeapons
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
            item.useTurn = true;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
        
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i <= Main.rand.Next(4,5); i++)
            {

                Vector2 playerPosition = player.position;

                float posX = playerPosition.X + Main.rand.Next(-5, 5) * 16; //because the tile size in terraria is 16x16 pxs
                float posY = playerPosition.Y + Main.rand.Next(-5, 5) * 16;

                Projectile.NewProjectile(posX, posY, speedX, speedY, type, damage, knockBack, Main.myPlayer);
            }
            return true;
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
