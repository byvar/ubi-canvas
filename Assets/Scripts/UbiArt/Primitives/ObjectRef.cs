using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class ObjectRef : ICSerializable {
		public uint objectRef;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<uint>(ref objectRef);
		}
		public static implicit operator uint(ObjectRef o) {
			return o.objectRef;
		}
		public static implicit operator ObjectRef(uint o) {
			return new ObjectRef { objectRef = o };
		}
	}
}
