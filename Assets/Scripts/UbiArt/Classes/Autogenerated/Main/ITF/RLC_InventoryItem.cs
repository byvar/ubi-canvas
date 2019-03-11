using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_InventoryItem : CSerializable {
		[Serialize("itemId")] public uint itemId;
		[Serialize("amount")] public uint amount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(itemId));
			SerializeField(s, nameof(amount));
		}
		public override uint? ClassCRC => 0x24E8388C;
	}
}

