using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace UbiArt {
    /// <summary>
    /// An extended version of the <see cref="BinaryReader"/> for reading binary data
    /// </summary>
    public class Reader : BinaryReader {
		#region Constructors
		public Reader(Stream stream, bool isLittleEndian = true, bool leaveOpen = false)
			// The encoding passed in to the base ctor is irrelevant since we have re-implemented the string reading
			: base(stream, new UTF8Encoding(), leaveOpen) {
			IsLittleEndian = isLittleEndian;
		}
		#endregion

		#region Protected Properties

		/// <summary>
		/// A common buffer to use for reading value types. This is created once to avoid allocating a new
		/// byte array on each read call. The length is set to 8 due to 64-bit values currently being the largest supported.
		/// </summary>
		protected byte[] ValueBuffer { get; } = new byte[8];

        protected bool RequiresByteReversing => IsLittleEndian != BitConverter.IsLittleEndian;

        protected uint BytesSinceAlignStart { get; set; }
        protected bool AutoAlignOn { get; set; }

		#endregion

		#region Public Properties

		public bool IsLittleEndian { get; set; }

		#endregion

		#region Protected Methods

		/// <summary>
		/// Reads the specified number of bytes to <see cref="ValueBuffer"/> and reverses them if needed.
		/// </summary>
		/// <param name="count">The number of bytes to read</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void ReadToValueBuffer(int count) {
            ReadBytes(ValueBuffer, 0, count);

            if (RequiresByteReversing)
                Array.Reverse(ValueBuffer, 0, count);
        }

        #endregion

        #region Read Methods

        public override int ReadInt32() {
            ReadToValueBuffer(4);
            return BitConverter.ToInt32(ValueBuffer, 0);
        }

        public override float ReadSingle() {
            ReadToValueBuffer(4);
            return BitConverter.ToSingle(ValueBuffer, 0);
        }

        public override short ReadInt16() {
            ReadToValueBuffer(2);
            return BitConverter.ToInt16(ValueBuffer, 0);
        }

        public override ushort ReadUInt16() {
            ReadToValueBuffer(2);
            return BitConverter.ToUInt16(ValueBuffer, 0);
        }

        public override long ReadInt64() {
            ReadToValueBuffer(8);
            return BitConverter.ToInt64(ValueBuffer, 0);
        }

        public override uint ReadUInt32() {
            ReadToValueBuffer(4);
            return BitConverter.ToUInt32(ValueBuffer, 0);
        }

        public override ulong ReadUInt64() {
            ReadToValueBuffer(8);
            return BitConverter.ToUInt64(ValueBuffer, 0);
        }

        public override byte[] ReadBytes(int count) {
            if (count == 0)
                return Array.Empty<byte>();

            byte[] buffer = new byte[count];

            ReadBytes(buffer, 0, count, throwOnIncompleteRead: true);

            return buffer;
        }

        public void ReadBytes(byte[] buffer, int offset, int count, bool throwOnIncompleteRead = true) {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Non-negative amount of bytes is required");

            int numRead = 0;
            int toRead = count;
            do {
                int n = BaseStream.Read(buffer, offset + numRead, toRead);
                if (n == 0)
                    break;
                numRead += n;
                toRead -= n;
            } while (toRead > 0);

            if (throwOnIncompleteRead && numRead != count)
                throw new EndOfStreamException();

            if (AutoAlignOn)
                BytesSinceAlignStart += (uint)count;
        }

        public override sbyte ReadSByte() => (sbyte)ReadByte();

        public override byte ReadByte() {
            byte result = base.ReadByte();

            if (AutoAlignOn)
                BytesSinceAlignStart++;

            return result;
        }

        public string ReadNullDelimitedString(Encoding encoding) {
            List<byte> bytes = new List<byte>();
            byte b = ReadByte();

            while (b != 0x0) {
                bytes.Add(b);
                b = ReadByte();
            }

            if (bytes.Count > 0) {
                if (encoding == null)
                    throw new ArgumentNullException(nameof(encoding));
                return encoding.GetString(bytes.ToArray());
            }

            return String.Empty;
        }

        public string ReadString(long size, Encoding encoding) {
            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding));

            // Read the bytes
            byte[] bytes = ReadBytes((int)size);

            // Get the string from the bytes using the specified encoding
            string str = encoding.GetString(bytes);

            // Trim after first null character
            int nullIndex = str.IndexOf((char)0x00);

            if (nullIndex != -1)
                str = str.Substring(0, nullIndex);

            // Return the string
            return str;
        }

        public override char ReadChar() {
            return Convert.ToChar(ReadByte());
        }

        public override string ReadString() {
            int size = ReadInt32();
            if (size > 0) {
                return ReadString(size, Encoding.UTF8);
            } else if (size == 0) {
                return "";
            } else {
                return null;
            }
        }
        public string ReadString16() {
            int size = ReadInt32();
            if (size > 0) {
                return ReadString(size * 2, Encoding.BigEndianUnicode);
            } else if (size == 0) {
                return "";
            } else {
                return null;
            }
        }
        #endregion

        #region Alignment

        // To make sure position is a multiple of alignBytes
        public void Align(int alignBytes) {
            if (BaseStream.Position % alignBytes != 0)
                ReadBytes(alignBytes - (int)(BaseStream.Position % alignBytes));
        }
        public void AlignOffset(int alignBytes, int offset) {
            if ((BaseStream.Position - offset) % alignBytes != 0)
                ReadBytes(alignBytes - (int)((BaseStream.Position - offset) % alignBytes));
        }

        // To make sure position is a multiple of alignBytes after reading a block of blocksize, regardless of prior position
        public void Align(int blockSize, int alignBytes) {
            int rest = blockSize % alignBytes;

            if (rest > 0) {
                byte[] aligned = ReadBytes(alignBytes - rest);

                if (aligned.Any(b => b != 0x0))
                    throw new Exception("A data byte was skipped during alignment");
            }
        }
		#endregion
    }
}