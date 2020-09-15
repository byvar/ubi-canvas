using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ShadowZoneAIComponent : ActorComponent {
		public bool startOn;
		public bool pauseTween;
		public bool pauseTrajectory;
		public float pauseTime;
		public bool UseLaserDetection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startOn = s.Serialize<bool>(startOn, name: "startOn");
				pauseTween = s.Serialize<bool>(pauseTween, name: "pauseTween");
				pauseTrajectory = s.Serialize<bool>(pauseTrajectory, name: "pauseTrajectory");
				pauseTime = s.Serialize<float>(pauseTime, name: "pauseTime");
				UseLaserDetection = s.Serialize<bool>(UseLaserDetection, name: "UseLaserDetection");
			}
		}
		public override uint? ClassCRC => 0x5CC11486;
	}
}

