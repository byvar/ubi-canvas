namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class BezierCurveRenderer_Template : CSerializable {
		public float beginLength = 2;
		public float endLength = 2;
		public float beginWidth = 1;
		public float midWidth = 1;
		public float endWidth = 1;
		public float beginAlpha = 0;
		public float midAlpha = 1;
		public float endAlpha = 0;
		public Color beginColor = new Color(1, 1, 1, 0);
		public Color midColor = Color.White;
		public Color endColor = new Color(1, 1, 1, 0);
		public float tileLength = 1f;
		public bool stretchTexture;
		public float tessellationLength = 0.1f;
		public GFXPrimitiveParam primitiveParameters;
		public Path texture;
		public GFXMaterialSerializable material;
		public BezierDivMode divMode = BezierDivMode.Adaptive4;
		public float startUV;
		public Color color = Color.White;
		public Color fogColor;
		public UV_MODE uvMode;
		public byte Vita_00 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR) {
				beginLength = s.Serialize<float>(beginLength, name: "beginLength");
				endLength = s.Serialize<float>(endLength, name: "endLength");
				beginWidth = s.Serialize<float>(beginWidth, name: "beginWidth");
				midWidth = s.Serialize<float>(midWidth, name: "midWidth");
				endWidth = s.Serialize<float>(endWidth, name: "endWidth");
				beginAlpha = s.Serialize<float>(beginAlpha, name: "beginAlpha");
				midAlpha = s.Serialize<float>(midAlpha, name: "midAlpha");
				endAlpha = s.Serialize<float>(endAlpha, name: "endAlpha");
				startUV = s.Serialize<float>(startUV, name: "startUV");
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				color = s.SerializeObject<Color>(color, name: "color");
				fogColor = s.SerializeObject<Color>(fogColor, name: "fogColor");
				texture = s.SerializeObject<Path>(texture, name: "texture");
				uvMode = s.Serialize<UV_MODE>(uvMode, name: "uvMode");
				tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
			} else {
				beginLength = s.Serialize<float>(beginLength, name: "beginLength");
				endLength = s.Serialize<float>(endLength, name: "endLength");
				beginWidth = s.Serialize<float>(beginWidth, name: "beginWidth");
				midWidth = s.Serialize<float>(midWidth, name: "midWidth");
				endWidth = s.Serialize<float>(endWidth, name: "endWidth");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					beginAlpha = s.Serialize<float>(beginAlpha, name: "beginAlpha");
					midAlpha = s.Serialize<float>(midAlpha, name: "midAlpha");
					endAlpha = s.Serialize<float>(endAlpha, name: "endAlpha");
				}
				beginColor = s.SerializeObject<Color>(beginColor, name: "beginColor");
				midColor = s.SerializeObject<Color>(midColor, name: "midColor");
				endColor = s.SerializeObject<Color>(endColor, name: "endColor");
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				stretchTexture = s.Serialize<bool>(stretchTexture, name: "stretchTexture");
				tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
				primitiveParameters = s.SerializeObject<GFXPrimitiveParam>(primitiveParameters, name: "primitiveParameters");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				if (s.Settings.platform == Settings.Platform.Vita) {
					uvMode = s.Serialize<UV_MODE>(uvMode, name: "uvMode");
					Vita_00 = s.Serialize<byte>(Vita_00, name: nameof(Vita_00));
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				divMode = s.Serialize<BezierDivMode>(divMode, name: "divMode");
			}
		}
		public enum BezierDivMode {
			[Serialize("BezierDivMode_Adaptive1")] Adaptive1 = 5,
			[Serialize("BezierDivMode_Adaptive2")] Adaptive2 = 6,
			[Serialize("BezierDivMode_Adaptive4")] Adaptive4 = 7,
			[Serialize("BezierDivMode_Fix82"    )] Fix82 = 1,
			[Serialize("BezierDivMode_Fix22"    )] Fix22 = 2,
			[Serialize("BezierDivMode_Fix44"    )] Fix44 = 4,
		}
		public enum UV_MODE {
			[Serialize("UV_MODE_OPTIMUM")] OPTIMUM = 0,
			[Serialize("UV_MODE_SPEED"  )] SPEED = 1,
		}
	}
}

