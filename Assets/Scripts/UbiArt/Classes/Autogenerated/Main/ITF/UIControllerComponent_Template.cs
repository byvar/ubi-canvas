using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIControllerComponent_Template : UIComponent_Template {
		[Serialize("buttonActions"        )] public CList<UIControllerComponent_Template.ControllerTextObject> buttonActions;
		[Serialize("textboxPath"          )] public Path textboxPath;
		[Serialize("inputActorScaleFactor")] public float inputActorScaleFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(buttonActions));
				SerializeField(s, nameof(textboxPath));
				SerializeField(s, nameof(inputActorScaleFactor));
			} else {
				SerializeField(s, nameof(buttonActions));
				SerializeField(s, nameof(textboxPath));
			}
		}
		public partial class ControllerTextObject : CSerializable {
			[Serialize("boneName")] public StringID boneName;
			[Serialize("locId"   )] public LocalisationId locId;
			[Serialize("color"   )] public Color color;
			[Serialize("hAlign"  )] public FONT_ALIGN hAlign;
			[Serialize("vAlign"  )] public FONT vAlign;
			[Serialize("anchor"  )] public AREA_ANCHOR anchor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(boneName));
				SerializeField(s, nameof(locId));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(hAlign));
				SerializeField(s, nameof(vAlign));
				SerializeField(s, nameof(anchor));
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

