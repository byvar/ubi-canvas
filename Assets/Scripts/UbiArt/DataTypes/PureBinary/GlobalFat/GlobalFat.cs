using System.Collections.Generic;
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

		#region Editing
		private FolderDescriptor GetOrAddFolder(string folder) {
			FolderDescriptor f = folders.FirstOrDefault(fo => fo.path == folder);
			if (f == null) {
				f = new FolderDescriptor() {
					id = (ushort)folders.Count,
					path = folder
				};
				folders.Add(f);
			}
			return f;
		}
		private void RemoveFolder(string path, bool recursive = false) {
			FolderDescriptor f = folders.FirstOrDefault(fo => fo.path == path);
			if (f != null) {
				folders.Remove(f);
				List<FileDescriptor> filesInFolder = files.Where(fi => fi.folder == f.id).ToList();
				foreach (FileDescriptor file in filesInFolder) {
					RemoveFile(file, false);
				}
				foreach (FolderDescriptor folder in folders) {
					if (folder.id >= f.id) f.id--;
				}
				foreach (FileDescriptor file in files) {
					if (file.folder >= f.id) file.folder--;
				}
			}
			if (recursive) {
				List<FolderDescriptor> subfolders = folders.Where(fo => fo.path.StartsWith(path)).ToList();
				foreach (FolderDescriptor subfolder in subfolders) {
					RemoveFolder(subfolder.path, false);
				}
			}
		}
		private void RemoveFile(FileDescriptor f, bool removeFolderIfEmpty) {
			files.RemoveAll(fi => fi.id == f.id);
			if (removeFolderIfEmpty) {
				FolderDescriptor fo = folders.FirstOrDefault(fol => fol.id == f.folder);
				if (fo != null) {
					if (!files.Any(fi => fi.folder == fo.id)) {
						RemoveFolder(fo.path, false);
					}
				}
			}
		}

		public void RemovePath(Path path) {
			FileDescriptor f = files.FirstOrDefault(fi => fi.id == path.stringID);
			if (f != null) {
				RemoveFile(f, true);
			}
		}

		/// <summary>
		/// Gets or adds new file. Does not link file to a bundle, so remember to use LinkFile afterwards.
		/// </summary>
		/// <param name="path">File path</param>
		/// <returns></returns>
		public FileDescriptor GetOrAddFile(Path path) {
			FileDescriptor f = files.FirstOrDefault(fi => fi.id == path.stringID);
			if (f == null) {
				FolderDescriptor folder = GetOrAddFolder(path.folder);
				f = new FileDescriptor() {
					id = path.stringID,
					filename = path.filename,
					folder = folder.id
				};
				files.Add(f);
			}
			return f;
		}

		public BundleDescriptor GetOrAddBundle(string bundle) {
			BundleDescriptor b = bundles.FirstOrDefault(bd => bd.Name == bundle);
			if (b == null) {
				b = new BundleDescriptor() {
					ID = (byte)bundles.Count,
					Name = bundle
				};
				bundles.Add(b);
			}
			return b;
		}

		public void LinkFile(Path path, string bundle) {
			BundleDescriptor b = bundles.FirstOrDefault(bd => bd.Name == bundle);
			if (b != null) {
				FileDescriptor f = files.FirstOrDefault(fi => fi.id == path.stringID);
				if (f != null) {
					LinkFile(f, b);
				}
			}
		}
		public void UnlinkFile(Path path, string bundle) {
			BundleDescriptor b = bundles.FirstOrDefault(bd => bd.Name == bundle);
			if (b != null) {
				FileDescriptor f = files.FirstOrDefault(fi => fi.id == path.stringID);
				if (f != null) {
					UnlinkFile(f, b);
				}
			}
		}
		public void LinkFile(FileDescriptor file, BundleDescriptor bundle) {
			if (bundle == null || file == null) return;
			if (!file.bundles.Contains(bundle.ID)) {
				file.bundles.Add(bundle.ID);
				//file.bundleIDs.Insert(0, bundle.id);
			}
		}
		public void UnlinkFile(FileDescriptor file, BundleDescriptor bundle) {
			if (bundle == null || file == null) return;
			if (file.bundles.Contains(bundle.ID)) {
				file.bundles.Remove(bundle.ID);
			}
		}
		public void UnlinkFileAll(Path path) {
			UnlinkFileAll(files.FirstOrDefault(fi => fi.id == path.stringID));
		}
		public void UnlinkFileAll(FileDescriptor file) {
			if (file == null) return;
			file.bundles.Clear();
		}
		#endregion
	}
}
