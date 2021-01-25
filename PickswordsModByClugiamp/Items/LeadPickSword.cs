using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class LeadPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lead Picksword");
			Tooltip.SetDefault("Worse than tungsten");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(copper: 16);

			item.autoReuse = true;
			item.useTime = 13;
			item.useAnimation = 20;
			
		    item.Size = new Vector2(26);
			item.melee = true;
			item.pick = 43;
			item.damage = 10;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.LeadBroadsword);
			recipe1.AddIngredient(ItemID.LeadPickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}