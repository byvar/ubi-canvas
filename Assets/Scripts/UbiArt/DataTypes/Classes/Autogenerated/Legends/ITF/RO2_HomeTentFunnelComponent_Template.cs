namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeTentFunnelComponent_Template : CSerializable {
		public Placeholder enterShape;
		public Vec2d enterPoint0;
		public Vec2d enterPoint1;
		public float playerSpeedMultiplier;
		public float travelSpeed;
		public float scale;
		public float catchCooldown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enterShape = s.SerializeObject<Placeholder>(enterShape, name: "enterShape");
			enterPoint0 = s.SerializeObject<Vec2d>(enterPoint0, name: "enterPoint0");
			enterPoint1 = s.SerializeObject<Vec2d>(enterPoint1, name: "enterPoint1");
			playerSpeedMultiplier = s.Serialize<float>(playerSpeedMultiplier, name: "playerSpeedMultiplier");
			travelSpeed = s.Serialize<float>(travelSpeed, name: "travelSpeed");
			scale = s.Serialize<float>(scale, name: "scale");
			catchCooldown = s.Serialize<float>(catchCooldown, name: "catchCooldown");
		}
		public override uint? ClassCRC => 0x8616D48B;
	}
}

