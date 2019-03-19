using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Heal_Template : W1W_InteractiveGenComponent_Template {
		[Serialize("Path__0"                                   )] public Path Path__0;
		[Serialize("Path__1"                                   )] public Path Path__1;
		[Serialize("Path__2"                                   )] public Path Path__2;
		[Serialize("Path__3"                                   )] public Path Path__3;
		[Serialize("Path__4"                                   )] public Path Path__4;
		[Serialize("Path__5"                                   )] public Path Path__5;
		[Serialize("Path__6"                                   )] public Path Path__6;
		[Serialize("Path__7"                                   )] public Path Path__7;
		[Serialize("Path__8"                                   )] public Path Path__8;
		[Serialize("CArray<Path>__9"                           )] public CArray<Path> CArray_Path__9;
		[Serialize("Path__10"                                  )] public Path Path__10;
		[Serialize("CArray<W1W_Heal_Template.InputDisplay>__11")] public CArray<W1W_Heal_Template.InputDisplay> CArray_W1W_Heal_Template_InputDisplay__11;
		[Serialize("float__12"                                 )] public float float__12;
		[Serialize("float__13"                                 )] public float float__13;
		[Serialize("Color__14"                                 )] public Color Color__14;
		[Serialize("Color__15"                                 )] public Color Color__15;
		[Serialize("string__16"                                )] public string string__16;
		[Serialize("string__17"                                )] public string string__17;
		[Serialize("StringID__18"                              )] public StringID StringID__18;
		[Serialize("StringID__19"                              )] public StringID StringID__19;
		[Serialize("StringID__20"                              )] public StringID StringID__20;
		[Serialize("StringID__21"                              )] public StringID StringID__21;
		[Serialize("StringID__22"                              )] public StringID StringID__22;
		[Serialize("StringID__23"                              )] public StringID StringID__23;
		[Serialize("StringID__24"                              )] public StringID StringID__24;
		[Serialize("StringID__25"                              )] public StringID StringID__25;
		[Serialize("StringID__26"                              )] public StringID StringID__26;
		[Serialize("StringID__27"                              )] public StringID StringID__27;
		[Serialize("StringID__28"                              )] public StringID StringID__28;
		[Serialize("StringID__29"                              )] public StringID StringID__29;
		[Serialize("StringID__30"                              )] public StringID StringID__30;
		[Serialize("float__31"                                 )] public float float__31;
		[Serialize("float__32"                                 )] public float float__32;
		[Serialize("Curve2D__33"                               )] public Curve2D Curve2D__33;
		[Serialize("Curve2D__34"                               )] public Curve2D Curve2D__34;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(Path__1));
			SerializeField(s, nameof(Path__2));
			SerializeField(s, nameof(Path__3));
			SerializeField(s, nameof(Path__4));
			SerializeField(s, nameof(Path__5));
			SerializeField(s, nameof(Path__6));
			SerializeField(s, nameof(Path__7));
			SerializeField(s, nameof(Path__8));
			SerializeField(s, nameof(CArray_Path__9));
			SerializeField(s, nameof(Path__10));
			SerializeField(s, nameof(CArray_W1W_Heal_Template_InputDisplay__11));
			SerializeField(s, nameof(float__12));
			SerializeField(s, nameof(float__13));
			SerializeField(s, nameof(Color__14));
			SerializeField(s, nameof(Color__15));
			SerializeField(s, nameof(string__16));
			SerializeField(s, nameof(string__17));
			SerializeField(s, nameof(StringID__18));
			SerializeField(s, nameof(StringID__19));
			SerializeField(s, nameof(StringID__20));
			SerializeField(s, nameof(StringID__21));
			SerializeField(s, nameof(StringID__22));
			SerializeField(s, nameof(StringID__23));
			SerializeField(s, nameof(StringID__24));
			SerializeField(s, nameof(StringID__25));
			SerializeField(s, nameof(StringID__26));
			SerializeField(s, nameof(StringID__27));
			SerializeField(s, nameof(StringID__28));
			SerializeField(s, nameof(StringID__29));
			SerializeField(s, nameof(StringID__30));
			SerializeField(s, nameof(float__31));
			SerializeField(s, nameof(float__32));
			SerializeField(s, nameof(Curve2D__33));
			SerializeField(s, nameof(Curve2D__34));
		}
		[Games(GameFlags.VH)]
		public partial class InputDisplay : CSerializable {
			[Serialize("StringID__0")] public StringID StringID__0;
			[Serialize("StringID__1")] public StringID StringID__1;
			[Serialize("Vector2__2" )] public Vector2 Vector2__2;
			[Serialize("float__3"   )] public float float__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(Vector2__2));
				SerializeField(s, nameof(float__3));
			}
		}
		public override uint? ClassCRC => 0x2DA8A2A6;
	}
}

