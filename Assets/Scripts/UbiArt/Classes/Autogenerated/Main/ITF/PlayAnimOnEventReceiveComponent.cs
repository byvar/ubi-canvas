using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayAnimOnEventReceiveComponent : ActorComponent {
		[Serialize("disabledAfterEvent"        )] public bool disabledAfterEvent;
		[Serialize("playingEventCheckpointSave")] public bool playingEventCheckpointSave;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(disabledAfterEvent));
					SerializeField(s, nameof(playingEventCheckpointSave));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(disabledAfterEvent));
					SerializeField(s, nameof(playingEventCheckpointSave));
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

