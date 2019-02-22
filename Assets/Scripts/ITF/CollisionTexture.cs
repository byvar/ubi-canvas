using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class CollisionTexture : BaseObject {
		[Serialize(0, "build")] public int build;
		[Serialize(1, "offset")] public float offset;
		[Serialize(2, "cornerIn")] public Vector2 cornerIn;
		[Serialize(3, "cornerOut")] public Vector2 cornerOut;
		[Serialize(4, "cornerInCur")] public bool cornerInCur;
		[Serialize(5, "cornerOutCur")] public bool cornerOutCur;

		public CollisionTexture(Reader reader) : base(reader) {
		}
	}
}
