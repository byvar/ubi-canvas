using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class PlayAnimOnEventReceiveComponent : ActorComponent {
		public bool disabledAfterEvent;
		public bool playingEventCheckpointSave;
		public int eventIdlePlayed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					disabledAfterEvent = s.Serialize<bool>(disabledAfterEvent, name: "disabledAfterEvent");
					playingEventCheckpointSave = s.Serialize<bool>(playingEventCheckpointSave, name: "playingEventCheckpointSave");
					eventIdlePlayed = s.Serialize<int>(eventIdlePlayed, name: "eventIdlePlayed");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					disabledAfterEvent = s.Serialize<bool>(disabledAfterEvent, name: "disabledAfterEvent");
					playingEventCheckpointSave = s.Serialize<bool>(playingEventCheckpointSave, name: "playingEventCheckpointSave");
				}
			}
		}
		public override uint? ClassCRC => 0xAA6D656B;
	}
}

