using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SnakeNetworkFollowerComponent : ActorComponent {
		[Serialize("baseSpeed"                  )] public float baseSpeed;
		[Serialize("baseAcceleration"           )] public float baseAcceleration;
		[Serialize("activeMode"                 )] public ActiveMode activeMode;
		[Serialize("disableOnCheckpointIfActive")] public bool disableOnCheckpointIfActive;
		[Serialize("everStarted"                )] public bool everStarted;
		[Serialize("activeMode"                 )] public Enum_activeMode activeMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(baseSpeed));
					SerializeField(s, nameof(baseAcceleration));
					SerializeField(s, nameof(activeMode));
					SerializeField(s, nameof(disableOnCheckpointIfActive));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(everStarted));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(baseSpeed));
					SerializeField(s, nameof(baseAcceleration));
					SerializeField(s, nameof(activeMode));
					SerializeField(s, nameof(disableOnCheckpointIfActive));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(everStarted));
				}
			}
		}
		public enum ActiveMode {
			[Serialize("ActiveMode_Default"                    )] Default = 0,
			[Serialize("ActiveMode_AlwaysActiveDeactivateOnEnd")] AlwaysActiveDeactivateOnEnd = 1,
		}
		public enum Enum_activeMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xF1967384;
	}
}

