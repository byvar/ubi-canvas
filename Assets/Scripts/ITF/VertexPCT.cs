using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class VertexPCT : BaseObject {
		[Serialize(0, "pos")] public Vector3 pos;
		[Serialize(1, "color")] public ColorInteger color;
		[Serialize(2, "uv")] public Vector2 uv;

		public VertexPCT(Reader reader) : base(reader) {
		}
	}
}
