namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_423_sub_B47350 : CSerializable {
		public float Speed;
		public float Gravity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Speed = s.Serialize<float>(Speed, name: "Speed");
			Gravity = s.Serialize<float>(Gravity, name: "Gravity");
		}
		public override uint? ClassCRC => 0xE535E8BD;
	}
}

