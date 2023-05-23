namespace UbiArt.GlobalFat {
	public class FileBundleLink : ICSerializable {
		public StringID id;
		public CListP<byte> bundles;

		public void Serialize(CSerializerObject s, string name) {
			id = s.SerializeObject<StringID>(id, name: "id");
			bundles = s.SerializeObject<CListP<byte>>(bundles, name: "bundles");
		}
	}
}
