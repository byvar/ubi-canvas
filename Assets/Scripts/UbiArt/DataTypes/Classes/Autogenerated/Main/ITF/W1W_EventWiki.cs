namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventWiki : Event {
		public bool bool__0;
		public uint uint__1;
		public uint uint__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
		}
		public override uint? ClassCRC => 0xF8CB5796;
	}
}

