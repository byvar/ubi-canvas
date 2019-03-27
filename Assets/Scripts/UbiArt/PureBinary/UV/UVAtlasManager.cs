namespace UbiArt.UV {
	public class UVAtlasManager : CSerializable {
		[Serialize("unk"  )] public uint unk;
		[Serialize("atlas")] public CMap<StringID, UVAtlas> atlas;

		protected override void SerializeImpl(CSerializerObject s) {
			SerializeField(s, nameof(unk));
			SerializeField(s, nameof(atlas));
		}

		public UVAtlas GetAtlasIfExists(Path path) {
			if (atlas != null && atlas.ContainsKey(path.stringID)) {
				return atlas[path.stringID];
			}
			return null;
		}
	}
}
