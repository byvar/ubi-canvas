using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class AABB {
		public void SetPoint(Vec2d point) {
			MIN = new Vec2d(point.x, point.y);
			MAX = new Vec2d(point.x, point.y);
		}
		public void Grow(Vec2d point) {
			if(point == null) return;
			if (point.x < MIN.x) MIN.x = point.x;
			if (point.y < MIN.y) MIN.y = point.y;
			if (point.x > MAX.x) MAX.x = point.x;
			if (point.y > MAX.y) MAX.y = point.y;

		}
		public void Grow(Vec3d point) {
			if (point == null) return;
			Grow(new Vec2d(point.x, point.y));
		}
		public void Grow(AABB aabb) {
			Grow(aabb?.MIN);
			Grow(aabb?.MAX);
		}
	}
}
