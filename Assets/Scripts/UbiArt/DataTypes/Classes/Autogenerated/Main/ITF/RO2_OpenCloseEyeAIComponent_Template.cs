using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_OpenCloseEyeAIComponent_Template : ActorComponent_Template {
		public float closedTimer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			closedTimer = s.Serialize<float>(closedTimer, name: "closedTimer");
		}
		public override uint? ClassCRC => 0x1DD64089;
	}
}

