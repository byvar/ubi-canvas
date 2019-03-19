using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class ObjectId : ICSerializable {
		public uint id;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<uint>(ref id);
		}

		public const int Invalid = -1;

		public bool IsNull {
			get {
				return id == 0xFFFFFFFF;
			}
		}
	}
}
