using System.Linq;

namespace UbiArt.GlobalFat {
	public class GlobalFat : ICSerializable {
		public CListO<BundleDescriptor> bundles;
		public CListO<FileDescriptor> files;
		public CListO<FolderDescriptor> folders;

		public void Serialize(CSerializerObject s, string name) {
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				bundles = s.SerializeObject<CListO<BundleDescriptor>>(bundles, name: "bundles");
				files = s.SerializeObject<CListO<FileDescriptor>>(files, name: "files");
				if (s.Settings.game == Settings.Game.RL) {
					folders = s.SerializeObject<CListO<FolderDescriptor>>(folders, name: "folders");
					var filesCount = files.Count;
					for (int i = 0; i < filesCount; i++) {
						if (s is CSerializerObjectBinary s_read) {
							var link = s.SerializeObject<FileBundleLink>(default, name: name);
							var file = files[i]; // Try file at current index first
							if(file.id != link.id) file = files.FirstOrDefault(f => f.id == link.id); // If that's not the right one, then search for it
							if(file != null) file.bundles = link.bundles;
						} else {
							files[i].SerializeBundles(s, name);
						}
						files = s.SerializeObject<CListO<FileDescriptor>>(files, name: "files");
					}
				}
			} else {
				files = s.SerializeObject<CListO<FileDescriptor>>(files, name: "files");
				bundles = s.SerializeObject<CListO<BundleDescriptor>>(bundles, name: "bundles");
				folders = s.SerializeObject<CListO<FolderDescriptor>>(folders, name: "folders");
			}
		}
	}
}
