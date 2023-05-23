namespace UbiArt.GlobalFat {
	public class FolderDescriptor : ICSerializable {
		public string path;
		public ushort id;

		public void Serialize(CSerializerObject s, string name) {
			path = s.Serialize<string>(path, name: "path");
			id = s.Serialize<ushort>(id, name: "id");
		}
	}
}
