using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayLoop_evtTemplate : SequenceEvent_Template {
		[Serialize("DoCompleteFrameResetAfterLoop")] public bool DoCompleteFrameResetAfterLoop;
		[Serialize("JumpMode"                     )] public bool JumpMode;
		[Serialize("bool__0"                      )] public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
			} else {
				SerializeField(s, nameof(DoCompleteFrameResetAfterLoop));
				SerializeField(s, nameof(JumpMode));
			}
		}
		public override uint? ClassCRC => 0xDD4618A7;
	}
}

