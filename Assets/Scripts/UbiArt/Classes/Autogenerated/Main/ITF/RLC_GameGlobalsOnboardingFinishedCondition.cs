using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsOnboardingFinishedCondition : online.GameGlobalsCondition {
		[Serialize("finished")] public bool finished;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(finished));
		}
		public override uint? ClassCRC => 0x15D3A4AB;
	}
}

