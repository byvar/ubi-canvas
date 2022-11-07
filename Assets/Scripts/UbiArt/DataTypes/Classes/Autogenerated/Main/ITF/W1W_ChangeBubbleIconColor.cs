namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ChangeBubbleIconColor : Event {
		public Color Color__0;
		public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Color__0 = s.SerializeObject<Color>(Color__0, name: "Color__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
		}
		public override uint? ClassCRC => 0x9CA8940B;
	}
}

