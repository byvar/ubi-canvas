using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class BezierCurveRenderer_Template : CSerializable {
		[Serialize("beginLength"        )] public float beginLength;
		[Serialize("endLength"          )] public float endLength;
		[Serialize("beginWidth"         )] public float beginWidth;
		[Serialize("midWidth"           )] public float midWidth;
		[Serialize("endWidth"           )] public float endWidth;
		[Serialize("beginAlpha"         )] public float beginAlpha;
		[Serialize("midAlpha"           )] public float midAlpha;
		[Serialize("endAlpha"           )] public float endAlpha;
		[Serialize("beginColor"         )] public Color beginColor;
		[Serialize("midColor"           )] public Color midColor;
		[Serialize("endColor"           )] public Color endColor;
		[Serialize("tileLength"         )] public float tileLength;
		[Serialize("stretchTexture"     )] public bool stretchTexture;
		[Serialize("tessellationLength" )] public float tessellationLength;
		[Serialize("primitiveParameters")] public GFXPrimitiveParam primitiveParameters;
		[Serialize("texture"            )] public Path texture;
		[Serialize("material"           )] public GFXMaterialSerializable material;
		[Serialize("divMode"            )] public BezierDivMode divMode;
		[Serialize("float__0"           )] public float float__0;
		[Serialize("float__1"           )] public float float__1;
		[Serialize("float__2"           )] public float float__2;
		[Serialize("float__3"           )] public float float__3;
		[Serialize("float__4"           )] public float float__4;
		[Serialize("float__5"           )] public float float__5;
		[Serialize("float__6"           )] public float float__6;
		[Serialize("float__7"           )] public float float__7;
		[Serialize("float__8"           )] public float float__8;
		[Serialize("float__9"           )] public float float__9;
		[Serialize("Color__10"          )] public Color Color__10;
		[Serialize("Color__11"          )] public Color Color__11;
		[Serialize("Path__12"           )] public Path Path__12;
		[Serialize("Enum_RJR_0__13"     )] public Enum_RJR_0 Enum_RJR_0__13;
		[Serialize("float__14"          )] public float float__14;
		[Serialize("float__15"          )] public float float__15;
		[Serialize("float__16"          )] public float float__16;
		[Serialize("float__17"          )] public float float__17;
		[Serialize("float__18"          )] public float float__18;
		[Serialize("float__19"          )] public float float__19;
		[Serialize("float__20"          )] public float float__20;
		[Serialize("float__21"          )] public float float__21;
		[Serialize("float__22"          )] public float float__22;
		[Serialize("float__23"          )] public float float__23;
		[Serialize("float__24"          )] public float float__24;
		[Serialize("Color__25"          )] public Color Color__25;
		[Serialize("Color__26"          )] public Color Color__26;
		[Serialize("Path__27"           )] public Path Path__27;
		[Serialize("Enum_RFR_0__28"     )] public Enum_RFR_0 Enum_RFR_0__28;
		[Serialize("float__29"          )] public float float__29;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(Color__10));
				SerializeField(s, nameof(Color__11));
				SerializeField(s, nameof(Path__12));
				SerializeField(s, nameof(Enum_RJR_0__13));
				SerializeField(s, nameof(float__14));
			} else if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(float__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(float__19));
				SerializeField(s, nameof(float__20));
				SerializeField(s, nameof(float__21));
				SerializeField(s, nameof(float__22));
				SerializeField(s, nameof(float__23));
				SerializeField(s, nameof(float__24));
				SerializeField(s, nameof(Color__25));
				SerializeField(s, nameof(Color__26));
				SerializeField(s, nameof(Path__27));
				SerializeField(s, nameof(Enum_RFR_0__28));
				SerializeField(s, nameof(float__29));
			} else {
				SerializeField(s, nameof(beginLength));
				SerializeField(s, nameof(endLength));
				SerializeField(s, nameof(beginWidth));
				SerializeField(s, nameof(midWidth));
				SerializeField(s, nameof(endWidth));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(beginAlpha));
					SerializeField(s, nameof(midAlpha));
					SerializeField(s, nameof(endAlpha));
				}
				SerializeField(s, nameof(beginColor));
				SerializeField(s, nameof(midColor));
				SerializeField(s, nameof(endColor));
				SerializeField(s, nameof(tileLength));
				SerializeField(s, nameof(stretchTexture));
				SerializeField(s, nameof(tessellationLength));
				SerializeField(s, nameof(primitiveParameters));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(divMode));
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
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
	}
}

