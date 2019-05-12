using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Animations;

namespace UbiArt.Animation {
	// See: ITF::AnimSkeleton::serialize
	// skl.ckd file
	public class AnimSkeleton : CSerializable {
		[Serialize("version"     )] public uint version;
		[Serialize("boneTags"    )] public CList<StringID> boneTags;
		[Serialize("boneIndices" )] public CList<StringID> boneIndices;
		[Serialize("boneTags2"   )] public CList<StringID> boneTags2;
		[Serialize("boneIndices2")] public CList<StringID> boneIndices2;
		[Serialize("boneTags2"   )] public CList<StringID> boneTags3;
		[Serialize("boneTags"    )] public CList<ulong> boneTagsAdv;
		[Serialize("boneTags2"   )] public CList<ulong> boneTags2Adv;
		[Serialize("boneTags3"   )] public CList<ulong> boneTags3Adv;
		[Serialize("boneIndices3")] public CList<StringID> boneIndices3;
		[Serialize("bones"       )] public CList<AnimBone> bones;
		[Serialize("bonesDyn"    )] public CList<AnimBoneDyn> bonesDyn;
		[Serialize("byteArray"   )] public CArray<CArray<byte>> byteArray;
		[Serialize("byteArray"   )] public byte[] byteArrayOrigins;
		[Serialize("bankId0"     )] public uint bankId0;
		[Serialize("bankId"      )] public uint bankId;
		[Serialize("bank"        )] public Nullable<AnimPolylineBank> bank;
		[Serialize("bank"        )] public AnimPolylineBank bankOrigins;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(version));
			if (Settings.s.game == Settings.Game.RA) {
				SerializeField(s, nameof(boneTagsAdv));
				SerializeField(s, nameof(boneIndices));
				SerializeField(s, nameof(boneTags2Adv));
				SerializeField(s, nameof(boneIndices2));
				SerializeField(s, nameof(boneTags3Adv));
				SerializeField(s, nameof(boneIndices3));
			} else {
				SerializeField(s, nameof(boneTags));
				SerializeField(s, nameof(boneIndices));
				SerializeField(s, nameof(boneTags2));
				SerializeField(s, nameof(boneIndices2));
				if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
					SerializeField(s, nameof(boneTags3));
					SerializeField(s, nameof(boneIndices3));
				}
			}
			SerializeField(s, nameof(bones));
			SerializeField(s, nameof(bonesDyn));
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				SerializeField(s, nameof(byteArray));
			} else {
				s.SerializeBytes(ref byteArrayOrigins, 8);
			}
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bankId0));
			}
			SerializeField(s, nameof(bankId));
			if (bankId != 0) {
				if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
					SerializeField(s, nameof(bank));
				} else {
					SerializeField(s, nameof(bankOrigins));
				}
			}
			/*
			Example of what comes after bonesDyn:
			00000000
			01CE8C67
			F77E1A0C
			*/

			/*
			legends example:
			00000000
			01CE8227
			0713E113
			*/
		}
		public AnimBone GetBoneFromLink(Link link) {
			return bones.FirstOrDefault(b => b.key == link);
		}
		public int GetBoneIndexFromTag(StringID tag) {
			if (Settings.s.game == Settings.Game.RA) {
				return boneTagsAdv.IndexOf(boneTagsAdv.First(b => tag.stringID == b));
			} else {
				return boneTags.IndexOf(tag);
			}
		}

		public UnityBone[] CreateBones(GameObject gao) {
			UnityBone[] unityBones = new UnityBone[bones.Count];
			for (int i = 0; i < bones.Count; i++) {
				GameObject boneGao = new GameObject("Bone " + i);
				unityBones[i] = boneGao.AddComponent<UnityBone>();
				unityBones[i].bind = true;
				unityBones[i].transform.parent = gao.transform;
			}
			ResetBones(unityBones);
			return unityBones;
		}

		public void ResetBones(UnityBone[] unityBones) {
			for (int i = 0; i < bones.Count; i++) {
				/*if (bones[i].parentKey.stringID != 0) {
					AnimBone parent = GetBoneFromLink(bones[i].parentKey);
					int parentIndex = bones.IndexOf(parent);
					unityBones[i].parent = unityBones[parentIndex];
				} else {
					unityBones[i].parent = gao.transform;
				}*/
				if (bones[i].parentKey.stringID != 0) {
					AnimBone parent = GetBoneFromLink(bones[i].parentKey);
					int parentIndex = bones.IndexOf(parent);
					unityBones[i].parent = unityBones[parentIndex];
				} else {
					unityBones[i].parent = null;
				}
				unityBones[i].bindPosition = bonesDyn[i].position;
				unityBones[i].bindScale = bonesDyn[i].scale;
				unityBones[i].bindRotation = bonesDyn[i].angle;
				//unityBones[i].xOffset = bonesDyn[i].float1;
				unityBones[i].localPosition = Vector3.zero;
				unityBones[i].localScale = Vector3.one;
				unityBones[i].localRotation = 0;
				unityBones[i].bindZ = bonesDyn[i].z;
				unityBones[i].localZ = 0;
				if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
					unityBones[i].xOffset = bonesDyn[i].xOffset;
					unityBones[i].xScaleMultiplier = bonesDyn[i].xOffset;
				}
				//unityBones[i].UpdateBone();
			}

			// Calculate T Pose
			int[] updateOrder = GetBonesUpdateOrder();
			for (int i = 0; i < updateOrder.Length; i++) {
				unityBones[updateOrder[i]].UpdateBone();
			}
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

		public int[] GetBonesUpdateOrder() {
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
					if (bones[i].parentKey == bones[curBone].key) {
						boneQueue.Enqueue(i);
					}
				}
			}
			if (currentIndex != bones.Count) MapLoader.Loader.print(currentIndex + " - " + bones.Count);
			return order;
		}

		public void ResetBonesZero(Transform[] unityBones) {
			for (int i = 0; i < bones.Count; i++) {
				UnityBone b = unityBones[i].GetComponent<UnityBone>();
				b.parent = null;
				b.localPosition = Vector3.zero;
				b.localScale = Vector3.one;
				b.localRotation = new Angle(0);
				b.UpdateBone();
				/*b.bindPosition = bonesDyn[i].position;
				unityBones[i].localScale = bonesDyn[i].scale;
				b.bindRotation = Quaternion.Euler(new Vector3(0, 0, bonesDyn[i].angle.EulerAngle));
				b.localPosition = Vector3.zero;
				b.localRotation = Quaternion.identity;*/
			}
		}
	}
}
