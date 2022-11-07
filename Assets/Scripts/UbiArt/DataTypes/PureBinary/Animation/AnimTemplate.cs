using System.Collections.Generic;
using System.Linq;

namespace UbiArt.Animation {
	// See: ITF::AnimTemplate::serialize
	public class AnimTemplate : CSerializable {
		public KeyArray<int> boneKeys;
		public float unkfloat;
		public CListO<AnimBone> bones;
		public CListO<AnimBoneDyn> bonesDyn;
		public CListO<AnimPatchPoint> patchPoints;
		public CListO<AnimPatch> patches;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			boneKeys = s.SerializeObject<KeyArray<int>>(boneKeys, name: "boneKeys");
			if (s.Settings.engineVersion <= Settings.EngineVersion.RO) {
				unkfloat = s.Serialize<float>(unkfloat, name: "unkfloat");
			}
			bones = s.SerializeObject<CListO<AnimBone>>(bones, name: "bones");
			bonesDyn = s.SerializeObject<CListO<AnimBoneDyn>>(bonesDyn, name: "bonesDyn");
			patchPoints = s.SerializeObject<CListO<AnimPatchPoint>>(patchPoints, name: "patchPoints");
			patches = s.SerializeObject<CListO<AnimPatch>>(patches, name: "patches");
		}

		public AnimPatchPoint GetPointFromLink(Link link) {
			return patchPoints.FirstOrDefault(p => p.key == link);
		}

		public AnimBone GetBoneFromLink(Link link) {
			return bones.FirstOrDefault(b => b.key == link);
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
			if (currentIndex != bones.Count) UbiArtContext.SystemLogger?.LogInfo(currentIndex + " - " + bones.Count);
			if (skeleton != null) {
				for (int i = 0; i < bones.Count; i++) {
					order[i] = skeleton.GetBoneIndexFromTag(bones[order[i]].tag);
				}
			}
			return order;
		}
	}
}
