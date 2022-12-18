namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class ControlDecibelVolume : CSerializable {
		public Placeholder input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<Placeholder>(input, name: "input");
		}
		public override uint? ClassCRC => 0x2DEC8742;
	}
}

