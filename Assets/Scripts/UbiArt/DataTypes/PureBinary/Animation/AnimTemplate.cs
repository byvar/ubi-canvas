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
			if (s.Settings.EngineVersion <= EngineVersion.RO) {
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
		public static Vec2d[] GetPatchControlPoints(Vec2d[] points, Vec2d[] normals) {
			var N01 = (float)(points[0] - points[1]).Magnitude * 0.5f;
			var N23 = (float)(points[2] - points[3]).Magnitude * 0.5f;
			var result = new Vec2d[8];
			result[0] = points[0];
			result[1] = new Vec2d(points[0].x - normals[0].y * N01, points[0].y + normals[0].x * N01);
			result[2] = new Vec2d(points[1].x + normals[1].y * N01, points[1].y - normals[1].x * N01);
			result[3] = points[1];
			result[4] = points[2];
			result[5] = new Vec2d(points[2].x - normals[2].y * N23, points[2].y + normals[2].x * N01);
			result[6] = new Vec2d(points[3].x + normals[3].y * N23, points[3].y - normals[3].x * N01);
			result[7] = points[3];
			return result;
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
