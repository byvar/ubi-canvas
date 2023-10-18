using System.Linq;
using UbiArt.ITF;

namespace UbiArt.Animation {
	// See: ITF::AnimMeshVertex::serialize
	// asc.ckd file
	public class AnimMeshVertex : CSerializable {
		public const uint VersionLegends = 11;

		public uint version;

		public CListO<StringID> animFriendly;
		public CListP<ulong> animFriendly_adv;

		public CListP<uint> animIndex; // Index of an animation is found using animIndex[IndexOf(stringID, animFriendly)]

		public CListO<CListO<FrameMeshInfo>> frameMeshInfo; // frameMeshInfo[animIndex][frame]
		public CListP<uint> uvStartIndices; // Vec2ds indices?
		public CListO<CListP<uint>> unk4;
		public CListO<AABB> animAABB;
		public CListO<Vec2d> uvs;
		public CListO<PatchData> patches;
		public CListP<string> animNames;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");

			if (s.Settings.Game == Game.RA || s.Settings.Game == Game.RM) {
				animFriendly_adv = s.SerializeObject<CListP<ulong>>(animFriendly_adv, name: "animFriendly");
			} else {
				animFriendly = s.SerializeObject<CListO<StringID>>(animFriendly, name: "animFriendly");
			}
			animIndex = s.SerializeObject<CListP<uint>>(animIndex, name: "animIndex");
			frameMeshInfo = s.SerializeObject<CListO<CListO<FrameMeshInfo>>>(frameMeshInfo, name: "frameMeshInfo");
			uvStartIndices = s.SerializeObject<CListP<uint>>(uvStartIndices, name: "uvStartIndices");
			unk4 = s.SerializeObject<CListO<CListP<uint>>>(unk4, name: "unk4");
			animAABB = s.SerializeObject<CListO<AABB>>(animAABB, name: "aabb");
			uvs = s.SerializeObject<CListO<Vec2d>>(uvs, name: "uvs");
			patches = s.SerializeObject<CListO<PatchData>>(patches, name: "patches");
			animNames = s.SerializeObject<CListP<string>>(animNames, name: "animNames");
		}

		public void Reinit(Settings settings) {
			if (settings.Game == Game.RL && version >= VersionLegends) {
				version = VersionLegends;
				if (animFriendly == null && animFriendly_adv != null) {
					animFriendly = new CListO<StringID>();
					foreach (var u in animFriendly_adv) {
						animFriendly.Add(new StringID((uint)(u & 0xFFFFFFFF)));
					}
				}
				if (animNames == null || animNames.Count == 0) {
					animNames = new CListP<string>(Enumerable.Repeat("",animFriendly.Count).ToList());
				}
			}
		}
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Settings);
		}
	}
}
