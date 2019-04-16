using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTemplate::serialize
	public class AnimTemplate : CSerializable {
		[Serialize("boneKeys"   )] public KeyArray<int> boneKeys;
		[Serialize("bones"      )] public CList<AnimBone> bones;
		[Serialize("bonesDyn"   )] public CList<AnimBoneDyn> bonesDyn;
		[Serialize("patchPoints")] public CList<AnimPatchPoint> patchPoints;
		[Serialize("patches"    )] public CList<AnimPatch> patches;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(boneKeys));
			SerializeField(s, nameof(bones));
			SerializeField(s, nameof(bonesDyn));
			SerializeField(s, nameof(patchPoints));
			SerializeField(s, nameof(patches));
		}

		public AnimPatchPoint GetPointFromLink(Link link) {
			return patchPoints.FirstOrDefault(p => p.key == link);
		}

		public AnimBone GetBoneFromLink(Link link) {
			return bones.FirstOrDefault(b => b.key == link);
		}
		public Transform[] GetBones(Mesh mesh, GameObject skeleton_gao, AnimSkeleton skeleton, Transform[] skeletonBones) {
			/*Transform[] unityBones = new Transform[bones.Count];
			for (int i = 0; i < bones.Count; i++) {
				GameObject boneGao = new GameObject("Bone " + i);
				unityBones[i] = boneGao.transform;
			}
			for (int i = 0; i < bones.Count; i++) {
				if (bones[i].parentKey.stringID != 0) {
					AnimBone parent = GetBoneFromLink(bones[i].parentKey);
					int parentIndex = bones.IndexOf(parent);
					unityBones[i].parent = unityBones[parentIndex];
				} else {
					unityBones[i].parent = gao.transform;
				}
				unityBones[i].localPosition = Vector3.zero;
				unityBones[i].localScale = Vector3.one;
				unityBones[i].localRotation = Quaternion.identity;
			}
			Matrix4x4[] bindPoses = new Matrix4x4[bones.Count];
			for (int i = 0; i < bones.Count; i++) {
				bindPoses[i] = unityBones[i].worldToLocalMatrix * gao.transform.localToWorldMatrix;
			}
			for (int i = 0; i < bones.Count; i++) {
				unityBones[i].localPosition = bonesDyn[i].origin;
				unityBones[i].localScale = bonesDyn[i].scale;
				unityBones[i].localEulerAngles = new Vector3(0,0,bonesDyn[i].angle.EulerAngle);
			}
			mesh.bindposes = bindPoses;
			return unityBones;*/
			Transform[] unityBones = new Transform[bones.Count];
			for (int i = 0; i < bones.Count; i++) {
				int boneIndex = skeleton.GetBoneIndexFromTag(bones[i].tag);
				//unityBones[i] = skeletonBones[boneIndex];
				Transform parentBone = skeletonBones[boneIndex];
				GameObject boneGao = new GameObject("Bone " + i);
				unityBones[i] = boneGao.transform;
				unityBones[i].transform.SetParent(parentBone);
			}
			/*for (int i = 0; i < bones.Count; i++) {
				unityBones[i].localPosition = bonesDyn[i].position;
				unityBones[i].localScale = bonesDyn[i].scale;
				unityBones[i].localRotation = bonesDyn[i].angle.QuaternionAngle;
			}*/
			/*for (int i = 0; i < bones.Count; i++) {
				unityBones[i].localPosition = Vector3.zero;
				unityBones[i].localScale = Vector3.one;
				unityBones[i].localRotation = Quaternion.identity;
			}*/
			for (int i = 0; i < bones.Count; i++) {
				unityBones[i].parent.localPosition = Vector3.zero;
				unityBones[i].parent.localScale = Vector3.one;
				unityBones[i].parent.localRotation = Quaternion.identity;
				//unityBones[i].parent.localScale = bonesDyn[i].scale;
				//unityBones[i].parent.localRotation = bonesDyn[i].angle.QuaternionAngle;
			}
			   //ResetBones(skeletonBones, skeleton);
			Matrix4x4[] bindPoses = new Matrix4x4[bones.Count];
			for (int i = 0; i < bones.Count; i++) {
				bindPoses[i] = unityBones[i].worldToLocalMatrix * skeleton_gao.transform.localToWorldMatrix;
			}
			for (int i = 0; i < bones.Count; i++) {
				unityBones[i].parent.localPosition = Vector3.zero;
				unityBones[i].parent.localScale = Vector3.one;
				unityBones[i].parent.localRotation = Quaternion.identity;
			}
			//ResetBonesZero(skeletonBones, skeleton);
			/*for (int i = 0; i < bones.Count; i++) {
				unityBones[i].localPosition = bonesDyn[i].position;
				unityBones[i].localScale = bonesDyn[i].scale;
				unityBones[i].localRotation = bonesDyn[i].angle.QuaternionAngle;
			}*/
			mesh.bindposes = bindPoses;
			return unityBones;
		}
		public void ResetBones(Transform[] unityBones, AnimSkeleton skeleton) {
			for (int i = 0; i < bones.Count; i++) {
				int boneIndex = skeleton.GetBoneIndexFromTag(bones[i].tag);
				UnityBone b = unityBones[boneIndex].GetComponent<UnityBone>();
				if (bones[i].parentKey.stringID != 0) {
					AnimBone parent = GetBoneFromLink(bones[i].parentKey);
					int parentIndex = skeleton.GetBoneIndexFromTag(parent.tag);
					b.parent = unityBones[parentIndex].GetComponent<UnityBone>();
				} else {
					b.parent = null;
				}
				b.localPosition = bonesDyn[i].position;
				b.localScale = bonesDyn[i].scale;
				b.localRotation = bonesDyn[i].angle;
				b.UpdateBone();
			}
		}
		public void ResetBonesZero(Transform[] unityBones, AnimSkeleton skeleton) {
			for (int i = 0; i < bones.Count; i++) {
				int boneIndex = skeleton.GetBoneIndexFromTag(bones[i].tag);
				UnityBone b = unityBones[boneIndex].GetComponent<UnityBone>();
				b.parent = null;
				b.localPosition = Vector3.zero;
				b.localScale = Vector3.one;
				b.localRotation = new Angle(0);
				b.UpdateBone();
			}
		}
		public Mesh CreateMesh() {
			Mesh meshUnity = new Mesh();
			List<Link> pointLinks = patches.SelectMany(p => p.points).Distinct().ToList();
			Vector3[] verts = new Vector3[pointLinks.Count];
			Vector2[] uvs = new Vector2[pointLinks.Count];
			BoneWeight[] weights = new BoneWeight[pointLinks.Count];
			List<int> tris = new List<int>();
			for (int i = 0; i < pointLinks.Count; i++) {
				AnimPatchPoint pp = GetPointFromLink(pointLinks[i]);
				verts[i] = pp.local.pos;
				uvs[i] = pp.uv;
				AnimBone bone = GetBoneFromLink(pp.local.boneId);
				if (bone != null) {
					weights[i] = new BoneWeight() {
						boneIndex0 = bones.IndexOf(bone),
						weight0 = 1,
						weight1 = 0,
						weight2 = 0,
						weight3 = 0
					};
				}
			}
			for (int i = 0; i < patches.Count; i++) {
				AnimPatch p = patches[i];
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
