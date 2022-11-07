namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Vehicle_Template : W1W_InteractiveGenComponent_Template {
		public Vec2d Vector2__0;
		public StringID StringID__1_;
		public Path Path__2;
		public float float__3;
		public float float__4;
		public Vec2d Vector2__5;
		public Vec2d Vector2__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public StringID StringID__10;
		public StringID StringID__11;
		public StringID StringID__12;
		public StringID StringID__13;
		public StringID StringID__14;
		public StringID StringID__15;
		public StringID StringID__16;
		public StringID StringID__17;
		public StringID StringID__18;
		public StringID StringID__19;
		public StringID StringID__20;
		public StringID StringID__21;
		public float float__22;
		public StringID StringID__23;
		public StringID StringID__24;
		public StringID StringID__25;
		public StringID StringID__26;
		public StringID StringID__27;
		public float float__28;
		public StringID StringID__29;
		public float float__30;
		public StringID StringID__31;
		public float float__32;
		public StringID StringID__33;
		public StringID StringID__34;
		public StringID StringID__35;
		public float float__36;
		public float float__37;
		public bool bool__38;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
			StringID__1_ = s.SerializeObject<StringID>(StringID__1_, name: "StringID__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			Vector2__5 = s.SerializeObject<Vec2d>(Vector2__5, name: "Vector2__5");
			Vector2__6 = s.SerializeObject<Vec2d>(Vector2__6, name: "Vector2__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
			StringID__10 = s.SerializeObject<StringID>(StringID__10, name: "StringID__10");
			StringID__11 = s.SerializeObject<StringID>(StringID__11, name: "StringID__11");
			StringID__12 = s.SerializeObject<StringID>(StringID__12, name: "StringID__12");
			StringID__13 = s.SerializeObject<StringID>(StringID__13, name: "StringID__13");
			StringID__14 = s.SerializeObject<StringID>(StringID__14, name: "StringID__14");
			StringID__15 = s.SerializeObject<StringID>(StringID__15, name: "StringID__15");
			StringID__16 = s.SerializeObject<StringID>(StringID__16, name: "StringID__16");
			StringID__17 = s.SerializeObject<StringID>(StringID__17, name: "StringID__17");
			StringID__18 = s.SerializeObject<StringID>(StringID__18, name: "StringID__18");
			StringID__19 = s.SerializeObject<StringID>(StringID__19, name: "StringID__19");
			StringID__20 = s.SerializeObject<StringID>(StringID__20, name: "StringID__20");
			StringID__21 = s.SerializeObject<StringID>(StringID__21, name: "StringID__21");
			float__22 = s.Serialize<float>(float__22, name: "float__22");
			StringID__23 = s.SerializeObject<StringID>(StringID__23, name: "StringID__23");
			StringID__24 = s.SerializeObject<StringID>(StringID__24, name: "StringID__24");
			StringID__25 = s.SerializeObject<StringID>(StringID__25, name: "StringID__25");
			StringID__26 = s.SerializeObject<StringID>(StringID__26, name: "StringID__26");
			StringID__27 = s.SerializeObject<StringID>(StringID__27, name: "StringID__27");
			float__28 = s.Serialize<float>(float__28, name: "float__28");
			StringID__29 = s.SerializeObject<StringID>(StringID__29, name: "StringID__29");
			float__30 = s.Serialize<float>(float__30, name: "float__30");
			StringID__31 = s.SerializeObject<StringID>(StringID__31, name: "StringID__31");
			float__32 = s.Serialize<float>(float__32, name: "float__32");
			StringID__33 = s.SerializeObject<StringID>(StringID__33, name: "StringID__33");
			StringID__34 = s.SerializeObject<StringID>(StringID__34, name: "StringID__34");
			StringID__35 = s.SerializeObject<StringID>(StringID__35, name: "StringID__35");
			float__36 = s.Serialize<float>(float__36, name: "float__36");
			float__37 = s.Serialize<float>(float__37, name: "float__37");
			bool__38 = s.Serialize<bool>(bool__38, name: "bool__38");
		}
		public override uint? ClassCRC => 0x272276BA;
	}
}

