using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Weapons
{
    public class LegendsSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Sword of Evils Bane.");
        }

        public override void SetDefaults()
        {
			item.damage = 65;
			item.knockBack = 6f;
			item.useStyle = 1;
			item.useAnimation = 10;
			item.useTime = 10;
			item.width = 46;
			item.height = 46;
			item.maxStack = 1;
			item.rare = 7;

			item.consumable = false;
			item.noUseGraphic = false;
			item.noMelee = false;
			item.autoReuse = true;
			item.melee = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 1);
        
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumSword);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.BrokenArmor, 300);
			target.AddBuff(BuffID.OnFire, 300);
		}	
	}
}
