using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class CollisionFrieze : BaseObject {
		[Serialize(0, "build")] public bool build;
		[Serialize(1, "offset")] public float offset;
		[Serialize(2, "extremity")] public Vector2 extremity;
		[Serialize(3, "extremity2")] public Vector2 extremity2;
		[Serialize(4, "flip")] public bool flip;
		[Serialize(5, "methode")] public uint methode;
		[Serialize(6, "distMaxToSkipParallelEdge")] public float distMaxToSkipParallelEdge;
		[Serialize(7, "smoothFactor")] public float smoothFactor;
		[Serialize(8, "isSmooth")] public bool isSmooth;

		public CollisionFrieze(Reader reader) : base(reader) {
		}
	}
}
