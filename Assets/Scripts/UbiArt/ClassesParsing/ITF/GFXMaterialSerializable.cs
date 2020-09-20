using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class GFXMaterialSerializable {
		public GenericFile<GFXMaterialShader_Template> shader;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(shaderPath, (extS) => {
					if (l.msh.ContainsKey(shaderPath.stringID)) {
						shader = l.msh[shaderPath.stringID];
					} else {
						shader = extS.SerializeObject<GenericFile<GFXMaterialShader_Template>>(shader);
						l.msh[shaderPath.stringID] = shader;
					}
				});
			}
		}
		/*protected Dictionary<GFXMaterialShader_Template, Material> materials = new Dictionary<GFXMaterialShader_Template, Material>();
		protected Material materialShaderNull = null;*/

		public Material GetUnityMaterial(GFXMaterialShader_Template shader = null) {
			if (shader == null) shader = (this.shader != null ? this.shader.obj : null);
			/*if (shader == null) {
				if (materialShaderNull != null) {
					return new Material(materialShaderNull);
				}
			} else if (materials.ContainsKey(shader)) {
				return new Material(materials[shader]);
			}*/
			Shader sh = Shader.Find("Custom/UbiArtAlpha");
			Material mat = new Material(sh);
			//Material mat = new Material(MapLoader.Loader.baseTransparentMaterial);
			if (shader != null) {
				mat.SetVector("_ShaderParams", new Vector4(
					shader.renderRegular ? 1f : 0f,
					shader.renderFrontLight ? 1f : 0f,
					shader.renderBackLight ? 1f : 0f,
					0f));
				mat.SetVector("_ShaderParams2", new Vector4(
					(int)shader.materialtype2,
					(int)shader.blendmode,
					0f,
					0f));
				BlendMode blendSrc = BlendMode.SrcAlpha;
				BlendMode blendDst = BlendMode.OneMinusSrcAlpha;
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
				mat.SetInt("_ZWrite", (int)ZWrite.On);
				if (shader.renderFrontLight || shader.renderBackLight) {
					blendSrc = BlendMode.SrcAlpha;
					blendDst = BlendMode.One;
					mat.SetInt("_ZWrite", (int)ZWrite.Off);
				}
				mat.SetFloat("_BlendSrc", (int)blendSrc);
				mat.SetFloat("_BlendDst", (int)blendDst);
			}
			if (textureSet != null) {
				mat.SetVector("_UseTextures", new Vector4(
					textureSet.tex_diffuse != null ? 1f : 0f,
					textureSet.tex_back_light != null ? 1f : 0f,
					0f, 0f));
				if (textureSet.tex_diffuse != null) mat.SetTexture("_Diffuse", textureSet.tex_diffuse.Texture);
				if (textureSet.tex_back_light != null) mat.SetTexture("_BackLight", textureSet.tex_back_light.Texture);
			}
			/*if (shader != null) {
				materials[shader] = mat;
			} else materialShaderNull = mat;
			return new Material(mat);*/
			return mat;
		}

		private enum ZWrite {
			Off = 0,
			On = 1
		}
	}
}
