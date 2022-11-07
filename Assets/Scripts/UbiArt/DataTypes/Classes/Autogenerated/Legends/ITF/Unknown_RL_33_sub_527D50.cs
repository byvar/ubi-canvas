namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class Unknown_RL_33_sub_527D50 : CSerializable {
		public Placeholder input;
		public float frequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<Placeholder>(input, name: "input");
			frequency = s.Serialize<float>(frequency, name: "frequency");
		}
		public override uint? ClassCRC => 0xE5DD8D51;
	}
}

