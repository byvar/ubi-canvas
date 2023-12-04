using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UbiCanvas;
using UbiCanvas.Helpers;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class AnimLightComponent {
		private AnimLightComponent_Template tpl;
		private UnityAnimation ua;
		MaterialPropertyBlock mpb;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is AnimLightComponent_Template) {
				tpl = template as AnimLightComponent_Template;
				CreateGameObjects(gao);

			}
		}

		private void CreateGameObjects(GameObject gao) {
			var context = UbiArtContext;
			if (!context.Loader.LoadAnimations) return;
			Material tex_mat = GFXMaterialShader_Template.GetShaderMaterial(shader: shader?.obj);
			if (context.Settings.EngineVersion > EngineVersion.RO) {
				CreateUnityAnimation(gao, tex_mat);
			} else {
				ProcessOrigins(gao, tex_mat);
			}
		}

		private void ProcessOrigins(GameObject gao, Material tex_mat) {
			var c = UbiArtContext;
			if (!UbiArtContext.Loader.LoadAnimations) return;

			// Create skeleton
			var skeleton_gao = new GameObject("AnimLightComponent - Skeleton");
			skeleton_gao.transform.SetParent(gao.transform, false);
			skeleton_gao.transform.localPosition = Vector3.zero;
			skeleton_gao.transform.localRotation = Quaternion.identity;
			skeleton_gao.transform.localScale = Vector3.one;

			// Collect resources
			ICSerializable[] resources = tpl.animSet.resources;
			var resourceList = tpl.animSet.resourceList;
			ICSerializable sklRes = resources.Where(res => res is AnimSkeleton).FirstOrDefault();
			AnimSkeleton skeleton = sklRes != null ? (AnimSkeleton)sklRes : null;
			if (skeleton == null) return;

			var bones = skeleton.CreateBones(c, skeleton_gao);

			// Create list of patchbanks
			List<UnityAnimation.UnityPatchBank> pbksOrigins = new List<UnityAnimation.UnityPatchBank>();
			for(int i = 0; i < resources.Length; i++) {
				var res = resources[i];
				if (res is TextureCooked tex) {
					var texPath = tpl.animSet.resourceList[i];
					var pbkPathLower = $"{texPath.GetFilenameWithoutExtension(fullPath: true).ToLowerInvariant()}.pbk";
					for (int j = 0; j < resources.Length; j++) {
						if (resources[j] is AnimPatchBank pbk && resourceList[j].FullPath.ToLowerInvariant() == pbkPathLower) {
							var pbkPath = tpl.animSet.resourceList[j];
							pbksOrigins.Add(new UnityAnimation.UnityPatchBank() {
								PBK = pbk,
								TextureID = texPath.stringID
							});
						}
					}
				}
			}
			Dictionary<StringID, UnityAnimation.UnityPatchBank> unityPBKsOrigins = pbksOrigins.ToDictionary(tb => tb.TextureID);
			Dictionary<StringID, UnityAnimation.UnityPatchBank> unityPBKs = new Dictionary<StringID, UnityAnimation.UnityPatchBank>();
			// Now add the "bank change" entries
			foreach (var bankChange in tpl.animSet.banks) {
				var texturePath = bankChange.bankPath;
				var fullPath = bankChange.pbkPath;
				if(bankChange.state != uint.MaxValue) continue; // Only changed in specific cases

				if(bankChange.pbk != null) {
					unityPBKs[bankChange.bankName] = new UnityAnimation.UnityPatchBank() {
						PBK = bankChange.pbk,
						ID = bankChange.bankName,
						TexturePathOrigins = texturePath
					};
				}
			}

			// Create templates
			foreach (var pbk in unityPBKs.Concat(unityPBKsOrigins)) {
				var bank = pbk.Value;
				bank.Patches = new UnityAnimation.UnityPatch[bank.PBK.templates.Count];

				for (int i = 0; i < bank.PBK.templates.Count; i++) {
					AnimTemplate at = bank.PBK.templates[i];

					bank.Patches[i] = new UnityAnimation.UnityPatch() {
						Template = at
					};

					Mesh mesh = at.CreateMesh();
					if (mesh == null) continue;

					GameObject patch_gao = new GameObject($"AnimLightComponent - {bank.ID ?? bank.TextureID} - Template {i}");
					patch_gao.transform.SetParent(gao.transform, false);
					patch_gao.transform.localPosition = Vector3.zero;
					patch_gao.transform.localRotation = Quaternion.identity;
					patch_gao.transform.localScale = Vector3.one;

					UnityBone[] mesh_bones = at.GetBones(c, mesh, skeleton_gao, skeleton, bones);
					//Transform[] mesh_bones = at.GetBones(mesh, skeleton_gao, skeleton, bones);
					//MeshFilter mf = patch_gao.AddComponent<MeshFilter>();
					//mf.sharedMesh = mesh;
					SkinnedMeshRenderer mr = patch_gao.AddComponent<SkinnedMeshRenderer>();
					mr.bones = mesh_bones.Select(b => b != null ? b.transform : null).ToArray();
					mr.sharedMaterial = tex_mat;
					mr.sharedMesh = mesh;
					FillMaterialParams(mr);
					//SetMaterialTextures(bank.TextureBankPath.textureSet, mr);

					List<int> roots = at.GetRootIndices();
					if (roots.Count > 0) mr.rootBone = mr.bones[roots[0]];

					bank.Patches[i].Object = patch_gao;
					bank.Patches[i].Renderer = mr;
				}
			}
			skeleton.ResetBones(c, bones);
			ua = skeleton_gao.AddComponent<UnityAnimation>();
			ua.bones = bones;
			ua.skeleton = skeleton;
			ua.alc = this;
			ua.alc_tpl = tpl;
			ua.patchBanks = unityPBKs;
			ua.patchBanksOrigins = unityPBKsOrigins;
			ua.AllPatchBanks = unityPBKs.Concat(unityPBKsOrigins).Select(v => v.Value).Distinct().ToArray();
			/*List<Path> animPaths = new List<Path>();
			foreach (SubAnim_Template sat in tpl.animSet.animations) {
				animPaths.Add(sat.name);
			}*/

			List<UnityAnimation.UnityAnimationTrack> anims = new List<UnityAnimation.UnityAnimationTrack>();
			foreach (SubAnim_Template sat in tpl.animSet.animations) {
				var fullPath = new Path($"{tpl.animationPath?.FullPath ?? ""}{sat.name?.FullPath ?? ""}");

				var resourceIndex = resourceList.FindItemIndex(p => p == fullPath);

				if (resourceIndex != -1) {
					anims.Add(new UnityAnimation.UnityAnimationTrack() {
						ID = sat.friendlyName,
						Path = resourceList[resourceIndex],
						Track = resources[resourceIndex] as AnimTrack,
						SubAnim = sat
					});
				}
			}
			ua.anims = anims.ToArray();
			if (ua.anims.Length > 0) {
				ua.animIndex = 0;
			}
			var defaultAnim = tpl.defaultAnimation;
			if (defaultAnim != null && !defaultAnim.IsNull) {
				var newAnimIndex = ua.anims.FindItemIndex(anm => anm.ID == defaultAnim);
				if (newAnimIndex != -1) ua.animIndex = newAnimIndex;
			}
			ua.Init();
		}

		private void CreateUnityAnimation(GameObject gao, Material tex_mat) {
			var c = UbiArtContext;
			if (!UbiArtContext.Loader.LoadAnimations) return;

			AnimSkeleton skeleton = subAnimInfo?.animPackage?.skel ?? tpl.animSet?.animPackage?.skel;
			if(skeleton == null) return;

			// Create skeleton
			var skeleton_gao = new GameObject("AnimLightComponent - Skeleton");
			skeleton_gao.transform.SetParent(gao.transform, false);
			skeleton_gao.transform.localPosition = Vector3.zero;
			skeleton_gao.transform.localRotation = Quaternion.identity;
			skeleton_gao.transform.localScale = Vector3.one;
			var bones = skeleton.CreateBones(c, skeleton_gao);

			// Create list of texture banks
			Dictionary<StringID, TextureBankPath> textureBanks = new Dictionary<StringID, TextureBankPath>();
			foreach (TextureBankPath bp in tpl.animSet.animPackage.textureBank) {
				if (bp?.pbk == null) continue;
				textureBanks[bp.id] = bp;
			}
			foreach (TextureBankPath bp in subAnimInfo?.animPackage?.textureBank) {
				if(bp?.pbk == null) continue;
				textureBanks[bp.id] = bp;
			}
			Dictionary<StringID, UnityAnimation.UnityPatchBank> unityPBKs = textureBanks
				.Select(tb => new UnityAnimation.UnityPatchBank() {
					ID = tb.Key,
					PBK = tb.Value.pbk,
					TextureBankPath = tb.Value
				}).ToDictionary(tb => tb.ID);

			// Create templates
			foreach (var pbk in unityPBKs) {
				var bank = pbk.Value;
				bank.Patches = new UnityAnimation.UnityPatch[bank.PBK.templates.Count];

				for (int i = 0; i < bank.PBK.templates.Count; i++) {
					AnimTemplate at = bank.PBK.templates[i];
					bank.Patches[i] = new UnityAnimation.UnityPatch() {
						Template = at
					};

					Mesh mesh = at.CreateMesh();
					if (mesh == null) continue;
					
					GameObject patch_gao = new GameObject($"AnimLightComponent - {bank.ID ?? bank.TextureID} - Template {i}");
					patch_gao.transform.SetParent(gao.transform, false);
					patch_gao.transform.localPosition = Vector3.zero;
					patch_gao.transform.localRotation = Quaternion.identity;
					patch_gao.transform.localScale = Vector3.one;

					UnityBone[] mesh_bones = at.GetBones(c, mesh, skeleton_gao, skeleton, bones);
					//Transform[] mesh_bones = at.GetBones(mesh, skeleton_gao, skeleton, bones);
					//MeshFilter mf = patch_gao.AddComponent<MeshFilter>();
					//mf.sharedMesh = mesh;
					SkinnedMeshRenderer mr = patch_gao.AddComponent<SkinnedMeshRenderer>();
					mr.bones = mesh_bones.Select(b => b != null ? b.transform : null).ToArray();
					mr.sharedMaterial = tex_mat;
					mr.sharedMesh = mesh;
					FillMaterialParams(mr);
					SetMaterialTextures(bank.TextureBankPath.textureSet, mr);

					bank.Patches[i].Object = patch_gao;
					bank.Patches[i].Renderer = mr;
				}
			}


			skeleton.ResetBones(c, bones);
			ua = skeleton_gao.AddComponent<UnityAnimation>();
			ua.bones = bones;
			ua.skeleton = skeleton;
			ua.patchBanks = unityPBKs;
			ua.AllPatchBanks = unityPBKs.Select(v => v.Value).Distinct().ToArray();
			ua.alc = this;
			ua.alc_tpl = tpl;


			List<UnityAnimation.UnityAnimationTrack> anims = new List<UnityAnimation.UnityAnimationTrack>();
			foreach (SubAnim_Template sat in subAnimInfo.animations) {
				if (sat.anim == null) continue;
				anims.Add(new UnityAnimation.UnityAnimationTrack() {
					ID = sat.friendlyName,
					Path = sat.name,
					Track = sat.anim,
					SubAnim = sat
				});
			}
			foreach (SubAnim_Template sat in tpl.animSet.animations) {
				if(sat.anim == null) continue;
				if(anims.Any(a => a.ID == sat.friendlyName)) continue;
				anims.Add(new UnityAnimation.UnityAnimationTrack() {
					ID = sat.friendlyName,
					Path = sat.name,
					Track = sat.anim,
					SubAnim = sat
				});
			}
			ua.anims = anims.ToArray();
			// Set default animation if possible
			if (ua.anims.Length > 0) {
				ua.animIndex = 0;
			}
			var defaultAnim = this.defaultAnim;
			if(defaultAnim == null || defaultAnim.IsNull) defaultAnim = tpl.defaultAnimation;
			if (defaultAnim != null && !defaultAnim.IsNull) {
				var newAnimIndex = ua.anims.FindItemIndex(anm => anm.ID == defaultAnim);
				if(newAnimIndex != -1) ua.animIndex = newAnimIndex;
			}
			ua.Init();

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
			if (UbiArtContext.Settings.EngineVersion > EngineVersion.RO) {
				GFXPrimitiveParam param = PrimitiveParameters;
				mpb.SetColor("_ColorFactor", param.TotalColorFactor.GetUnityColor());
				mpb.SetColor("_LightConfig", new Vector4(
					param.FrontLightBrightness,
					param.FrontLightContrast,
					param.BackLightBrightness,
					param.BackLightContrast));
				mpb.SetColor("_ColorFog", param.colorFog.GetUnityColor());
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
					var t = textureSet.tex_diffuse.GetUnityTexture(UbiArtContext);
					mpb.SetTexture("_Diffuse", t.Texture);
					mpb.SetVector("_Diffuse_ST", new Vector4(1, t.HeightFactor, 0, 0));
				}
				if (textureSet.tex_back_light != null) {
					var t = textureSet.tex_back_light.GetUnityTexture(UbiArtContext);
					mpb.SetTexture("_BackLight", t.Texture);
					mpb.SetVector("_BackLight_ST", new Vector4(1, t.HeightFactor, 0, 0));
				}
				if (textureSet.tex_separateAlpha != null) {
					var t = textureSet.tex_separateAlpha.GetUnityTexture(UbiArtContext);
					mpb.SetTexture("_SeparateAlpha", t.Texture);
					mpb.SetVector("_SeparateAlpha_ST", new Vector4(1, t.HeightFactor, 0, 0));
				}
			}
			r.SetPropertyBlock(mpb, index);
		}
		public void SetMaterialTextureOrigins(TextureCooked tex, Renderer r, int index = 0) {
			if (mpb == null) mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			if (r != null && tex != null) {
				var t = tex.GetUnityTexture(UbiArtContext);
				mpb.SetVector("_UseTextures", new Vector4(1, 0, 0, 0));
				mpb.SetTexture("_Diffuse", t.Texture);
				mpb.SetVector("_Diffuse_ST", new Vector4(1, t.HeightFactor, 0, 0));
			}
			r.SetPropertyBlock(mpb, index);
		}
		public void SetColor(UnityEngine.Color col, Renderer r, int index = 0) {
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
