using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class TextBoxComponent : UIComponent {
		public uint style;
		public Vec2d offset;
		public Vec2d scale;
		public Vec2d area;
		public float maxWidth;
		public string rawText;
		public LocalisationId locId;
		public bool unsecureSource;
		public Enum_GlobalScissor GlobalScissor;
		public bool scaleToMatchWithArea;
		public float autoScrollSpeed;
		public float autoScrollWaitTime;
		public Color overridingColor;
		public FONT_ALIGN overridingHAlignment;
		public FONT_ALIGN2 overridingHAlignment2;
		public FONT overridingVAlignment;
		public float depthOffset;
		public uint ViewportVisibility;
		public bool AdaptToLangage;
		public Vec2d offsetLangage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					style = s.Serialize<uint>(style, name: "style");
					offset = s.SerializeObject<Vec2d>(offset, name: "offset");
					scale = s.SerializeObject<Vec2d>(scale, name: "scale");
					area = s.SerializeObject<Vec2d>(area, name: "area");
					maxWidth = s.Serialize<float>(maxWidth, name: "maxWidth");
					rawText = s.Serialize<string>(rawText, name: "rawText");
					locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
					scaleToMatchWithArea = s.Serialize<bool>(scaleToMatchWithArea, name: "scaleToMatchWithArea");
					autoScrollSpeed = s.Serialize<float>(autoScrollSpeed, name: "autoScrollSpeed");
					autoScrollWaitTime = s.Serialize<float>(autoScrollWaitTime, name: "autoScrollWaitTime");
					overridingColor = s.SerializeObject<Color>(overridingColor, name: "overridingColor");
					overridingHAlignment2 = s.Serialize<FONT_ALIGN2>(overridingHAlignment2, name: "overridingHAlignment2");
					overridingVAlignment = s.Serialize<FONT>(overridingVAlignment, name: "overridingVAlignment");
					depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					style = s.Serialize<uint>(style, name: "style");
					offset = s.SerializeObject<Vec2d>(offset, name: "offset");
					scale = s.SerializeObject<Vec2d>(scale, name: "scale");
					area = s.SerializeObject<Vec2d>(area, name: "area");
					maxWidth = s.Serialize<float>(maxWidth, name: "maxWidth");
					rawText = s.Serialize<string>(rawText, name: "rawText");
					locId = (LocalisationId)s.SerializeObject<StringID>((StringID)locId, name: "locId");
					scaleToMatchWithArea = s.Serialize<bool>(scaleToMatchWithArea, name: "scaleToMatchWithArea");
					autoScrollSpeed = s.Serialize<float>(autoScrollSpeed, name: "autoScrollSpeed");
					autoScrollWaitTime = s.Serialize<float>(autoScrollWaitTime, name: "autoScrollWaitTime");
					overridingColor = s.SerializeObject<Color>(overridingColor, name: "overridingColor");
					overridingHAlignment2 = s.Serialize<FONT_ALIGN2>(overridingHAlignment2, name: "overridingHAlignment2");
					overridingVAlignment = s.Serialize<FONT>(overridingVAlignment, name: "overridingVAlignment");
					depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					style = s.Serialize<uint>(style, name: "style");
					offset = s.SerializeObject<Vec2d>(offset, name: "offset");
					scale = s.SerializeObject<Vec2d>(scale, name: "scale");
					area = s.SerializeObject<Vec2d>(area, name: "area");
					maxWidth = s.Serialize<float>(maxWidth, name: "maxWidth");
					rawText = s.Serialize<string>(rawText, name: "rawText");
					locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
					unsecureSource = s.Serialize<bool>(unsecureSource, name: "unsecureSource");
					GlobalScissor = s.Serialize<Enum_GlobalScissor>(GlobalScissor, name: "GlobalScissor");
					if (s.HasFlags(SerializeFlags.Flags8)) {
						scaleToMatchWithArea = s.Serialize<bool>(scaleToMatchWithArea, name: "scaleToMatchWithArea");
					}
					autoScrollSpeed = s.Serialize<float>(autoScrollSpeed, name: "autoScrollSpeed");
					autoScrollWaitTime = s.Serialize<float>(autoScrollWaitTime, name: "autoScrollWaitTime");
					overridingColor = s.SerializeObject<Color>(overridingColor, name: "overridingColor");
					overridingHAlignment = s.Serialize<FONT_ALIGN>(overridingHAlignment, name: "overridingHAlignment");
					overridingVAlignment = s.Serialize<FONT>(overridingVAlignment, name: "overridingVAlignment");
					depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
					ViewportVisibility = s.Serialize<uint>(ViewportVisibility, name: "ViewportVisibility");
					AdaptToLangage = s.Serialize<bool>(AdaptToLangage, name: "AdaptToLangage");
					offsetLangage = s.SerializeObject<Vec2d>(offsetLangage, name: "offsetLangage");
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
		public enum FONT_ALIGN2 {
			[Serialize("FONT_ALIGN_NONE"   )] NONE = -1,
			[Serialize("FONT_ALIGN_LEFT"   )] LEFT = 0,
			[Serialize("FONT_ALIGN_CENTER" )] CENTER = 1,
			[Serialize("FONT_ALIGN_RIGHT"  )] RIGHT = 2,
		}
		public override uint? ClassCRC => 0x13E9D108;
	}
}

