using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class ClubberShark : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Clubber Shark");
			Tooltip.SetDefault("You are a good tailor, but a horrible person");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Orange;
			item.value = Item.sellPrice(gold: 2);

			item.autoReuse = true;
			item.useTime = 18;
			item.useAnimation = 22;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 100;
			item.damage = 24;
			item.useStyle = 1;
			item.knockBack = 7;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.ReaverShark);
			recipe1.AddIngredient(ItemID.PurpleClubberfish);
            recipe1.AddTile(TileID.Loom);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}