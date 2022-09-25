using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_MusicScoreAIBranchComponent : RO2_BezierBranchComponent {
		public bool startOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					startOpen = s.Serialize<bool>(startOpen, name: "startOpen", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					startOpen = s.Serialize<bool>(startOpen, name: "startOpen");
				}
			}
		}
		public override uint? ClassCRC => 0xDB2FA652;
	}
}

