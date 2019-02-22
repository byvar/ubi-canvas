using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AABB : BaseObject {
		[Serialize(0, "MIN")] public Vector2 min;
		[Serialize(1, "MAX")] public Vector2 max;

		public AABB(Reader reader) : base(reader) {
			min = reader.ReadVector2();
			max = reader.ReadVector2();
		}
	}
}
