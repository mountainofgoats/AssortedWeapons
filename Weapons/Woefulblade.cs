using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Weapons
{
    public class WoefulBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Silence, my brother.");
        }

        public override void SetDefaults()
        {
			item.damage = 70;
			item.knockBack = 1f;
			item.useStyle = 3;
			item.useAnimation = 10;
			item.useTime = 10;
			item.width = 28;
			item.height = 28;
			item.maxStack = 1;
			item.rare = 5;

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
			recipe.AddIngredient(ItemID.LifeCrystal, 10);
			recipe.AddIngredient(ItemID.PlatinumShortsword);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			player.AddBuff(BuffID.RapidHealing, 300);
		}	
	}
}
