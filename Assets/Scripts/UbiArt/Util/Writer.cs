using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace UbiArt {
	public class Writer : BinaryWriter {
		bool isLittleEndian = true;
		public Writer(System.IO.Stream stream) : base(stream) { isLittleEndian = true; }
		public Writer(System.IO.Stream stream, bool isLittleEndian) : base(stream) { this.isLittleEndian = isLittleEndian; }

		public override void Write(Boolean value) {
			if (value == true) {
				Write(1);
			} else {
				Write(0);
			}
		}
		public override void Write(Char value) {
			Write(Convert.ToByte(value));
		}

		public override void Write(Int32 value) {
			var data = BitConverter.GetBytes(value);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			base.Write(data);
		}

		public override void Write(Int16 value) {
			var data = BitConverter.GetBytes(value);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			base.Write(data);
		}

		public override void Write(UInt32 value) {
			var data = BitConverter.GetBytes(value);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			base.Write(data);
		}

		public override void Write(UInt16 value) {
			var data = BitConverter.GetBytes(value);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			base.Write(data);
		}

		public override void Write(Int64 value) {
			var data = BitConverter.GetBytes(value);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			base.Write(data);
		}

		public override void Write(UInt64 value) {
			var data = BitConverter.GetBytes(value);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			base.Write(data);
		}

		public override void Write(Single value) {
			var data = BitConverter.GetBytes(value);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			base.Write(data);
		}

		public override void Write(Double value) {
			var data = BitConverter.GetBytes(value);
			if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
			base.Write(data);
		}

		public override void Write(String value) {
			var data = Encoding.ASCII.GetBytes(value);
			Write(data.Length);
			Write(data);
		}
		public void Write16(String value) {
			var data = Encoding.BigEndianUnicode.GetBytes(value);
			Write(data.Length / 2);
			Write(data);
		}

		public void Write(Vector2 value) {
			Write(value.x);
			Write(value.y);
		}

		public void Write(Vector3 value) {
			Write(value.x);
			Write(value.y);
			Write(value.z);
		}

		public void Write(Vector4 value) {
			Write(value.x);
			Write(value.y);
			Write(value.z);
			Write(value.w);
		}

		public void Write(Color value) {
			Write(value.b);
			Write(value.g);
			Write(value.r);
			Write(value.a);
		}

		// To make sure position is a multiple of alignBytes
		public void Align(int alignBytes) {
			if (BaseStream.Position % alignBytes != 0) {
				BaseStream.Seek(alignBytes - (int)(BaseStream.Position % alignBytes), SeekOrigin.Current);
			}
		}

		// To make sure position is a multiple of alignBytes after reading a block of blocksize, regardless of prior position
		public void Align(int blockSize, int alignBytes) {
			int rest = blockSize % alignBytes;
			if (rest > 0) {
				BaseStream.Seek(alignBytes - rest, SeekOrigin.Current);
			}
		}
	}
}