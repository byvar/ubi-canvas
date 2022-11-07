namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class ZAction : CSerializable {
		public StringID name;
		public bool inverted;
		public float scale;
		public CListO<ZInput> input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			inverted = s.Serialize<bool>(inverted, name: "inverted");
			scale = s.Serialize<float>(scale, name: "scale");
			input = s.SerializeObject<CListO<ZInput>>(input, name: "input");
		}
	}
}

