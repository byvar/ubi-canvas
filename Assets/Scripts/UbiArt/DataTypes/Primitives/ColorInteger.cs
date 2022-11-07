using System;

namespace UbiArt {
	public class ColorInteger : ICSerializable {
		public uint colorBytes;

		public ColorInteger() {
		}
		public ColorInteger(float r, float g, float b, float a) {
			uint rc = (uint)MathF.Max(0, MathF.Min(255, r * 255f));
			uint gc = (uint)MathF.Max(0, MathF.Min(255, g * 255f));
			uint bc = (uint)MathF.Max(0, MathF.Min(255, b * 255f));
			uint ac = (uint)MathF.Max(0, MathF.Min(255, a * 255f));
			colorBytes = (rc | (gc << 8) | (bc << 16) | (ac << 24));
		}

		public float R => ((colorBytes >> 0) & 0xFF) / 255f;
		public float G => ((colorBytes >> 8) & 0xFF) / 255f;
		public float B => ((colorBytes >> 16) & 0xFF) / 255f;
		public float A => ((colorBytes >> 24) & 0xFF) / 255f;

		public void Serialize(CSerializerObject s, string name) {
			colorBytes = s.Serialize<uint>(colorBytes);
		}
	}
}
