using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class EnchantedPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Enchanted Picksword");
			Tooltip.SetDefault("On right click uses melee\nHe hates orange things \nCan slash Palladium ore");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Orange;
			item.value = Item.sellPrice(gold: 5, silver: 7, copper: 80);
			
			item.autoReuse = true;
			item.useTime = 45;
			item.useAnimation = 18;			
			
			item.Size = new Vector2(30);
			item.melee = true;
			item.damage = 40;
			item.pick = 100;
			item.useStyle = 1;
			item.shootSpeed = 9.5f;
			item.knockBack = 5.25f;
			item.UseSound = SoundID.Item1;
		}
		public override bool AltFunctionUse(Player player)//Allows the item to be right clicked
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)//Sets what happens on right click
			{
				item.useAnimation = 18;	
				item.useTime = 45;
				item.shoot = 173;
				return true;
			}
			else //Sets what happens on left click
			{
				item.useAnimation = 23;	
				item.useTime = 18;
				item.shoot = 0;
				player.AddBuff(mod.BuffType("CPSRightClick"), 90);//Debuff the attack damage to balance the item
				int buff = mod.BuffType("CPSRightClick");
				return player.HasBuff(buff);
			}
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.EnchantedSword);
			recipe1.AddIngredient(ItemID.MoltenPickaxe);
            recipe1.AddTile(TileID.Hellforge);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(this);
            recipe2.AddTile(TileID.Hellforge);
			recipe2.SetResult(ItemID.EnchantedSword);
			recipe2.AddRecipe();
		}
	}
}