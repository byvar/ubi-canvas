using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class GFXMaterialSerializable {
		public GenericFile<GFXMaterialShader_Template> shader;
		MaterialPropertyBlock mpb;

		protected static Dictionary<string, Material> mats;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Context l = s.Context;
				l.LoadFile<GenericFile<GFXMaterialShader_Template>>(shaderPath, result => shader = result);
			}
		}

		public Material GetShaderMaterial(GFXMaterialShader_Template shader = null) {
			if (shader == null) shader = (this.shader != null ? this.shader.obj : null);
			return GFXMaterialShader_Template.GetShaderMaterial(shader);
		}

		public void FillUnityMaterialPropertyBlock(Renderer r, int index = 0, GFXMaterialShader_Template shader = null) {
			if (shader == null) shader = (this.shader != null ? this.shader.obj : null);
			if (mpb == null) mpb = new MaterialPropertyBlock();
			if (shader == null) {
				r.GetPropertyBlock(mpb, index);
			} else {
				r.GetPropertyBlock(mpb, index);
				mpb.SetVector("_ShaderParams", new Vector4(
					shader.renderRegular ? 1f : 0f,
					shader.renderFrontLight ? 1f : 0f,
					shader.renderBackLight ? 1f : 0f,
					0f));
				mpb.SetVector("_ShaderParams2", new Vector4(
					(int)shader.materialtype2,
					(int)shader.blendmode,
					0f,
					0f));
			}
			if (textureSet != null) {
				mpb.SetVector("_UseTextures", new Vector4(
					textureSet.tex_diffuse != null ? 1f : 0f,
					textureSet.tex_back_light != null ? 1f : 0f,
					0f,
					textureSet.tex_separateAlpha != null ? 1f : 0f));
				if (textureSet.tex_diffuse != null) {
					mpb.SetTexture("_Diffuse", textureSet.tex_diffuse.Texture);
					mpb.SetVector("_Diffuse_ST", new Vector4(1,1,0,0));
				}
				if (textureSet.tex_back_light != null) {
					mpb.SetTexture("_BackLight", textureSet.tex_back_light.Texture);
					mpb.SetVector("_BackLight_ST", new Vector4(1,1,0,0));
				}
				if (textureSet.tex_separateAlpha != null) {
					mpb.SetTexture("_SeparateAlpha", textureSet.tex_separateAlpha.Texture);
					mpb.SetVector("_SeparateAlpha_ST", new Vector4(1, 1, 0, 0));
				}
			}

			// Set property block
			r.SetPropertyBlock(mpb, index);
		}

		private enum ZWrite {
			Off = 0,
			On = 1
		}
	}
}
