using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class TextureGraphicComponent {

		public override void InitUnityComponent(Actor act, GameObject gao, int index) {
			base.InitUnityComponent(act, gao, index);
			if (material != null && material.textureSet != null && material.textureSet.tex_diffuse != null) {
				MeshFilter mf = gao.AddComponent<MeshFilter>();
				MeshRenderer mr = gao.AddComponent<MeshRenderer>();
				mf.sharedMesh = CreateMesh(material.textureSet.tex_diffuse);
				Material mat = new Material(MapLoader.Loader.baseMaterial);
				mat.SetTexture("_MainTex", material.textureSet.tex_diffuse.Texture);
				mr.material = mat;
			} else if (act.template != null && act.template.obj != null && act.template.obj.COMPONENTS.Count > index
				&& act.template.obj.COMPONENTS[index].obj != null
				&& act.template.obj.COMPONENTS[index].obj is TextureGraphicComponent_Template) {
				TextureGraphicComponent_Template tpl = act.template.obj.COMPONENTS[index].obj as TextureGraphicComponent_Template;
				if (tpl.material != null && tpl.material.textureSet != null && tpl.material.textureSet.tex_diffuse != null) {
					MeshFilter mf = gao.AddComponent<MeshFilter>();
					MeshRenderer mr = gao.AddComponent<MeshRenderer>();
					mf.sharedMesh = CreateMesh(tpl.material.textureSet.tex_diffuse);
					Material mat = new Material(MapLoader.Loader.baseMaterial);
					mat.SetTexture("_MainTex", tpl.material.textureSet.tex_diffuse.Texture);
					mr.material = mat;
				}
			}
		}

		private Mesh CreateMesh(TextureCooked tex) {
			CArray<Vector2> uvsArr = null;
			Mesh meshUnity = new Mesh();
			if (spriteIndex != 0xFFFFFFFF && tex.atlas != null) {
				if (tex.atlas.uvData.ContainsKey((int)spriteIndex)) {
					uvsArr = tex.atlas.uvData[(int)spriteIndex].uvs;
					MapLoader.Loader.print(material.textureSet.diffuse + " - " + uvsArr.Count);
				}
			}
			Vector3[] vertices = new Vector3[4];
			if (Settings.s.game == Settings.Game.COL) {
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
			int[] triangles = new int[] { 0, 1, 2, 1, 3, 2 };
			meshUnity.vertices = vertices;
			meshUnity.normals = normals;
			meshUnity.triangles = triangles;
			meshUnity.SetUVs(0, uvs.ToList());
			return meshUnity;
		}
	}
}
