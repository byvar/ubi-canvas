using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_LuckyTicketPack : RLC_DynamicStoreItem {
		[Serialize("Price"           )] public uint Price;
		[Serialize("Amount"          )] public uint Amount;
		[Serialize("GoldenTicketPack")] public bool GoldenTicketPack;
		[Serialize("msdkItemId"      )] public uint msdkItemId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(Amount));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(GoldenTicketPack));
			}
			SerializeField(s, nameof(msdkItemId));
		}
		public override uint? ClassCRC => 0xACECEBCA;
	}
}

