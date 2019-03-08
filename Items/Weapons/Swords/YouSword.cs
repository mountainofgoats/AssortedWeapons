using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Items.Weapons.Swords
{
    public class YouSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The gem reflects another you.");
        }

        public override void SetDefaults()
        {
			item.damage = 60;
			item.knockBack = 99f;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 15;
			item.width = 42;
			item.height = 42;
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
			recipe.AddIngredient(ItemID.TitaniumSword);
			recipe.AddIngredient(ItemID.CursedFlame, 10);
			recipe.AddIngredient(ItemID.Ichor, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.CursedInferno, 300);
			target.AddBuff(BuffID.Ichor, 300);
		}	
	}
}
