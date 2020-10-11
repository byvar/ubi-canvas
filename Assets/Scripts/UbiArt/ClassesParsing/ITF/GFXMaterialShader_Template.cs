using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class GFXMaterialShader_Template {

		protected static Dictionary<string, Material> mats;

		public static Material GetShaderMaterial(GFXMaterialShader_Template shader = null) {
			if (shader == null) {
				return MapLoader.Loader.baseTransparentMaterial;
			} else {
				BlendMode blendSrc = BlendMode.SrcAlpha;
				BlendMode blendDst = BlendMode.OneMinusSrcAlpha;
				ZWrite zwrite = ZWrite.On;
				switch (shader.blendmode) {
					case GFXMaterialShader_Template.GFX_BLEND.ALPHA:
						blendSrc = BlendMode.SrcAlpha;
						blendDst = BlendMode.OneMinusSrcAlpha;
						break;
					case GFXMaterialShader_Template.GFX_BLEND.ALPHAPREMULT:
						blendSrc = BlendMode.One;
						blendDst = BlendMode.OneMinusSrcAlpha;
						break;
					case GFXMaterialShader_Template.GFX_BLEND.ADD:
						blendSrc = BlendMode.One;
						blendDst = BlendMode.One;
						break;
					case GFXMaterialShader_Template.GFX_BLEND.ADDALPHA:
						blendSrc = BlendMode.SrcAlpha;
						blendDst = BlendMode.One;
						break;
					case GFXMaterialShader_Template.GFX_BLEND.MUL:
						blendSrc = BlendMode.DstColor;
						blendDst = BlendMode.Zero;
						break;
					case GFXMaterialShader_Template.GFX_BLEND.MUL2X:
						blendSrc = BlendMode.DstColor;
						blendDst = BlendMode.SrcColor;
						break;
				}
				/*if (shader.renderFrontLight || shader.renderBackLight) {
					blendSrc = BlendMode.SrcAlpha;
					blendDst = BlendMode.One;
					zwrite = ZWrite.Off;
				}*/
				if (!(blendSrc == BlendMode.SrcAlpha && blendDst == BlendMode.OneMinusSrcAlpha && zwrite == ZWrite.On)) {
					string key = $"{blendSrc}-{blendDst}-{zwrite}";
					if (mats == null) {
						mats = new Dictionary<string, Material>();
					}
					if (!mats.ContainsKey(key)) {
						mats[key] = new Material(MapLoader.Loader.baseTransparentMaterial);
						mats[key].SetInt("_ZWrite", (int)zwrite);
						mats[key].SetFloat("_BlendSrc", (int)blendSrc);
						mats[key].SetFloat("_BlendDst", (int)blendDst);
					}
					return mats[key];
				}
				return MapLoader.Loader.baseTransparentMaterial;
			}
		}

		private enum ZWrite {
			Off = 0,
			On = 1
		}
	}
}
