using UnityEngine;

namespace UbiArt {
	public static class Vec4dExtensions {
		public static Vector4 GetUnityVector(this Vec4d v) => new Vector4(v.x, v.y, v.z, v.w);
		public static Vec4d GetUbiArtVector(this Vector4 v) => new Vec4d(v.x, v.y, v.z, v.w);
	}
}
