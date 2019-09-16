using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class PathRef : ICSerializable, IEquatable<PathRef> {
		public string folder;
		public string filename;
		public StringID stringID;
		public uint flags;

		public PathRef() {}

		public PathRef(string folder, string filename) {
			folder = folder.Replace('\\', '/');
			if (folder != null && folder != "" && !folder.EndsWith("/")) folder += "/";
			if (folder != null && folder.StartsWith("/")) folder = folder.Substring(1);
			if (filename != null && filename.EndsWith(".ckd")) filename = filename.Substring(0, filename.Length - 4);
			this.folder = folder;
			this.filename = filename;
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

		public void Serialize(CSerializerObject s, string name) {
			// null path: 0, 0, -1, 0
			s.Serialize<string>(ref folder);
			s.Serialize<string>(ref filename);
			s.Serialize<StringID>(ref stringID);
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				s.Serialize<uint>(ref flags);
				if (flags != 0) MapLoader.Loader.print("PathRef with nonzero flags: " + this + " - " + flags);
			}
		}
		public override string ToString() {
			if (stringID.IsNull) return "PathRef(null)";
			return "PathRef(\"" + folder + "\", \"" + filename + "\")";
		}
		public override bool Equals(object obj) {
			return obj is PathRef && this == (PathRef)obj;
		}
		public override int GetHashCode() {
			return stringID.GetHashCode();
		}

		public bool Equals(PathRef other) {
			return this == (PathRef)other;
		}

		public static bool operator ==(PathRef x, PathRef y) {
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null)) return false;
			if (ReferenceEquals(y, null)) return false;
			return x.stringID == y.stringID;
		}
		public static bool operator !=(PathRef x, PathRef y) {
			return !(x == y);
		}
		public static implicit operator PathRef(Path p) {
			return new PathRef {
				filename = p.filename,
				folder = p.folder,
				flags = p.flags,
				stringID = p.stringID
			};
		}
	}
}
