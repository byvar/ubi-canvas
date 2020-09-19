using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class ObjectId : ICSerializable {
		public long id;

		public void Serialize(CSerializerObject s, string name) {
			id = s.Serialize<long>(id);
		}

		public const int Invalid = -1;

		public bool IsNull {
			get {
				return id == -1;
			}
		}
	}
}
