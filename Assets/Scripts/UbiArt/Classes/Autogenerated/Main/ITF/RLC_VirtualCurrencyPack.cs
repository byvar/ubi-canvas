using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_VirtualCurrencyPack : RLC_DynamicStoreItem {
		[Serialize("Price"         )] public float Price;
		[Serialize("Amount"        )] public uint Amount;
		[Serialize("formattedPrice")] public string formattedPrice;
		[Serialize("locId"         )] public uint locId_;
		[Serialize("icon"          )] public uint icon;
		[Serialize("stickerNew"    )] public bool stickerNew;
		[Serialize("stickerPopular")] public bool stickerPopular;
		[Serialize("reduction"     )] public float reduction;
		[Serialize("exclamation"   )] public bool exclamation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(Amount));
			SerializeField(s, nameof(formattedPrice));
			SerializeField(s, nameof(locId_));
			SerializeField(s, nameof(icon));
			SerializeField(s, nameof(stickerNew));
			SerializeField(s, nameof(stickerPopular));
			SerializeField(s, nameof(reduction));
			SerializeField(s, nameof(exclamation));
		}
		public override uint? ClassCRC => 0x727065A8;
	}
}

