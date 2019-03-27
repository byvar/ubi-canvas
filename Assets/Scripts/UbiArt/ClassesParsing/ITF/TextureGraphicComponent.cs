using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class TextureGraphicComponent {

		public override void InitUnityComponent(Actor act, GameObject gao) {
			base.InitUnityComponent(act, gao);
			if (material != null && material.textureSet != null && material.textureSet.diffuseTex != null) {
				MeshFilter mf = gao.AddComponent<MeshFilter>();
				MeshRenderer mr = gao.AddComponent<MeshRenderer>();
				mf.sharedMesh = CreateMesh();
				Material mat = new Material(MapLoader.Loader.baseMaterial);
				mat.SetTexture("_MainTex", material.textureSet.diffuseTex.Texture);
				mr.material = mat;
			}
		}

		private Mesh CreateMesh() {
			Mesh meshUnity = new Mesh();
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
			uvs[0] = new Vector3(0, 1);
			uvs[1] = new Vector3(0, 0);
			uvs[2] = new Vector3(1, 1);
			uvs[3] = new Vector3(1, 0);
			int[] triangles = new int[] { 0, 1, 2, 1, 3, 2 };
			meshUnity.vertices = vertices;
			meshUnity.normals = normals;
			meshUnity.triangles = triangles;
			meshUnity.SetUVs(0, uvs.ToList());
			return meshUnity;
		}
	}
}
