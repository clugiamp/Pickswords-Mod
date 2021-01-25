using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class TitaniumPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Titanium PickSword");
			Tooltip.SetDefault("Waste of titanium ore");
		}

		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.LightRed;
			item.value = Item.sellPrice(gold: 1, silver: 8, copper: 60);

			item.autoReuse = true;
			item.useTurn = true;
			item.useTime = 12;
			item.useAnimation = 27;
			
		    item.Size = new Vector2(40);
			item.melee = true;
			item.pick = 190;
			item.damage = 46;
			item.useStyle = 1;
			item.knockBack = 6;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.TitaniumSword);
			recipe1.AddIngredient(ItemID.TitaniumPickaxe);
            recipe1.AddTile(TileID.MythrilAnvil);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}