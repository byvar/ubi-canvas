using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class Frise {
		public CList<Generic<FriseConfig>> config;

		protected override void InitGameObject() {
			base.InitGameObject();
			UnityFrise uf = gao.AddComponent<UnityFrise>();
			uf.frise = this;
			if (config != null && config.Count > 0) {
				UnityFriseConfig ufcg = gao.AddComponent<UnityFriseConfig>();
				ufcg.friseConfig = config[0].obj;
			}
			if (meshBuildData.value != null) {
				if (meshBuildData.value.StaticVertexList.Count > 0) {
					Mesh mesh = new Mesh();
					mesh.vertices = meshBuildData.value.StaticVertexList.Select(v => new Vector3(v.pos.x, v.pos.y, -v.pos.z)).ToArray();
					int[] tris = new int[meshBuildData.value.StaticIndexList.First().List.Count * 2];
					for (int i = 0; i < meshBuildData.value.StaticIndexList.First().List.Count / 3; i++) {
						tris[(i * 6) + 0] = meshBuildData.value.StaticIndexList.First().List[(i * 3) + 0];
						tris[(i * 6) + 1] = meshBuildData.value.StaticIndexList.First().List[(i * 3) + 1];
						tris[(i * 6) + 2] = meshBuildData.value.StaticIndexList.First().List[(i * 3) + 2];
						tris[(i * 6) + 3] = meshBuildData.value.StaticIndexList.First().List[(i * 3) + 0];
						tris[(i * 6) + 4] = meshBuildData.value.StaticIndexList.First().List[(i * 3) + 2];
						tris[(i * 6) + 5] = meshBuildData.value.StaticIndexList.First().List[(i * 3) + 1];
					}
					mesh.triangles = tris;
					//mesh.triangles = meshBuildData.staticIndexList.First().list.Select(i => (int)i).ToArray();
					mesh.uv = meshBuildData.value.StaticVertexList.Select(v => v.uv).ToArray();
					MeshFilter mf = gao.AddComponent<MeshFilter>();
					mf.mesh = mesh;
					MeshRenderer mr = gao.AddComponent<MeshRenderer>();
					Material mat;
					if (config != null && config[0].obj.textureConfigs.Count > 0) {
						if (config[0].obj.textureConfigs[0].material.shader != null) {
							// TODO: Get rid of GFX_MAT2 here
							if (config[0].obj.textureConfigs[0].material.shader[0].obj.materialtype2 == GFXMaterialShader_Template.GFX_MAT2.DEFAULT) {
								mat = new Material(MapLoader.Loader.baseMaterial);
							} else {
								mat = new Material(MapLoader.Loader.baseLightMaterial);
							}
							if (!config[0].obj.textureConfigs[0].material.shader[0].obj.renderRegular) gao.SetActive(false);
						} else {
							mat = new Material(MapLoader.Loader.baseMaterial);
						}
						//mat.color = config[0].obj.textureConfigs[0].color.Color;
						if (config[0].obj.textureConfigs[0].material.textureSet.diffuseTex != null) {
							mat.SetTexture("_MainTex", config[0].obj.textureConfigs[0].material.textureSet.diffuseTex.Texture);
						} else {
							mat.SetTexture("_MainTex", Util.CreateDummyTexture());
						}
					} else {
						mat = new Material(MapLoader.Loader.baseMaterial);
					}
					mr.material = mat;
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
						l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
					}
				});
			}
		}
	}
}
