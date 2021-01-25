using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class DeathbringersButcherer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Deathbringer's butcherer");
			Tooltip.SetDefault("Able to slash Hellstone ore \nKinda edgy");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice(silver: 1, copper: 80);

			item.autoReuse = true;
			item.useTime = 14;
			item.useAnimation = 22;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 70;
			item.damage = 17;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.BloodButcherer);
			recipe1.AddIngredient(ItemID.DeathbringerPickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}