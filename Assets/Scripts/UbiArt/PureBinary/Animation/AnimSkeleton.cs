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
		[Serialize("boneIndices3")] public CList<StringID> boneIndices3;
		[Serialize("bones"       )] public CList<AnimBone> bones;
		[Serialize("bonesDyn"    )] public CList<AnimBoneDyn> bonesDyn;
		[Serialize("byteArray"   )] public CArray<CArray<byte>> byteArray;
		[Serialize("bankId0"     )] public uint bankId0;
		[Serialize("bankId"      )] public uint bankId;
		[Serialize("bank"        )] public Nullable<AnimPolylineBank> bank;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(boneTags));
			SerializeField(s, nameof(boneIndices));
			SerializeField(s, nameof(boneTags2));
			SerializeField(s, nameof(boneIndices2));
			SerializeField(s, nameof(boneTags3));
			SerializeField(s, nameof(boneIndices3));
			SerializeField(s, nameof(bones));
			SerializeField(s, nameof(bonesDyn));
			SerializeField(s, nameof(byteArray));
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bankId0));
			}
			SerializeField(s, nameof(bankId));
			if (bankId != 0) {
				SerializeField(s, nameof(bank));
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
			return boneTags.IndexOf(tag);
		}

		public Transform[] CreateBones(GameObject gao) {
			Transform[] unityBones = new Transform[bones.Count];
			for (int i = 0; i < bones.Count; i++) {
				GameObject boneGao = new GameObject("Bone " + i);
				boneGao.AddComponent<UnityBone>();
				unityBones[i] = boneGao.transform;
			}
			for (int i = 0; i < bones.Count; i++) {
				/*if (bones[i].parentKey.stringID != 0) {
					AnimBone parent = GetBoneFromLink(bones[i].parentKey);
					int parentIndex = bones.IndexOf(parent);
					unityBones[i].parent = unityBones[parentIndex];
				} else {
					unityBones[i].parent = gao.transform;
				}*/
				unityBones[i].parent = gao.transform;
				unityBones[i].localPosition = Vector3.zero;
				unityBones[i].localScale = Vector3.one;
				unityBones[i].localRotation = Quaternion.identity;
			}
			return unityBones;
		}

		public void ResetBones(Transform[] unityBones) {
			for (int i = 0; i < bones.Count; i++) {
				UnityBone b = unityBones[i].GetComponent<UnityBone>();
				if (bones[i].parentKey.stringID != 0) {
					AnimBone parent = GetBoneFromLink(bones[i].parentKey);
					int parentIndex = bones.IndexOf(parent);
					b.parent = unityBones[parentIndex].GetComponent<UnityBone>();
					/*ParentConstraint p = unityBones[i].gameObject.AddComponent<ParentConstraint>();
					p.constraintActive = false;
					p.AddSource(new ConstraintSource() { sourceTransform = unityBones[parentIndex], weight = 1 });
					p.translationOffsets
					unityBones[i].parent = unityBones[parentIndex];*/
				}
				b.localPosition = bonesDyn[i].position;
				b.localScale = bonesDyn[i].scale;
				b.localRotation = bonesDyn[i].angle;
				b.bindPosition = bonesDyn[i].position;
				b.bindScale = bonesDyn[i].scale;
				b.bindRotation = bonesDyn[i].angle;
				
				b.localPosition = Vector3.zero;
				b.localScale = Vector3.one;
				b.localRotation = new Angle(0);
				b.bind = true;
				b.UpdateBone();
			}
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
