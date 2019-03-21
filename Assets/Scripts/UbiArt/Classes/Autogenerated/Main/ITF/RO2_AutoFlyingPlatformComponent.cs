using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AutoFlyingPlatformComponent : ActorComponent {
		[Serialize("baseSpeed"                  )] public float baseSpeed;
		[Serialize("baseAcceleration"           )] public float baseAcceleration;
		[Serialize("activeMode"                 )] public ActiveMode activeMode;
		[Serialize("disableOnCheckpointIfActive")] public bool disableOnCheckpointIfActive;
		[Serialize("everStarted"                )] public bool everStarted;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
		public enum ActiveMode {
			[Serialize("ActiveMode_Default"                    )] Default = 0,
			[Serialize("ActiveMode_AlwaysActiveDeactivateOnEnd")] AlwaysActiveDeactivateOnEnd = 1,
		}
		public override uint? ClassCRC => 0xEF01789A;
	}
}

