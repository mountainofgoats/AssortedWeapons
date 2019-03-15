using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Items.Weapons.Swords
{
    public class BorealQuarterstaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Poke");
        }

        public override void SetDefaults()
        {
			item.useStyle = 3;
			item.damage = 8;
			item.knockBack = 50f;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 40;
			item.height = 40;
			item.maxStack = 1;
			item.rare = 1;
			item.consumable = false;
			item.noUseGraphic = false;
			item.noMelee = false;
			item.autoReuse = true;
			item.melee = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
        }
				public override bool CanUseItem(Player player) 
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.AddIngredient(ItemID.BorealWood, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}