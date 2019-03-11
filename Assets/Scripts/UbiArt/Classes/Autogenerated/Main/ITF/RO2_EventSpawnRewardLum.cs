using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventSpawnRewardLum : RO2_EventSpawnReward {
		[Serialize("isRed")] public bool isRed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isRed));
		}
		public override uint? ClassCRC => 0x3179CCFC;
	}
}

