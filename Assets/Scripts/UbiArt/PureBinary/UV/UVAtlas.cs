using UnityEngine;

namespace UbiArt.UV {
	public class UVAtlas : CSerializable {
		public static uint versionLegends = 0xC;
		public static uint versionAdventures = 0x12;
		[Serialize("version")] public uint version;
		[Serialize("uvData" )] public CMap<int, UVdata> uvData;
		[Serialize("uvParams")] public CMap<int, UVparameters> uvParams;
		[Serialize("uv3D"    )] public CMap<int, Vector3> uv3D;
		[Serialize("float0")] public float float0;
		[Serialize("float1")] public float float1;

		protected override void SerializeImpl(CSerializerObject s) {
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(uvData));
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				SerializeField(s, nameof(uvParams));
				if (Settings.s.game == Settings.Game.RA) {
					SerializeField(s, nameof(uv3D));
					SerializeField(s, nameof(float0));
					SerializeField(s, nameof(float1));
				}
			}
		}
	}
}
