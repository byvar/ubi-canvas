using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class VertexPNC3T : BaseObject {
		[Serialize(0, "pos")] public Vector3 pos;
		[Serialize(1, "color")] public ColorInteger color;
		[Serialize(2, "uv1")] public Vector2 uv1;
		[Serialize(3, "uv2")] public Vector4 uv2;
		[Serialize(4, "uv3")] public Vector4 uv3;
		[Serialize(5, "uv4")] public Vector2 uv4;

		public VertexPNC3T(Reader reader) : base(reader) {
		}
	}
}
