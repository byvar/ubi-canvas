using UnityEngine;

namespace UbiArt.ITF {
	public static class GFXMaterialSerializableExtensions {
		private static MaterialPropertyBlock mpb;

		public static Material GetShaderMaterial(this GFXMaterialSerializable gfxmat, GFXMaterialShader_Template shader = null) {
			if (shader == null) shader = (gfxmat.shader != null ? gfxmat.shader.obj : null);
			return GFXMaterialShader_Template.GetShaderMaterial(shader);
		}

		public static void FillUnityMaterialPropertyBlock(this GFXMaterialSerializable gfxmat, Context c, Renderer r, int index = 0, GFXMaterialShader_Template shader = null) {
			if (shader == null) shader = (gfxmat.shader != null ? gfxmat.shader.obj : null);
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
			if (gfxmat.textureSet != null) {
				mpb.SetVector("_UseTextures", new Vector4(
					gfxmat.textureSet.tex_diffuse != null ? 1f : 0f,
					gfxmat.textureSet.tex_back_light != null ? 1f : 0f,
					0f,
					gfxmat.textureSet.tex_separateAlpha != null ? 1f : 0f));
				if (gfxmat.textureSet.tex_diffuse != null) {
					mpb.SetTexture("_Diffuse", gfxmat.textureSet.tex_diffuse.GetUnityTexture(c).Texture);
					mpb.SetVector("_Diffuse_ST", new Vector4(1,1,0,0));
				}
				if (gfxmat.textureSet.tex_back_light != null) {
					mpb.SetTexture("_BackLight", gfxmat.textureSet.tex_back_light.GetUnityTexture(c).Texture);
					mpb.SetVector("_BackLight_ST", new Vector4(1,1,0,0));
				}
				if (gfxmat.textureSet.tex_separateAlpha != null) {
					mpb.SetTexture("_SeparateAlpha", gfxmat.textureSet.tex_separateAlpha.GetUnityTexture(c).Texture);
					mpb.SetVector("_SeparateAlpha_ST", new Vector4(1, 1, 0, 0));
				}
			}

			// Set property block
			r.SetPropertyBlock(mpb, index);
		}
	}
}
