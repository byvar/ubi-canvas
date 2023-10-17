using UnityEngine;

namespace UbiArt {
	public static class Vec3dExtensions {
		public static Vector3 GetUnityVector(this Vec3d v, bool invertZ = false) => invertZ ? new Vector3(v.x, v.y, -v.z) : new Vector3(v.x, v.y, v.z);
		public static Vec3d GetUbiArtVector(this Vector3 v, bool invertZ = false) => invertZ ? new Vec3d(v.x, v.y, -v.z) : new Vec3d(v.x, v.y, v.z);
	}
}
