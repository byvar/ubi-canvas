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
		public uint version;
		public CListO<StringID> boneTags;
		public CListO<StringID> boneIndices;
		public CListO<StringID> boneTags2;
		public CListO<StringID> boneIndices2;
		public CListO<StringID> boneTags3;
		public CListP<ulong> boneTagsAdv;
		public CListP<ulong> boneTags2Adv;
		public CListP<ulong> boneTags3Adv;
		public CListO<StringID> boneIndices3;
		public CListO<AnimBone> bones;
		public CListO<AnimBoneDyn> bonesDyn;
		public CArrayO<CArrayP<byte>> byteArray;
		public byte[] byteArrayOrigins;
		public uint bankId0;
		public uint bankId;
		public Nullable<AnimPolylineBank> bank;
		public AnimPolylineBank bankOrigins;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");
			if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
				boneTagsAdv = s.SerializeObject<CListP<ulong>>(boneTagsAdv, name: "boneTags");
				boneIndices = s.SerializeObject<CListO<StringID>>(boneIndices, name: "boneIndices");
				boneTags2Adv = s.SerializeObject<CListP<ulong>>(boneTags2Adv, name: "boneTags2");
				boneIndices2 = s.SerializeObject<CListO<StringID>>(boneIndices2, name: "boneIndices2");
				boneTags3Adv = s.SerializeObject<CListP<ulong>>(boneTags3Adv, name: "boneTags3"); // matches subSkeleton
				boneIndices3 = s.SerializeObject<CListO<StringID>>(boneIndices3, name: "boneIndices3");
			} else {
				boneTags = s.SerializeObject<CListO<StringID>>(boneTags, name: "boneTags");
				boneIndices = s.SerializeObject<CListO<StringID>>(boneIndices, name: "boneIndices");
				boneTags2 = s.SerializeObject<CListO<StringID>>(boneTags2, name: "boneTags2");
				boneIndices2 = s.SerializeObject<CListO<StringID>>(boneIndices2, name: "boneIndices2");
				if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
					boneTags3 = s.SerializeObject<CListO<StringID>>(boneTags3, name: "boneTags3"); // matches subSkeleton
					boneIndices3 = s.SerializeObject<CListO<StringID>>(boneIndices3, name: "boneIndices3");
				}
			}
			bones = s.SerializeObject<CListO<AnimBone>>(bones, name: "bones");
			bonesDyn = s.SerializeObject<CListO<AnimBoneDyn>>(bonesDyn, name: "bonesDyn");
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				byteArray = s.SerializeObject<CArrayO<CArrayP<byte>>>(byteArray, name: "byteArray");
			} else {
				byteArrayOrigins = s.SerializeBytes(byteArrayOrigins, 8);
			}
			if (s.Settings.game == Settings.Game.RL) {
				bankId0 = s.Serialize<uint>(bankId0, name: "bankId0");
			}
			bankId = s.Serialize<uint>(bankId, name: "bankId");
			if (bankId != 0) {
				if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
					bank = s.SerializeObject<Nullable<AnimPolylineBank>>(bank, name: "bank");
				} else {
					bankOrigins = s.SerializeObject<AnimPolylineBank>(bankOrigins, name: "bank");
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
			if (UbiArtContext.Settings.game == Settings.Game.RA || UbiArtContext.Settings.game == Settings.Game.RM) {
				if (boneTagsAdv.Any(b => tag.stringID == b)) {
					return boneTagsAdv.IndexOf(boneTagsAdv.First(b => tag.stringID == b));
				} else {
					return -1;
				}
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
				unityBones[i].bindPosition = (Vector2)bonesDyn[i].position;
				unityBones[i].bindScale = (Vector2)bonesDyn[i].scale;
				unityBones[i].bindRotation = bonesDyn[i].angle;
				//unityBones[i].xOffset = bonesDyn[i].float1;
				unityBones[i].localPosition = Vector3.zero;
				unityBones[i].localScale = Vector3.one;
				unityBones[i].localRotation = 0;
				unityBones[i].bindZ = bonesDyn[i].z;
				unityBones[i].localZ = 0;
				if (UbiArtContext.Settings.engineVersion <= Settings.EngineVersion.RO) {
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
				b.localRotation = 0f;
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
