using UnityEngine;

namespace ITF {
	public class PhysShapePolygon : PhysShape {
		[Serialize(0, "Points")] public Container<Vector2> points;
		[Serialize(1, "normals")] public Container<Vector2> normals;
		[Serialize(2, "edge")] public Container<Vector2> edge;
		[Serialize(3, "distances")] public Container<float> distances;

		public PhysShapePolygon(Reader reader) : base(reader) {
		}
	}
}