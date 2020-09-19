using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class ColorInteger : ICSerializable {
		public uint colorBytes;

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
	}
}
