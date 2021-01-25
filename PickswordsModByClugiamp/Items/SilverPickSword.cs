using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class SilverPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Silver Picksword");
			Tooltip.SetDefault("Can slash meteorite");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(copper: 50);

			item.autoReuse = true;
			item.useTime = 13;
			item.useAnimation = 20;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 45;
			item.damage = 11;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.SilverBroadsword);
			recipe1.AddIngredient(ItemID.SilverPickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}