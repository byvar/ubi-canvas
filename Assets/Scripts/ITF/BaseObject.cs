using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class BaseObject {
		public uint sizeOf;
		public BaseObject(Reader reader) {
			if ((reader.flags & Reader.Flags.AddObjectSizes) != 0) {
				sizeOf = reader.ReadUInt32();
			}

		}
	}
}
