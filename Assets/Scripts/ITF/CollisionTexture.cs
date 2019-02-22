using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class CollisionTexture : BaseObject {
		public int build;
		public float offset;
		public Vector2 cornerIn;
		public Vector2 cornerOut;
		public bool cornerInCur;
		public bool cornerOutCur;

		public CollisionTexture(Reader reader) : base(reader) {
			build = reader.ReadInt32();
			offset = reader.ReadSingle();
			cornerIn = reader.ReadVector2();
			cornerOut = reader.ReadVector2();
			cornerInCur = reader.ReadBoolean();
			cornerOutCur = reader.ReadBoolean();
		}
	}
}
