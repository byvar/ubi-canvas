using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class TextBoxComponent : UIComponent {
		[Serialize("style"               )] public uint style;
		[Serialize("offset"              )] public Vector2 offset;
		[Serialize("scale"               )] public Vector2 scale;
		[Serialize("area"                )] public Vector2 area;
		[Serialize("maxWidth"            )] public float maxWidth;
		[Serialize("rawText"             )] public string rawText;
		[Serialize("locId"               )] public LocalisationId locId;
		[Serialize("unsecureSource"      )] public bool unsecureSource;
		[Serialize("GlobalScissor"       )] public Enum_GlobalScissor GlobalScissor;
		[Serialize("scaleToMatchWithArea")] public bool scaleToMatchWithArea;
		[Serialize("autoScrollSpeed"     )] public float autoScrollSpeed;
		[Serialize("autoScrollWaitTime"  )] public float autoScrollWaitTime;
		[Serialize("overridingColor"     )] public Color overridingColor;
		[Serialize("overridingHAlignment")] public FONT_ALIGN overridingHAlignment;
		[Serialize("overridingVAlignment")] public FONT overridingVAlignment;
		[Serialize("depthOffset"         )] public float depthOffset;
		[Serialize("ViewportVisibility"  )] public uint ViewportVisibility;
		[Serialize("AdaptToLangage"      )] public bool AdaptToLangage;
		[Serialize("offsetLangage"       )] public Vector2 offsetLangage;
		[Serialize("overridingHAlignment")] public Enum_overridingHAlignment overridingHAlignment;
		[Serialize("overridingVAlignment")] public Enum_overridingVAlignment overridingVAlignment;
		[Serialize("locId"               )] public StringID locId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(style));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(scale));
					SerializeField(s, nameof(area));
					SerializeField(s, nameof(maxWidth));
					SerializeField(s, nameof(rawText));
					SerializeField(s, nameof(locId));
					SerializeField(s, nameof(scaleToMatchWithArea));
					SerializeField(s, nameof(autoScrollSpeed));
					SerializeField(s, nameof(autoScrollWaitTime));
					SerializeField(s, nameof(overridingColor));
					SerializeField(s, nameof(overridingHAlignment));
					SerializeField(s, nameof(overridingVAlignment));
					SerializeField(s, nameof(depthOffset));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(style));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(scale));
					SerializeField(s, nameof(area));
					SerializeField(s, nameof(maxWidth));
					SerializeField(s, nameof(rawText));
					SerializeField(s, nameof(locId));
					SerializeField(s, nameof(scaleToMatchWithArea));
					SerializeField(s, nameof(autoScrollSpeed));
					SerializeField(s, nameof(autoScrollWaitTime));
					SerializeField(s, nameof(overridingColor));
					SerializeField(s, nameof(overridingHAlignment));
					SerializeField(s, nameof(overridingVAlignment));
					SerializeField(s, nameof(depthOffset));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(style));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(scale));
					SerializeField(s, nameof(area));
					SerializeField(s, nameof(maxWidth));
					SerializeField(s, nameof(rawText));
					SerializeField(s, nameof(locId));
					SerializeField(s, nameof(unsecureSource));
					SerializeField(s, nameof(GlobalScissor));
					if (s.HasFlags(SerializeFlags.Flags8)) {
						SerializeField(s, nameof(scaleToMatchWithArea));
					}
					SerializeField(s, nameof(autoScrollSpeed));
					SerializeField(s, nameof(autoScrollWaitTime));
					SerializeField(s, nameof(overridingColor));
					SerializeField(s, nameof(overridingHAlignment));
					SerializeField(s, nameof(overridingVAlignment));
					SerializeField(s, nameof(depthOffset));
					SerializeField(s, nameof(ViewportVisibility));
					SerializeField(s, nameof(AdaptToLangage));
					SerializeField(s, nameof(offsetLangage));
				}
			}
		}
		public enum Enum_GlobalScissor {
			[Serialize("NONE"     )] NONE = 0,
			[Serialize("SCISSOR_1")] SCISSOR_1 = 1,
			[Serialize("SCISSOR_2")] SCISSOR_2 = 2,
			[Serialize("SCISSOR_3")] SCISSOR_3 = 3,
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
		public enum Enum_overridingHAlignment {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
		}
		public enum Enum_overridingHAlignment {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x13E9D108;
	}
}

