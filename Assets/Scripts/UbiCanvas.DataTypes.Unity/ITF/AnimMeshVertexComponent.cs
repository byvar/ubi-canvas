using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UbiCanvas;
using UbiCanvas.Helpers;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class AnimMeshVertexComponent {
		private AnimMeshVertexComponent_Template tpl;
		private AnimMeshVertex amv => tpl?.amv;
		private UnityAnimation ua;
		private Material tex_mat;
		MaterialPropertyBlock mpb;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is AnimMeshVertexComponent_Template) {
				tpl = template as AnimMeshVertexComponent_Template;
				CreateGameObjects(gao);

			}
		}

		private void CreateGameObjects(GameObject gao) {
			var context = UbiArtContext;
			if (!context.Loader.LoadAnimations) return;
			tex_mat = GFXMaterialShader_Template.GetShaderMaterial(shader: tpl?.material?.shader?.obj);

			var parentGao = new GameObject($"AnimMeshVertex");
			var unityAMV = parentGao.AddComponent<UnityAnimMeshVertex>();
			unityAMV.transform.SetParent(gao.transform, false);
			unityAMV.transform.localPosition = Vector3.zero;
			unityAMV.transform.localRotation = Quaternion.identity;
			unityAMV.transform.localScale = Vector3.one;

			unityAMV.AnimMeshVertexComponent = this;
			unityAMV.AnimMeshVertexComponentTemplate = tpl;
			var stringIDs = (context.Settings.Game == Game.RA || context.Settings.Game == Game.RM) ?
				amv.animFriendly_adv.Select(a => new StringID((uint)(a & 0xFFFFFFFF))).ToArray() :
				amv.animFriendly.ToArray();
			unityAMV.anims = stringIDs.Select((sid, i) => new UnityAnimMeshVertex.AnimationTrack() {
				ID = sid,
				Index = (int)amv.animIndex[i],
				Data = anims?.FirstOrDefault(a => a.animName == sid),
				Name = sid?.ToString(context)
			}).ToArray();
			if (unityAMV.anims.Any()) {
				unityAMV.animIndex = 0;
				if (anims.Any()) {
					unityAMV.animIndex = unityAMV.anims.FindItemIndex(a => a.Data == anims[0]);
				}
			}
			unityAMV.Init();
		}


		public GameObject CreatePatch(GameObject gao, int index, out MeshRenderer renderer, out Mesh mesh, out MeshFilter filter) {
			GameObject patch_gao = new GameObject($"AnimMeshVertex - Patch {index}");
			patch_gao.transform.SetParent(gao.transform, false);
			patch_gao.transform.localPosition = Vector3.zero;
			patch_gao.transform.localRotation = Quaternion.identity;
			patch_gao.transform.localScale = Vector3.one;

			filter = patch_gao.AddComponent<MeshFilter>();
			renderer = patch_gao.AddComponent<MeshRenderer>();
			renderer.sharedMaterial = tex_mat;
			mesh = new Mesh();
			mesh.vertices = new Vector3[] {
				new Vector3(-1, 1, 0),
				new Vector3(-1, -1, 0),
				new Vector3(1, 1, 0),
				new Vector3(1, -1, 0),
			};
			mesh.normals = Enumerable.Repeat(Vector3.forward, 4).ToArray();
			mesh.SetTriangles(new int[] {
				1, 0, 2,
				1, 2, 3
			}, 0);

			filter.sharedMesh = mesh;

			FillMaterialParams(renderer);
			tpl?.material?.FillUnityMaterialPropertyBlock(UbiArtContext, renderer, index: 0, shader: null);

			return patch_gao;
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

		public void SetColor(UnityEngine.Color col, Renderer r, int index = 0) {
			if (mpb == null) mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			mpb.SetColor("_ColorFactor", col);
			r.SetPropertyBlock(mpb, index);
		}

	}
}
