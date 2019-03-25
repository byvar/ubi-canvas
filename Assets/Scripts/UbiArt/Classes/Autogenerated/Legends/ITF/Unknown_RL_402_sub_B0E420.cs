using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_402_sub_B0E420 : ActorComponent {
		[Serialize("startOn"          )] public bool startOn;
		[Serialize("pauseTween"       )] public bool pauseTween;
		[Serialize("pauseTrajectory"  )] public bool pauseTrajectory;
		[Serialize("pauseTime"        )] public float pauseTime;
		[Serialize("UseLaserDetection")] public bool UseLaserDetection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOn), boolAsByte: true);
				SerializeField(s, nameof(pauseTween), boolAsByte: true);
				SerializeField(s, nameof(pauseTrajectory), boolAsByte: true);
				SerializeField(s, nameof(pauseTime));
				SerializeField(s, nameof(UseLaserDetection), boolAsByte: true);
			}
		}
		public override uint? ClassCRC => 0xFF8630D5;
	}
}

