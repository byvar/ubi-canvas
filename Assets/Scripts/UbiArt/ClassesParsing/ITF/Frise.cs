using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class Frise {
		public GenericFile<FriseConfig> config;
		public GameObject mesh_static;
		public GameObject mesh_anim;
		public GenericFile<GFXMaterialShader_Template> shader;

		protected override void InitGameObject() {
			base.InitGameObject();
			UnityFrise uf = gao.AddComponent<UnityFrise>();
			uf.frise = this;
			if (config != null && config.obj != null) {
				UnityFriseConfig ufcg = gao.AddComponent<UnityFriseConfig>();
				ufcg.friseConfig = config.obj;
				if (config.obj.textureConfigs != null) {
					foreach (FriseTextureConfig ftc in config.obj.textureConfigs) {
						if (ftc.material != null && ftc.material.shader != null && ftc.material.shader.obj != null) {
							UnityGFXMaterialShader_Template sh = gao.AddComponent<UnityGFXMaterialShader_Template>();
							sh.shader = ftc.material.shader.obj;
						}
					}
				}
			}
			if (meshBuildData != null && meshBuildData.value != null) {
				if (meshBuildData.value.StaticIndexList.Count > 0) {
					mesh_static = new GameObject("Static");
					mesh_static.transform.SetParent(gao.transform, false);
					mesh_static.transform.localPosition = Vector3.zero;
					mesh_static.transform.localRotation = Quaternion.identity;
					mesh_static.transform.localScale = Vector3.one;
					Mesh mesh = new Mesh();
					mesh.subMeshCount = meshBuildData.value.StaticIndexList.Count;
					mesh.vertices = meshBuildData.value.StaticVertexList.Select(v => new Vector3(v.pos.x, v.pos.y, -v.pos.z)).ToArray();
					mesh.uv = meshBuildData.value.StaticVertexList.Select(v => v.uv).ToArray();
					mesh.colors = meshBuildData.value.StaticVertexList.Select(v => v.color.Color).ToArray();
					//mesh.SetUVs(4, meshBuildData.value.StaticVertexList.Select(v => v.color.Vector).ToList());
					//MapLoader.Loader.print(meshBuildData.value.StaticVertexList[0].color.Vector);
					MeshFilter mf = mesh_static.AddComponent<MeshFilter>();
					MeshRenderer mr = mesh_static.AddComponent<MeshRenderer>();
					Material[] mats = new Material[meshBuildData.value.StaticIndexList.Count];
					for (int m = 0; m < meshBuildData.value.StaticIndexList.Count; m++) {
						int[] tris = new int[meshBuildData.value.StaticIndexList[m].List.Count * 2];
						for (int i = 0; i < meshBuildData.value.StaticIndexList[m].List.Count / 3; i++) {
							tris[(i * 6) + 0] = meshBuildData.value.StaticIndexList[m].List[(i * 3) + 0];
							tris[(i * 6) + 1] = meshBuildData.value.StaticIndexList[m].List[(i * 3) + 1];
							tris[(i * 6) + 2] = meshBuildData.value.StaticIndexList[m].List[(i * 3) + 2];
							tris[(i * 6) + 3] = meshBuildData.value.StaticIndexList[m].List[(i * 3) + 0];
							tris[(i * 6) + 4] = meshBuildData.value.StaticIndexList[m].List[(i * 3) + 2];
							tris[(i * 6) + 5] = meshBuildData.value.StaticIndexList[m].List[(i * 3) + 1];
						}
						mesh.SetTriangles(tris, m);

						Material mat;
						int idTexConfig = meshBuildData.value.StaticIndexList[m].IdTexConfig == 0xFFFFFFFF ? 0 : (int)meshBuildData.value.StaticIndexList[m].IdTexConfig;
						if (config != null && config.obj.textureConfigs.Count > idTexConfig) {
							/*if (config.obj.textureConfigs[idTexConfig].material.shader != null && config.obj.textureConfigs[idTexConfig].material.shader.obj != null) {
								// TODO: Get rid of GFX_MAT2 here
								if (config.obj.textureConfigs[idTexConfig].material.shader.obj.materialtype2 == GFXMaterialShader_Template.GFX_MAT2.DEFAULT) {
									mat = new Material(MapLoader.Loader.baseMaterial);
								} else {
									mat = new Material(MapLoader.Loader.baseLightMaterial);
								}
								if (!config.obj.textureConfigs[idTexConfig].material.shader.obj.renderRegular) gao.SetActive(false);
							} else {
								mat = new Material(MapLoader.Loader.baseMaterial);
							}
							//mat.color = config.obj.textureConfigs[idTexConfig].color.Color;
							if (config.obj.textureConfigs[idTexConfig].material.textureSet.tex_diffuse != null) {
								mat.SetTexture("_MainTex", config.obj.textureConfigs[idTexConfig].material.textureSet.tex_diffuse.Texture);
							} else {
								mat.SetTexture("_MainTex", Util.CreateDummyTexture());
							}
							mat.color = UseTemplatePrimitiveParams ? config.obj.PrimitiveParameters.colorFactor : PrimitiveParameters.colorFactor;*/
							mat = config.obj.textureConfigs[idTexConfig].material.GetUnityMaterial(shader != null ? shader.obj : null);
							FillMaterialParams(mat);
							GenericFile<GFXMaterialShader_Template> sh = config.obj.textureConfigs[idTexConfig].material.shader;
							if (sh != null && sh.obj != null && (sh.obj.renderBackLight || sh.obj.renderFrontLight)) {
								mesh_static.layer = 0;
								if (sh.obj.renderFrontLight) mesh_static.layer |= LayerMask.NameToLayer("FrontLight");
								if (sh.obj.renderBackLight) mesh_static.layer |= LayerMask.NameToLayer("BackLight");
							}
							if (config.obj.textureConfigs[idTexConfig].scrollUV != Vector2.zero) {
								AnimatedTexture animTex = mesh_static.AddComponent<AnimatedTexture>();
								animTex.ResetMaterial(config.obj.textureConfigs[idTexConfig], mat);
							}
						} else {
							mat = new Material(MapLoader.Loader.baseMaterial);
							FillMaterialParams(mat);
						}
						mats[m] = mat;
					}
					mf.mesh = mesh;
					mr.sharedMaterials = mats;
				}
				if (meshBuildData.value.AnimIndexList.Count > 0) {
					mesh_anim = new GameObject("Anim");
					mesh_anim.transform.SetParent(gao.transform, false);
					mesh_anim.transform.localPosition = Vector3.zero;
					mesh_anim.transform.localRotation = Quaternion.identity;
					mesh_anim.transform.localScale = Vector3.one;
					Mesh mesh = new Mesh();
					mesh.subMeshCount = meshBuildData.value.AnimIndexList.Count;
					mesh.vertices = meshBuildData.value.AnimVertexList.Select(v => new Vector3(v.pos.x, v.pos.y, -v.pos.z)).ToArray();
					mesh.uv = meshBuildData.value.AnimVertexList.Select(v => v.uv1).ToArray();
					mesh.SetUVs(1, meshBuildData.value.AnimVertexList.Select(v => v.uv2.UnityVector).ToList());
					mesh.SetUVs(2, meshBuildData.value.AnimVertexList.Select(v => v.uv3.UnityVector).ToList());
					mesh.SetUVs(3, meshBuildData.value.AnimVertexList.Select(v => v.uv4).ToList());
					mesh.colors = meshBuildData.value.AnimVertexList.Select(v => v.color.Color).ToArray();
					//mesh.SetUVs(4, meshBuildData.value.AnimVertexList.Select(v => v.color.Vector).ToList());
					//MapLoader.Loader.print(meshBuildData.value.StaticVertexList[0].color.Vector);
					MeshFilter mf = mesh_anim.AddComponent<MeshFilter>();
					MeshRenderer mr = mesh_anim.AddComponent<MeshRenderer>();
					Material[] mats = new Material[meshBuildData.value.AnimIndexList.Count];
					for (int m = 0; m < meshBuildData.value.AnimIndexList.Count; m++) {
						int[] tris = new int[meshBuildData.value.AnimIndexList[m].List.Count * 2];
						for (int i = 0; i < meshBuildData.value.AnimIndexList[m].List.Count / 3; i++) {
							tris[(i * 6) + 0] = meshBuildData.value.AnimIndexList[m].List[(i * 3) + 0];
							tris[(i * 6) + 1] = meshBuildData.value.AnimIndexList[m].List[(i * 3) + 1];
							tris[(i * 6) + 2] = meshBuildData.value.AnimIndexList[m].List[(i * 3) + 2];
							tris[(i * 6) + 3] = meshBuildData.value.AnimIndexList[m].List[(i * 3) + 0];
							tris[(i * 6) + 4] = meshBuildData.value.AnimIndexList[m].List[(i * 3) + 2];
							tris[(i * 6) + 5] = meshBuildData.value.AnimIndexList[m].List[(i * 3) + 1];
						}
						mesh.SetTriangles(tris, m);

						Material mat;
						int idTexConfig = meshBuildData.value.AnimIndexList[m].IdTexConfig == 0xFFFFFFFF ? 0 : (int)meshBuildData.value.AnimIndexList[m].IdTexConfig;
						if (config != null && config.obj.textureConfigs.Count > idTexConfig) {
							/*if (config.obj.textureConfigs[idTexConfig].material.shader != null && config.obj.textureConfigs[idTexConfig].material.shader.obj != null) {
								// TODO: Get rid of GFX_MAT2 here
								if (config.obj.textureConfigs[idTexConfig].material.shader.obj.materialtype2 == GFXMaterialShader_Template.GFX_MAT2.DEFAULT) {
									mat = new Material(MapLoader.Loader.baseMaterial);
								} else {
									mat = new Material(MapLoader.Loader.baseLightMaterial);
								}
								if (!config.obj.textureConfigs[idTexConfig].material.shader.obj.renderRegular) gao.SetActive(false);
							} else {
								mat = new Material(MapLoader.Loader.baseMaterial);
							}
							//mat.color = config.obj.textureConfigs[idTexConfig].color.Color;
							if (config.obj.textureConfigs[idTexConfig].material.textureSet.tex_diffuse != null) {
								mat.SetTexture("_MainTex", config.obj.textureConfigs[idTexConfig].material.textureSet.tex_diffuse.Texture);
							} else {
								mat.SetTexture("_MainTex", Util.CreateDummyTexture());
							}
							mat.color = UseTemplatePrimitiveParams ? config.obj.PrimitiveParameters.colorFactor : PrimitiveParameters.colorFactor;*/
							mat = config.obj.textureConfigs[idTexConfig].material.GetUnityMaterial(shader != null ? shader.obj : null);
							FillMaterialParams(mat);
							GenericFile<GFXMaterialShader_Template> sh = config.obj.textureConfigs[idTexConfig].material.shader;
							if (sh != null && sh.obj != null && (sh.obj.renderBackLight || sh.obj.renderFrontLight)) {
								mesh_anim.layer = 0;
								if (sh.obj.renderFrontLight) mesh_anim.layer |= LayerMask.NameToLayer("FrontLight");
								if (sh.obj.renderBackLight) mesh_anim.layer |= LayerMask.NameToLayer("BackLight");
							}
							if (config.obj.textureConfigs[idTexConfig].scrollUV != Vector2.zero) {
								AnimatedTexture animTex = mesh_anim.AddComponent<AnimatedTexture>();
								animTex.ResetMaterial(config.obj.textureConfigs[idTexConfig], mat);
							}
						} else {
							mat = new Material(MapLoader.Loader.baseMaterial);
							FillMaterialParams(mat);
						}
						mats[m] = mat;
					}
					mf.mesh = mesh;
					mr.sharedMaterials = mats;
				}
			}
		}

		private void FillMaterialParams(Material mat) {
			bool hasConfig = config != null && config.obj != null;
			//if (!hasConfig) return;
			//GFXPrimitiveParam param = (UseTemplatePrimitiveParams && hasConfig) ? config.obj.PrimitiveParameters : PrimitiveParameters;
			GFXPrimitiveParam param = PrimitiveParameters;
			mat.SetColor("_ColorFactor", param.colorFactor);
			mat.SetColor("_LightConfig", new Vector4(
				param.FrontLightBrightness,
				param.FrontLightContrast,
				param.BackLightBrightness,
				param.BackLightContrast));
			mat.SetColor("_ColorFog", param.colorFog);
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
				l.Load(ConfigName, (extS) => {
					if (l.fcg.ContainsKey(ConfigName.stringID)) {
						config = l.fcg[ConfigName.stringID];
					} else {
						//extS.log = true;
						extS.Serialize(ref config);
						l.fcg[ConfigName.stringID] = config;
					}
				});
			}
		}
	}
}
