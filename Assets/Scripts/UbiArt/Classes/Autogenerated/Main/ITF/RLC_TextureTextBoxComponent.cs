using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TextureTextBoxComponent : TextureGraphicComponent {
		public bool is2D;
		public string Text;
		public uint fontSize;
		public bool fontAutoScale;
		public bool fontAutoFit;
		public Vec2d shadowOffset;
		public Vec2d textureSize;
		public Color textColor;
		public Color textShadowColor;
		public bool unsecureSource;
		public bool AllowAutomaticShowOnActivate;
		public FONT_ALIGN textHAlignement;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			is2D = s.Serialize<bool>(is2D, name: "is2D");
			Text = s.Serialize<string>(Text, name: "Text");
			fontSize = s.Serialize<uint>(fontSize, name: "fontSize");
			fontAutoScale = s.Serialize<bool>(fontAutoScale, name: "fontAutoScale");
			fontAutoFit = s.Serialize<bool>(fontAutoFit, name: "fontAutoFit");
			shadowOffset = s.SerializeObject<Vec2d>(shadowOffset, name: "shadowOffset");
			textureSize = s.SerializeObject<Vec2d>(textureSize, name: "textureSize");
			textColor = s.SerializeObject<Color>(textColor, name: "textColor");
			textShadowColor = s.SerializeObject<Color>(textShadowColor, name: "textShadowColor");
			unsecureSource = s.Serialize<bool>(unsecureSource, name: "unsecureSource");
			AllowAutomaticShowOnActivate = s.Serialize<bool>(AllowAutomaticShowOnActivate, name: "AllowAutomaticShowOnActivate");
			textHAlignement = s.Serialize<FONT_ALIGN>(textHAlignement, name: "textHAlignement");
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

