using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class AngleAmount {
		public float angle;
		public AngleAmount(Reader reader) {
			angle = reader.ReadSingle();
		}
	}
}
