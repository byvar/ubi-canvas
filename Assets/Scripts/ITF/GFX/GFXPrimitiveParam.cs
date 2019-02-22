using UnityEngine;

namespace ITF {
	public class GFXPrimitiveParam : BaseObject {
		[Serialize(0, "colorFactor")] public Color colorFactor;
		[Serialize(1, "FrontLightBrightness")] public float frontLightBrightness;
		[Serialize(2, "FrontLightContrast")] public float frontLightContrast;
		[Serialize(3, "BackLightBrightness")] public float backLightBrightness;
		[Serialize(4, "BackLightContrast")] public float backLightContrast;
		[Serialize(5, "colorFog")] public Color colorFog;
		[Serialize(6, "DynamicFogFactor")] public float dynamicFogFactor;
		[Serialize(7, "useStaticFog")] public bool useStaticFog;
		[Serialize(8, "RenderInReflections")] public bool renderInReflections;
		//[Serialize(9, "RenderToTexture")] public bool renderToTexture;
		[Serialize(10, "gfxOccludeInfo")] public GfxOccludeInfo gfxOccludeInfo;


		public GFXPrimitiveParam(Reader reader) : base(reader) {
		}

		public enum GfxOccludeInfo {
			Default,
			BigOpaque,
			SmallOrTransparent,
			ZPassOnly
		}
	}
}
