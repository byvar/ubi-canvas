namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventActorRea_Wait : Event {
		public bool bool__0;
		public StringID StringID__1;
		public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
		}
		public override uint? ClassCRC => 0x9367F119;
	}
}

