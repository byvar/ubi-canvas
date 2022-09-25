using UbiArt.FileFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt {
	public class Pointer : IEquatable<Pointer> {
		public long offset;
		public FileWithPointers file;
		public Pointer(long offset, FileWithPointers file) {
			this.offset = offset;
			this.file = file;
		}

		public long FileOffset => offset;

		public override bool Equals(System.Object obj) {
			return obj is Pointer && this == (Pointer)obj;
		}
		public override int GetHashCode() {
			return offset.GetHashCode() ^ file.GetHashCode();
		}

		public bool Equals(Pointer other) {
			return this == (Pointer)other;
		}

		public static bool operator ==(Pointer x, Pointer y) {
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null)) return false;
			if (ReferenceEquals(y, null)) return false;
			return x.offset == y.offset && x.file == y.file;
		}
		public static bool operator !=(Pointer x, Pointer y) {
			return !(x == y);
		}
		public static Pointer operator +(Pointer x, long y) {
			return new Pointer((x.offset + y), x.file);
		}
		public static Pointer operator -(Pointer x, long y) {
			return new Pointer((x.offset - y), x.file);
		}
		public override string ToString() {
			if (file != null) {
				return file.name + "|" + String.Format("0x{0:X8}", offset);
			} else {
				return "FakeFile|" + String.Format("0x{0:X8}", offset);
			}
		}

		public static Pointer Current(Reader reader) {
			Context l = Controller.MainContext;
			long curPos = reader.BaseStream.Position;
			FileWithPointers curFile = l.GetFileByReader(reader);
			return new Pointer(curPos, curFile);
		}


		public static Pointer Current(Writer writer) {
			Context l = Controller.MainContext;
			long curPos = writer.BaseStream.Position;
			FileWithPointers curFile = l.GetFileByWriter(writer);
			return new Pointer(curPos, curFile);
		}
	}
}