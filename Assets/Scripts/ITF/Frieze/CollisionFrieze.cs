using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class CollisionFrieze : BaseObject {
		public bool build;
		public float offset;
		public Vector2 extremity;
		public Vector2 extremity2;
		public bool flip;
		public uint methode;
		public float distMaxToSkipParallelEdge;
		public float smoothFactor;
		public bool isSmooth;

		public CollisionFrieze(Reader reader) : base(reader) {
			build = reader.ReadBoolean();
			offset = reader.ReadSingle();
			extremity = reader.ReadVector2();
			extremity2 = reader.ReadVector2();
			flip = reader.ReadBoolean();
			methode = reader.ReadUInt32();
			distMaxToSkipParallelEdge = reader.ReadSingle();
			smoothFactor = reader.ReadSingle();
			isSmooth = reader.ReadBoolean();
		}
	}
}
