using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class PlayAnimOnEventReceiveComponent : ActorComponent {
		[Serialize("disabledAfterEvent"        )] public bool disabledAfterEvent;
		[Serialize("playingEventCheckpointSave")] public bool playingEventCheckpointSave;
		[Serialize("eventIdlePlayed"           )] public int eventIdlePlayed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
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

