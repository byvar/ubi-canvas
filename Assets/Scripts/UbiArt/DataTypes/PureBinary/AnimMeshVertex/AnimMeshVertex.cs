using UbiArt.ITF;

namespace UbiArt.Animation {
	// See: ITF::AnimMeshVertex::serialize
	// asc.ckd file
	public class AnimMeshVertex : CSerializable {
		public const uint VersionLegends = 11;

		public uint version;

		public CListO<StringID> unk1;
		public CListP<ulong> unk1Adv;

		public CListP<uint> unk2;

		public CListO<CListO<FrameMeshInfo>> frameMeshInfo;
		public CListP<uint> unk3;
		public uint unk4;
		public CListO<AABB> aabb;
		public CListO<Vec2d> vec2ds;
		public CListO<PatchData> patches;
		public CListP<string> animNames;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");

			if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
				unk1Adv = s.SerializeObject<CListP<ulong>>(unk1Adv, name: "unk1");
			} else {
				unk1 = s.SerializeObject<CListO<StringID>>(unk1, name: "unk1");
			}
			unk2 = s.SerializeObject<CListP<uint>>(unk2, name: "unk2");
			frameMeshInfo = s.SerializeObject<CListO<CListO<FrameMeshInfo>>>(frameMeshInfo, name: "frameMeshInfo");
			unk3 = s.SerializeObject<CListP<uint>>(unk3, name: "unk3");
			unk4 = s.Serialize<uint>(unk4, name: "unk4");
			aabb = s.SerializeObject<CListO<AABB>>(aabb, name: "aabb");
			vec2ds = s.SerializeObject<CListO<Vec2d>>(vec2ds, name: "vec2ds");
			patches = s.SerializeObject<CListO<PatchData>>(patches, name: "patches");
			animNames = s.SerializeObject<CListP<string>>(animNames, name: "animNames");
		}

		public void Reinit(Settings settings) {
			if (settings.engineVersion == Settings.EngineVersion.RL && version >= VersionLegends) {
				version = VersionLegends;
			}
		}
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Settings);
		}
	}
}
