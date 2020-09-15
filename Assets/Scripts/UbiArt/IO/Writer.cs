using System;
using System.IO;
using System.Text;

namespace UbiArt {
    public class Writer : BinaryWriter {
        bool isLittleEndian = true;
        byte? xorKey;
        uint bytesSinceAlignStart;
        bool autoAlignOn = false;

        public Writer(Stream stream) : base(stream) { isLittleEndian = true; }
        public Writer(Stream stream, bool isLittleEndian) : base(stream) { this.isLittleEndian = isLittleEndian; }

        public override void Write(Char value) {
            Write(Convert.ToByte(value));
        }

        public override void Write(Int32 value) {
            var data = BitConverter.GetBytes(value);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(Int16 value) {
            var data = BitConverter.GetBytes(value);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(UInt32 value) {
            var data = BitConverter.GetBytes(value);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(UInt16 value) {
            var data = BitConverter.GetBytes(value);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(Int64 value) {
            var data = BitConverter.GetBytes(value);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(UInt64 value) {
            var data = BitConverter.GetBytes(value);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(Single value) {
            var data = BitConverter.GetBytes(value);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(Double value) {
            var data = BitConverter.GetBytes(value);
            if (isLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(String value) {
            if (value == null) value = "";
            var data = Encoding.ASCII.GetBytes(value);
            Write(data.Length);
            Write(data);
        }
        public void Write16(String value) {
            if (value == null) value = "";
            var data = Encoding.BigEndianUnicode.GetBytes(value);
            Write(data.Length / 2);
            Write(data);
        }

        public void WriteNullDelimitedString(string value, Encoding encoding = null) {
            if (encoding == null)
                encoding = Settings.StringEncoding;
            byte[] data = encoding.GetBytes(value + '\0');
            Write(data);
        }

        public void WriteString(string value, long? size = null, Encoding encoding = null) {
            if (value == null) return;
            if (encoding == null)
                encoding = Settings.StringEncoding;
            byte[] data = encoding.GetBytes(value + '\0');
            if (size.HasValue) {
                if (data.Length != size) {
                    Array.Resize(ref data, (int)size);
                }
            }
            Write(data);
        }

        public override void Write(byte[] buffer) {
            if (buffer == null) 
                return;
            
            var data = buffer;

            if (xorKey.HasValue) {
                // Avoid changing data in array, so create a copy
                data = new byte[buffer.Length];
                Array.Copy(buffer, 0, data, 0, buffer.Length);
                for (int i = 0; i < data.Length; i++) {
                    data[i] = (byte)(data[i] ^ xorKey.Value);
                }
            }

            base.Write(data);
            
            if (autoAlignOn) 
                bytesSinceAlignStart += (uint)data.Length;
        }

        public override void Write(byte value) {
            if (xorKey.HasValue)
                value = (byte)(value ^ xorKey.Value);

            base.Write(value);
            
            if (autoAlignOn) 
                bytesSinceAlignStart++;
        }

        public override void Write(sbyte value) => Write((byte)value);

        #region Alignment
        // To make sure position is a multiple of alignBytes
        public void Align(int alignBytes) {
            if (BaseStream.Position % alignBytes != 0) {
                int length = alignBytes - (int)(BaseStream.Position % alignBytes);
                byte[] data = new byte[length];
                Write(data);
            }
        }
        public void AlignOffset(int alignBytes, int offset) {
            if ((BaseStream.Position - offset) % alignBytes != 0) {
                int length = alignBytes - (int)((BaseStream.Position - offset) % alignBytes);
                byte[] data = new byte[length];
                Write(data);
            }
        }

        // To make sure position is a multiple of alignBytes after reading a block of blocksize, regardless of prior position
        public void Align(int blockSize, int alignBytes) {
            int rest = blockSize % alignBytes;
            if (rest > 0) {
                int length = alignBytes - rest;
                byte[] data = new byte[length];
                Write(data);
            }
        }

        public void AutoAlign(int alignBytes) {
            if (bytesSinceAlignStart % alignBytes != 0) {
                int length = alignBytes - (int)(bytesSinceAlignStart % alignBytes);
                byte[] data = new byte[length];
                Write(data);
            }
            bytesSinceAlignStart = 0;
        }
        #endregion
        
        #region XOR & Checksum
        public void BeginXOR(byte xorKey) {
            this.xorKey = xorKey;
        }
        public void EndXOR() {
            xorKey = null;
        }
        #endregion
    }
}