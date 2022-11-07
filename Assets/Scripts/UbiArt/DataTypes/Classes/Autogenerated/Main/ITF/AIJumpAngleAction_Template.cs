namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class AIJumpAngleAction_Template : AIAction_Template {
		public float jumpForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpForce = s.Serialize<float>(jumpForce, name: "jumpForce");
		}
		public override uint? ClassCRC => 0xB8B3E40D;
	}
}

