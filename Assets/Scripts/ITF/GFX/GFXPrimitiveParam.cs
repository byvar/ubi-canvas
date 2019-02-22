using UnityEngine;

namespace ITF {
	public class GFXPrimitiveParam : BaseObject {
		public Color colorFactor;
		public float frontLightBrightness;
		public float frontLightContrast;
		public float backLightBrightness;
		public float backLightContrast;
		public Color colorFog;
		public float dynamicFogFactor;
		public bool useStaticFog;
		public bool renderInReflections;
		public bool renderToTexture;
		public GfxOccludeInfo gfxOccludeInfo;


		public GFXPrimitiveParam(Reader reader) : base(reader) {
			colorFactor = reader.ReadColor();
			frontLightBrightness = reader.ReadSingle();
			frontLightContrast = reader.ReadSingle();
			backLightBrightness = reader.ReadSingle();
			backLightContrast = reader.ReadSingle();
			colorFog = reader.ReadColor();
			dynamicFogFactor = reader.ReadSingle();
			useStaticFog = reader.ReadBoolean();
			renderInReflections = reader.ReadBoolean();
			gfxOccludeInfo = (GfxOccludeInfo)reader.ReadUInt32();
		}

		public enum GfxOccludeInfo {
			Default,
			BigOpaque,
			SmallOrTransparent,
			ZPassOnly
		}
	}
}
