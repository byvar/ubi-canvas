using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Transform2D : BaseObject {
		public Matrix2D rot;
		public Vector2 pos;

		public Transform2D(Reader reader) : base(reader) {
			rot = new Matrix2D(reader);
			pos = reader.ReadVector2();
		}
	}
}
