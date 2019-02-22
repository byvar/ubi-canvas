using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class ShapeDetectorComponent : DetectorComponent {
		[Serialize(0, "localOffset")] public Vector2 localOffset;
		[Serialize(1, "localScale")] public Vector2 localScale;
		[Serialize(2, "useShapeTransform")] public bool useShapeTransform;
		public ShapeDetectorComponent(Reader reader) : base(reader) {
		}
	}
}
