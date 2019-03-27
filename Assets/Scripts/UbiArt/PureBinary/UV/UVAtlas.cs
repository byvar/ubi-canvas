namespace UbiArt.UV {
	public class UVAtlas : CSerializable {
		public static uint versionLegends = 0xC;
		public static uint versionAdventures = 0x12;
		[Serialize("version")] public uint version;
		[Serialize("uvData" )] public CMap<int, UVdata> uvData;
		[Serialize("uvParams")] public CMap<int, UVparameters> uvParams;

		protected override void SerializeImpl(CSerializerObject s) {
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(uvData));
			SerializeField(s, nameof(uvParams));
		}
	}
}
