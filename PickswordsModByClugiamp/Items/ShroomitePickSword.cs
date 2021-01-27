using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class ShroomitePickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The longer Shroomite digging claw");
			Tooltip.SetDefault("Not a picksword but.. whatever");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Yellow;
			item.value = Item.sellPrice(platinum: 1);

			item.autoReuse = true;
			item.useTime = 4;
			item.useAnimation = 12;
			
		    item.Size = new Vector2(25);
			item.melee = true;
			item.pick = 200;
			item.damage = 60;
			item.useStyle = 1;
			item.knockBack = 6;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.ShroomiteBar, 25);
			recipe1.AddTile(TileID.MythrilAnvil);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}