using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UbiArt {
    public class Reader : BinaryReader {
        public delegate void ReadAction(Reader reader, Pointer offset);
        bool isLittleEndian = true;
        uint bytesSinceAlignStart = 0;

        public Reader(Stream stream) : base(stream) { isLittleEndian = true; }
        public Reader(Stream stream, bool isLittleEndian) : base(stream) { this.isLittleEndian = isLittleEndian; }

        public override int ReadInt32() {
            byte data0 = ReadByte();
            byte data1 = ReadByte();
            byte data2 = ReadByte();
            byte data3 = ReadByte();

            if (isLittleEndian != BitConverter.IsLittleEndian) {
                return (int)((data0 << 24) | (data1 << 16) | (data2 << 8) | data3);
            } else {
                return (int)((data3 << 24) | (data2 << 16) | (data1 << 8) | data0);
            }
        }

        public override float ReadSingle() {
            var data = ReadBytes(4);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToSingle(data, 0);
        }

        public override Int16 ReadInt16() {
            byte data0 = ReadByte();
            byte data1 = ReadByte();

            if (isLittleEndian != BitConverter.IsLittleEndian) {
                return (short)((data0 << 8) | data1);
            } else {
                return (short)((data1 << 8) | data0);
            }
        }

        public override UInt16 ReadUInt16() {
            byte data0 = ReadByte();
            byte data1 = ReadByte();

            if (isLittleEndian != BitConverter.IsLittleEndian) {
                return (ushort)((data0 << 8) | data1);
            } else {
                return (ushort)((data1 << 8) | data0);
            }
        }

        public override Int64 ReadInt64() {
            long data0 = ReadByte();
            long data1 = ReadByte();
            long data2 = ReadByte();
            long data3 = ReadByte();
            long data4 = ReadByte();
            long data5 = ReadByte();
            long data6 = ReadByte();
            long data7 = ReadByte();

            if (isLittleEndian != BitConverter.IsLittleEndian) {
                return (long)((data0 << 56) | (data1 << 48) | (data2 << 40) | (data3 << 32) | (data4 << 24) | (data5 << 16) | (data6 << 8) | data7);
            } else {
                return (long)((data7 << 56) | (data6 << 48) | (data5 << 40) | (data4 << 32) | (data3 << 24) | (data2 << 16) | (data1 << 8) | data0);
            }
        }

        public override UInt32 ReadUInt32() {
            uint data0 = ReadByte();
            uint data1 = ReadByte();
            uint data2 = ReadByte();
            uint data3 = ReadByte();

            if (isLittleEndian != BitConverter.IsLittleEndian) {
                return (uint)((data0 << 24) | (data1 << 16) | (data2 << 8) | data3);
            } else {
                return (uint)((data3 << 24) | (data2 << 16) | (data1 << 8) | data0);
            }
        }

		public override UInt64 ReadUInt64() {
            ulong data0 = ReadByte();
            ulong data1 = ReadByte();
            ulong data2 = ReadByte();
            ulong data3 = ReadByte();
            ulong data4 = ReadByte();
            ulong data5 = ReadByte();
            ulong data6 = ReadByte();
            ulong data7 = ReadByte();

            if (isLittleEndian != BitConverter.IsLittleEndian) {
                return (ulong)((data0 << 56) | (data1 << 48) | (data2 << 40) | (data3 << 32) | (data4 << 24) | (data5 << 16) | (data6 << 8) | data7);
            } else {
                return (ulong)((data7 << 56) | (data6 << 48) | (data5 << 40) | (data4 << 32) | (data3 << 24) | (data2 << 16) | (data1 << 8) | data0);
            }
        }

        public override char ReadChar() {
            return Convert.ToChar(ReadByte());
        }

        /*public override byte[] ReadBytes(int count) {
            byte[] bytes = base.ReadBytes(count);
            return bytes;
        }*/

        public override sbyte ReadSByte() => (sbyte)ReadByte();

        /*public override byte ReadByte() {
            byte result = base.ReadByte();
            return result;
        }*/

        public string ReadNullDelimitedString(Encoding encoding = null) {
            List<byte> bytes = new List<byte>();
            byte b = ReadByte();
            while (b != 0x0) {
                bytes.Add(b);
                b = ReadByte();
            }
            if (bytes.Count > 0) {
                if (encoding == null)
                    encoding = Settings.StringEncoding;
                return encoding.GetString(bytes.ToArray());
            }
            return "";
        }

        public string ReadString(long size, Encoding encoding = null) {
            if (encoding == null)
                encoding = Settings.StringEncoding;
			byte[] bytes = ReadBytes((int)size);
			int firstIndexOf = Array.IndexOf<byte>(bytes, (byte)0x0);
			if (firstIndexOf >= 0 && firstIndexOf < bytes.Length) {
				if(firstIndexOf == 0) return "";
				Array.Resize<byte>(ref bytes, firstIndexOf);
			}
			return encoding.GetString(bytes);
            //return System.Text.Encoding.UTF8.GetString(ReadBytes(size)).TrimEnd('\0');
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

        #region Alignment
        // To make sure position is a multiple of alignBytes
        public void Align(int alignBytes) {
            if (BaseStream.Position % alignBytes != 0) {
                ReadBytes(alignBytes - (int)(BaseStream.Position % alignBytes));
            }
        }
        public void AlignOffset(int alignBytes, int offset) {
            if ((BaseStream.Position - offset) % alignBytes != 0) {
                ReadBytes(alignBytes - (int)((BaseStream.Position - offset) % alignBytes));
            }
        }

        // To make sure position is a multiple of alignBytes after reading a block of blocksize, regardless of prior position
        public void Align(int blockSize, int alignBytes) {
            int rest = blockSize % alignBytes;
            if (rest > 0) {
                byte[] aligned = ReadBytes(alignBytes - rest);
                foreach (byte b in aligned) if (b != 0x0) throw new Exception("A data byte was skipped during alignment");
            }
        }
		#endregion
    }
}