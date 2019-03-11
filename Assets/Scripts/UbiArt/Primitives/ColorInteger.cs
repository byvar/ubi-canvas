using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class ColorInteger : ICSerializable {
		public uint colorBytes;

		public Color Color {
			get {
				return new Color(
					((colorBytes << 24) & 0xFF) / 255f,
					((colorBytes << 16) & 0xFF) / 255f,
					((colorBytes << 8) & 0xFF) / 255f,
					((colorBytes << 0) & 0xFF) / 255f
					);
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<uint>(ref colorBytes);
		}
	}
}
