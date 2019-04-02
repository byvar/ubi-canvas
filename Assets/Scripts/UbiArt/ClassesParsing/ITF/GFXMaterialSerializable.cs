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
						extS.Serialize(ref shader);
						l.msh[shaderPath.stringID] = shader;
					}
				});
			}
		}

		public Material UnityMaterial {
			get {
				Shader sh = Shader.Find("Custom/UbiArtAlpha");
				Material mat = new Material(sh);
				if (shader != null && shader.obj != null) {
					mat.SetVector("_ShaderParams", new Vector4(
						shader.obj.renderRegular ? 1f : 0f,
						shader.obj.renderFrontLight ? 1f : 0f,
						shader.obj.renderBackLight ? 1f : 0f,
						0f));
					mat.SetVector("_ShaderParams2", new Vector4(
						(int)shader.obj.materialtype2,
						(int)shader.obj.blendmode,
						0f,
						0f));
					BlendMode blendSrc = BlendMode.SrcAlpha;
					BlendMode blendDst = BlendMode.OneMinusSrcAlpha;
					switch (shader.obj.blendmode) {
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
						case GFXMaterialShader_Template.GFX_BLEND.MUL:
							blendSrc = BlendMode.DstColor;
							blendDst = BlendMode.Zero;
							break;
						case GFXMaterialShader_Template.GFX_BLEND.MUL2X:
							blendSrc = BlendMode.DstColor;
							blendDst = BlendMode.SrcColor;
							break;

					}
					mat.SetFloat("_BlendSrc", (int)blendSrc);
					mat.SetFloat("_BlendDst", (int)blendDst);
				}
				if (textureSet != null) {
					mat.SetVector("_UseTextures", new Vector4(
						textureSet.tex_diffuse != null ? 1f : 0f,
						0f, 0f, 0f));
					if(textureSet.tex_diffuse != null) mat.SetTexture("_Diffuse", textureSet.tex_diffuse.Texture);
				}
				return mat;
			}
		}
	}
}
