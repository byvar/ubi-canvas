using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class TextureGraphicComponent {
		public UnityTextureGraphicComponent tex_gao_component;
		public Material tex_mat;
		public MeshRenderer tex_renderer;
		public TextureGraphicComponent_Template tpl;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is TextureGraphicComponent_Template) {
				tpl = template as TextureGraphicComponent_Template;
			}
			if (material != null && material.textureSet != null && material.textureSet.tex_diffuse != null) {
				CreateGameObject(gao, material);
			} else if (tpl != null) {
				if (tpl.material != null && tpl.material.textureSet != null && tpl.material.textureSet.tex_diffuse != null) {
					CreateGameObject(gao, tpl.material);
				}
			}
		}

		private void CreateGameObject(GameObject gao, GFXMaterialSerializable material) {
			GameObject tex_gao = new GameObject("TextureGraphicComponent");
			tex_gao.transform.SetParent(gao.transform, false);
			tex_gao.transform.localPosition = Vector3.zero;
			tex_gao.transform.localRotation = Quaternion.identity;
			tex_gao.transform.localScale = Vector3.one;
			if (tpl != null) {
				var pos = tpl?.posOffset?.GetUnityVector() ?? Vector2.zero;
				tex_gao.transform.localPosition = new Vector3(pos.x, pos.y, -tpl.zOffset);

				var scl = tpl?.size?.GetUnityVector() ?? Vector2.one;
				tex_gao.transform.localScale = new Vector3(scl.x, scl.y, 1f);
			}
			tex_gao_component = tex_gao.AddComponent<UnityTextureGraphicComponent>();
			tex_gao_component.tgc = this;
			
			MeshFilter mf = tex_gao.AddComponent<MeshFilter>();
			MeshRenderer mr = tex_gao.AddComponent<MeshRenderer>();
			mf.sharedMesh = CreateMesh(material.textureSet.tex_diffuse);
			tex_mat = material.GetShaderMaterial();
			tex_renderer = mr;
			material.FillUnityMaterialPropertyBlock(UbiArtContext, tex_renderer);
			FillMaterialParams(tex_renderer);
			mr.sharedMaterial = tex_mat;
		}

		private Mesh CreateMesh(TextureCooked tex) {
			CArrayO<Vec2d> uvsArr = null;
			Mesh meshUnity = new Mesh();
			if (spriteIndex != 0xFFFFFFFF && tex.atlas != null) {
				if (tex.atlas.uvData.ContainsKey((int)spriteIndex)) {
					uvsArr = tex.atlas.uvData[(int)spriteIndex].uvs;
					UbiArtContext.SystemLogger?.LogInfo("Texture path with UV count:" + material.textureSet.diffuse + " - " + uvsArr.Count);
				}
			}
			Vector3[] vertices = new Vector3[4];
			if (UbiArtContext.Settings.Game == Game.COL) {
				vertices[0] = new Vector3(-size.x / 2f, -size.y / 2f, 0f);
				vertices[1] = new Vector3(-size.x / 2f, size.y / 2f, 0f);
				vertices[2] = new Vector3(size.x / 2f, -size.y / 2f, 0f);
				vertices[3] = new Vector3(size.x / 2f, size.y / 2f, 0f);
			} else {
				vertices[0] = new Vector3(-0.5f, -0.5f, 0f);
				vertices[1] = new Vector3(-0.5f, 0.5f, 0f);
				vertices[2] = new Vector3(0.5f, -0.5f, 0f);
				vertices[3] = new Vector3(0.5f, 0.5f, 0f);
			}
			Vector3[] normals = new Vector3[4];
			normals[0] = Vector3.forward;
			normals[1] = Vector3.forward;
			normals[2] = Vector3.forward;
			normals[3] = Vector3.forward;
			Vector3[] uvs = new Vector3[4];
			if (uvsArr == null || uvsArr.Count != 2) {
				uvs[0] = new Vector3(0, 1);
				uvs[1] = new Vector3(0, 0);
				uvs[2] = new Vector3(1, 1);
				uvs[3] = new Vector3(1, 0);
			} else {
				uvs[0] = new Vector3(uvsArr[0].x, uvsArr[1].y);
				uvs[1] = new Vector3(uvsArr[0].x, uvsArr[0].y);
				uvs[2] = new Vector3(uvsArr[1].x, uvsArr[1].y);
				uvs[3] = new Vector3(uvsArr[1].x, uvsArr[0].y);
			}
			int[] triangles = new int[] { 0, 1, 2, 2, 1, 3 };
			meshUnity.vertices = vertices;
			meshUnity.normals = normals;
			meshUnity.triangles = triangles;
			meshUnity.SetUVs(0, uvs.ToList());
			//meshUnity.SetUVs(4, Enumerable.Repeat(Vector4.one, 4).ToList());
			return meshUnity;
		}
		private void FillMaterialParams(Renderer r, int index = 0) {
			MaterialPropertyBlock mpb = new MaterialPropertyBlock();
			r.GetPropertyBlock(mpb, index);
			GFXPrimitiveParam param = PrimitiveParameters;
			param?.FillMaterialParams(UbiArtContext, mpb);
			r.SetPropertyBlock(mpb, index);
		}
	}
}
