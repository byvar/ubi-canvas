using System;
using System.IO;
using System.Text;

namespace UbiArt {
    public class Writer : BinaryWriter {
		#region Constructors

		public Writer(Stream stream, bool isLittleEndian = true, bool leaveOpen = false) : base(new StreamWrapper(stream), new UTF8Encoding(), leaveOpen) {
			IsLittleEndian = isLittleEndian;
		}

		#endregion

		#region Public Properties

		public bool IsLittleEndian { get; set; }
		public new StreamWrapper BaseStream => (StreamWrapper)base.BaseStream;

		#endregion

		#region Protected Properties

		protected uint BytesSinceAlignStart { get; set; }
        protected bool AutoAlignOn { get; set; }

		protected IXORCalculator XORCalculator {
			get => BaseStream.XORCalculator;
			set => BaseStream.XORCalculator = value;
		}
		protected IChecksumCalculator ChecksumCalculator {
			get => BaseStream.ChecksumCalculator;
			set => BaseStream.ChecksumCalculator = value;
		}

		#endregion

		#region Write Methods

		public override void Write(int value) {
            var data = BitConverter.GetBytes(value);
            if (IsLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(short value) {
            var data = BitConverter.GetBytes(value);
            if (IsLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(uint value) {
            var data = BitConverter.GetBytes(value);
            if (IsLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(ushort value) {
            var data = BitConverter.GetBytes(value);
            if (IsLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(long value) {
            var data = BitConverter.GetBytes(value);
            if (IsLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(ulong value) {
            var data = BitConverter.GetBytes(value);
            if (IsLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(float value) {
            var data = BitConverter.GetBytes(value);
            if (IsLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public override void Write(double value) {
            var data = BitConverter.GetBytes(value);
            if (IsLittleEndian != BitConverter.IsLittleEndian) Array.Reverse(data);
            Write(data);
        }

        public void WriteNullDelimitedString(string value, Encoding encoding) {
            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding));

            if (value == null) value = "";
            byte[] data = encoding.GetBytes(value + '\0');
            Write(data);
        }

        public void WriteString(string value, long size, Encoding encoding) {
            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding));

            value ??= "";
            byte[] data = encoding.GetBytes(value + '\0');
            if (data.Length != size)
                Array.Resize(ref data, (int)size);
            Write(data);
        }

        public override void Write(byte[] buffer) {
            if (buffer == null)
                return;

            base.Write(buffer);

            if (AutoAlignOn)
                BytesSinceAlignStart += (uint)buffer.Length;
        }

        public override void Write(byte value) {
            base.Write(value);

            if (AutoAlignOn)
                BytesSinceAlignStart++;
        }

        public override void Write(sbyte value) => Write((byte)value);

        public override void Write(Char value) {
            Write(Convert.ToByte(value));
        }

        public override void Write(bool value) {
            if (value) Write((int)1);
            else Write((int)0);
        }
        public override void Write(String value) {
            if (value == null) value = "";
            var data = Encoding.UTF8.GetBytes(value);
            Write(data.Length);
            Write(data);
        }
        public void Write16(String value) {
            if (value == null) value = "";
            var data = Encoding.BigEndianUnicode.GetBytes(value);
            Write(data.Length / 2);
            Write(data);
        }
        #endregion

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
            if (BytesSinceAlignStart % alignBytes != 0) {
                int length = alignBytes - (int)(BytesSinceAlignStart % alignBytes);
                byte[] data = new byte[length];
                Write(data);
            }
            BytesSinceAlignStart = 0;
        }

		#endregion

		#region XOR & Checksum

		public void BeginXOR(IXORCalculator xorCalculator) => XORCalculator = xorCalculator;
		public void EndXOR() => XORCalculator = null;
		public IXORCalculator GetXORCalculator() => XORCalculator;

		public void BeginCalculateChecksum(IChecksumCalculator checksumCalculator) => ChecksumCalculator = checksumCalculator;
		public IChecksumCalculator PauseCalculateChecksum() {
			IChecksumCalculator c = ChecksumCalculator;
			ChecksumCalculator = null;
			return c;

		}
		public T EndCalculateChecksum<T>() {
			IChecksumCalculator c = ChecksumCalculator;
			ChecksumCalculator = null;
			return ((IChecksumCalculator<T>)c).ChecksumValue;
		}

		#endregion
	}
}