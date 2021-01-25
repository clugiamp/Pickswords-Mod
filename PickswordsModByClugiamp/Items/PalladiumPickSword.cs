using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class  PalladiumPickSword : ModItem
    {
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Palladium Picksword");
			Tooltip.SetDefault("Right click for melee \nHates blue things \nCan slash Mythril and Orichalcum");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.LightRed;
			item.value = Item.sellPrice(gold: 1);

			item.autoReuse = true;
			item.useTime = 25;
			item.useAnimation = 25;
			
		    item.Size = new Vector2(40);
			item.melee = true;
			item.damage = 41;
			item.useStyle = 1;
			item.shootSpeed = 5;
			item.knockBack = 4.75f;
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
				item.shoot = ModContent.ProjectileType<Projectiles.SpinningWeaponProjectilePal>();
				return player.ownedProjectileCounts[item.shoot] < 1;
			}
			else //Sets what happens on left click
			{
				item.pick = 130;	
				item.useTime = 11;
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
			recipe1.AddIngredient(ItemID.PalladiumSword);
			recipe1.AddIngredient(ItemID.PalladiumPickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
    }
}