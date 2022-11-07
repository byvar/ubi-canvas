using UnityEngine;

namespace UbiArt.ITF {
	public static class GFX_Vector4Extensions {
		public static Vector4 GetUnityVector(this GFX_Vector4 v) => new Vector4(v.x, v.y, v.z, v.w);
		public static GFX_Vector4 GetUbiArtVector(this Vector4 v) => new GFX_Vector4() {
			x = v.x,
			y = v.y,
			z = v.z,
			w = v.w
		};
	}
}
