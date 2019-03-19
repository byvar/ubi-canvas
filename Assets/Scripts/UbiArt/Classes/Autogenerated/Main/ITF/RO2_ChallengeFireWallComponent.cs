using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeFireWallComponent : ActorComponent {
		[Serialize("screenPosition"          )] public Vector2 screenPosition;
		[Serialize("actorPosAtCheckpointSave")] public Vector3 actorPosAtCheckpointSave;
		[Serialize("state"                   )] public State state;
		[Serialize("useScreenPos"            )] public int useScreenPos;
		[Serialize("state"                   )] public Enum_state state;
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
		public enum Enum_state {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0xFFC40D74;
	}
}

