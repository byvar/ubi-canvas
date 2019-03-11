using UnityEngine;

namespace UbiArt.ITF {
	public partial class ShadowZoneAIComponent : ActorComponent {
		[Serialize("startOn"          )] public bool startOn;
		[Serialize("pauseTween"       )] public bool pauseTween;
		[Serialize("pauseTrajectory"  )] public bool pauseTrajectory;
		[Serialize("pauseTime"        )] public float pauseTime;
		[Serialize("UseLaserDetection")] public bool UseLaserDetection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOn));
				SerializeField(s, nameof(pauseTween));
				SerializeField(s, nameof(pauseTrajectory));
				SerializeField(s, nameof(pauseTime));
				SerializeField(s, nameof(UseLaserDetection));
			}
		}
		public override uint? ClassCRC => 0x5CC11486;
	}
}

