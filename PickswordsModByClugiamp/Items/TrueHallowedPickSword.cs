using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class TrueHallowedPickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True hallowed pick axe and sword");
			Tooltip.SetDefault("On right click uses melee\nDeus Vult!");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Yellow;
			item.value = Item.sellPrice(gold: 72);
			
			item.autoReuse = true;
			item.useTime = 16;
			item.useAnimation = 16;			
			
			item.Size = new Vector2(40);
			item.melee = true;
			item.damage = 66;
			item.pick = 200;
			item.axe = 22;
			item.useStyle = 1;
			item.shootSpeed = 11;
			item.knockBack = 4.5f;
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
				item.useAnimation = 16;	
				item.useTime = 22;
				item.shoot = 156;
				return true;
			}
			else //Sets what happens on left click
			{
				item.useAnimation = 25;	
				item.useTime = 7;
				item.shoot = 0;
				player.AddBuff(mod.BuffType("CPSRightClick"), 90);//Debuff the attack damage to balance the item
				int buff = mod.BuffType("CPSRightClick");
				return player.HasBuff(buff);
			}
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.TrueExcalibur);
			recipe1.AddIngredient(ItemID.PickaxeAxe);
            recipe1.AddTile(TileID.AdamantiteForge);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(this);
            recipe2.AddTile(TileID.AdamantiteForge);
			recipe2.SetResult(ItemID.TrueExcalibur);
			recipe2.AddRecipe();
		}
	}
}