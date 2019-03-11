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
	}
}
