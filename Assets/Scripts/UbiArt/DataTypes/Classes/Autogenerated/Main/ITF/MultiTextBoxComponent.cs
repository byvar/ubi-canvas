using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MultiTextBoxComponent : ActorComponent {
		public CListO<MultiTextBoxComponent.TextBox> textBoxList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					textBoxList = s.SerializeObject<CListO<MultiTextBoxComponent.TextBox>>(textBoxList, name: "textBoxList");
				}
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class TextBox : CSerializable {
			public SmartLocId text;
			public Vec2d area;
			public Vec3d offset;
			public Vec2d scale;
			public uint style;
			public bool scaleToMatchWithArea;
			public float maxWidth;
			public float autoScrollSpeed;
			public float autoScrollWaitTime;
			public Color overridingColor;
			public FONT_ALIGN overridingHAlignment;
			public FONT overridingVAlignment;
			public AREA_ANCHOR overridingAnchor;
			public bool unsecureSource;
			public SmartLocId SmartLocId__0;
			public Vec2d Vector2__1;
			public Vec3d Vector3__2;
			public Vec2d Vector2__3;
			public uint uint__4;
			public bool bool__5;
			public float float__6;
			public float float__7;
			public float float__8;
			public Color Color__9;
			public Enum_VH_0 Enum_VH_0__10;
			public Enum_VH_1 Enum_VH_1__11;
			public Enum_VH_2 Enum_VH_2__12;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.Settings.game == Settings.Game.VH) {
					if (s.HasFlags(SerializeFlags.Default)) {
						SmartLocId__0 = s.SerializeObject<SmartLocId>(SmartLocId__0, name: "SmartLocId__0");
						Vector2__1 = s.SerializeObject<Vec2d>(Vector2__1, name: "Vector2__1");
						Vector3__2 = s.SerializeObject<Vec3d>(Vector3__2, name: "Vector3__2");
						Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
						uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
						bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
						float__6 = s.Serialize<float>(float__6, name: "float__6");
						float__7 = s.Serialize<float>(float__7, name: "float__7");
						float__8 = s.Serialize<float>(float__8, name: "float__8");
						Color__9 = s.SerializeObject<Color>(Color__9, name: "Color__9");
						Enum_VH_0__10 = s.Serialize<Enum_VH_0>(Enum_VH_0__10, name: "Enum_VH_0__10");
						Enum_VH_1__11 = s.Serialize<Enum_VH_1>(Enum_VH_1__11, name: "Enum_VH_1__11");
						Enum_VH_2__12 = s.Serialize<Enum_VH_2>(Enum_VH_2__12, name: "Enum_VH_2__12");
					}
				} else {
					if (s.HasFlags(SerializeFlags.Default)) {
						text = s.SerializeObject<SmartLocId>(text, name: "text");
						area = s.SerializeObject<Vec2d>(area, name: "area");
						offset = s.SerializeObject<Vec3d>(offset, name: "offset");
						scale = s.SerializeObject<Vec2d>(scale, name: "scale");
						style = s.Serialize<uint>(style, name: "style");
						scaleToMatchWithArea = s.Serialize<bool>(scaleToMatchWithArea, name: "scaleToMatchWithArea");
						maxWidth = s.Serialize<float>(maxWidth, name: "maxWidth");
						autoScrollSpeed = s.Serialize<float>(autoScrollSpeed, name: "autoScrollSpeed");
						autoScrollWaitTime = s.Serialize<float>(autoScrollWaitTime, name: "autoScrollWaitTime");
						overridingColor = s.SerializeObject<Color>(overridingColor, name: "overridingColor");
						overridingHAlignment = s.Serialize<FONT_ALIGN>(overridingHAlignment, name: "overridingHAlignment");
						overridingVAlignment = s.Serialize<FONT>(overridingVAlignment, name: "overridingVAlignment");
						overridingAnchor = s.Serialize<AREA_ANCHOR>(overridingAnchor, name: "overridingAnchor");
						unsecureSource = s.Serialize<bool>(unsecureSource, name: "unsecureSource");
					}
				}
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
			public enum AREA_ANCHOR {
				[Serialize("AREA_ANCHOR_NONE"         )] NONE = -1,
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
			public enum Enum_VH_0 {
				[Serialize("Value__1")] Value__1 = -1,
				[Serialize("Value_0" )] Value_0 = 0,
				[Serialize("Value_1" )] Value_1 = 1,
				[Serialize("Value_2" )] Value_2 = 2,
				[Serialize("Value_3" )] Value_3 = 3,
			}
			public enum Enum_VH_1 {
				[Serialize("Value__1")] Value__1 = -1,
				[Serialize("Value_0" )] Value_0 = 0,
				[Serialize("Value_1" )] Value_1 = 1,
				[Serialize("Value_2" )] Value_2 = 2,
			}
			public enum Enum_VH_2 {
				[Serialize("Value__1")] Value__1 = -1,
				[Serialize("Value_0" )] Value_0 = 0,
				[Serialize("Value_1" )] Value_1 = 1,
				[Serialize("Value_2" )] Value_2 = 2,
				[Serialize("Value_3" )] Value_3 = 3,
				[Serialize("Value_4" )] Value_4 = 4,
				[Serialize("Value_5" )] Value_5 = 5,
				[Serialize("Value_6" )] Value_6 = 6,
				[Serialize("Value_7" )] Value_7 = 7,
				[Serialize("Value_8" )] Value_8 = 8,
			}
		}
		public override uint? ClassCRC => 0xC7C07D02;
	}
}

