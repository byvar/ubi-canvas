using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_EventSpawnRewardLum : RO2_EventSpawnReward {
		public bool isRed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isRed = s.Serialize<bool>(isRed, name: "isRed");
		}
		public override uint? ClassCRC => 0x3179CCFC;
	}
}

