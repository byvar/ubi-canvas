#nullable enable
using System;
using System.Runtime.CompilerServices;

namespace BinarySerializer {
	/// <summary>
	/// Bit helper methods
	/// </summary>
	public static class BitHelpers {
		/// <summary>
		/// Extracts the bits from a value
		/// </summary>
		/// <param name="value">The value to extract the bits from</param>
		/// <param name="count">The amount of bits to extract</param>
		/// <param name="offset">The offset to start from</param>
		/// <returns>The extracted bits as an integer</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ExtractBits(int value, int count, int offset) {
			return ((1 << count) - 1) & (value >> offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ExtractBits(byte[] buffer, int count, int offset) {
			if (buffer == null)
				throw new ArgumentNullException(nameof(buffer));

			int value = 0;
			int bufferOffset = offset / 8;

			for (int i = 0; i < 4; i++) {
				if (bufferOffset + i >= buffer.Length)
					break;

				value |= buffer[bufferOffset + i] << (8 * i);
			}

			return ExtractBits(value, count, offset % 8);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ExtractBits64(byte[] buffer, int count, int offset) {
			if (buffer == null)
				throw new ArgumentNullException(nameof(buffer));

			long value = 0;
			int bufferOffset = offset / 8;

			for (int i = 0; i < 8; i++) {
				if (bufferOffset + i >= buffer.Length)
					break;

				value |= (long)buffer[bufferOffset + i] << (8 * i);
			}

			return ExtractBits64(value, count, offset % 8);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ExtractBits64(long value, int count, int offset, SignedNumberRepresentation sign = SignedNumberRepresentation.Unsigned) {
			if (sign == SignedNumberRepresentation.Unsigned) {
				return (((long)1 << count) - 1) & (value >> offset);
			} else {
				long temp = (((long)1 << (count - 1)) - 1) & (value >> offset);

				if ((value & ((long)1 << (offset + count - 1))) != 0) // If signed
				{
					if (sign == SignedNumberRepresentation.SignMagnitude) {
						// Same value with 1 sign bit
						temp = -temp;
					} else if (sign == SignedNumberRepresentation.TwosComplement) {
						long maskValue = (((long)1 << (count - 1)) - 1);

						// 2's complement
						temp = (((long)-1) & ~maskValue) | temp;
					}
				}
				return temp;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SetBits(int bits, int value, int count, int offset) {
			int mask = ((1 << count) - 1) << offset;
			bits = (bits & ~mask) | ((value << offset) & mask);
			return bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long SetBits64(long bits, long value, int count, int offset, SignedNumberRepresentation sign = SignedNumberRepresentation.Unsigned) {
			long mask = (((long)1 << count) - 1) << offset;
			if (value >= 0 || sign is SignedNumberRepresentation.Unsigned or SignedNumberRepresentation.TwosComplement) {
				bits = (bits & ~mask) | ((value << offset) & mask);
			} else if (sign == SignedNumberRepresentation.SignMagnitude) {
				long maskValue = (((long)1 << (count - 1)) - 1) << offset;
				bits = (bits & ~mask) // Clear region for value
					| ((long)1 << (count - 1)) // Add sign bit
					| (((-value) << offset) & maskValue);
			}
			return bits;
		}

		public static int ReverseBits(int value) {
			int result = 0;

			for (int i = 0; i < 32; i++)
				result = SetBits(result, ExtractBits(value, 1, i), 1, 32 - i - 1);

			return result;
		}

		public static long ReverseBits64(long value) {
			var result = 0L;

			for (int i = 0; i < 64; i++)
				result = SetBits64(result, ExtractBits64(value, 1, i), 1, 64 - i - 1);

			return result;
		}

		public static void CopyBits(ref byte b1, ref byte b2, int count, int offset1, int offset2, bool setB1) {
			if (setB1)
				b1 = (byte)SetBits(b1, ExtractBits(b2, count, offset2), count, offset1);
			else
				b2 = (byte)SetBits(b2, ExtractBits(b1, count, offset1), count, offset2);
		}
	}
}