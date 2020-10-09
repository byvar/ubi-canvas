using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_AutoFlyingPlatformComponent : ActorComponent {
		public float baseSpeed;
		public float baseAcceleration;
		public ActiveMode activeMode;
		public bool disableOnCheckpointIfActive;
		public bool everStarted;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				baseSpeed = s.Serialize<float>(baseSpeed, name: "baseSpeed");
				baseAcceleration = s.Serialize<float>(baseAcceleration, name: "baseAcceleration");
				activeMode = s.Serialize<ActiveMode>(activeMode, name: "activeMode");
				disableOnCheckpointIfActive = s.Serialize<bool>(disableOnCheckpointIfActive, name: "disableOnCheckpointIfActive");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				everStarted = s.Serialize<bool>(everStarted, name: "everStarted");
			}
		}
		public enum ActiveMode {
			[Serialize("ActiveMode_Default"                    )] Default = 0,
			[Serialize("ActiveMode_AlwaysActiveDeactivateOnEnd")] AlwaysActiveDeactivateOnEnd = 1,
		}
		public override uint? ClassCRC => 0xEF01789A;
	}
}

