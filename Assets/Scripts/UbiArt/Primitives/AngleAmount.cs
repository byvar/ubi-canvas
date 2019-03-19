using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class AngleAmount : ICSerializable {
		public float angle;
		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<float>(ref angle);
		}

		// Casts
		public static implicit operator float(AngleAmount a) {
			return a.angle;
		}
		public static implicit operator AngleAmount(float a) {
			return new AngleAmount { angle = a };
		}
		public static implicit operator AngleAmount(Angle a) {
			return new AngleAmount { angle = a.angle };
		}
	}
}
