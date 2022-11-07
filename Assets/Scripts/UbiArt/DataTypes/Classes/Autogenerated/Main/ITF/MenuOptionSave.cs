namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class MenuOptionSave : CSerializable {
		public bool bool__0;
		public bool bool__1;
		public bool bool__2;
		public bool bool__3;
		public uint uint__4;
		public uint uint__5;
		public string string__6;
		public string string__7;
		public string string__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
			uint__5 = s.Serialize<uint>(uint__5, name: "uint__5");
			string__6 = s.Serialize<string>(string__6, name: "string__6");
			string__7 = s.Serialize<string>(string__7, name: "string__7");
			string__8 = s.Serialize<string>(string__8, name: "string__8");
		}
	}
}

