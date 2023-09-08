using System.Collections.Generic;
using System.Linq;
using UbiCanvas.Helpers;

namespace UbiArt.GlobalFat {
	public class GlobalFat : ICSerializable {
		public CListO<BundleDescriptor> bundles = new CListO<BundleDescriptor>();
		public CListO<FileDescriptor> files = new CListO<FileDescriptor>();
		public CListO<FolderDescriptor> folders = new CListO<FolderDescriptor>();

		public void Serialize(CSerializerObject s, string name) {
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				bundles = s.SerializeObject<CListO<BundleDescriptor>>(bundles, name: "bundles");
				files = s.SerializeObject<CListO<FileDescriptor>>(files, name: "files");
				if (s.Settings.Game == Game.RL) {
					folders = s.SerializeObject<CListO<FolderDescriptor>>(folders, name: "folders");
				}
				UpdateLookupTables();

				if (s.Settings.Game == Game.RL) {
					if (s is CSerializerObjectBinary s_read) {
						var filesCount = files.Count;
						for (int i = 0; i < filesCount; i++) {
							var link = s.SerializeObject<FileAdditionalDescriptor>(default, name: name);
							var file = files[i]; // Try file at current index first
							if (file.id != link.id) file = FilesLookup[link.id]; // If that's not the right one, then search for it
							if (file != null) {
								file.folder = link.folder;
								file.filename = link.filename;
							}
						}
					} else {
						foreach (var f in files)
							f.SerializeFolderFilename(s, name);
					}
				}
			} else {
				files = s.SerializeObject<CListO<FileDescriptor>>(files, name: "files");
				bundles = s.SerializeObject<CListO<BundleDescriptor>>(bundles, name: "bundles");
				folders = s.SerializeObject<CListO<FolderDescriptor>>(folders, name: "folders");
			}
		}

		#region Editing
		Dictionary<StringID, FileDescriptor> FilesLookup = new Dictionary<StringID, FileDescriptor>();
		Dictionary<string, FolderDescriptor> FoldersLookup = new Dictionary<string, FolderDescriptor>();

		public void UpdateLookupTables() {
			FilesLookup.Clear();
			FoldersLookup.Clear();
			foreach(var f in files) FilesLookup[f.id] = f;
			foreach(var f in folders) FoldersLookup[f.path] = f;
		}


		private FolderDescriptor GetOrAddFolder(string folder) {
			FolderDescriptor f = FoldersLookup.TryGetItem(folder);
			if (f == null) {
				f = new FolderDescriptor() {
					id = (ushort)folders.Count,
					path = folder
				};
				folders.Add(f);
				FoldersLookup[f.path] = f;
			}
			return f;
		}
		private void RemoveFolder(string path, bool recursive = false) {
			FolderDescriptor f = FoldersLookup.TryGetItem(path);
			if (f != null) {
				FoldersLookup.Remove(path);
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
			FilesLookup.Remove(f.id);
			files.RemoveAll(fi => fi.id == f.id);
			if (removeFolderIfEmpty) {
				FolderDescriptor fo = folders.FirstOrDefault(fol => fol.id == f.folder); // to check: Can't we just do folders[f.folder]?
				if (fo != null) {
					if (!files.Any(fi => fi.folder == fo.id)) {
						RemoveFolder(fo.path, false);
					}
				}
			}
		}

		public void RemovePath(Path path) {
			FileDescriptor f = FilesLookup.TryGetItem(path.stringID);
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
			FileDescriptor f = FilesLookup.TryGetItem(path.stringID);
			if (f == null) {
				FolderDescriptor folder = GetOrAddFolder(path.folder);
				f = new FileDescriptor() {
					id = path.stringID,
					filename = path.filename,
					folder = folder.id
				};
				files.Add(f);
				FilesLookup[f.id] = f;
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
				FileDescriptor f = FilesLookup.TryGetItem(path.stringID);
				if (f != null) {
					LinkFile(f, b);
				}
			}
		}
		public void UnlinkFile(Path path, string bundle) {
			BundleDescriptor b = bundles.FirstOrDefault(bd => bd.Name == bundle);
			if (b != null) {
				FileDescriptor f = FilesLookup.TryGetItem(path.stringID);
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
			UnlinkFileAll(FilesLookup.TryGetItem(path.stringID));
		}
		public void UnlinkFileAll(FileDescriptor file) {
			if (file == null) return;
			file.bundles.Clear();
		}
		#endregion
	}
}
