using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScoreRecapRewardComponent : ActorComponent {
		public float waitTimeBeforeDisplay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitTimeBeforeDisplay = s.Serialize<float>(waitTimeBeforeDisplay, name: "waitTimeBeforeDisplay");
		}
		public override uint? ClassCRC => 0x0B7958BE;
	}
}

