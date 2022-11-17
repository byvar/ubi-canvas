namespace UbiArt.UV {
	public class UVAtlasManager : CSerializable {
		public uint unk;
		public CMap<StringID, UVAtlas> atlas;

		protected override void SerializeImpl(CSerializerObject s) {
			unk = s.Serialize<uint>(unk, name: "unk");
			atlas = s.SerializeObject<CMap<StringID, UVAtlas>>(atlas, name: "atlas");
		}

		public UVAtlas GetAtlasIfExists(Path path) {
			if (atlas != null && atlas.ContainsKey(path.stringID)) {
				return atlas[path.stringID];
			}
			return null;
		}

		public void Reinit(Settings settings) {
			foreach(var at in atlas)
				at.Value?.Reinit(settings);
		}
	}
}
