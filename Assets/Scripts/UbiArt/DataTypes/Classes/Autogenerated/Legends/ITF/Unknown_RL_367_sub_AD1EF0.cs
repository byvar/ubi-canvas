namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_367_sub_AD1EF0 : CSerializable {
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

