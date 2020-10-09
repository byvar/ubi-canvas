using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_GameGlobalsOnboardingFinishedCondition : online.GameGlobalsCondition {
		public bool finished;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			finished = s.Serialize<bool>(finished, name: "finished");
		}
		public override uint? ClassCRC => 0x15D3A4AB;
	}
}

