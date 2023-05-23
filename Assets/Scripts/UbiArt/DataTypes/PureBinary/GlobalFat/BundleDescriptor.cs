namespace UbiArt.GlobalFat {
	public class BundleDescriptor : ICSerializable {
		public byte ID;
		public string Name;

		public void Serialize(CSerializerObject s, string name) {
			ID = s.Serialize<byte>(ID, name: "ID");
			Name = s.Serialize<string>(Name, name: "Name");
		}
	}
}
