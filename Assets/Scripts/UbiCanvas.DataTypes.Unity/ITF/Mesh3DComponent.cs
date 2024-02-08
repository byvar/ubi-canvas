using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UbiCanvas;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class Mesh3DComponent {
		private Mesh3DComponent_Template tpl;
		private GameObject[] patches = new GameObject[0];
		private SkinnedMeshRenderer[] patchRenderers = new SkinnedMeshRenderer[0];
		private GameObject skeleton_gao;
		private UnityBone[] bones;
		//private int zValue = 0;
		private UnityAnimation ua;
		MaterialPropertyBlock mpb;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is Mesh3DComponent_Template) {
				tpl = template as Mesh3DComponent_Template;
				CreateGameObjects(gao);

			}
		}

		private void CreateGameObjects(GameObject gao) {
			var context = UbiArtContext;
			if (!context.Loader.LoadAnimations) return;

			Engine3D.Mesh3D usedMesh = (Engine3D.Mesh3D)(mesh3D?.Object ?? tpl.mesh3D?.Object);
			if (usedMesh == null) {
				CListO<Path> usedMeshList = mesh3DList;
				if(usedMeshList == null || !usedMeshList.Any()) usedMeshList = tpl.mesh3Dlist;
				if (usedMeshList != null) {
					foreach (var p in usedMeshList) {
						CreateGameObjectForMesh(p.Object as Engine3D.Mesh3D, gao);
					}
				}
			} else {
				CreateGameObjectForMesh(usedMesh, gao);
			}
		}

		private void CreateGameObjectForMesh(Engine3D.Mesh3D mesh3D, GameObject parentGao) {
			if(mesh3D == null) return;

			var usedMaterialList = (materialList == null || !materialList.Any()) ? tpl.materialList : materialList;
			var gao = new GameObject($"Mesh {mesh3D.MeshID}");

			gao.transform.SetParent(parentGao.transform, false);
			gao.transform.localPosition = Vector3.zero;
			gao.transform.localRotation = Quaternion.identity;
			gao.transform.localScale = Vector3.one;

			var elInd = 0;
			foreach (var el in mesh3D.Elements) {
				var meshGAO = new GameObject($"Element {elInd++}");
				meshGAO.transform.SetParent(gao.transform, false);
				meshGAO.transform.localPosition = Vector3.zero;
				meshGAO.transform.localRotation = Quaternion.identity;
				meshGAO.transform.localScale = Vector3.one;

				Vector3 ConvertVertex(Vec3d v) => new Vector3(v.x, v.y, -v.z);
				Vector3 GetVertex(int index) => ConvertVertex(mesh3D.Vertices[index]);
				Vector2 GetUV(int index) => mesh3D.UVs[index].GetUnityVector();
				Vector3 GetNormal(int index) => ConvertVertex(mesh3D.Normals[index]);
				IEnumerable<T> SelectTriple<T>(Engine3D.Mesh3D.TripleIndex t, System.Func<int, T> func) {
					yield return func((int)t.Index0);
					yield return func((int)t.Index2);
					yield return func((int)t.Index1);
				}

				Mesh mesh = new Mesh();
				mesh.vertices = el.Triangles.SelectMany(t => SelectTriple(t.Vertex, i => GetVertex(i))).ToArray();
				mesh.normals = el.Triangles.SelectMany(t => SelectTriple(t.Normal, i => GetNormal(i))).ToArray();
				mesh.uv = el.Triangles.SelectMany(t => SelectTriple(t.UV1, i => GetUV(i))).ToArray();
				mesh.triangles = Enumerable.Range(0,el.Triangles.Count * 3).ToArray();
				//mesh.colors = meshBuildData.value.StaticVertexList.Select(v => v.color.GetUnityColor()).ToArray();
				//mesh.SetUVs(4, meshBuildData.value.StaticVertexList.Select(v => v.color.Vector).ToList());
				//MapLoader.Loader.print(meshBuildData.value.StaticVertexList[0].color.Vector);
				MeshFilter mf = meshGAO.AddComponent<MeshFilter>();
				MeshRenderer mr = meshGAO.AddComponent<MeshRenderer>();

				int materialIndex = (int)el.MaterialIndex;
				var mats = new Material[1];

				if (materialIndex < usedMaterialList.Count) {
					var usedMat = usedMaterialList[materialIndex];
					mats[0] = usedMat.GetShaderMaterial(shader: null, transparent: false);
					mr.sharedMaterials = mats;
					usedMat.FillUnityMaterialPropertyBlock(UbiArtContext, mr, index: 0, shader: null);
				} else {
					mats[0] = GFXMaterialShader_Template.GetShaderMaterial(shader: null, transparent: false);
					mr.sharedMaterials = mats;
				}
				FillMaterialParams(mr, index: 0);
				mf.sharedMesh = mesh;
				mr.gameObject.layer = LayerMask.NameToLayer("Default");
			}
		}
		private void FillMaterialParams(Renderer r, int index = 0) {
			if (mpb == null) mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			if (UbiArtContext.Settings.EngineVersion > EngineVersion.RO) {
				GFXPrimitiveParam param = PrimitiveParameters;
				param?.FillMaterialParams(UbiArtContext, mpb);
			} else {
				GFXPrimitiveParam.FillMaterialParamsDefault(UbiArtContext, mpb);
			}
			r.SetPropertyBlock(mpb, index);
		}
	}
}
