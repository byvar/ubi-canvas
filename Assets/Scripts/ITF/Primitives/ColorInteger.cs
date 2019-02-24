using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class ColorInteger {
		public uint colorBytes;
		public ColorInteger(Reader reader) {
			colorBytes = reader.ReadUInt32();
		}

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
	}
}
