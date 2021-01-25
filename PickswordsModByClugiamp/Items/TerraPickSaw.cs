using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class TerraPickSaw : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Terra Picksaw");
			Tooltip.SetDefault("On right click uses melee\nThey've forced me to do this \nCapable of slashing Lizahrd bricks");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Yellow;
			item.value = Item.sellPrice(gold: 22, silver: 7, copper: 80);
			
			item.autoReuse = true;
			item.useTime = 16;
			item.useAnimation = 16;			
			
			item.Size = new Vector2(30);
			item.melee = true;
			item.damage = 95;
			item.pick = 210;
			item.axe = 25;
			item.tileBoost = 1;
			item.useStyle = 1;
			item.shootSpeed = 12;
			item.knockBack = 6.5f;
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
				item.useTime = 32;
				item.shoot = 132;
				return true;
			}
			else //Sets what happens on left click
			{
				item.useAnimation = 16;	
				item.useTime = 6;
				item.shoot = 0;
				player.AddBuff(mod.BuffType("CPSRightClick"), 90);//Debuff the attack damage to balance the item
				int buff = mod.BuffType("CPSRightClick");
				return player.HasBuff(buff);
			}
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.TerraBlade);
			recipe1.AddIngredient(ItemID.Picksaw);
            recipe1.AddTile(TileID.LihzahrdFurnace);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}