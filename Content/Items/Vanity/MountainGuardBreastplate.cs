using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace XDContentMod.Content.Items.Vanity
{
	[AutoloadEquip(EquipType.Body)]

	public class MountainGuardBreastplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mountain Guard Breastplate");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() 
		{
			int width = 30; int height = 18;
			Item.Size = new Vector2(width, height);

			Item.rare = ItemRarityID.LightRed;
			Item.value = Item.buyPrice(gold: 20);
			Item.vanity = true;
		}
	}
}