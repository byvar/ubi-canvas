using System;

namespace UbiArt {
	public class ColorInteger : ICSerializable {
		public uint colorBytes;

		public ColorInteger() {
		}
		public ColorInteger(float r, float g, float b, float a) {
			uint rc = Math.Max(0, Math.Min(255, (uint)(r * 255f))) & 0xFF;
			uint gc = Math.Max(0, Math.Min(255, (uint)(g * 255f))) & 0xFF;
			uint bc = Math.Max(0, Math.Min(255, (uint)(b * 255f))) & 0xFF;
			uint ac = Math.Max(0, Math.Min(255, (uint)(a * 255f))) & 0xFF;
			colorBytes = (rc | (gc << 8) | (bc << 16) | (ac << 24));
		}

		public float R => ((colorBytes >> 0) & 0xFF) / 255f;
		public float G => ((colorBytes >> 8) & 0xFF) / 255f;
		public float B => ((colorBytes >> 16) & 0xFF) / 255f;
		public float A => ((colorBytes >> 24) & 0xFF) / 255f;

		public void Serialize(CSerializerObject s, string name) {
			colorBytes = s.Serialize<uint>(colorBytes);
		}

		public override string ToString() {
			return $"ColorInteger({R}, {G}, {B}, {A})";
		}
	}
}
