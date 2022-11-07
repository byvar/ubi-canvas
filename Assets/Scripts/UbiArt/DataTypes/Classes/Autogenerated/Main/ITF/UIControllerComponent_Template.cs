namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class UIControllerComponent_Template : UIComponent_Template {
		public CListO<UIControllerComponent_Template.ControllerTextObject> buttonActions;
		public Path textboxPath;
		public float inputActorScaleFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				buttonActions = s.SerializeObject<CListO<UIControllerComponent_Template.ControllerTextObject>>(buttonActions, name: "buttonActions");
				textboxPath = s.SerializeObject<Path>(textboxPath, name: "textboxPath");
				inputActorScaleFactor = s.Serialize<float>(inputActorScaleFactor, name: "inputActorScaleFactor");
			} else if (s.Settings.game == Settings.Game.COL) {
				textboxPath = s.SerializeObject<Path>(textboxPath, name: "textboxPath");
				inputActorScaleFactor = s.Serialize<float>(inputActorScaleFactor, name: "inputActorScaleFactor");
			} else {
				buttonActions = s.SerializeObject<CListO<UIControllerComponent_Template.ControllerTextObject>>(buttonActions, name: "buttonActions");
				textboxPath = s.SerializeObject<Path>(textboxPath, name: "textboxPath");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class ControllerTextObject : CSerializable {
			public StringID boneName;
			public LocalisationId locId;
			public Color color;
			public FONT_ALIGN hAlign;
			public FONT vAlign;
			public AREA_ANCHOR anchor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
				locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
				color = s.SerializeObject<Color>(color, name: "color");
				hAlign = s.Serialize<FONT_ALIGN>(hAlign, name: "hAlign");
				vAlign = s.Serialize<FONT>(vAlign, name: "vAlign");
				anchor = s.Serialize<AREA_ANCHOR>(anchor, name: "anchor");
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
		public override uint? ClassCRC => 0x70E57FB8;
	}
}

