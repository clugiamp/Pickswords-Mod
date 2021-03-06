using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class CopperPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Copper Picksword");
			Tooltip.SetDefault("You've really made it");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(copper: 10);

			item.autoReuse = true;
			item.useTime = 15;
			item.useAnimation = 23;
			
		    item.Size = new Vector2(26);
			item.melee = true;
			item.pick = 35;
			item.damage = 8;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.CopperBroadsword);
			recipe1.AddIngredient(ItemID.CopperPickaxe);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.CopperShortsword);
			recipe2.AddIngredient(ItemID.CopperPickaxe);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}