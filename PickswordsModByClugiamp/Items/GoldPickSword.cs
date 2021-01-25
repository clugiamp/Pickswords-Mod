using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class GoldPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Gold Picksword");
			Tooltip.SetDefault("Can slash meteorite");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(silver: 1);

			item.autoReuse = true;
			item.useTime = 17;
			item.useAnimation = 20;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 55;
			item.damage = 13;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.GoldBroadsword);
			recipe1.AddIngredient(ItemID.GoldPickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}