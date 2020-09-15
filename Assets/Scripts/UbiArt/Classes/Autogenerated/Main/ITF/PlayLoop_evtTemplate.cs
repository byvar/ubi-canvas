using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayLoop_evtTemplate : SequenceEvent_Template {
		public bool DoCompleteFrameResetAfterLoop;
		public bool JumpMode;
		public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion == Settings.EngineVersion.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else if (Settings.s.game == Settings.Game.VH) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			} else {
				DoCompleteFrameResetAfterLoop = s.Serialize<bool>(DoCompleteFrameResetAfterLoop, name: "DoCompleteFrameResetAfterLoop");
				JumpMode = s.Serialize<bool>(JumpMode, name: "JumpMode");
			}
		}
		public override uint? ClassCRC => 0xDD4618A7;
	}
}

