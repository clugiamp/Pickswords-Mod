using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class ChlorophytePickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Chlorophyte Picksword");
			Tooltip.SetDefault("On right click uses melee\nWaste of Chlorophyte ore");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Lime;
			item.value = Item.sellPrice(gold: 2, silver: 7, copper: 80);
			
			item.autoReuse = true;
			item.useTime = 60;
			item.useAnimation = 26;			
			
			item.Size = new Vector2(40);
			item.melee = true;
			item.damage = 75;
			item.pick = 200;
			item.useStyle = 1;
			item.shootSpeed = 8;
			item.knockBack = 6;
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
				item.useTime = 60;
				item.shoot = 229;
				return true;
			}
			else //Sets what happens on left click
			{
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
			recipe1.AddIngredient(ItemID.ChlorophyteClaymore);
			recipe1.AddIngredient(ItemID.ChlorophytePickaxe);
            recipe1.AddTile(TileID.MythrilAnvil);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}