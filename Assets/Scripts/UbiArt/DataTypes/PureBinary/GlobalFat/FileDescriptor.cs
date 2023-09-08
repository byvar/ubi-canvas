namespace UbiArt.GlobalFat {
	public class FileDescriptor : ICSerializable {
		public StringID id;
		public ushort folder;
		public string filename;
		public CListP<byte> bundles = new CListP<byte>();

		public void Serialize(CSerializerObject s, string name) {
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				id = s.SerializeObject<StringID>(id, name: "id");
				bundles = s.SerializeObject<CListP<byte>>(bundles, name: "bundles");
			} else {
				folder = s.Serialize<ushort>(folder, name: "folder");
				filename = s.Serialize<string>(filename, name: "filename");
				bundles = s.SerializeObject<CListP<byte>>(bundles, name: "bundles");
			}
		}

		public void SerializeFolderFilename(CSerializerObject s, string name) {
			id = s.SerializeObject<StringID>(id, name: "id");
			folder = s.Serialize<ushort>(folder, name: "folder");
			filename = s.Serialize<string>(filename, name: "filename");
		}
	}
}
