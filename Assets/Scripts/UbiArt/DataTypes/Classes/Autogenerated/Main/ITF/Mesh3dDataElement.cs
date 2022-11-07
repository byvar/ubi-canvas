namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Mesh3dDataElement : CSerializable {
		public Path path;
		public Path dummyPath;
		public uint textureIndex;
		public StringID family;
		public int familyIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			path = s.SerializeObject<Path>(path, name: "path");
			dummyPath = s.SerializeObject<Path>(dummyPath, name: "dummyPath");
			textureIndex = s.Serialize<uint>(textureIndex, name: "textureIndex");
			family = s.SerializeObject<StringID>(family, name: "family");
			familyIndex = s.Serialize<int>(familyIndex, name: "familyIndex");
		}
	}
}

