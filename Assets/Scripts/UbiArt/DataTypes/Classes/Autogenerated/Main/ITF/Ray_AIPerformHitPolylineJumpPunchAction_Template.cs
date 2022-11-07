namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIPerformHitPolylineJumpPunchAction_Template : Ray_AIPerformHitPolylinePunchAction_Template {
		public float jumpForce;
		public float jumpXForce;
		public float antiGravTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpForce = s.Serialize<float>(jumpForce, name: "jumpForce");
			jumpXForce = s.Serialize<float>(jumpXForce, name: "jumpXForce");
			antiGravTime = s.Serialize<float>(antiGravTime, name: "antiGravTime");
		}
		public override uint? ClassCRC => 0x4C4C0B6D;
	}
}

