namespace UbiArt.Bundle {
	public class FilePackMaster : ICSerializable {
		public CListO<pair<FileHeaderRuntime, Path>> files;

		public void Serialize(CSerializerObject s, string name) {
			files = s.SerializeObject<CListO<pair<FileHeaderRuntime, Path>>>(files);
		}

		public FilePackMaster() {
			files = new CListO<pair<FileHeaderRuntime, Path>>();
		}
	}
}
