using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class MultiTextBoxComponent : ActorComponent {
		[Serialize("textBoxList")] public CList<MultiTextBoxComponent.TextBox> textBoxList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(textBoxList));
				}
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class TextBox : CSerializable {
			[Serialize("text"                )] public SmartLocId text;
			[Serialize("area"                )] public Vec2d area;
			[Serialize("offset"              )] public Vec3d offset;
			[Serialize("scale"               )] public Vec2d scale;
			[Serialize("style"               )] public uint style;
			[Serialize("scaleToMatchWithArea")] public bool scaleToMatchWithArea;
			[Serialize("maxWidth"            )] public float maxWidth;
			[Serialize("autoScrollSpeed"     )] public float autoScrollSpeed;
			[Serialize("autoScrollWaitTime"  )] public float autoScrollWaitTime;
			[Serialize("overridingColor"     )] public Color overridingColor;
			[Serialize("overridingHAlignment")] public FONT_ALIGN overridingHAlignment;
			[Serialize("overridingVAlignment")] public FONT overridingVAlignment;
			[Serialize("overridingAnchor"    )] public AREA_ANCHOR overridingAnchor;
			[Serialize("unsecureSource"      )] public bool unsecureSource;
			[Serialize("SmartLocId__0"       )] public SmartLocId SmartLocId__0;
			[Serialize("Vector2__1"          )] public Vec2d Vector2__1;
			[Serialize("Vector3__2"          )] public Vec3d Vector3__2;
			[Serialize("Vector2__3"          )] public Vec2d Vector2__3;
			[Serialize("uint__4"             )] public uint uint__4;
			[Serialize("bool__5"             )] public bool bool__5;
			[Serialize("float__6"            )] public float float__6;
			[Serialize("float__7"            )] public float float__7;
			[Serialize("float__8"            )] public float float__8;
			[Serialize("Color__9"            )] public Color Color__9;
			[Serialize("Enum_VH_0__10"       )] public Enum_VH_0 Enum_VH_0__10;
			[Serialize("Enum_VH_1__11"       )] public Enum_VH_1 Enum_VH_1__11;
			[Serialize("Enum_VH_2__12"       )] public Enum_VH_2 Enum_VH_2__12;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					if (s.HasFlags(SerializeFlags.Default)) {
						SerializeField(s, nameof(SmartLocId__0));
						SerializeField(s, nameof(Vector2__1));
						SerializeField(s, nameof(Vector3__2));
						SerializeField(s, nameof(Vector2__3));
						SerializeField(s, nameof(uint__4));
						SerializeField(s, nameof(bool__5));
						SerializeField(s, nameof(float__6));
						SerializeField(s, nameof(float__7));
						SerializeField(s, nameof(float__8));
						SerializeField(s, nameof(Color__9));
						SerializeField(s, nameof(Enum_VH_0__10));
						SerializeField(s, nameof(Enum_VH_1__11));
						SerializeField(s, nameof(Enum_VH_2__12));
					}
				} else {
					if (s.HasFlags(SerializeFlags.Default)) {
						SerializeField(s, nameof(text));
						SerializeField(s, nameof(area));
						SerializeField(s, nameof(offset));
						SerializeField(s, nameof(scale));
						SerializeField(s, nameof(style));
						SerializeField(s, nameof(scaleToMatchWithArea));
						SerializeField(s, nameof(maxWidth));
						SerializeField(s, nameof(autoScrollSpeed));
						SerializeField(s, nameof(autoScrollWaitTime));
						SerializeField(s, nameof(overridingColor));
						SerializeField(s, nameof(overridingHAlignment));
						SerializeField(s, nameof(overridingVAlignment));
						SerializeField(s, nameof(overridingAnchor));
						SerializeField(s, nameof(unsecureSource));
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

