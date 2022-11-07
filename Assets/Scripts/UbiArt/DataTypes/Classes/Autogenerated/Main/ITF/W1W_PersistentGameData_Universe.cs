namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_PersistentGameData_Universe : PersistentGameData_Universe {
		public bool bool__0;
		public uint uint__1;
		public uint uint__2;
		public uint uint__3;
		public uint uint__4;
		public bool bool__5;
		public bool bool__6;
		public bool bool__7;
		public bool bool__8;
		public bool bool__9;
		public bool bool__10;
		public bool bool__11;
		public bool bool__12;
		public bool bool__13;
		public bool bool__14;
		public bool bool__15;
		public Path Path__16;
		public uint uint__17;
		public uint uint__18;
		public uint uint__19;
		public W1W_PersistentGameData_Universe.NodeData W1W_PersistentGameData_Universe_NodeData__20;
		public MenuOptionSave MenuOptionSave__21;
		public bool bool__22;
		public uint uint__23;
		public float float__24;
		public bool bool__25;
		public CharactersDiariesSave CharactersDiariesSave__26;
		public bool bool__27;
		public bool bool__28;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
			uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
			bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
			bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
			bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
			bool__8 = s.Serialize<bool>(bool__8, name: "bool__8");
			bool__9 = s.Serialize<bool>(bool__9, name: "bool__9");
			bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
			bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
			bool__12 = s.Serialize<bool>(bool__12, name: "bool__12");
			bool__13 = s.Serialize<bool>(bool__13, name: "bool__13");
			bool__14 = s.Serialize<bool>(bool__14, name: "bool__14");
			bool__15 = s.Serialize<bool>(bool__15, name: "bool__15");
			Path__16 = s.SerializeObject<Path>(Path__16, name: "Path__16");
			uint__17 = s.Serialize<uint>(uint__17, name: "uint__17");
			uint__18 = s.Serialize<uint>(uint__18, name: "uint__18");
			uint__19 = s.Serialize<uint>(uint__19, name: "uint__19");
			W1W_PersistentGameData_Universe_NodeData__20 = s.SerializeObject<W1W_PersistentGameData_Universe.NodeData>(W1W_PersistentGameData_Universe_NodeData__20, name: "W1W_PersistentGameData_Universe.NodeData__20");
			MenuOptionSave__21 = s.SerializeObject<MenuOptionSave>(MenuOptionSave__21, name: "MenuOptionSave__21");
			bool__22 = s.Serialize<bool>(bool__22, name: "bool__22");
			uint__23 = s.Serialize<uint>(uint__23, name: "uint__23");
			float__24 = s.Serialize<float>(float__24, name: "float__24");
			bool__25 = s.Serialize<bool>(bool__25, name: "bool__25");
			CharactersDiariesSave__26 = s.SerializeObject<CharactersDiariesSave>(CharactersDiariesSave__26, name: "CharactersDiariesSave__26");
			bool__27 = s.Serialize<bool>(bool__27, name: "bool__27");
			bool__28 = s.Serialize<bool>(bool__28, name: "bool__28");
		}
		[Games(GameFlags.VH)]
		public partial class NodeData : CSerializable {
			public StringID StringID__0;
			public bool bool__1;
			public bool bool__2;
			public bool bool__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
				bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			}
		}
		public override uint? ClassCRC => 0x99632934;
	}
}

