using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_TimeSavingPack : RLC_DynamicStoreItem {
		[Serialize("offerIndex"        )] public uint offerIndex;
		[Serialize("timeSavingDuration")] public online.TimeInterval timeSavingDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(offerIndex));
			SerializeField(s, nameof(timeSavingDuration));
		}
		public override uint? ClassCRC => 0x2A9A352A;
	}
}

