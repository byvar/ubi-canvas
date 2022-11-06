using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlayLoop_evtTemplate : SequenceEvent_Template {
		public bool DoCompleteFrameResetAfterLoop;
		public bool JumpMode;
		public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.engineVersion == Settings.EngineVersion.RO || s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
			} else if (s.Settings.game == Settings.Game.VH) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			} else {
				DoCompleteFrameResetAfterLoop = s.Serialize<bool>(DoCompleteFrameResetAfterLoop, name: "DoCompleteFrameResetAfterLoop");
				JumpMode = s.Serialize<bool>(JumpMode, name: "JumpMode");
			}
		}
		public override uint? ClassCRC => 0xDD4618A7;
	}
}

