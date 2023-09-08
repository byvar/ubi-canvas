namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MultiTextBoxComponent : ActorComponent {
		public CListO<MultiTextBoxComponent.TextBox> textBoxList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
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

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.Settings.Game == Game.VH || s.Settings.Game == Game.RL) {
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
		}
		public override uint? ClassCRC => 0xC7C07D02;
	}
}

