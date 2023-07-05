using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UbiArt.Animation {
	public static class AnimTemplateExtensions {

		public static UnityBone[] GetBones(this AnimTemplate atl, Context context, Mesh mesh, GameObject skeleton_gao, AnimSkeleton skeleton, UnityBone[] skeletonBones) {
			UnityBone[] unityBones = new UnityBone[atl.bones.Count];
			for (int i = 0; i < atl.bones.Count; i++) {
				int boneIndex = skeleton.GetBoneIndexFromTag(atl.bones[i].tag);
				if (boneIndex == -1) continue;
				unityBones[i] = skeletonBones[boneIndex];
				//Vector3 scale = bonesDyn[i].scale / skeleton.bonesDyn[boneIndex].scale;
				//unityBones[i].localScale = new Vector3(Mathf.Abs(scale.y), Mathf.Abs(scale.x), scale.z);
				unityBones[i].bindPosition = Vector3.zero;
				unityBones[i].bindRotation = 0;
				if (context.Settings.engineVersion <= Settings.EngineVersion.RO) {
					unityBones[i].xOffset = atl.bonesDyn[i].xScale;
					unityBones[i].xScaleMultiplier = skeleton.bonesDyn[boneIndex].xScale / atl.bonesDyn[i].xScale;
				}
				//unityBones[i].bindRotation = bonesDyn[i].angle - unityBones[i].globalAngle;
				unityBones[i].bindScale = atl.bonesDyn[i].scale.GetUnityVector() / unityBones[i].computedScale;
				unityBones[i].bindScale = new Vector3(
					unityBones[i].bindScale.y,
					unityBones[i].bindScale.x,
					unityBones[i].bindScale.z);
				if (atl.bones[i].parentKey.stringID != 0) {
					AnimBone parent = atl.GetBoneFromLink(atl.bones[i].parentKey);
					int parentIndex = skeleton.GetBoneIndexFromTag(parent.tag);
					unityBones[i].parent = skeletonBones[parentIndex];
				} else {
					unityBones[i].parent = null;
				}
			}
			int[] updateOrder = atl.GetBonesUpdateOrder(null);
			for (int i = 0; i < updateOrder.Length; i++) {
				if (unityBones[updateOrder[i]] == null) continue;
				unityBones[updateOrder[i]].UpdateBone();
			}
			Matrix4x4[] bindPoses = new Matrix4x4[atl.bones.Count];
			for (int i = 0; i < atl.bones.Count; i++) {
				if (unityBones[i] == null) continue;
				bindPoses[i] = unityBones[i].transform.worldToLocalMatrix * skeleton_gao.transform.localToWorldMatrix;
			}
			skeleton.ResetBones(context, skeletonBones);
			mesh.bindposes = bindPoses;
			return unityBones;
		}


		public static void ResetBones(this AnimTemplate atl, Transform[] unityBones, AnimSkeleton skeleton) {
			for (int i = 0; i < atl.bones.Count; i++) {
				int boneIndex = skeleton.GetBoneIndexFromTag(atl.bones[i].tag);
				UnityBone b = unityBones[boneIndex].GetComponent<UnityBone>();
				if (atl.bones[i].parentKey.stringID != 0) {
					AnimBone parent = atl.GetBoneFromLink(atl.bones[i].parentKey);
					int parentIndex = skeleton.GetBoneIndexFromTag(parent.tag);
					b.parent = unityBones[parentIndex].GetComponent<UnityBone>();
				} else {
					b.parent = null;
				}
				b.localPosition = atl.bonesDyn[i].position.GetUnityVector();
				b.localScale = atl.bonesDyn[i].scale.GetUnityVector();
				b.localRotation = atl.bonesDyn[i].angle;
				b.UpdateBone();
			}
		}
		public static void ResetBonesZero(this AnimTemplate atl, Transform[] unityBones, AnimSkeleton skeleton) {
			for (int i = 0; i < atl.bones.Count; i++) {
				int boneIndex = skeleton.GetBoneIndexFromTag(atl.bones[i].tag);
				UnityBone b = unityBones[boneIndex].GetComponent<UnityBone>();
				b.parent = null;
				b.localPosition = Vector3.zero;
				b.localScale = Vector3.one;
				b.localRotation = new Angle(0);
				b.UpdateBone();
			}
		}
		public static Mesh CreateMesh(this AnimTemplate atl) {
			Mesh meshUnity = new Mesh();
			List<Link> pointLinks = atl.patches.SelectMany(p => p.points).Distinct().ToList();
			Vector3[] verts = new Vector3[pointLinks.Count];
			Vector2[] uvs = new Vector2[pointLinks.Count];
			BoneWeight[] weights = new BoneWeight[pointLinks.Count];
			List<int> tris = new List<int>();
			for (int i = 0; i < pointLinks.Count; i++) {
				AnimPatchPoint pp = atl.GetPointFromLink(pointLinks[i]);
				verts[i] = pp.local.pos.GetUnityVector();
				uvs[i] = pp.uv.GetUnityVector();
				AnimBone bone = atl.GetBoneFromLink(pp.local.boneId);
				if (bone != null) {
					weights[i] = new BoneWeight() {
						boneIndex0 = atl.bones.IndexOf(bone),
						weight0 = 1,
						weight1 = 0,
						weight2 = 0,
						weight3 = 0
					};
				}
			}
			for (int i = 0; i < atl.patches.Count; i++) {
				AnimPatch p = atl.patches[i];
				int[] trisPatch = new int[(p.numPoints - 2) * 3];
				List<int> pointIndices = p.points.Select(link => pointLinks.IndexOf(link)).ToList();
				for (int j = 0; j < p.numPoints - 2; j++) {
					if (j % 2 == 0) {
						trisPatch[(j * 3) + 1] = pointIndices[j];
						trisPatch[(j * 3)] = pointIndices[j + 1];
						trisPatch[(j * 3) + 2] = pointIndices[j + 2];
					} else {
						trisPatch[(j * 3)] = pointIndices[j];
						trisPatch[(j * 3) + 1] = pointIndices[j + 1];
						trisPatch[(j * 3) + 2] = pointIndices[j + 2];
					}
				}
				tris.AddRange(trisPatch);
			}
			if (verts.Length < 3) return null;
			Vector3[] normals = Enumerable.Repeat(Vector3.forward, verts.Length).ToArray();
			meshUnity.vertices = verts;
			meshUnity.normals = normals;
			meshUnity.SetTriangles(tris, 0);
			meshUnity.uv = uvs;
			meshUnity.boneWeights = weights;
			//meshUnity.SetUVs(4, Enumerable.Repeat(Vector4.one, 4).ToList());
			return meshUnity;
		}
	}
}
