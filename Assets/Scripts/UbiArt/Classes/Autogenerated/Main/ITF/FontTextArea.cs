using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class FontTextArea : CSerializable {
		public FontTextArea.FontSet FontTextArea_FontSet__0;
		public FontTextArea.Style FontTextArea_Style__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				FontTextArea_FontSet__0 = s.SerializeObject<FontTextArea.FontSet>(FontTextArea_FontSet__0, name: "FontTextArea.FontSet__0");
				FontTextArea_Style__1 = s.SerializeObject<FontTextArea.Style>(FontTextArea_Style__1, name: "FontTextArea.Style__1");
			} else {
			}
		}
		[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
		public partial class FontSet : CSerializable {
			public Path _default;
			public Path japanese;
			public Path korean;
			public Path tradChinese;
			public Path simpleChinese;
			public Path russian;
			public Path arabic;
			public Path thai;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
					_default = s.SerializeObject<Path>(_default, name: "default");
					japanese = s.SerializeObject<Path>(japanese, name: "japanese");
					korean = s.SerializeObject<Path>(korean, name: "korean");
					tradChinese = s.SerializeObject<Path>(tradChinese, name: "tradChinese");
					simpleChinese = s.SerializeObject<Path>(simpleChinese, name: "simpleChinese");
					russian = s.SerializeObject<Path>(russian, name: "russian");
				} else {
					_default = s.SerializeObject<Path>(_default, name: "default");
					japanese = s.SerializeObject<Path>(japanese, name: "japanese");
					korean = s.SerializeObject<Path>(korean, name: "korean");
					tradChinese = s.SerializeObject<Path>(tradChinese, name: "tradChinese");
					simpleChinese = s.SerializeObject<Path>(simpleChinese, name: "simpleChinese");
					russian = s.SerializeObject<Path>(russian, name: "russian");
					arabic = s.SerializeObject<Path>(arabic, name: "arabic");
					thai = s.SerializeObject<Path>(thai, name: "thai");
				}
			}
		}
		[Games(GameFlags.COL | GameFlags.VH | GameFlags.RA)]
		public partial class Style : CSerializable {
			public Path fontPath;
			public FontTextArea.FontSet fontSet;
			public float fontSize;
			public Color color;
			public Vec2d shadowOffset;
			public Color shadowColor;
			public float lineSpacing;
			public float paragraphSpacing;
			public AREA_ANCHOR anchor;
			public FONT_ALIGN hAlignment;
			public FONT_ALIGN2 hAlignment2;
			public FONT vAlignment;
			public bool useGradient;
			public float gradientSize;
			public float gradientOffset;
			public Color gradientColor;
			public float charSpacing;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.COL) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						fontPath = s.SerializeObject<Path>(fontPath, name: "fontPath");
					}
					fontSet = s.SerializeObject<FontTextArea.FontSet>(fontSet, name: "fontSet");
					fontSize = s.Serialize<float>(fontSize, name: "fontSize");
					color = s.SerializeObject<Color>(color, name: "color");
					shadowOffset = s.SerializeObject<Vec2d>(shadowOffset, name: "shadowOffset");
					shadowColor = s.SerializeObject<Color>(shadowColor, name: "shadowColor");
					lineSpacing = s.Serialize<float>(lineSpacing, name: "lineSpacing");
					paragraphSpacing = s.Serialize<float>(paragraphSpacing, name: "paragraphSpacing");
					anchor = s.Serialize<AREA_ANCHOR>(anchor, name: "anchor");
					hAlignment2 = s.Serialize<FONT_ALIGN2>(hAlignment2, name: "hAlignment");
					vAlignment = s.Serialize<FONT>(vAlignment, name: "vAlignment");
					useGradient = s.Serialize<bool>(useGradient, name: "useGradient", options: CSerializerObject.Options.BoolAsByte);
					gradientSize = s.Serialize<float>(gradientSize, name: "gradientSize");
					gradientOffset = s.Serialize<float>(gradientOffset, name: "gradientOffset");
					gradientColor = s.SerializeObject<Color>(gradientColor, name: "gradientColor");
					charSpacing = s.Serialize<float>(charSpacing, name: "charSpacing");
				} else if (Settings.s.game == Settings.Game.RL) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						fontPath = s.SerializeObject<Path>(fontPath, name: "fontPath");
					}
					fontSet = s.SerializeObject<FontTextArea.FontSet>(fontSet, name: "fontSet");
					fontSize = s.Serialize<float>(fontSize, name: "fontSize");
					color = s.SerializeObject<Color>(color, name: "color");
					shadowOffset = s.SerializeObject<Vec2d>(shadowOffset, name: "shadowOffset");
					shadowColor = s.SerializeObject<Color>(shadowColor, name: "shadowColor");
					lineSpacing = s.Serialize<float>(lineSpacing, name: "lineSpacing");
					paragraphSpacing = s.Serialize<float>(paragraphSpacing, name: "paragraphSpacing");
					anchor = s.Serialize<AREA_ANCHOR>(anchor, name: "anchor");
					hAlignment2 = s.Serialize<FONT_ALIGN2>(hAlignment2, name: "hAlignment");
					vAlignment = s.Serialize<FONT>(vAlignment, name: "vAlignment");
					useGradient = s.Serialize<bool>(useGradient, name: "useGradient");
					gradientSize = s.Serialize<float>(gradientSize, name: "gradientSize");
					gradientOffset = s.Serialize<float>(gradientOffset, name: "gradientOffset");
					gradientColor = s.SerializeObject<Color>(gradientColor, name: "gradientColor");
					charSpacing = s.Serialize<float>(charSpacing, name: "charSpacing");
				} else if (Settings.s.game == Settings.Game.VH) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						fontPath = s.SerializeObject<Path>(fontPath, name: "fontPath");
					}
					fontSet = s.SerializeObject<FontTextArea.FontSet>(fontSet, name: "fontSet");
					fontSize = s.Serialize<float>(fontSize, name: "fontSize");
					color = s.SerializeObject<Color>(color, name: "color");
					shadowOffset = s.SerializeObject<Vec2d>(shadowOffset, name: "shadowOffset");
					shadowColor = s.SerializeObject<Color>(shadowColor, name: "shadowColor");
					lineSpacing = s.Serialize<float>(lineSpacing, name: "lineSpacing");
					paragraphSpacing = s.Serialize<float>(paragraphSpacing, name: "paragraphSpacing");
					anchor = s.Serialize<AREA_ANCHOR>(anchor, name: "anchor");
					hAlignment = s.Serialize<FONT_ALIGN>(hAlignment, name: "hAlignment");
					vAlignment = s.Serialize<FONT>(vAlignment, name: "vAlignment");
					useGradient = s.Serialize<bool>(useGradient, name: "useGradient");
					gradientSize = s.Serialize<float>(gradientSize, name: "gradientSize");
					gradientOffset = s.Serialize<float>(gradientOffset, name: "gradientOffset");
					gradientColor = s.SerializeObject<Color>(gradientColor, name: "gradientColor");
					charSpacing = s.Serialize<float>(charSpacing, name: "charSpacing");
				} else {
					fontSet = s.SerializeObject<FontTextArea.FontSet>(fontSet, name: "fontSet");
					fontSize = s.Serialize<float>(fontSize, name: "fontSize");
					color = s.SerializeObject<Color>(color, name: "color");
					shadowOffset = s.SerializeObject<Vec2d>(shadowOffset, name: "shadowOffset");
					shadowColor = s.SerializeObject<Color>(shadowColor, name: "shadowColor");
					lineSpacing = s.Serialize<float>(lineSpacing, name: "lineSpacing");
					paragraphSpacing = s.Serialize<float>(paragraphSpacing, name: "paragraphSpacing");
					anchor = s.Serialize<AREA_ANCHOR>(anchor, name: "anchor");
					hAlignment = s.Serialize<FONT_ALIGN>(hAlignment, name: "hAlignment");
					vAlignment = s.Serialize<FONT>(vAlignment, name: "vAlignment");
					useGradient = s.Serialize<bool>(useGradient, name: "useGradient");
					gradientSize = s.Serialize<float>(gradientSize, name: "gradientSize");
					gradientOffset = s.Serialize<float>(gradientOffset, name: "gradientOffset");
					gradientColor = s.SerializeObject<Color>(gradientColor, name: "gradientColor");
					charSpacing = s.Serialize<float>(charSpacing, name: "charSpacing");
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
			public enum FONT_ALIGN2 {
				[Serialize("FONT_ALIGN_NONE")] NONE = -1,
				[Serialize("FONT_ALIGN_LEFT")] LEFT = 0,
				[Serialize("FONT_ALIGN_CENTER")] CENTER = 1,
				[Serialize("FONT_ALIGN_RIGHT")] RIGHT = 2,
			}
		}
	}
}

