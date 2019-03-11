using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_BeatboxSaveSlotPack : RLC_DynamicStoreItem {
		[Serialize("Price" )] public uint Price;
		[Serialize("Amount")] public uint Amount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(Amount));
		}
		public override uint? ClassCRC => 0x46A6D042;
	}
}

