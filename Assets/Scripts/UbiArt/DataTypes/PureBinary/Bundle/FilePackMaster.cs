namespace UbiArt.Bundle {
	public class FilePackMaster : ICSerializable {
		public CListO<Pair<FileHeaderRuntime, Path>> files;

		public void Serialize(CSerializerObject s, string name) {
			files = s.SerializeObject<CListO<Pair<FileHeaderRuntime, Path>>>(files);
		}

		public FilePackMaster() {
			files = new CListO<Pair<FileHeaderRuntime, Path>>();
		}
	}
}
