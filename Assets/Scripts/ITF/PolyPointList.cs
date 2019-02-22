using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class PolyPointList : BaseObject {
		public Container<PolyLineEdge> localPoints;
		public bool loop;
		public float length;

		public PolyPointList(Reader reader) : base(reader) {
			localPoints = new Container<PolyLineEdge>(reader);
			loop = reader.ReadBoolean();
			length = reader.ReadSingle();
		}
	}
}
