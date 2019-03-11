using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFTERFX : CSerializable {
		[Serialize("Type"       )] public AFX Type;
		[Serialize("paramF"     )] public CArray<float> paramF;
		[Serialize("paramI"     )] public CArray<int> paramI;
		[Serialize("paramC"     )] public CArray<Color> paramC;
		[Serialize("lifeTime"   )] public float lifeTime;
		[Serialize("colorTarget")] public Color colorTarget;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Type));
			SerializeField(s, nameof(paramF));
			SerializeField(s, nameof(paramI));
			SerializeField(s, nameof(paramC));
			SerializeField(s, nameof(lifeTime));
			SerializeField(s, nameof(colorTarget));
		}
		public enum AFX {
			[Serialize("AFX_None"          )] None = 0,
			[Serialize("AFX_Blur"          )] Blur = 1,
			[Serialize("AFX_Glow"          )] Glow = 2,
			[Serialize("AFX_Remanence"     )] Remanence = 3,
			[Serialize("AFX_DOF"           )] DOF = 4,
			[Serialize("AFX_RayCenter"     )] RayCenter = 5,
			[Serialize("AFX_ColorSetting"  )] ColorSetting = 6,
			[Serialize("AFX_ColorRemap"    )] ColorRemap = 7,
			[Serialize("AFX_ColorLevels"   )] ColorLevels = 8,
			[Serialize("AFX_Fade"          )] Fade = 9,
			[Serialize("AFX_Bright"        )] Bright = 10,
			[Serialize("AFX_AddSceneAndMul")] AddSceneAndMul = 11,
			[Serialize("AFX_objectsGlow"   )] objectsGlow = 12,
			[Serialize("AFX_simpleBlend"   )] simpleBlend = 13,
		}
	}
}

