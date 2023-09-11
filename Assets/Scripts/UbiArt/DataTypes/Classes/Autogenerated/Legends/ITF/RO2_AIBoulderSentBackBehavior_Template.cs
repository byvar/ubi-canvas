namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIBoulderSentBackBehavior_Template : TemplateAIBehavior {
		public float gravity;
		public float friction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gravity = s.Serialize<float>(gravity, name: "gravity");
			friction = s.Serialize<float>(friction, name: "friction");
		}
		public override uint? ClassCRC => 0xC3DCD81B;
	}
}

