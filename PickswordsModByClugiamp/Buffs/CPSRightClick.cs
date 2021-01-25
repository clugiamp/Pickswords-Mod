using Terraria;
using Terraria.ModLoader;

namespace PickswordsModByClugiamp.Buffs
{
	public class CPSRightClick : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Special ability");
			Description.SetDefault("This buff serves to make the sword function properly");		
		}
        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += -0.5f;
        }
	}
}