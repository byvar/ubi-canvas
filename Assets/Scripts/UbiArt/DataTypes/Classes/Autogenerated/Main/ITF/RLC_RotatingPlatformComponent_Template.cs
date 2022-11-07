namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_RotatingPlatformComponent_Template : ActorComponent_Template {
		public float rotationSpeed;
		public float shakingAmplitude;
		public float feedbackStuckAmplitude;
		public float centerDeadZoneHalfWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
			shakingAmplitude = s.Serialize<float>(shakingAmplitude, name: "shakingAmplitude");
			feedbackStuckAmplitude = s.Serialize<float>(feedbackStuckAmplitude, name: "feedbackStuckAmplitude");
			centerDeadZoneHalfWidth = s.Serialize<float>(centerDeadZoneHalfWidth, name: "centerDeadZoneHalfWidth");
		}
		public override uint? ClassCRC => 0x0A45FA22;
	}
}

