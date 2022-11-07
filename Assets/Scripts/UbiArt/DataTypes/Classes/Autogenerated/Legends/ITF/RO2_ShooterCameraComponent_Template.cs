namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterCameraComponent_Template : BaseCameraComponent_Template {
		public Vec2d defaultSpeed;
		public float defaultZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultSpeed = s.SerializeObject<Vec2d>(defaultSpeed, name: "defaultSpeed");
			defaultZOffset = s.Serialize<float>(defaultZOffset, name: "defaultZOffset");
		}
		public override uint? ClassCRC => 0x5ACC2440;
	}
}

