namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIJumpAction_Template : AIAction_Template {
		public float jumpForce;
		public float minXSpeed;
		public float maxXSpeed;
		public float minXForce;
		public float maxXForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpForce = s.Serialize<float>(jumpForce, name: "jumpForce");
			minXSpeed = s.Serialize<float>(minXSpeed, name: "minXSpeed");
			maxXSpeed = s.Serialize<float>(maxXSpeed, name: "maxXSpeed");
			minXForce = s.Serialize<float>(minXForce, name: "minXForce");
			maxXForce = s.Serialize<float>(maxXForce, name: "maxXForce");
		}
		public override uint? ClassCRC => 0x4072E059;
	}
}

