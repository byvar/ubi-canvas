namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CustomAnimEvt : Event {
		public StringID StringID__0;
		public StringID StringID__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
		}
		public override uint? ClassCRC => 0x7C8DAB43;
	}
}

