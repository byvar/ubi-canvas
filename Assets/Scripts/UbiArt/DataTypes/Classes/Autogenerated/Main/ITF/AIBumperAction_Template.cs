namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIBumperAction_Template : AIAction_Template {
		public float jumpForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpForce = s.Serialize<float>(jumpForce, name: "jumpForce");
		}
		public override uint? ClassCRC => 0x3DA0F136;
	}
}

