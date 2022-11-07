using UnityEngine;

namespace UbiArt {
	public static class Vec3dExtensions {
		public static Vector3 GetUnityVector(this Vec3d v) => new Vector3(v.x, v.y, v.z);
		public static Vec3d GetUbiArtVector(this Vector3 v) => new Vec3d(v.x, v.y, v.z);
	}
}
