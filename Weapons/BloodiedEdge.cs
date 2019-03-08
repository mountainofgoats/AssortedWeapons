using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssortedWeapons.Weapons
{
    public class BloodiedEdge : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An aura of death and pain surrounds you.");
        }

        public override void SetDefaults()
        {
			item.damage = 32;
			item.knockBack = 4f;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 15;
			item.width = 42;
			item.height = 48;
			item.maxStack = 1;
			item.rare = 2;

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
			recipe.AddIngredient(ItemID.BloodButcherer);
			recipe.AddIngredient(ItemID.LightsBane);
			recipe.AddIngredient(ItemID.ShadowScale, 10);
			recipe.AddIngredient(ItemID.TissueSample, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.BrokenArmor, 300);
		}	
	}
}
