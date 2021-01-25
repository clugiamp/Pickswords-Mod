using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class TungstenPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tungsten Picksword");
			Tooltip.SetDefault("Can slash meteorite");
		}

		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(copper: 16);

			item.autoReuse = true;
			item.useTime = 11;
			item.useAnimation = 21;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 50;
			item.damage = 12;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.TungstenBroadsword);
			recipe1.AddIngredient(ItemID.TungstenPickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}