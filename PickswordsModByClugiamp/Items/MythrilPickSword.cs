using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class MythrilPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mythril PickSword");
			Tooltip.SetDefault("Can slash Adamantite and Titanium");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.LightRed;
			item.value = Item.sellPrice(gold: 1, silver: 3, copper: 5);

			item.autoReuse = true;
			item.useTurn = true;
			item.useTime = 10;
			item.useAnimation = 26;
			
		    item.Size = new Vector2(40);
			item.melee = true;
			item.pick = 150;
			item.damage = 37;
			item.useStyle = 1;
			item.knockBack = 6;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.MythrilSword);
			recipe1.AddIngredient(ItemID.MythrilPickaxe);
            recipe1.AddTile(TileID.MythrilAnvil);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}