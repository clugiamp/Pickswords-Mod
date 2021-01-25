using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class NightmaresBane : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Nightmare's bane");
			Tooltip.SetDefault("Able to slash Hellstone ore \nSuper edgy");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice(silver: 1, copper:80);

			item.autoReuse = true;
			item.useTime = 15;
			item.useAnimation = 20;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 65;
			item.damage = 18;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.LightsBane);
			recipe1.AddIngredient(ItemID.NightmarePickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}