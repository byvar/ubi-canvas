using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class PlayAnimOnEventReceiveComponent : ActorComponent {
		[Serialize("disabledAfterEvent"        )] public bool disabledAfterEvent;
		[Serialize("playingEventCheckpointSave")] public bool playingEventCheckpointSave;
		[Serialize("disabledAfterEvent"        )] public int disabledAfterEvent;
		[Serialize("playingEventCheckpointSave")] public int playingEventCheckpointSave;
		[Serialize("eventIdlePlayed"           )] public int eventIdlePlayed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(disabledAfterEvent));
					SerializeField(s, nameof(playingEventCheckpointSave));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(disabledAfterEvent));
					SerializeField(s, nameof(playingEventCheckpointSave));
					SerializeField(s, nameof(eventIdlePlayed));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(disabledAfterEvent));
					SerializeField(s, nameof(playingEventCheckpointSave));
				}
			}
		}
		public override uint? ClassCRC => 0xAA6D656B;
	}
}

