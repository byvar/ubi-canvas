using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class AnimLightComponent {
		public GenericFile<GFXMaterialShader_Template> shader;
		private AnimLightComponent_Template tpl;
		private List<GameObject> patches;
		private List<Material> patchMaterials;
		private GameObject skeleton_gao;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is AnimLightComponent_Template) {
				tpl = template as AnimLightComponent_Template;
				CreateGameObjects(gao);
				
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(MatShader, (extS) => {
					if (l.msh.ContainsKey(MatShader.stringID)) {
						shader = l.msh[MatShader.stringID];
					} else {
						extS.Serialize(ref shader);
						l.msh[MatShader.stringID] = shader;
					}
				});
			}
		}
		// ^ Serialize
		// -------------------------------
		// v GameObject

		private void CreateGameObjects(GameObject gao) {
			patches = new List<GameObject>();
			patchMaterials = new List<Material>();
			Material tex_mat = GetUnityMaterial();
			FillMaterialParams(tex_mat);
			bool createdOne = false;
			foreach (TextureBankPath bp in subAnimInfo.animPackage.textureBank) {
				createdOne = ProcessTextureBank(bp, gao, tex_mat, subAnimInfo.animPackage.skel);
				if (createdOne) break;
			}
			if (!createdOne) {
				foreach (TextureBankPath bp in tpl.animSet.animPackage.textureBank) {
					createdOne = ProcessTextureBank(bp, gao, tex_mat, tpl.animSet.animPackage.skel);
					if (createdOne) break;
				}
			}
		}

		private bool ProcessTextureBank(TextureBankPath bp, GameObject gao, Material tex_mat, AnimSkeleton skeleton) {
			if (bp.textureSet != null && skeleton != null) {
				if (bp.pbk != null) {
					skeleton_gao = new GameObject("AnimLightComponent - Skeleton");
					skeleton_gao.transform.SetParent(gao.transform, false);
					skeleton_gao.transform.localPosition = Vector3.zero;
					skeleton_gao.transform.localRotation = Quaternion.identity;
					skeleton_gao.transform.localScale = Vector3.one;
					Transform[] bones = skeleton.CreateBones(skeleton_gao);
					for (int i = 0; i < bp.pbk.templates.Count; i++) {
						AnimTemplate at = bp.pbk.templates[i];
						Mesh mesh = at.CreateMesh();
						if (mesh == null) continue;

						Material patch_mat = new Material(tex_mat);
						SetMaterialTextures(patch_mat, bp.textureSet);

						GameObject patch_gao = new GameObject("AnimLightComponent - Template " + i);
						patch_gao.transform.SetParent(gao.transform, false);
						patch_gao.transform.localPosition = Vector3.zero;
						patch_gao.transform.localRotation = Quaternion.identity;
						patch_gao.transform.localScale = Vector3.one;

						Transform[] mesh_bones = at.GetBones(mesh, skeleton_gao, skeleton, bones);
						//Transform[] mesh_bones = at.GetBones(mesh, skeleton_gao, skeleton, bones);
						//MeshFilter mf = patch_gao.AddComponent<MeshFilter>();
						//mf.sharedMesh = mesh;
						SkinnedMeshRenderer mr = patch_gao.AddComponent<SkinnedMeshRenderer>();
						mr.bones = mesh_bones;
						mr.sharedMaterial = patch_mat;
						mr.sharedMesh = mesh;
						patches.Add(patch_gao);
						patchMaterials.Add(patch_mat);
					}
					skeleton.ResetBones(bones);
					UnityAnimation ua = skeleton_gao.AddComponent<UnityAnimation>();
					ua.bones = bones.Select(b => b.GetComponent<UnityBone>()).ToArray();
					ua.skeleton = skeleton;
					ua.anims = new List<System.Tuple<Path, AnimTrack>>();
					foreach (SubAnim_Template sat in tpl.animSet.animations) {
						ua.anims.Add(new System.Tuple<Path, AnimTrack>(sat.name, sat.anim));
					}
					ua.Init();
					/*for (int i = 0; i < bp.pbk.templates.Count; i++) {
						AnimTemplate at = bp.pbk.templates[i];
						at.ResetBones(bones, skeleton);
					}*/
					return true;
				}
			}
			return false;
		}

		private Mesh CreateMesh(TextureCooked tex) {
			Mesh meshUnity = new Mesh();
			/* CArray<Vector2> uvsArr = null;
			if (spriteIndex != 0xFFFFFFFF && tex.atlas != null) {
				if (tex.atlas.uvData.ContainsKey((int)spriteIndex)) {
					uvsArr = tex.atlas.uvData[(int)spriteIndex].uvs;
					MapLoader.Loader.print("Texture path with UV count:" + material.textureSet.diffuse + " - " + uvsArr.Count);
				}
			}*/
			Vector3[] vertices = new Vector3[4];
			vertices[0] = new Vector3(-0.5f, -0.5f, 0f);
			vertices[1] = new Vector3(-0.5f, 0.5f, 0f);
			vertices[2] = new Vector3(0.5f, -0.5f, 0f);
			vertices[3] = new Vector3(0.5f, 0.5f, 0f);
			Vector3[] normals = new Vector3[4];
			normals[0] = Vector3.forward;
			normals[1] = Vector3.forward;
			normals[2] = Vector3.forward;
			normals[3] = Vector3.forward;
			Vector3[] uvs = new Vector3[4];
			uvs[0] = new Vector3(0, 1);
			uvs[1] = new Vector3(0, 0);
			uvs[2] = new Vector3(1, 1);
			uvs[3] = new Vector3(1, 0);
			int[] triangles = new int[] { 0, 1, 2, 1, 3, 2 };
			meshUnity.vertices = vertices;
			meshUnity.normals = normals;
			meshUnity.triangles = triangles;
			meshUnity.SetUVs(0, uvs.ToList());
			//meshUnity.SetUVs(4, Enumerable.Repeat(Vector4.one, 4).ToList());
			return meshUnity;
		}
		private void FillMaterialParams(Material mat) {
			GFXPrimitiveParam param = PrimitiveParameters;
			mat.SetColor("_ColorFactor", param.colorFactor);
			mat.SetColor("_LightConfig", new Vector4(
				param.FrontLightBrightness,
				param.FrontLightContrast,
				param.BackLightBrightness,
				param.BackLightContrast));
			mat.SetColor("_ColorFog", param.colorFog);
		}
		public virtual int UpdateZSortValue(int val) {
			if (patchMaterials != null) {
				foreach (Material m in patchMaterials) {
					m.renderQueue = val++;
				}
			}
			return val;
		}
		private Material GetUnityMaterial(GFXMaterialShader_Template shader = null) {
			if (shader == null) shader = (this.shader != null ? this.shader.obj : null);
			Shader sh = Shader.Find("Custom/UbiArtAlpha");
			Material mat = new Material(sh);
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
			return mat;
		}
		private void SetMaterialTextures(Material mat, GFXMaterialTexturePathSet textureSet) {
			if (textureSet != null) {
				mat.SetVector("_UseTextures", new Vector4(
					textureSet.tex_diffuse != null ? 1f : 0f,
					textureSet.tex_back_light != null ? 1f : 0f,
					0f, 0f));
				if (textureSet.tex_diffuse != null) mat.SetTexture("_Diffuse", textureSet.tex_diffuse.SquareTexture);
				if (textureSet.tex_back_light != null) mat.SetTexture("_BackLight", textureSet.tex_back_light.SquareTexture);
			}
		}
		private enum ZWrite {
			Off = 0,
			On = 1
		}
	}
}
