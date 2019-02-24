using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class ObjectRef {
		public uint objectRef;
		public ObjectRef(Reader reader) {
			objectRef = reader.ReadUInt32();
		}
	}
}
