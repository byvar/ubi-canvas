namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventBDDisplayInputIcons : Event {
		public bool bool__0;
		public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
		}
		public override uint? ClassCRC => 0x7F15D99D;
	}
}

