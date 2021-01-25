using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class CactusPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cactus Picksword");
			Tooltip.SetDefault("Spiky");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(copper: 2);

			item.autoReuse = true;
			item.useTime = 15;
			item.useAnimation = 23;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 35;
			item.damage = 9;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.CactusSword);
			recipe1.AddIngredient(ItemID.CactusPickaxe);
            recipe1.AddTile(TileID.WorkBenches);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}