using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class ShapeDetectorComponent : DetectorComponent {
		public Vector2 localOffset;
		public Vector2 localScale;
		public bool useShapeTransform;
		public ShapeDetectorComponent(Reader reader) : base(reader) {
			localOffset = reader.ReadVector2();
			localScale = reader.ReadVector2();
			useShapeTransform = reader.ReadBoolean();
		}
	}
}
