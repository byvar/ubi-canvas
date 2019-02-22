using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class VertexPNC3T : BaseObject {
		public Vector3 pos;
		public ColorInteger color;
		public Vector2 uv1;
		public Vector4 uv2;
		public Vector4 uv3;
		public Vector2 uv4;

		public VertexPNC3T(Reader reader) : base(reader) {
			pos = reader.ReadVector3();
			color = new ColorInteger(reader);
			uv1 = reader.ReadVector2();
			uv2 = reader.ReadVector4();
			uv3 = reader.ReadVector4();
			uv4 = reader.ReadVector2();
		}
	}
}
