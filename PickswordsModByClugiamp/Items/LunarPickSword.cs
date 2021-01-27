using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class LunarPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lunar Picksword");
			Tooltip.SetDefault("Can slash Moonlord");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Red;
			item.value = Item.sellPrice(platinum: 1);

			item.autoReuse = true;
			item.useTime = 6;
			item.useAnimation = 12;
			
		    item.Size = new Vector2(50);
			item.melee = true;
			item.pick = 225;
			item.damage = 200;
			item.useStyle = 1;
			item.tileBoost = 4;
			item.knockBack = 5.5f;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.StardustPickaxe);
			recipe1.AddIngredient(ItemID.VortexPickaxe);
			recipe1.AddIngredient(ItemID.NebulaPickaxe);
			recipe1.AddIngredient(ItemID.SolarFlarePickaxe);
            recipe1.AddTile(TileID.LunarCraftingStation);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}