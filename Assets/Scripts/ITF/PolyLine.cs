using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class PolyLine : BaseObject {
		public PolyPointList polyPointList;
		public AABB AABB;
		public Connection connection;

		public PolyLine(Reader reader) : base(reader) {
			polyPointList = new PolyPointList(reader);
			AABB = new AABB(reader);
			connection = new Connection(reader);
		}

		public class Connection : BaseObject {
			public uint previousId;
			public Vector2 posInit;
			public Connection(Reader reader) : base(reader) {
				previousId = reader.ReadUInt32();
				posInit = reader.ReadVector2();
			}
		}
	}
}
