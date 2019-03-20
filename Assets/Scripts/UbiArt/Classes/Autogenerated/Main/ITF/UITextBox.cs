using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UITextBox : UIComponent {
		[Serialize("style"                  )] public uint style;
		[Serialize("offset"                 )] public Vector2 offset;
		[Serialize("depth"                  )] public float depth;
		[Serialize("scale"                  )] public Vector2 scale;
		[Serialize("area"                   )] public Vector2 area;
		[Serialize("maxWidth"               )] public float maxWidth;
		[Serialize("rawText"                )] public string rawText;
		[Serialize("locId"                  )] public LocalisationId locId;
		[Serialize("unsecureSource"         )] public bool unsecureSource;
		[Serialize("overridingColor"        )] public Color overridingColor;
		[Serialize("GlobalScissor"          )] public Enum_GlobalScissor GlobalScissor;
		[Serialize("scaleToMatchWithArea"   )] public bool scaleToMatchWithArea;
		[Serialize("autoScrollSpeed"        )] public float autoScrollSpeed;
		[Serialize("autoScrollWaitTime"     )] public float autoScrollWaitTime;
		[Serialize("autoScrollFirstWaitTime")] public float autoScrollFirstWaitTime;
		[Serialize("autoScrollLoop"         )] public bool autoScrollLoop;
		[Serialize("autoScrollMode"         )] public AutoScroll autoScrollMode;
		[Serialize("autoScrollUpdate"       )] public AutoScrollUpdate autoScrollUpdate;
		[Serialize("autoScrollLoopGap"      )] public uint autoScrollLoopGap;
		[Serialize("overridingHAlignment"   )] public FONT_ALIGN overridingHAlignment;
		[Serialize("overridingHAlignment"   )] public FONT_ALIGN2 overridingHAlignment2;
		[Serialize("overridingVAlignment"   )] public FONT overridingVAlignment;
		[Serialize("overridingAnchor"       )] public AREA_ANCHOR overridingAnchor;
		[Serialize("ViewportVisibility"     )] public uint ViewportVisibility;
		[Serialize("AdaptToLangage"         )] public bool AdaptToLangage;
		[Serialize("DontResizeForChinese"   )] public bool DontResizeForChinese;

		[Serialize("Enum_VH_0__9"           )] public Enum_VH_0 Enum_VH_0__9;
		[Serialize("bool__12"               )] public bool bool__12;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(style));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(depth));
					SerializeField(s, nameof(scale));
					SerializeField(s, nameof(area));
					SerializeField(s, nameof(maxWidth));
					SerializeField(s, nameof(rawText));
					SerializeField(s, nameof(locId));
					SerializeField(s, nameof(overridingColor));
					SerializeField(s, nameof(scaleToMatchWithArea));
					SerializeField(s, nameof(autoScrollSpeed));
					SerializeField(s, nameof(autoScrollWaitTime));
					SerializeField(s, nameof(overridingHAlignment2));
					SerializeField(s, nameof(overridingVAlignment));
					SerializeField(s, nameof(overridingAnchor));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(style));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(depth));
					SerializeField(s, nameof(scale));
					SerializeField(s, nameof(area));
					SerializeField(s, nameof(maxWidth));
					SerializeField(s, nameof(rawText));
					SerializeField(s, nameof(locId), type: typeof(StringID));
					SerializeField(s, nameof(overridingColor));
					SerializeField(s, nameof(scaleToMatchWithArea));
					SerializeField(s, nameof(autoScrollSpeed));
					SerializeField(s, nameof(autoScrollWaitTime));
					SerializeField(s, nameof(overridingHAlignment2));
					SerializeField(s, nameof(overridingVAlignment));
					SerializeField(s, nameof(overridingAnchor));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(style));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(depth));
					SerializeField(s, nameof(scale));
					SerializeField(s, nameof(area));
					SerializeField(s, nameof(maxWidth));
					SerializeField(s, nameof(rawText));
					SerializeField(s, nameof(locId));
					SerializeField(s, nameof(overridingColor));
					if (s.HasFlags(SerializeFlags.Flags8)) {
						SerializeField(s, nameof(scaleToMatchWithArea));
					}
					SerializeField(s, nameof(Enum_VH_0__9));
					SerializeField(s, nameof(autoScrollSpeed));
					SerializeField(s, nameof(autoScrollWaitTime));
					SerializeField(s, nameof(bool__12));
					SerializeField(s, nameof(autoScrollLoopGap));
					SerializeField(s, nameof(overridingHAlignment));
					SerializeField(s, nameof(overridingVAlignment));
					SerializeField(s, nameof(overridingAnchor));
				}
			} else {
				SerializeField(s, nameof(style));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(depth));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(area));
				SerializeField(s, nameof(maxWidth));
				SerializeField(s, nameof(rawText));
				SerializeField(s, nameof(locId));
				SerializeField(s, nameof(unsecureSource));
				SerializeField(s, nameof(overridingColor));
				SerializeField(s, nameof(GlobalScissor));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(scaleToMatchWithArea));
				}
				SerializeField(s, nameof(autoScrollSpeed));
				SerializeField(s, nameof(autoScrollWaitTime));
				SerializeField(s, nameof(autoScrollFirstWaitTime));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(autoScrollLoop));
				}
				SerializeField(s, nameof(autoScrollMode));
				SerializeField(s, nameof(autoScrollUpdate));
				SerializeField(s, nameof(autoScrollLoopGap));
				SerializeField(s, nameof(overridingHAlignment));
				SerializeField(s, nameof(overridingVAlignment));
				SerializeField(s, nameof(overridingAnchor));
				SerializeField(s, nameof(ViewportVisibility));
				SerializeField(s, nameof(AdaptToLangage));
				SerializeField(s, nameof(DontResizeForChinese));
			}
		}
		public enum Enum_GlobalScissor {
			[Serialize("NONE"     )] NONE = 0,
			[Serialize("SCISSOR_1")] SCISSOR_1 = 1,
			[Serialize("SCISSOR_2")] SCISSOR_2 = 2,
			[Serialize("SCISSOR_3")] SCISSOR_3 = 3,
		}
		public enum AutoScroll {
			[Serialize("AutoScroll_None"        )] None = 0,
			[Serialize("AutoScroll_BackAndForth")] BackAndForth = 1,
			[Serialize("AutoScroll_Loop"        )] Loop = 2,
			[Serialize("AutoScroll_LoopIfNeeded")] LoopIfNeeded = 3,
		}
		public enum AutoScrollUpdate {
			[Serialize("AutoScrollUpdate_Enable" )] Enable = 0,
			[Serialize("AutoScrollUpdate_Freeze" )] Freeze = 1,
			[Serialize("AutoScrollUpdate_Disable")] Disable = 2,
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
		public enum FONT_ALIGN2 {
			[Serialize("FONT_ALIGN_NONE"   )] NONE = -1,
			[Serialize("FONT_ALIGN_LEFT"   )] LEFT = 0,
			[Serialize("FONT_ALIGN_CENTER" )] CENTER = 1,
			[Serialize("FONT_ALIGN_RIGHT"  )] RIGHT = 2,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xD10CBEED;
	}
}

