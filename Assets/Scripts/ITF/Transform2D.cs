using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Transform2D : BaseObject {
		[Serialize(0, "Rot")] public Matrix2D rot;
		[Serialize(1, "Pos")] public Vector2 pos;

		public Transform2D(Reader reader) : base(reader) {
		}
	}
}
