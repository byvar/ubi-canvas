using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXPrimitiveParam {
		public void FillMaterialParams(Context context, MaterialPropertyBlock mpb) {
			mpb.SetColor("_ColorFactor", TotalColorFactor.GetUnityColor());
			mpb.SetColor("_LightConfig", new Vector4(
				FrontLightBrightness,
				FrontLightContrast,
				BackLightBrightness,
				BackLightContrast));

			bool unityUseGlobalLighting = false;
			if (context?.Settings?.Game != null && (context.Settings.Game == Game.RM || context.Settings.Game == Game.RA)) {
				unityUseGlobalLighting = UseGlobalLighting;
			}

			mpb.SetVector("_PrimitiveParams1", new Vector4(
				useStaticFog ? 1f : 0f,
				unityUseGlobalLighting ? 1f : 0f,
				0f,
				0f));
			mpb.SetColor("_ColorFog", colorFog.GetUnityColor());
		}
		public static void FillMaterialParamsDefault(Context context, MaterialPropertyBlock mpb) {
			mpb.SetColor("_ColorFactor", UnityEngine.Color.white);
			mpb.SetColor("_LightConfig", new Vector4(0, 1, 0, 1));
			mpb.SetColor("_ColorFog", Vector4.zero);
			bool unityUseGlobalLighting = false;
			if (context?.Settings?.Game != null && (context.Settings.Game == Game.RM || context.Settings.Game == Game.RA)) {
				unityUseGlobalLighting = true;
			}
			mpb.SetVector("_PrimitiveParams1", new Vector4(0, unityUseGlobalLighting ? 1f : 0f, 0, 0));
		}
	}
}
