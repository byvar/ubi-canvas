using System;
using System.IO;
using UnityEngine;

namespace UbiArt {
	public class Reader : BinaryReader {
		[Flags]
		public enum Flags {
			None = 0,
			Tag = 1,
			AddObjectSizes = 2,
			/*Option3 = 4,
			AddObjectSizes = 8*/
		}

		public Flags flags = Flags.None;
		public delegate void ReadAction(Reader reader, Pointer offset);
		bool isLittleEndian = true;
		uint bytesReadSinceAlignStart = 0;
		bool autoAlignOn = false;
		public Reader(System.IO.Stream stream) : base(stream) { isLittleEndian = true; }
		public Reader(System.IO.Stream stream, bool isLittleEndian) : base(stream) { this.isLittleEndian = isLittleEndian; }
		public bool AutoAligning {
			get { return autoAlignOn; }
			set { autoAlignOn = value; bytesReadSinceAlignStart = 0; }
		}

		public override bool ReadBoolean() {
			var data = ReadBytes(4);
			foreach (byte b in data) {
				if (b != 0) return true;
			}
			return false;
		}

		public override int ReadInt32() {
			var data = ReadBytes(4);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			return BitConverter.ToInt32(data, 0);
		}

		public override float ReadSingle() {
			var data = ReadBytes(4);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			return BitConverter.ToSingle(data, 0);
		}

		public override Int16 ReadInt16() {
			var data = ReadBytes(2);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			return BitConverter.ToInt16(data, 0);
		}

		public override UInt16 ReadUInt16() {
			var data = ReadBytes(2);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			return BitConverter.ToUInt16(data, 0);
		}

		public override Int64 ReadInt64() {
			var data = ReadBytes(8);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			return BitConverter.ToInt64(data, 0);
		}

		public override UInt64 ReadUInt64() {
			var data = ReadBytes(8);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			return BitConverter.ToUInt64(data, 0);
		}

		public override UInt32 ReadUInt32() {
			var data = ReadBytes(4);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			return BitConverter.ToUInt32(data, 0);
		}

		public override byte[] ReadBytes(int count) {
			byte[] bytes = base.ReadBytes(count);
			if (autoAlignOn) bytesReadSinceAlignStart += (uint)bytes.Length;
			return bytes;
		}

		public override byte ReadByte() {
			byte result = base.ReadByte();
			if (autoAlignOn) bytesReadSinceAlignStart++;
			return result;
		}

		public override char ReadChar() {
			return Convert.ToChar(ReadByte());
		}

		public string ReadNullDelimitedString() {
			string result = "";
			char c = Convert.ToChar(ReadByte());
			while (c != 0x0) {
				result += c;
				c = Convert.ToChar(ReadByte());
			}
			return result;
		}
		public override string ReadString() {
			int size = ReadInt32();
			if (size > 0) {
				return ReadString(size);
			} else if (size == 0) {
				return "";
			} else {
				return null;
			}
		}
		public string ReadString16() {
			int size = ReadInt32();
			if (size > 0) {
				return System.Text.Encoding.BigEndianUnicode.GetString(ReadBytes(size * 2)).TrimEnd('\0');
			} else if (size == 0) {
				return "";
			} else {
				return null;
			}
		}
		public string ReadString(int size) {
			return System.Text.Encoding.UTF8.GetString(ReadBytes(size)).TrimEnd('\0');
		}
		public Vector2 ReadVector2() {
			return new Vector2(ReadSingle(), ReadSingle());
		}
		public Vector3 ReadVector3() {
			return new Vector3(ReadSingle(), ReadSingle(), ReadSingle());
		}
		public Vector4 ReadVector4() {
			return new Vector4(ReadSingle(), ReadSingle(), ReadSingle(), ReadSingle());
		}
		public Color ReadColor() {
			float b = ReadSingle();
			float g = ReadSingle();
			float r = ReadSingle();
			float a = ReadSingle();
			return new Color(r, g, b, a);
		}

		// To make sure position is a multiple of alignBytes
		public void Align(int alignBytes) {
			if (BaseStream.Position % alignBytes != 0) {
				ReadBytes(alignBytes - (int)(BaseStream.Position % alignBytes));
			}
		}

		// To make sure position is a multiple of alignBytes after reading a block of blocksize, regardless of prior position
		public void Align(int blockSize, int alignBytes) {
			int rest = blockSize % alignBytes;
			if (rest > 0) {
				byte[] aligned = ReadBytes(alignBytes - rest);
				foreach (byte b in aligned) if (b != 0x0) throw new Exception("fuuuuuuuu");
			}
		}

		public void AutoAlign(int alignBytes) {
			if (bytesReadSinceAlignStart % alignBytes != 0) {
				ReadBytes(alignBytes - (int)(bytesReadSinceAlignStart % alignBytes));
			}
			bytesReadSinceAlignStart = 0;
		}

	}
}