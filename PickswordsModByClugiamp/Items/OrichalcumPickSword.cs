using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class  OrichalcumPickSword : ModItem
    {
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Orichalcum Picksword");
			Tooltip.SetDefault("Right click for melee \nUltimate Pink Spinning Power \nCan slash Adamantite and Titanium");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.LightRed;
			item.value = Item.sellPrice(gold: 1, silver: 3, copper: 5);

			item.autoReuse = true;
			item.useTime = 26;
			item.useAnimation = 26;
			
		    item.Size = new Vector2(40);
			item.melee = true;
			item.damage = 47;
			item.useStyle = 1;
			item.shootSpeed = 5;
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
				item.noMelee = true;
            	item.noUseGraphic = true;
            	item.channel = true;
				item.shoot = ModContent.ProjectileType<Projectiles.SpinningWeaponProjectileOri>();
				return player.ownedProjectileCounts[item.shoot] < 1;
			}
			else //Sets what happens on left click
			{
				item.pick = 165;
				item.useAnimation = 26;	
				item.useTime = 8;
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
			recipe1.AddIngredient(ItemID.OrichalcumSword);
			recipe1.AddIngredient(ItemID.OrichalcumPickaxe);
            recipe1.AddTile(TileID.MythrilAnvil);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
    }
}