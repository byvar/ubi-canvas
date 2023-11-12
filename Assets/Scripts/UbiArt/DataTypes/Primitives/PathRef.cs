using System;

namespace UbiArt {
	public class PathRef : Path, IEquatable<PathRef> {

		public PathRef() : base() { }
		public PathRef(PathRef p) : base(p) { }
		public PathRef(string folder, string filename, bool cooked = false) : base(folder, filename, cooked: cooked) { }
		public PathRef(string fullPath, bool cooked = false) : base(fullPath, cooked: cooked) { }


		public override string ToString() {
			if (stringID.IsNull) return "PathRef(null)";
			return $"PathRef(\"{folder}\", \"{filename}\", {stringID.stringID:X8})";
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
	}
}
