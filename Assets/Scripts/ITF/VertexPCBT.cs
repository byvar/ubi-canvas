using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class VertexPCBT : BaseObject {
		public Vector3 pos;
		public ColorInteger color;
		public uint blendIndices;
		public Vector2 uv;

		public VertexPCBT(Reader reader) : base(reader) {
			pos = reader.ReadVector3();
			color = new ColorInteger(reader);
			blendIndices = reader.ReadUInt32();
			uv = reader.ReadVector2();
		}
	}
}
