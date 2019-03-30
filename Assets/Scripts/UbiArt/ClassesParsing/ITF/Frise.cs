using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class Frise {
		public GenericFile<FriseConfig> config;

		protected override void InitGameObject() {
			base.InitGameObject();
			UnityFrise uf = gao.AddComponent<UnityFrise>();
			uf.frise = this;
			if (config != null && config.obj != null) {
				UnityFriseConfig ufcg = gao.AddComponent<UnityFriseConfig>();
				ufcg.friseConfig = config.obj;
			}
			if (meshBuildData.value != null) {
				if (meshBuildData.value.StaticIndexList.Count > 0) {
					Mesh mesh = new Mesh();
					mesh.subMeshCount = meshBuildData.value.StaticIndexList.Count;
					mesh.vertices = meshBuildData.value.StaticVertexList.Select(v => new Vector3(v.pos.x, v.pos.y, -v.pos.z)).ToArray();
					mesh.uv = meshBuildData.value.StaticVertexList.Select(v => v.uv).ToArray();
					MeshFilter mf = gao.AddComponent<MeshFilter>();
					MeshRenderer mr = gao.AddComponent<MeshRenderer>();
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
							if (config.obj.textureConfigs[idTexConfig].material.shader != null && config.obj.textureConfigs[idTexConfig].material.shader.obj != null) {
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
							if (config.obj.textureConfigs[idTexConfig].material.textureSet.diffuseTex != null) {
								mat.SetTexture("_MainTex", config.obj.textureConfigs[idTexConfig].material.textureSet.diffuseTex.Texture);
							} else {
								mat.SetTexture("_MainTex", Util.CreateDummyTexture());
							}
						} else {
							mat = new Material(MapLoader.Loader.baseMaterial);
						}
						mats[m] = mat;
					}
					mf.mesh = mesh;
					mr.materials = mats;
				}
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
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
