using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayLoop_evtTemplate : SequenceEvent_Template {
		[Serialize("DoCompleteFrameResetAfterLoop")] public bool DoCompleteFrameResetAfterLoop;
		[Serialize("JumpMode"                     )] public bool JumpMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(DoCompleteFrameResetAfterLoop));
				SerializeField(s, nameof(JumpMode));
			}
		}
		public override uint? ClassCRC => 0xDD4618A7;
	}
}

