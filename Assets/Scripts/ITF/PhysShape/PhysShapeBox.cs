using UnityEngine;

namespace ITF {
	public class PhysShapeBox : PhysShapePolygon {
		[Serialize(0, "Extent")] public Vector2 extent;
		public PhysShapeBox(Reader reader) : base(reader) {
		}
	}
}