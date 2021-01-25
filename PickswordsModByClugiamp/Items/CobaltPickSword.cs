using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class  CobaltPickSword : ModItem
    {
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cobalt Picksword");
			Tooltip.SetDefault("Right click for melee \nWhat did you expect? \nCan slash Mythril and Orichalcum");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.LightRed;
			item.value = Item.sellPrice(gold: 1);

			item.autoReuse = true;
			item.useTime = 23;
			item.useAnimation = 23;
			
		    item.Size = new Vector2(40);
			item.melee = true;
			item.damage = 39;
			item.useStyle = 1;
			item.shootSpeed = 5;
			item.knockBack = 4;
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
				item.noMelee = true;
            	item.noUseGraphic = true;
            	item.channel = true;
				item.shoot = ModContent.ProjectileType<Projectiles.SpinningWeaponProjectileCob>();
				return player.ownedProjectileCounts[item.shoot] < 1;
			}
			else //Sets what happens on left click
			{
				item.pick = 110;
				item.useAnimation = 25;	
				item.useTime = 13;
				item.noMelee = false;
            	item.noUseGraphic = false;
            	item.channel = false;
				item.shoot = 0;
				player.AddBuff(mod.BuffType("CPSRightClick"), 90);//Debuff the attack damage to balance the item
				int buff = mod.BuffType("CPSRightClick");
				return player.HasBuff(buff);
			}
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.CobaltSword);
			recipe1.AddIngredient(ItemID.CobaltPickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
    }
}