using UbiArt.FileFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt {
	public class Pointer : IEquatable<Pointer> {
		public long Offset { get; set; }
		public UbiArtFile File { get; set; }

		public Pointer(long offset, UbiArtFile file) {
			this.Offset = offset;
			this.File = file;
		}

		public override bool Equals(System.Object obj) {
			return obj is Pointer && this == (Pointer)obj;
		}
		public override int GetHashCode() {
			return Offset.GetHashCode() ^ File.GetHashCode();
		}

		public bool Equals(Pointer other) {
			return this == (Pointer)other;
		}

		public static bool operator ==(Pointer x, Pointer y) {
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null)) return false;
			if (ReferenceEquals(y, null)) return false;
			return x.Offset == y.Offset && x.File == y.File;
		}
		public static bool operator !=(Pointer x, Pointer y) {
			return !(x == y);
		}
		public static Pointer operator +(Pointer x, long y) {
			return new Pointer((x.Offset + y), x.File);
		}
		public static Pointer operator -(Pointer x, long y) {
			return new Pointer((x.Offset - y), x.File);
		}
		public override string ToString() {
			if (File != null) {
				return File.FilePath + "|" + String.Format("0x{0:X8}", Offset);
			} else {
				return "FakeFile|" + String.Format("0x{0:X8}", Offset);
			}
		}
	}
}