using System.Collections.Generic;
using System.Linq;

namespace UbiArt.Animation {
	// See: ITF::AnimSkeleton::serialize
	// skl.ckd file
	public class AnimSkeleton : CSerializable {
		public const uint VersionLegends = 0xF;

		public uint version;
		public CListO<StringID> boneTags; // StringIDs of the bone names. Example in Rayman's skl: B_Ray_Head
		public CListO<StringID> boneIndices;
		public CListP<ulong> boneTagsAdv;

		public CListO<StringID> boneTags2;
		public CListO<StringID> boneIndices2;
		public CListP<ulong> boneTags2Adv;

		public CListO<StringID> subskeletonTags; // Example names in Rayman's skl: Naked, Knight, Basic, Splinter, Mario, Demo.
		public CListO<StringID> subskeletonIndices;
		public CListP<ulong> subskeletonTagsAdv;

		public CListO<AnimBone> bones;
		public CListO<AnimBoneDyn> bonesDyn;
		public CArrayO<CArrayP<byte>> subskeletonConfigs; // Basically setups for which bones are enabled/visible in each skeleton
		public byte[] byteArrayOrigins;
		public uint bankId0;
		public uint bankId;
		public Nullable<AnimPolylineBank> bank;
		public AnimPolylineBank bankOrigins;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");
			if (s.Settings.Game == Game.RA || s.Settings.Game == Game.RM) {
				boneTagsAdv = s.SerializeObject<CListP<ulong>>(boneTagsAdv, name: "boneTags");
				boneIndices = s.SerializeObject<CListO<StringID>>(boneIndices, name: "boneIndices");
				boneTags2Adv = s.SerializeObject<CListP<ulong>>(boneTags2Adv, name: "boneTags2");
				boneIndices2 = s.SerializeObject<CListO<StringID>>(boneIndices2, name: "boneIndices2");
				subskeletonTagsAdv = s.SerializeObject<CListP<ulong>>(subskeletonTagsAdv, name: "subskeletonTags"); // matches subSkeleton
				subskeletonIndices = s.SerializeObject<CListO<StringID>>(subskeletonIndices, name: "subskeletonIndices");
			} else {
				boneTags = s.SerializeObject<CListO<StringID>>(boneTags, name: "boneTags");
				boneIndices = s.SerializeObject<CListO<StringID>>(boneIndices, name: "boneIndices");
				boneTags2 = s.SerializeObject<CListO<StringID>>(boneTags2, name: "boneTags2");
				boneIndices2 = s.SerializeObject<CListO<StringID>>(boneIndices2, name: "boneIndices2");
				if (s.Settings.EngineVersion > EngineVersion.RO) {
					subskeletonTags = s.SerializeObject<CListO<StringID>>(subskeletonTags, name: "subskeletonTags"); // matches subSkeleton
					subskeletonIndices = s.SerializeObject<CListO<StringID>>(subskeletonIndices, name: "subskeletonIndices");
				}
			}
			bones = s.SerializeObject<CListO<AnimBone>>(bones, name: "bones");
			bonesDyn = s.SerializeObject<CListO<AnimBoneDyn>>(bonesDyn, name: "bonesDyn");
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				subskeletonConfigs = s.SerializeObject<CArrayO<CArrayP<byte>>>(subskeletonConfigs, name: "subskeletonConfigs"); // subskeletonConfigs[numsubskeletons][numbones]
			}
			if (s.Settings.EngineVersion <= EngineVersion.RO || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				bankId0 = s.Serialize<uint>(bankId0, name: "bankId0");
			}
			bankId = s.Serialize<uint>(bankId, name: "bankId");
			if (bankId != 0) {
				bank = s.SerializeObject<Nullable<AnimPolylineBank>>(bank, name: "bank");
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
			if (s.Context.HasSettings<ConversionSettings>()) {
				var conv = s.Context.GetSettings<ConversionSettings>();
				if (conv.OldSettings.EngineVersion <= EngineVersion.RO && s.Settings.EngineVersion > EngineVersion.RO && version < VersionLegends) {
					version = VersionLegends;
				}
			}
			Reinit(s.Settings);
		}

		public AnimBone GetBoneFromLink(Link link) {
			return bones.FirstOrDefault(b => b.key == link);
		}
		public int GetBoneIndexFromTag(StringID tag) {
			if (UbiArtContext.Settings.Game == Game.RA || UbiArtContext.Settings.Game == Game.RM) {
				if (boneTagsAdv.Any(b => tag.stringID == b)) {
					return boneTagsAdv.IndexOf(boneTagsAdv.First(b => tag.stringID == b));
				} else {
					return -1;
				}
			} else {
				return boneTags.IndexOf(tag);
			}
		}
		public int GetBoneIndexFromTag2(StringID tag) {
			if (UbiArtContext.Settings.Game == Game.RA || UbiArtContext.Settings.Game == Game.RM) {
				if (boneTags2Adv.Any(b => tag.stringID == b)) {
					return boneTags2Adv.IndexOf(boneTags2Adv.First(b => tag.stringID == b));
				} else {
					return -1;
				}
			} else {
				return boneTags2.IndexOf(tag);
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
			if (settings.Game == Game.RL && version >= VersionLegends) {
				version = VersionLegends;
				if (boneTags == null) {
					boneTags = new CListO<StringID>();
					if (boneTagsAdv != null) {
						foreach (var bta in boneTagsAdv) boneTags.Add(new StringID((uint)bta));
					}
				}
				if (boneTags2 == null) {
					boneTags2 = new CListO<StringID>();
					if (boneTags2Adv != null) {
						foreach (var bta in boneTags2Adv) boneTags2.Add(new StringID((uint)bta));
					}
				}
				if (subskeletonTags == null) {
					subskeletonTags = new CListO<StringID>();
					if (subskeletonTagsAdv != null) {
						foreach (var bta in subskeletonTagsAdv) subskeletonTags.Add(new StringID((uint)bta));
					}
				}
			}
		}
	}
}
