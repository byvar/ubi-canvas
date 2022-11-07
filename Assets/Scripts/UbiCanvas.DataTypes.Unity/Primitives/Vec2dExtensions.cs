using UnityEngine;

namespace UbiArt {
	public static class Vec2dExtensions {
		public static Vector2 GetUnityVector(this Vec2d v) => new Vector2(v.x, v.y);
		public static Vec2d GetUbiArtVector(this Vector2 v) => new Vec2d(v.x, v.y);
	}
}
