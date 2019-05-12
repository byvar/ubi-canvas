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
		[Serialize("unkfloat"   )] public float unkfloat;
		[Serialize("bones"      )] public CList<AnimBone> bones;
		[Serialize("bonesDyn"   )] public CList<AnimBoneDyn> bonesDyn;
		[Serialize("patchPoints")] public CList<AnimPatchPoint> patchPoints;
		[Serialize("patches"    )] public CList<AnimPatch> patches;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(boneKeys));
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
				SerializeField(s, nameof(unkfloat));
			}
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
		public UnityBone[] GetBones(Mesh mesh, GameObject skeleton_gao, AnimSkeleton skeleton, UnityBone[] skeletonBones) {
			UnityBone[] unityBones = new UnityBone[bones.Count];
			for (int i = 0; i < bones.Count; i++) {
				int boneIndex = skeleton.GetBoneIndexFromTag(bones[i].tag);
				if (boneIndex == -1) continue;
				unityBones[i] = skeletonBones[boneIndex];
				//Vector3 scale = bonesDyn[i].scale / skeleton.bonesDyn[boneIndex].scale;
				//unityBones[i].localScale = new Vector3(Mathf.Abs(scale.y), Mathf.Abs(scale.x), scale.z);
				unityBones[i].bindPosition = Vector3.zero;
				unityBones[i].bindRotation = 0;
				if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
					unityBones[i].xOffset = bonesDyn[i].xOffset;
					unityBones[i].xScaleMultiplier = skeleton.bonesDyn[boneIndex].xOffset / bonesDyn[i].xOffset;
				}
				//unityBones[i].bindRotation = bonesDyn[i].angle - unityBones[i].globalAngle;
				unityBones[i].bindScale = bonesDyn[i].scale / unityBones[i].computedScale;
				unityBones[i].bindScale = new Vector3(
					unityBones[i].bindScale.y,
					unityBones[i].bindScale.x,
					unityBones[i].bindScale.z);
				if (bones[i].parentKey.stringID != 0) {
					AnimBone parent = GetBoneFromLink(bones[i].parentKey);
					int parentIndex = skeleton.GetBoneIndexFromTag(parent.tag);
					unityBones[i].parent = skeletonBones[parentIndex];
				} else {
					unityBones[i].parent = null;
				}
			}
			int[] updateOrder = GetBonesUpdateOrder(null);
			for (int i = 0; i < updateOrder.Length; i++) {
				if (unityBones[updateOrder[i]] == null) continue;
				unityBones[updateOrder[i]].UpdateBone();
			}
			Matrix4x4[] bindPoses = new Matrix4x4[bones.Count];
			for (int i = 0; i < bones.Count; i++) {
				if (unityBones[i] == null) continue;
				bindPoses[i] = unityBones[i].transform.worldToLocalMatrix * skeleton_gao.transform.localToWorldMatrix;
			}
			skeleton.ResetBones(skeletonBones);
			mesh.bindposes = bindPoses;
			return unityBones;
		}

		public List<int> GetRootIndices() {
			List<int> rootIndices = new List<int>();
			for (int i = 0; i < bones.Count; i++) {
				if ((bones[i].parentKey.stringID == 0)) {
					rootIndices.Add(i);
				}
			}
			return rootIndices;
		}
		public int[] GetBonesUpdateOrder(AnimSkeleton skeleton) {
			int[] order = new int[bones.Count];
			List<int> rootIndices = GetRootIndices();
			int currentIndex = 0;
			Queue<int> boneQueue = new Queue<int>();
			foreach (int i in rootIndices) {
				boneQueue.Enqueue(i);
			}
			while (boneQueue.Count > 0) {
				int curBone = boneQueue.Dequeue();
				order[currentIndex++] = curBone;
				for (int i = 0; i < bones.Count; i++) {
					if(bones[i].parentKey == bones[curBone].key) {
						boneQueue.Enqueue(i);
					}
				}
			}
			if (currentIndex != bones.Count) MapLoader.Loader.print(currentIndex + " - " + bones.Count);
			if (skeleton != null) {
				for (int i = 0; i < bones.Count; i++) {
					order[i] = skeleton.GetBoneIndexFromTag(bones[order[i]].tag);
				}
			}
			return order;
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
