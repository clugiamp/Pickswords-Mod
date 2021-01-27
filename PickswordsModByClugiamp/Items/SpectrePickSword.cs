using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class SpectrePickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Spectre Picksword");
			Tooltip.SetDefault("Spooky, no wait...");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Yellow;
			item.value = Item.sellPrice(gold: 4);

			item.autoReuse = true;
			item.useTime = 10;
			item.useAnimation = 24;
			
		    item.Size = new Vector2(30);
			item.melee = true;
			item.pick = 200;
			item.damage = 60;
			item.useStyle = 1;
			item.tileBoost = 3;
			item.knockBack = 5.5f;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.SpectreBar, 25);
            recipe1.AddTile(TileID.MythrilAnvil);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}