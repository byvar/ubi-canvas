namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventKarlHealed : Event {
		public uint uint__0;
		public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
		}
		public override uint? ClassCRC => 0x6BCFB0E8;
	}
}

