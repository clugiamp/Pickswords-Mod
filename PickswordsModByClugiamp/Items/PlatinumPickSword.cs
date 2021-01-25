using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class PlatinumPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Platinum Picksword");
			Tooltip.SetDefault("Can slash Meteorite");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(silver: 1, copper: 50);

			item.autoReuse = true;
			item.useTime = 15;
			item.useAnimation = 19;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 59;
			item.damage = 15;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.PlatinumBroadsword);
			recipe1.AddIngredient(ItemID.PlatinumPickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}