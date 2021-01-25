using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class MoltenPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Molten Picksword");
			Tooltip.SetDefault("This shouldn't be here");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Orange;
			item.value = Item.sellPrice(silver: 2, copper: 70);

			item.autoReuse = true;
			item.useTime = 18;
			item.useAnimation = 26;
			
		    item.Size = new Vector2(32);
			item.melee = true;
			item.pick = 100;
			item.damage = 33;
			item.useStyle = 1;
			item.knockBack = 6.5f;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.FieryGreatsword);
			recipe1.AddIngredient(ItemID.MoltenPickaxe);
            recipe1.AddTile(TileID.Hellforge);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}