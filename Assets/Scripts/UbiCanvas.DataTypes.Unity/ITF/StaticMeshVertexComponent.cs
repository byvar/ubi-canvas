using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UbiCanvas;
using UbiCanvas.Helpers;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class StaticMeshVertexComponent {
		private StaticMeshVertexComponent_Template tpl;
		private UnityAnimation ua;
		MaterialPropertyBlock mpb;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is StaticMeshVertexComponent_Template) {
				tpl = template as StaticMeshVertexComponent_Template;
				CreateGameObjects(gao);

			}
		}

		private void CreateGameObjects(GameObject gao) {
			var context = UbiArtContext;
			Material tex_mat = GFXMaterialShader_Template.GetShaderMaterial(shader: material?.shader?.obj);
			foreach (var element in staticMeshElements) {
				CreateGameObject(element, gao);
			}
		}

		private GameObject CreateGameObject(StaticMeshElement element, GameObject gao) {
			GameObject mesh_static;
			MeshRenderer mr_static;
			mesh_static = new GameObject($"{element?.frisePath?.id}");
			mesh_static.transform.SetParent(gao.transform, false);
			var unityPos = (element.pos?.GetUnityVector(invertZ: true) ?? Vector3.zero);
			mesh_static.transform.localPosition = unityPos + new Vector3(0, 0, 0.005f);// Vector3.zero;
			mesh_static.transform.localRotation = Quaternion.identity;
			mesh_static.transform.localScale = Vector3.one;
			Mesh mesh = new Mesh();
			mesh.subMeshCount = 1;
			element.pos.GetUnityVector();
			mesh.vertices = element.staticVertexList.Select(v => new Vector3(v.pos.x, v.pos.y, -v.pos.z) - unityPos).ToArray();
			mesh.uv = element.staticVertexList.Select(v => v.uv1.GetUnityVector()).ToArray();
			mesh.colors = element.staticVertexList.Select(v => v.color.GetUnityColor()).ToArray();

			MeshFilter mf = mesh_static.AddComponent<MeshFilter>();
			MeshRenderer mr = mesh_static.AddComponent<MeshRenderer>();
			Material mat = material.GetShaderMaterial();

			mr.sharedMaterial = mat;
				
			int trisCount = element.staticIndexList.Count;
			int[] tris = new int[trisCount];

			for (int i = 0; i < trisCount / 3; i++) {
				tris[(i * 3) + 0] = element.staticIndexList[(i * 3) + 0];
				tris[(i * 3) + 1] = element.staticIndexList[(i * 3) + 1];
				tris[(i * 3) + 2] = element.staticIndexList[(i * 3) + 2];
			}
			mesh.SetTriangles(tris, 0);

			material?.FillUnityMaterialPropertyBlock(UbiArtContext, mr, index: 0, shader: null);
			FillMaterialParams(mr, 0);
			GenericFile<GFXMaterialShader_Template> sh = material.shader;
			if (sh != null && sh.obj != null && !sh.obj.renderRegular && (sh.obj.renderBackLight || sh.obj.renderFrontLight)) {
				mesh_static.layer = 0;
				if (sh.obj.renderFrontLight) mesh_static.layer |= LayerMask.NameToLayer("FrontLight");
				if (sh.obj.renderBackLight) mesh_static.layer |= LayerMask.NameToLayer("BackLight");
				if (sh.obj.renderRegular) mesh_static.layer |= LayerMask.NameToLayer("Default");
			}
			
			mf.sharedMesh = mesh;
			mr_static = mr;

			return mesh_static;
		}

		private void FillMaterialParams(Renderer r, int index = 0) {
			//bool hasConfig = config != null && config.obj != null;
			//if (!hasConfig) return;
			//GFXPrimitiveParam param = (UseTemplatePrimitiveParams && hasConfig) ? config.obj.PrimitiveParameters : PrimitiveParameters;

			MaterialPropertyBlock mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			GFXPrimitiveParam param = PrimitiveParameters;
			mpb.SetColor("_ColorFactor", param.colorFactor.GetUnityColor());
			mpb.SetColor("_LightConfig", new Vector4(
				param.FrontLightBrightness,
				param.FrontLightContrast,
				param.BackLightBrightness,
				param.BackLightContrast));
			mpb.SetColor("_ColorFog", param.colorFog.GetUnityColor());
			r.SetPropertyBlock(mpb, index);
		}
	}
}
