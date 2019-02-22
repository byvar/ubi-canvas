using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Matrix2D : BaseObject {
		public Vector2 col1;
		public Vector2 col2;

		public Matrix2D(Reader reader) : base(reader) {
			col1 = reader.ReadVector2();
			col2 = reader.ReadVector2();
		}
	}
}
