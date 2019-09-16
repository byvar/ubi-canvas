using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class Path : ICSerializable, IEquatable<Path> {
		public string folder;
		public string filename;
		public StringID stringID;
		public uint flags;
		public bool specialUncooked;

		public Path() {
			stringID = new StringID();
		}

		public Path(string folder, string filename, bool cooked=false) {
			folder = folder.Replace('\\', '/');
			if (folder != null && folder != "" && !folder.EndsWith("/")) folder += "/";
			if (folder != null && folder.StartsWith("/")) folder = folder.Substring(1);
			if (!cooked && filename != null && filename != "" && filename.EndsWith(".ckd")) filename = filename.Substring(0, filename.Length - 4);
			this.folder = folder;
			this.filename = filename;
			if ((folder != null && folder != "") || (filename != null && filename != "")) {
				stringID = new StringID(FullPath);
			} else {
				stringID = new StringID();
			}
		}
		public Path(string fullPath, bool cooked = false) {
			fullPath = fullPath.Replace('\\', '/');
			if (fullPath.Contains('/')) {
				folder = fullPath.Substring(0, fullPath.LastIndexOf('/') + 1);
				filename = fullPath.Substring(fullPath.LastIndexOf('/') + 1);
			} else {
				folder = "";
				filename = fullPath;
			}
			if (folder != null && folder != "" && !folder.EndsWith("/")) folder += "/";
			if (folder != null && folder.StartsWith("/")) folder = folder.Substring(1);
			if (!cooked && filename != null && filename != "" && filename.EndsWith(".ckd")) filename = filename.Substring(0, filename.Length - 4);
			if ((folder != null && folder != "") || (filename != null && filename != "")) {
				stringID = new StringID(FullPath);
			} else {
				stringID = new StringID();
			}
		}

		public string FullPath {
			get {
				return (folder ?? "") + (filename ?? "");
			}
		}

		public bool IsNull {
			get {
				return ((folder == null || folder == "") && (filename == null || filename == "") && stringID.IsNull);
			}
		}

		public bool IsCooked {
			get {
				return (folder != null && folder.StartsWith(Settings.s.ITFDirectory)) 
					|| (filename != null && filename.EndsWith(".ckd"));
			}
		}

		public Path CookedPath {
			get {
				if (!IsNull && !IsCooked) {
					return new Path(folder != null ? Settings.s.ITFDirectory + folder : null,
						filename != null ? filename + ".ckd" : null, cooked: true);
				}
				return this;
			}
		}

		public string GetExtension(bool removeCooked = false) {
			if (filename != null && filename.Contains('.')) {
				string ext = filename.Substring(filename.IndexOf('.') + 1);
				if (removeCooked && ext.EndsWith(".ckd")) ext = ext.Substring(0, ext.Length - 4);
				return ext;
			}
			return "";
		}

		public void Serialize(CSerializerObject s, string name) {
			// null path: 0, 0, -1, 0
			s.Serialize<string>(ref folder);
			s.Serialize<string>(ref filename);
			s.Serialize<StringID>(ref stringID);
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				s.Serialize<uint>(ref flags);
				if (flags != 0) MapLoader.Loader.print("Path with nonzero flags: " + this + " - " + flags);
			}
		}

		public override string ToString() {
			if (stringID.IsNull) return "Path(null)";
			return "Path(\"" + folder + "\", \"" + filename + "\")";
		}

		/* Flags:
		 * 0x8: Contains spaces?
		 * 0x10: Unicode
		 * 0x80: Absolute path (rather than relative to the bundle)
		 */
		
		public override bool Equals(object obj) {
			return obj is Path && this == (Path)obj;
		}
		public override int GetHashCode() {
			return stringID.GetHashCode();
		}

		public bool Equals(Path other) {
			return this == (Path)other;
		}

		public static bool operator ==(Path x, Path y) {
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null)) return false;
			if (ReferenceEquals(y, null)) return false;
			return x.stringID == y.stringID;
		}
		public static bool operator !=(Path x, Path y) {
			return !(x == y);
		}
		public static implicit operator Path(PathRef p) {
			return new Path {
				filename = p.filename,
				folder = p.folder,
				flags = p.flags,
				stringID = p.stringID
			};
		}
	}
}
