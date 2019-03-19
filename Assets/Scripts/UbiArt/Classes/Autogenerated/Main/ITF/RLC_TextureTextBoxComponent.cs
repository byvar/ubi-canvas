using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TextureTextBoxComponent : TextureGraphicComponent {
		[Serialize("is2D"                        )] public bool is2D;
		[Serialize("Text"                        )] public string Text;
		[Serialize("fontSize"                    )] public uint fontSize;
		[Serialize("fontAutoScale"               )] public bool fontAutoScale;
		[Serialize("fontAutoFit"                 )] public bool fontAutoFit;
		[Serialize("shadowOffset"                )] public Vector2 shadowOffset;
		[Serialize("textureSize"                 )] public Vector2 textureSize;
		[Serialize("textColor"                   )] public Color textColor;
		[Serialize("textShadowColor"             )] public Color textShadowColor;
		[Serialize("unsecureSource"              )] public bool unsecureSource;
		[Serialize("AllowAutomaticShowOnActivate")] public bool AllowAutomaticShowOnActivate;
		[Serialize("textHAlignement"             )] public FONT_ALIGN textHAlignement;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(is2D));
			SerializeField(s, nameof(Text));
			SerializeField(s, nameof(fontSize));
			SerializeField(s, nameof(fontAutoScale));
			SerializeField(s, nameof(fontAutoFit));
			SerializeField(s, nameof(shadowOffset));
			SerializeField(s, nameof(textureSize));
			SerializeField(s, nameof(textColor));
			SerializeField(s, nameof(textShadowColor));
			SerializeField(s, nameof(unsecureSource));
			SerializeField(s, nameof(AllowAutomaticShowOnActivate));
			SerializeField(s, nameof(textHAlignement));
		}
		public enum FONT_ALIGN {
			[Serialize("FONT_ALIGN_NONE"   )] NONE = -1,
			[Serialize("FONT_ALIGN_LEFT"   )] LEFT = 0,
			[Serialize("FONT_ALIGN_CENTER" )] CENTER = 1,
			[Serialize("FONT_ALIGN_RIGHT"  )] RIGHT = 2,
			[Serialize("FONT_ALIGN_JUSTIFY")] JUSTIFY = 3,
		}
		public override uint? ClassCRC => 0x7669E5B4;
	}
}

