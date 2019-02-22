using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class PolyPointList : BaseObject {
		[Serialize(0, "LocalPoints")] public Container<PolyLineEdge> localPoints;
		[Serialize(1, "Loop")] public bool loop;
		[Serialize(2, "Length")] public float length;

		public PolyPointList(Reader reader) : base(reader) {
		}
	}
}
