using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeFireWallComponent : ActorComponent {
		[Serialize("screenPosition"          )] public Vector2 screenPosition;
		[Serialize("actorPosAtCheckpointSave")] public Vector3 actorPosAtCheckpointSave;
		[Serialize("state"                   )] public State state;
		[Serialize("useScreenPos"            )] public bool useScreenPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(screenPosition));
				SerializeField(s, nameof(actorPosAtCheckpointSave));
				SerializeField(s, nameof(useScreenPos));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(state));
				}
			} else {
				SerializeField(s, nameof(screenPosition));
				SerializeField(s, nameof(actorPosAtCheckpointSave));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(state));
				}
			}
		}
		public enum State {
			[Serialize("StateUnknown" )] Unknown = 0,
			[Serialize("StateDisabled")] Disabled = 1,
			[Serialize("StateFadeIn"  )] FadeIn = 2,
			[Serialize("StateEnabled" )] Enabled = 3,
			[Serialize("StateFadeOut" )] FadeOut = 4,
		}
		public override uint? ClassCRC => 0xFFC40D74;
	}
}

