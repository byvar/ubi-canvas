namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShadowZoneAIComponent : ActorComponent {
		public bool startOn;
		public bool pauseTween;
		public bool pauseTrajectory;
		public float pauseTime;
		public bool UseLaserDetection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startOn = s.Serialize<bool>(startOn, name: "startOn", options: CSerializerObject.Options.BoolAsByte);
				pauseTween = s.Serialize<bool>(pauseTween, name: "pauseTween", options: CSerializerObject.Options.BoolAsByte);
				pauseTrajectory = s.Serialize<bool>(pauseTrajectory, name: "pauseTrajectory", options: CSerializerObject.Options.BoolAsByte);
				pauseTime = s.Serialize<float>(pauseTime, name: "pauseTime");
				UseLaserDetection = s.Serialize<bool>(UseLaserDetection, name: "UseLaserDetection", options: CSerializerObject.Options.BoolAsByte);
			}
		}
		public override uint? ClassCRC => 0xFF8630D5;
	}
}

