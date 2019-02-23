using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_RadialParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "centerOffset")] public Vector2 centerOffset;
		[Serialize(2, "strength")] public float strength;
		[Serialize(3, "size")] public float size;

		public AFX_RadialParam(Reader reader) : base(reader) {
		}
	}
}
