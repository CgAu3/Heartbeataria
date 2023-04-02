using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace XDContentMod.Content.Items.Mounts 
{
	public class KFCDeliveryScooterKeys : ModItem 
	{
		public override void SetStaticDefaults () 
		{
			DisplayName.SetDefault("KFC Delivery Scooter Keys");
			Tooltip.SetDefault("Summons a rideable KFC Delivery Scooter mount");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId [Type] = 1;
		}


		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.value = Item.buyPrice(gold: 30);
			Item.rare = 8;
			Item.useAnimation = 15;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.noMelee = true;
			Item.mountType = ModContent.MountType<Content.Mounts.KFCDeliveryScooter>();
			Item.UseSound = SoundID.Item25;
		}
	}
}