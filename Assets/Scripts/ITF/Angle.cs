using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class Angle {
		public float angle;
		public Angle(Reader reader) {
			angle = reader.ReadSingle();
		}
	}
}
