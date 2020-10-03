using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_VirtualCurrencyPack : RLC_DynamicStoreItem {
		public float Price;
		public uint Amount;
		public string formattedPrice;
		public uint locId_;
		public uint icon;
		public bool stickerNew;
		public bool stickerPopular;
		public float reduction;
		public bool exclamation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Price = s.Serialize<float>(Price, name: "Price");
			Amount = s.Serialize<uint>(Amount, name: "Amount");
			formattedPrice = s.Serialize<string>(formattedPrice, name: "formattedPrice");
			locId_ = s.Serialize<uint>(locId_, name: "locId");
			icon = s.Serialize<uint>(icon, name: "icon");
			stickerNew = s.Serialize<bool>(stickerNew, name: "stickerNew");
			stickerPopular = s.Serialize<bool>(stickerPopular, name: "stickerPopular");
			reduction = s.Serialize<float>(reduction, name: "reduction");
			exclamation = s.Serialize<bool>(exclamation, name: "exclamation");
		}
		public override uint? ClassCRC => 0x727065A8;
	}
}

