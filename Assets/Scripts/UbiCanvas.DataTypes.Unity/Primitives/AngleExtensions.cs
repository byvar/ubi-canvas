using UnityEngine;

namespace UbiArt {
	public static class AngleExtensions {
		public static Quaternion GetUnityQuaternion(this Angle angle) => Quaternion.Euler(0, 0, angle.EulerAngle);
		public static void SetUnityQuaternion(this Angle angle, Quaternion quaternion) => angle.EulerAngle = quaternion.eulerAngles.z;
	}
}
