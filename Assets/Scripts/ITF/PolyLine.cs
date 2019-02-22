using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class PolyLine : BaseObject {
		[Serialize(0, "PolyPointList")] public PolyPointList polyPointList;
		[Serialize(1, "AABB")] public AABB AABB;
		[Serialize(2, "Connection")] public Connection connection;

		public PolyLine(Reader reader) : base(reader) {
		}

		public class Connection : BaseObject {
			[Serialize(0, "PreviousId")] public uint previousId;
			[Serialize(1, "PosInit")] public Vector2 posInit;
			public Connection(Reader reader) : base(reader) {
			}
		}
	}
}
