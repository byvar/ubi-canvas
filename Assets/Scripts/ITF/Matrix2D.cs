using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Matrix2D : BaseObject {
		[Serialize(0, "Col1")] public Vector2 col1;
		[Serialize(1, "Col2")] public Vector2 col2;

		public Matrix2D(Reader reader) : base(reader) {
		}
	}
}
