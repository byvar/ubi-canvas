using System.IO;

namespace UbiArt
{
    public class TeaEncoder : IStreamEncoder
    {
        public TeaEncoder(long length, uint[] key)
        {
			Length = length;
			Key = key;
		}

		public uint[] Key { get; protected set; }
		public long Length { get; protected set; }
        public string Name => $"Tea";

		private void DecodeInternal(uint[] data) {
			int count = data.Length;
			if (count > 1) {
				int rounds = (52 / count) + 6;
				long delta = (0x9E3779B9 * rounds) & uint.MaxValue;
				for (int r = 0; r < rounds; r++) {
					uint n = data[0];
					uint di, t;
					for (int i = count - 1; i >= 0; i--) {
						t = i == 0 ? data[count - 1] : data[i - 1];
						di = data[i];
						long nlong = 0x100000000 + // make sure it stays positive
							di -
							(
								(
									((n >> 3) ^ (t << 4)) +
									((n << 2) ^ (t >> 5))
								) ^
								(
									(t ^ Key[(i ^ (delta >> 2)) & 3]) +
									(n ^ delta)
								)
							);
						n = (uint)(nlong & uint.MaxValue);
						data[i] = n;
					}
					delta = (delta + 0x61C88647) & uint.MaxValue;
				}
			}
		}
		private void EncodeInternal(uint[] data) {
			int count = data.Length;
			if (count > 1) {
				//int rounds = (52 / count) + 6;
				long targetDelta = (0x9E3779B9 * (52 / count) - 0x4AB325AA) & uint.MaxValue;
				long delta = 0;
				while (delta != targetDelta) {
					delta = (delta + 0x100000000 - 0x61C88647) & uint.MaxValue;
					uint n = data[count - 1];
					uint di, t;
					for (int i = 0; i < count; i++) {
						t = (i == count - 1) ? data[0] : data[i + 1];
						di = data[i];
						long nlong = 0x100000000 + // make sure it stays positive
							di +
							(
								(
									((t >> 3) ^ (n << 4)) +
									((t << 2) ^ (n >> 5))
								) ^
								(
									(n ^ Key[(i ^ (delta >> 2)) & 3]) +
									(t ^ delta)
								)
							); // n and t swapped from decrypt function
						n = (uint)(nlong & uint.MaxValue);
						data[i] = n;
					}
				}
			}
		}

		public void DecodeStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[Length];
            input.Read(buffer, 0, buffer.Length);
			uint[] data = new uint[(Length + 3) >> 2];
			for (int i = 0; i < Length; i++) {
				int targetUInt = (i / 4);
				int targetShift = (i % 4) * 8;
				data[targetUInt] = data[targetUInt] | ((uint)buffer[i] << targetShift);
			}
			DecodeInternal(data);
			foreach (var d in data) {
				if(d == 0) continue;
				WriteChar((byte)((d >>  0) & 0xFF));
				WriteChar((byte)((d >>  8) & 0xFF));
				WriteChar((byte)((d >> 16) & 0xFF));
				WriteChar((byte)((d >> 24) & 0xFF));
			}

			void WriteChar(byte b) {
				if(b != 0) output.WriteByte(b);
			}
        }

		public void EncodeStream(Stream input, Stream output) {
			byte[] buffer = new byte[Length];
			input.Read(buffer, 0, buffer.Length);
			uint[] data = new uint[(Length + 3) >> 2];
			for (int i = 0; i < Length; i++) {
				int targetUInt = (i / 4);
				int targetShift = (i % 4) * 8;
				data[targetUInt] = data[targetUInt] | ((uint)buffer[i] << targetShift);
			}
			EncodeInternal(data);
			foreach (var d in data) {
				//if (d == 0) continue;
				WriteChar((byte)((d >> 0) & 0xFF));
				WriteChar((byte)((d >> 8) & 0xFF));
				WriteChar((byte)((d >> 16) & 0xFF));
				WriteChar((byte)((d >> 24) & 0xFF));
			}

			void WriteChar(byte b) {
				output.WriteByte(b);
			}
		}
    }
}