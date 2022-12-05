namespace UbiArt.UV {
	public class UVAtlas : CSerializable {
		public static uint versionLegends = 0xC;
		public static uint versionAdventures = 0x12;
		public uint version;
		public CMap<int, UVdata> uvData;
		public CMap<int, UVparameters> uvParams;
		public CMap<int, Vec3d> uv3D;
		public float float0;
		public float float1;

		protected override void SerializeImpl(CSerializerObject s) {
			version = s.Serialize<uint>(version, name: "version");
			uvData = s.SerializeObject<CMap<int, UVdata>>(uvData, name: "uvData");
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				uvParams = s.SerializeObject<CMap<int, UVparameters>>(uvParams, name: "uvParams");
				if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
					uv3D = s.SerializeObject<CMap<int, Vec3d>>(uv3D, name: "uv3D");
					float0 = s.Serialize<float>(float0, name: "float0");
					float1 = s.Serialize<float>(float1, name: "float1");
				}
			}
		}

		public void Reinit(Settings settings) {
			if (settings.game == Settings.Game.RL && version >= versionLegends) {
				version = versionLegends;
			}
		}
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Settings);
		}

	}
}
