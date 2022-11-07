namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BossSequenceComponent : ActorComponent {
		public bool bool__0;
		public Path Path__1;
		public Path Path__2;
		public Path Path__3;
		public uint uint__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public float float__10;
		public float float__11;
		public float float__12;
		public float float__13;
		public float float__14;
		public bool bool__15;
		public uint uint__16;
		public float float__17;
		public float float__18;
		public float float__19;
		public uint uint__20;
		public float float__21;
		public float float__22;
		public float float__23;
		public float float__24;
		public float float__25;
		public uint uint__26;
		public float float__27;
		public float float__28;
		public float float__29;
		public float float__30;
		public float float__31;
		public uint uint__32;
		public float float__33;
		public float float__34;
		public float float__35;
		public bool bool__36;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
			float__10 = s.Serialize<float>(float__10, name: "float__10");
			float__11 = s.Serialize<float>(float__11, name: "float__11");
			float__12 = s.Serialize<float>(float__12, name: "float__12");
			float__13 = s.Serialize<float>(float__13, name: "float__13");
			float__14 = s.Serialize<float>(float__14, name: "float__14");
			bool__15 = s.Serialize<bool>(bool__15, name: "bool__15");
			uint__16 = s.Serialize<uint>(uint__16, name: "uint__16");
			float__17 = s.Serialize<float>(float__17, name: "float__17");
			float__18 = s.Serialize<float>(float__18, name: "float__18");
			float__19 = s.Serialize<float>(float__19, name: "float__19");
			uint__20 = s.Serialize<uint>(uint__20, name: "uint__20");
			float__21 = s.Serialize<float>(float__21, name: "float__21");
			float__22 = s.Serialize<float>(float__22, name: "float__22");
			float__23 = s.Serialize<float>(float__23, name: "float__23");
			float__24 = s.Serialize<float>(float__24, name: "float__24");
			float__25 = s.Serialize<float>(float__25, name: "float__25");
			uint__26 = s.Serialize<uint>(uint__26, name: "uint__26");
			float__27 = s.Serialize<float>(float__27, name: "float__27");
			float__28 = s.Serialize<float>(float__28, name: "float__28");
			float__29 = s.Serialize<float>(float__29, name: "float__29");
			float__30 = s.Serialize<float>(float__30, name: "float__30");
			float__31 = s.Serialize<float>(float__31, name: "float__31");
			uint__32 = s.Serialize<uint>(uint__32, name: "uint__32");
			float__33 = s.Serialize<float>(float__33, name: "float__33");
			float__34 = s.Serialize<float>(float__34, name: "float__34");
			float__35 = s.Serialize<float>(float__35, name: "float__35");
			bool__36 = s.Serialize<bool>(bool__36, name: "bool__36");
		}
		public override uint? ClassCRC => 0x64536F79;
	}
}

