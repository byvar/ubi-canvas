using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class Link {
		public uint stringID;
		public Link(Reader reader) {
			stringID = reader.ReadUInt32();
		}
	}
}
