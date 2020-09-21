using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Heal_Template : W1W_InteractiveGenComponent_Template {
		public Path Path__0;
		public Path Path__1;
		public Path Path__2;
		public Path Path__3;
		public Path Path__4;
		public Path Path__5;
		public Path Path__6;
		public Path Path__7;
		public Path Path__8;
		public CArrayO<Path> CArray_Path__9;
		public Path Path__10;
		public CArrayO<W1W_Heal_Template.InputDisplay> CArray_W1W_Heal_Template_InputDisplay__11;
		public float float__12;
		public float float__13;
		public Color Color__14;
		public Color Color__15;
		public string string__16;
		public string string__17;
		public StringID StringID__18;
		public StringID StringID__19;
		public StringID StringID__20;
		public StringID StringID__21;
		public StringID StringID__22;
		public StringID StringID__23;
		public StringID StringID__24;
		public StringID StringID__25;
		public StringID StringID__26;
		public StringID StringID__27;
		public StringID StringID__28;
		public StringID StringID__29;
		public StringID StringID__30;
		public float float__31;
		public float float__32;
		public Curve2D Curve2D__33;
		public Curve2D Curve2D__34;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
			Path__4 = s.SerializeObject<Path>(Path__4, name: "Path__4");
			Path__5 = s.SerializeObject<Path>(Path__5, name: "Path__5");
			Path__6 = s.SerializeObject<Path>(Path__6, name: "Path__6");
			Path__7 = s.SerializeObject<Path>(Path__7, name: "Path__7");
			Path__8 = s.SerializeObject<Path>(Path__8, name: "Path__8");
			CArray_Path__9 = s.SerializeObject<CArrayO<Path>>(CArray_Path__9, name: "CArray_Path__9");
			Path__10 = s.SerializeObject<Path>(Path__10, name: "Path__10");
			CArray_W1W_Heal_Template_InputDisplay__11 = s.SerializeObject<CArrayO<W1W_Heal_Template.InputDisplay>>(CArray_W1W_Heal_Template_InputDisplay__11, name: "CArray_W1W_Heal_Template_InputDisplay__11");
			float__12 = s.Serialize<float>(float__12, name: "float__12");
			float__13 = s.Serialize<float>(float__13, name: "float__13");
			Color__14 = s.SerializeObject<Color>(Color__14, name: "Color__14");
			Color__15 = s.SerializeObject<Color>(Color__15, name: "Color__15");
			string__16 = s.Serialize<string>(string__16, name: "string__16");
			string__17 = s.Serialize<string>(string__17, name: "string__17");
			StringID__18 = s.SerializeObject<StringID>(StringID__18, name: "StringID__18");
			StringID__19 = s.SerializeObject<StringID>(StringID__19, name: "StringID__19");
			StringID__20 = s.SerializeObject<StringID>(StringID__20, name: "StringID__20");
			StringID__21 = s.SerializeObject<StringID>(StringID__21, name: "StringID__21");
			StringID__22 = s.SerializeObject<StringID>(StringID__22, name: "StringID__22");
			StringID__23 = s.SerializeObject<StringID>(StringID__23, name: "StringID__23");
			StringID__24 = s.SerializeObject<StringID>(StringID__24, name: "StringID__24");
			StringID__25 = s.SerializeObject<StringID>(StringID__25, name: "StringID__25");
			StringID__26 = s.SerializeObject<StringID>(StringID__26, name: "StringID__26");
			StringID__27 = s.SerializeObject<StringID>(StringID__27, name: "StringID__27");
			StringID__28 = s.SerializeObject<StringID>(StringID__28, name: "StringID__28");
			StringID__29 = s.SerializeObject<StringID>(StringID__29, name: "StringID__29");
			StringID__30 = s.SerializeObject<StringID>(StringID__30, name: "StringID__30");
			float__31 = s.Serialize<float>(float__31, name: "float__31");
			float__32 = s.Serialize<float>(float__32, name: "float__32");
			Curve2D__33 = s.SerializeObject<Curve2D>(Curve2D__33, name: "Curve2D__33");
			Curve2D__34 = s.SerializeObject<Curve2D>(Curve2D__34, name: "Curve2D__34");
		}
		[Games(GameFlags.VH)]
		public partial class InputDisplay : CSerializable {
			public StringID StringID__0;
			public StringID StringID__1;
			public Vec2d Vector2__2;
			public float float__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
				Vector2__2 = s.SerializeObject<Vec2d>(Vector2__2, name: "Vector2__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
			}
		}
		public override uint? ClassCRC => 0x2DA8A2A6;
	}
}

