using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PickswordsModByClugiamp.Items
{
	public class BonePickSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Bone Picksword");
			Tooltip.SetDefault("Harder than iron");
		}
		public override void SetDefaults() 
		{
			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice(gold: 1);

			item.autoReuse = true;
			item.useTime = 11;
			item.useAnimation = 19;
			
		    item.Size = new Vector2(28);
			item.melee = true;
			item.pick = 55;
			item.damage = 16;
			item.useStyle = 1;
			item.knockBack = 5.5f;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.BoneSword);
			recipe1.AddIngredient(ItemID.BonePickaxe);
            recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}