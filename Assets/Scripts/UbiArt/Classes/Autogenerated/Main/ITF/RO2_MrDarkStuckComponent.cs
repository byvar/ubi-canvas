using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MrDarkStuckComponent : ActorComponent {
		[Serialize("disabledAfterEvent"        )] public bool disabledAfterEvent;
		[Serialize("playingEventCheckpointSave")] public bool playingEventCheckpointSave;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(disabledAfterEvent));
				SerializeField(s, nameof(playingEventCheckpointSave));
			}
		}
		public override uint? ClassCRC => 0x428CD65D;
	}
}

