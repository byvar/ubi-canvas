using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class VertexPCT : BaseObject {
		public Vector3 pos;
		public ColorInteger color;
		public Vector2 uv;

		public VertexPCT(Reader reader) : base(reader) {
			pos = reader.ReadVector3();
			color = new ColorInteger(reader);
			uv = reader.ReadVector2();
		}
	}
}
