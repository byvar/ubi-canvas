using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class ColorInteger : ICSerializable {
		public uint colorBytes;


		public ColorInteger() {
		}
		public ColorInteger(float r, float g, float b, float a) {
			uint rc = (uint)(r * 255f);
			uint gc = (uint)(g * 255f);
			uint bc = (uint)(b * 255f);
			uint ac = (uint)(a * 255f);
			colorBytes = (rc | (gc << 8) | (bc << 16) | (ac << 24));
		}


		public UnityEngine.Color Color {
			get {
				return new UnityEngine.Color(
					((colorBytes >> 0) & 0xFF) / 255f,
					((colorBytes >> 8) & 0xFF) / 255f,
					((colorBytes >> 16) & 0xFF) / 255f,
					((colorBytes >> 24) & 0xFF) / 255f
					);
			}
		}
		public Vector4 Vector {
			get {
				return new Vector4(
					((colorBytes >> 0) & 0xFF) / 255f,
					((colorBytes >> 8) & 0xFF) / 255f,
					((colorBytes >> 16) & 0xFF) / 255f,
					((colorBytes >> 24) & 0xFF) / 255f
					);
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			colorBytes = s.Serialize<uint>(colorBytes);
		}



		public static implicit operator ColorInteger(UnityEngine.Color v) {
			return new ColorInteger(v.r, v.g, v.b, v.a);
		}
		public static implicit operator UnityEngine.Color(ColorInteger v) {
			return v.Color;
		}
	}
}
