using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventTickleRewarded : Event {
		[Serialize("rewardValue")] public uint rewardValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rewardValue));
		}
		public override uint? ClassCRC => 0x9D2D508D;
	}
}

