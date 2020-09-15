using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class SequenceLauncherComponent_Template : ActorComponent_Template {
		public EventSequenceControl eventPlaySequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				eventPlaySequence = s.SerializeObject<EventSequenceControl>(eventPlaySequence, name: "eventPlaySequence");
			}
		}
		public override uint? ClassCRC => 0x4CB88B86;
	}
}

