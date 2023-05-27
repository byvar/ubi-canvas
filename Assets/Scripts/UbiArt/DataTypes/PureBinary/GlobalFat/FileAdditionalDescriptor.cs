namespace UbiArt.GlobalFat {
	public class FileAdditionalDescriptor : ICSerializable {
		public StringID id;
		public ushort folder;
		public string filename;

		public void Serialize(CSerializerObject s, string name) {
			id = s.SerializeObject<StringID>(id, name: "id");
			folder = s.Serialize<ushort>(folder, name: "folder");
			filename = s.Serialize<string>(filename, name: "filename");
		}
	}
}
