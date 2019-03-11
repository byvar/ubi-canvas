using UnityEngine;

namespace UbiArt.ITF {
	public partial class MultiTextBoxComponent : ActorComponent {
		[Serialize("textBoxList")] public CList<MultiTextBoxComponent.TextBox> textBoxList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(textBoxList));
			}
		}
		public partial class TextBox : CSerializable {
			[Serialize("text"                )] public SmartLocId text;
			[Serialize("area"                )] public Vector2 area;
			[Serialize("offset"              )] public Vector3 offset;
			[Serialize("scale"               )] public Vector2 scale;
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
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
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

