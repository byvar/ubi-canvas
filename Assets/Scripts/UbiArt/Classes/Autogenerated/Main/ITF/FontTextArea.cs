using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class FontTextArea : CSerializable {
		[Serialize("FontTextArea.FontSet__0")] public FontTextArea.FontSet FontTextArea_FontSet__0;
		[Serialize("FontTextArea.Style__1"  )] public FontTextArea.Style FontTextArea_Style__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(FontTextArea_FontSet__0));
				SerializeField(s, nameof(FontTextArea_Style__1));
			} else {
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class FontSet : CSerializable {
			[Serialize("default"      )] public Path _default;
			[Serialize("japanese"     )] public Path japanese;
			[Serialize("korean"       )] public Path korean;
			[Serialize("tradChinese"  )] public Path tradChinese;
			[Serialize("simpleChinese")] public Path simpleChinese;
			[Serialize("russian"      )] public Path russian;
			[Serialize("arabic"       )] public Path arabic;
			[Serialize("thai"         )] public Path thai;
			[Serialize("Path__0"      )] public Path Path__0;
			[Serialize("Path__1"      )] public Path Path__1;
			[Serialize("Path__2"      )] public Path Path__2;
			[Serialize("Path__3"      )] public Path Path__3;
			[Serialize("Path__4"      )] public Path Path__4;
			[Serialize("Path__5"      )] public Path Path__5;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					SerializeField(s, nameof(Path__0));
					SerializeField(s, nameof(Path__1));
					SerializeField(s, nameof(Path__2));
					SerializeField(s, nameof(Path__3));
					SerializeField(s, nameof(Path__4));
					SerializeField(s, nameof(Path__5));
				} else {
					SerializeField(s, nameof(_default));
					SerializeField(s, nameof(japanese));
					SerializeField(s, nameof(korean));
					SerializeField(s, nameof(tradChinese));
					SerializeField(s, nameof(simpleChinese));
					SerializeField(s, nameof(russian));
					SerializeField(s, nameof(arabic));
					SerializeField(s, nameof(thai));
				}
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class Style : CSerializable {
			[Serialize("fontSet"                )] public FontTextArea.FontSet fontSet;
			[Serialize("fontSize"               )] public float fontSize;
			[Serialize("color"                  )] public Color color;
			[Serialize("shadowOffset"           )] public Vector2 shadowOffset;
			[Serialize("shadowColor"            )] public Color shadowColor;
			[Serialize("lineSpacing"            )] public float lineSpacing;
			[Serialize("paragraphSpacing"       )] public float paragraphSpacing;
			[Serialize("anchor"                 )] public AREA_ANCHOR anchor;
			[Serialize("hAlignment"             )] public FONT_ALIGN hAlignment;
			[Serialize("vAlignment"             )] public FONT vAlignment;
			[Serialize("useGradient"            )] public bool useGradient;
			[Serialize("gradientSize"           )] public float gradientSize;
			[Serialize("gradientOffset"         )] public float gradientOffset;
			[Serialize("gradientColor"          )] public Color gradientColor;
			[Serialize("charSpacing"            )] public float charSpacing;
			[Serialize("Path__0"                )] public Path Path__0;
			[Serialize("FontTextArea.FontSet__1")] public FontTextArea.FontSet FontTextArea_FontSet__1;
			[Serialize("float__2"               )] public float float__2;
			[Serialize("Color__3"               )] public Color Color__3;
			[Serialize("Vector2__4"             )] public Vector2 Vector2__4;
			[Serialize("Color__5"               )] public Color Color__5;
			[Serialize("float__6"               )] public float float__6;
			[Serialize("float__7"               )] public float float__7;
			[Serialize("Enum_VH_0__8"           )] public Enum_VH_0 Enum_VH_0__8;
			[Serialize("Enum_VH_1__9"           )] public Enum_VH_1 Enum_VH_1__9;
			[Serialize("Enum_VH_2__10"          )] public Enum_VH_2 Enum_VH_2__10;
			[Serialize("bool__11"               )] public bool bool__11;
			[Serialize("float__12"              )] public float float__12;
			[Serialize("float__13"              )] public float float__13;
			[Serialize("Color__14"              )] public Color Color__14;
			[Serialize("float__15"              )] public float float__15;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						SerializeField(s, nameof(Path__0));
					}
					SerializeField(s, nameof(FontTextArea_FontSet__1));
					SerializeField(s, nameof(float__2));
					SerializeField(s, nameof(Color__3));
					SerializeField(s, nameof(Vector2__4));
					SerializeField(s, nameof(Color__5));
					SerializeField(s, nameof(float__6));
					SerializeField(s, nameof(float__7));
					SerializeField(s, nameof(Enum_VH_0__8));
					SerializeField(s, nameof(Enum_VH_1__9));
					SerializeField(s, nameof(Enum_VH_2__10));
					SerializeField(s, nameof(bool__11));
					SerializeField(s, nameof(float__12));
					SerializeField(s, nameof(float__13));
					SerializeField(s, nameof(Color__14));
					SerializeField(s, nameof(float__15));
				} else {
					SerializeField(s, nameof(fontSet));
					SerializeField(s, nameof(fontSize));
					SerializeField(s, nameof(color));
					SerializeField(s, nameof(shadowOffset));
					SerializeField(s, nameof(shadowColor));
					SerializeField(s, nameof(lineSpacing));
					SerializeField(s, nameof(paragraphSpacing));
					SerializeField(s, nameof(anchor));
					SerializeField(s, nameof(hAlignment));
					SerializeField(s, nameof(vAlignment));
					SerializeField(s, nameof(useGradient));
					SerializeField(s, nameof(gradientSize));
					SerializeField(s, nameof(gradientOffset));
					SerializeField(s, nameof(gradientColor));
					SerializeField(s, nameof(charSpacing));
				}
			}
			public enum AREA_ANCHOR {
				[Serialize("AREA_ANCHOR_TOP_LEFT"     )] TOP_LEFT = 0,
				[Serialize("AREA_ANCHOR_MIDDLE_CENTER")] MIDDLE_CENTER = 1,
				[Serialize("AREA_ANCHOR_MIDDLE_LEFT"  )] MIDDLE_LEFT = 2,
				[Serialize("AREA_ANCHOR_MIDDLE_RIGHT" )] MIDDLE_RIGHT = 3,
				[Serialize("AREA_ANCHOR_TOP_CENTER"   )] TOP_CENTER = 4,
				[Serialize("AREA_ANCHOR_TOP_RIGHT"    )] TOP_RIGHT = 5,
				[Serialize("AREA_ANCHOR_BOTTOM_CENTER")] BOTTOM_CENTER = 6,
				[Serialize("AREA_ANCHOR_BOTTOM_LEFT"  )] BOTTOM_LEFT = 7,
				[Serialize("AREA_ANCHOR_BOTTOM_RIGHT" )] BOTTOM_RIGHT = 8,
			}
			public enum FONT_ALIGN {
				[Serialize("FONT_ALIGN_NONE"   )] NONE = -1,
				[Serialize("FONT_ALIGN_LEFT"   )] LEFT = 0,
				[Serialize("FONT_ALIGN_CENTER" )] CENTER = 1,
				[Serialize("FONT_ALIGN_RIGHT"  )] RIGHT = 2,
				[Serialize("FONT_ALIGN_JUSTIFY")] JUSTIFY = 3,
			}
			public enum FONT {
				[Serialize("FONT_ALIGN_NONE"   )] ALIGN_NONE = -1,
				[Serialize("FONT_VALIGN_TOP"   )] VALIGN_TOP = 0,
				[Serialize("FONT_VALIGN_MIDDLE")] VALIGN_MIDDLE = 1,
				[Serialize("FONT_VALIGN_BOTTOM")] VALIGN_BOTTOM = 2,
			}
			public enum Enum_VH_0 {
				[Serialize("Value_0")] Value_0 = 0,
				[Serialize("Value_1")] Value_1 = 1,
				[Serialize("Value_2")] Value_2 = 2,
				[Serialize("Value_3")] Value_3 = 3,
				[Serialize("Value_4")] Value_4 = 4,
				[Serialize("Value_5")] Value_5 = 5,
				[Serialize("Value_6")] Value_6 = 6,
				[Serialize("Value_7")] Value_7 = 7,
				[Serialize("Value_8")] Value_8 = 8,
			}
			public enum Enum_VH_1 {
				[Serialize("Value__1")] Value__1 = -1,
				[Serialize("Value_0" )] Value_0 = 0,
				[Serialize("Value_1" )] Value_1 = 1,
				[Serialize("Value_2" )] Value_2 = 2,
				[Serialize("Value_3" )] Value_3 = 3,
			}
			public enum Enum_VH_2 {
				[Serialize("Value__1")] Value__1 = -1,
				[Serialize("Value_0" )] Value_0 = 0,
				[Serialize("Value_1" )] Value_1 = 1,
				[Serialize("Value_2" )] Value_2 = 2,
			}
		}
	}
}

