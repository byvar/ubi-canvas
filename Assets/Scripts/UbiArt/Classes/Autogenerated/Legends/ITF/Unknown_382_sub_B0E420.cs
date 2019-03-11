using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_382_sub_B0E420 : CSerializable {
		[Serialize("startOn"          )] public Placeholder startOn;
		[Serialize("startOn"          )] public bool startOn;
		[Serialize("pauseTween"       )] public Placeholder pauseTween;
		[Serialize("pauseTween"       )] public bool pauseTween;
		[Serialize("pauseTrajectory"  )] public Placeholder pauseTrajectory;
		[Serialize("pauseTrajectory"  )] public bool pauseTrajectory;
		[Serialize("pauseTime"        )] public float pauseTime;
		[Serialize("UseLaserDetection")] public bool UseLaserDetection;
		[Serialize("UseLaserDetection")] public Placeholder UseLaserDetection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOn));
				SerializeField(s, nameof(startOn));
				SerializeField(s, nameof(pauseTween));
				SerializeField(s, nameof(pauseTween));
				SerializeField(s, nameof(pauseTrajectory));
				SerializeField(s, nameof(pauseTrajectory));
				SerializeField(s, nameof(pauseTime));
				SerializeField(s, nameof(UseLaserDetection));
			}
			SerializeField(s, nameof(UseLaserDetection));
		}
		public override uint? ClassCRC => 0xFF8630D5;
	}
}

