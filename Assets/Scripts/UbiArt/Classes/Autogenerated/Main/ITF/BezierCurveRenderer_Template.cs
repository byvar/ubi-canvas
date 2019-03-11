using UnityEngine;

namespace UbiArt.ITF {
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
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
		public enum BezierDivMode {
			[Serialize("BezierDivMode_Adaptive1")] Adaptive1 = 5,
			[Serialize("BezierDivMode_Adaptive2")] Adaptive2 = 6,
			[Serialize("BezierDivMode_Adaptive4")] Adaptive4 = 7,
			[Serialize("BezierDivMode_Fix82"    )] Fix82 = 1,
			[Serialize("BezierDivMode_Fix22"    )] Fix22 = 2,
			[Serialize("BezierDivMode_Fix44"    )] Fix44 = 4,
		}
	}
}

