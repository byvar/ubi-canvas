namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Letter : W1W_InteractiveGenComponent {
		public bool bool__0;
		public StringID StringID__1_;
		public uint uint__2;
		public uint uint__3;
		public uint uint__4;
		public bool bool__5;
		public float float__6;
		public float float__7;
		public LocalisationId LocalisationId__8;
		public LocalisationId LocalisationId__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			StringID__1_ = s.SerializeObject<StringID>(StringID__1_, name: "StringID__1");
			uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
			uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
			bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				LocalisationId__8 = s.SerializeObject<LocalisationId>(LocalisationId__8, name: "LocalisationId__8");
				LocalisationId__9 = s.SerializeObject<LocalisationId>(LocalisationId__9, name: "LocalisationId__9");
			}
		}
		public override uint? ClassCRC => 0x4D192E6A;
	}
}

