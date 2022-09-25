using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class AnimLightComponent {
		public GenericFile<GFXMaterialShader_Template> shader;
		private AnimLightComponent_Template tpl;
		private GameObject[] patches = new GameObject[0];
		private SkinnedMeshRenderer[] patchRenderers = new SkinnedMeshRenderer[0];
		private GameObject skeleton_gao;
		private UnityBone[] bones;
		//private int zValue = 0;
		private UnityAnimation ua;
		MaterialPropertyBlock mpb;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is AnimLightComponent_Template) {
				tpl = template as AnimLightComponent_Template;
				CreateGameObjects(gao);
				
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Context l = s.Context;
				l.Load(MatShader, (extS) => {
					if (l.msh.ContainsKey(MatShader.stringID)) {
						shader = l.msh[MatShader.stringID];
					} else {
						shader = extS.SerializeObject<GenericFile<GFXMaterialShader_Template>>(shader);
						l.msh[MatShader.stringID] = shader;
					}
				});
			}
		}
		// ^ Serialize
		// -------------------------------
		// v GameObject

		private void CreateGameObjects(GameObject gao) {
			var context = UbiArtContext;
			if (!context.loadAnimations) return;
			Material tex_mat = GFXMaterialShader_Template.GetShaderMaterial(shader: shader?.obj);
			bool createdOne = false;
			if (context.Settings.engineVersion > Settings.EngineVersion.RO) {
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
			} else {
				ProcessOrigins(gao, tex_mat);
			}
		}

		private void ProcessOrigins(GameObject gao, Material tex_mat) {
			ICSerializable[] resources = tpl.animSet.resources;
			if (!UbiArtContext.loadAnimations) return;
			ICSerializable pbkRes = resources.Where(res => res is AnimPatchBank).FirstOrDefault();
			AnimPatchBank pbk = pbkRes != null ? (AnimPatchBank)pbkRes : null;
			ICSerializable sklRes = resources.Where(res => res is AnimSkeleton).FirstOrDefault();
			AnimSkeleton skeleton = sklRes != null ? (AnimSkeleton)sklRes : null;
			if (pbk == null || skeleton == null) return;
			patches = new GameObject[pbk.templates.Count];
			patchRenderers = new SkinnedMeshRenderer[patches.Length];
			skeleton_gao = new GameObject("AnimLightComponent - Skeleton");
			skeleton_gao.transform.SetParent(gao.transform, false);
			skeleton_gao.transform.localPosition = Vector3.zero;
			skeleton_gao.transform.localRotation = Quaternion.identity;
			skeleton_gao.transform.localScale = Vector3.one;

			bones = skeleton.CreateBones(skeleton_gao);
			for (int i = 0; i < pbk.templates.Count; i++) {
				AnimTemplate at = pbk.templates[i];
				Mesh mesh = at.CreateMesh();
				if (mesh == null) continue;

				GameObject patch_gao = new GameObject("AnimLightComponent - Template " + i);
				patch_gao.transform.SetParent(gao.transform, false);
				patch_gao.transform.localPosition = Vector3.zero;
				patch_gao.transform.localRotation = Quaternion.identity;
				patch_gao.transform.localScale = Vector3.one;

				UnityBone[] mesh_bones = at.GetBones(mesh, skeleton_gao, skeleton, bones);
				//Transform[] mesh_bones = at.GetBones(mesh, skeleton_gao, skeleton, bones);
				//MeshFilter mf = patch_gao.AddComponent<MeshFilter>();
				//mf.sharedMesh = mesh;
				SkinnedMeshRenderer mr = patch_gao.AddComponent<SkinnedMeshRenderer>();
				mr.bones = mesh_bones.Select(b => b?.transform).ToArray();
				mr.sharedMaterial = tex_mat;
				mr.sharedMesh = mesh;
				FillMaterialParams(mr);
				List<int> roots = at.GetRootIndices();
				if (roots.Count > 0) mr.rootBone = mr.bones[roots[0]];
				patches[i] = patch_gao;
				patchRenderers[i] = mr;
			}
			skeleton.ResetBones(bones);
			ua = skeleton_gao.AddComponent<UnityAnimation>();
			ua.bones = bones;
			ua.skeleton = skeleton;
			ua.anims = new List<System.Tuple<Path, AnimTrack>>();
			ua.patches = patches;
			ua.patchRenderers = patchRenderers;
			ua.pbk = pbk;
			ua.alc = this;
			/*List<Path> animPaths = new List<Path>();
			foreach (SubAnim_Template sat in tpl.animSet.animations) {
				animPaths.Add(sat.name);
			}*/
			Context l = UbiArtContext;

			ua.anims = new List<System.Tuple<Path, AnimTrack>>();
			for (int i = 0; i < resources.Length; i++) {
				if (resources[i] != null && resources[i] is AnimTrack) {
					ua.anims.Add(new System.Tuple<Path, AnimTrack>(tpl.animSet.resourceList[i], resources[i] as AnimTrack));
				}
			}
			if (ua.anims.Count > 0) {
				ua.animIndex = 0;
				ua.animTrack = ua.anims[0].Item2;
			}
			ua.Init();
		}

		private bool ProcessTextureBank(TextureBankPath bp, GameObject gao, Material tex_mat, AnimSkeleton skeleton) {
			if (bp != null && bp.textureSet != null && skeleton != null) {
				if (bp.pbk != null) {
					patches = new GameObject[bp.pbk.templates.Count];
					patchRenderers = new SkinnedMeshRenderer[patches.Length];
					skeleton_gao = new GameObject("AnimLightComponent - Skeleton");
					skeleton_gao.transform.SetParent(gao.transform, false);
					skeleton_gao.transform.localPosition = Vector3.zero;
					skeleton_gao.transform.localRotation = Quaternion.identity;
					skeleton_gao.transform.localScale = Vector3.one;
					bones = skeleton.CreateBones(skeleton_gao);
					for (int i = 0; i < bp.pbk.templates.Count; i++) {
						AnimTemplate at = bp.pbk.templates[i];
						Mesh mesh = at.CreateMesh();
						if (mesh == null) continue;

						GameObject patch_gao = new GameObject("AnimLightComponent - Template " + i);
						patch_gao.transform.SetParent(gao.transform, false);
						patch_gao.transform.localPosition = Vector3.zero;
						patch_gao.transform.localRotation = Quaternion.identity;
						patch_gao.transform.localScale = Vector3.one;

						UnityBone[] mesh_bones = at.GetBones(mesh, skeleton_gao, skeleton, bones);
						//Transform[] mesh_bones = at.GetBones(mesh, skeleton_gao, skeleton, bones);
						//MeshFilter mf = patch_gao.AddComponent<MeshFilter>();
						//mf.sharedMesh = mesh;
						SkinnedMeshRenderer mr = patch_gao.AddComponent<SkinnedMeshRenderer>();
						mr.bones = mesh_bones.Select(b => b != null ? b.transform : null).ToArray();
						mr.sharedMaterial = tex_mat;
						mr.sharedMesh = mesh;
						FillMaterialParams(mr);
						SetMaterialTextures(bp.textureSet, mr);
						patches[i] = patch_gao;
						patchRenderers[i] = mr;
					}
					skeleton.ResetBones(bones);
					ua = skeleton_gao.AddComponent<UnityAnimation>();
					ua.bones = bones;
					ua.skeleton = skeleton;
					List<Path> animPaths = new List<Path>();
					ua.anims = new List<System.Tuple<Path, AnimTrack>>();
					ua.patches = patches;
					ua.patchRenderers = patchRenderers;
					ua.pbk = bp.pbk;
					ua.alc = this;
					foreach (SubAnim_Template sat in tpl.animSet.animations) {
						animPaths.Add(sat.name);
					}
					Context l = UbiArtContext;
					ua.anims = animPaths.Distinct().Select(p => l.anm.ContainsKey(p.stringID) ? new System.Tuple<Path, AnimTrack>(p, l.anm[p.stringID]) : null).Where(t => t != null).ToList();
					if (ua.anims.Count > 0) {
						ua.animIndex = 0;
						ua.animTrack = ua.anims[0].Item2;
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
		private void FillMaterialParams(Renderer r, int index = 0) {
			if (mpb == null) mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			if (UbiArtContext.Settings.engineVersion > Settings.EngineVersion.RO) {
				GFXPrimitiveParam param = PrimitiveParameters;
				mpb.SetColor("_ColorFactor", param.colorFactor);
				mpb.SetColor("_LightConfig", new Vector4(
					param.FrontLightBrightness,
					param.FrontLightContrast,
					param.BackLightBrightness,
					param.BackLightContrast));
				mpb.SetColor("_ColorFog", param.colorFog);
			} else {
				mpb.SetColor("_ColorFactor", UnityEngine.Color.white);
				mpb.SetColor("_LightConfig", new Vector4(1, 0, 1, 0));
				mpb.SetColor("_ColorFog", Vector4.zero);
			}
			r.SetPropertyBlock(mpb, index);
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

			// Set property block
			r.SetPropertyBlock(mpb, index);
		}


		private void SetMaterialTextures(GFXMaterialTexturePathSet textureSet, Renderer r, int index = 0) {
			if (mpb == null) mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			if (textureSet != null) {
				mpb.SetVector("_UseTextures", new Vector4(
					textureSet.tex_diffuse != null ? 1f : 0f,
					textureSet.tex_back_light != null ? 1f : 0f,
					0f,
					textureSet.tex_separateAlpha != null ? 1f : 0f));

				if (textureSet.tex_diffuse != null) {
					mpb.SetTexture("_Diffuse", textureSet.tex_diffuse.SquareTexture);
					mpb.SetVector("_Diffuse_ST", new Vector4(1, 1, 0, 0));
				}
				if (textureSet.tex_back_light != null) {
					mpb.SetTexture("_BackLight", textureSet.tex_back_light.SquareTexture);
					mpb.SetVector("_BackLight_ST", new Vector4(1, 1, 0, 0));
				}
				if (textureSet.tex_separateAlpha != null) {
					mpb.SetTexture("_SeparateAlpha", textureSet.tex_separateAlpha.Texture);
					mpb.SetVector("_SeparateAlpha_ST", new Vector4(1, 1, 0, 0));
				}
			}
			r.SetPropertyBlock(mpb, index);
		}
		public void SetMaterialTextureOrigins(TextureCooked tex, Renderer r, int index = 0) {
			if (mpb == null) mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			if (r != null && tex != null) {
				mpb.SetVector("_UseTextures", new Vector4(1, 0, 0, 0));
				mpb.SetTexture("_Diffuse", tex.SquareTexture);
				mpb.SetVector("_Diffuse_ST", new Vector4(1, 1, 0, 0));
			}
			r.SetPropertyBlock(mpb, index);
		}
		public void SetColor(Color col, Renderer r, int index = 0) {
			if (mpb == null) mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			mpb.SetColor("_ColorFactor", col);
			r.SetPropertyBlock(mpb, index);
		}

		/*private void SetMaterialTextures(Material mat) {
			if (textureSet != null) {
				mat.SetVector("_UseTextures", new Vector4(
					textureSet.tex_diffuse != null ? 1f : 0f,
					textureSet.tex_back_light != null ? 1f : 0f,
					0f, 0f));
				if (textureSet.tex_diffuse != null) mat.SetTexture("_Diffuse", textureSet.tex_diffuse.SquareTexture);
				if (textureSet.tex_back_light != null) mat.SetTexture("_BackLight", textureSet.tex_back_light.SquareTexture);
			}
		}*/
	}
}
