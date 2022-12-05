using System.Collections.Generic;
using System.Linq;

namespace UbiArt.Animation {
	// See: ITF::AnimSkeleton::serialize
	// skl.ckd file
	public class AnimSkeleton : CSerializable {
		public const uint VersionLegends = 0xF;

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

		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Settings);
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
			if (currentIndex != bones.Count) UbiArtContext.SystemLogger?.LogInfo(currentIndex + " - " + bones.Count);
			return order;
		}
		public void Reinit(Settings settings) {
			if (settings.game == Settings.Game.RL && version >= VersionLegends) {
				version = VersionLegends;
				if (boneTags == null) {
					boneTags = new CListO<StringID>();
					foreach (var bta in boneTagsAdv) boneTags.Add(new StringID((uint)bta));
				}
				if (boneTags2 == null) {
					boneTags2 = new CListO<StringID>();
					foreach(var bta in boneTags2Adv) boneTags2.Add(new StringID((uint)bta));
				}
				if (boneTags3 == null) {
					boneTags3 = new CListO<StringID>();
					foreach(var bta in boneTags3Adv) boneTags3.Add(new StringID((uint)bta));
				}
			}
		}
	}
}
