using UnityEngine;

namespace UbiArt {
	public static class ColorIntegerExtensions {
		public static UnityEngine.Color GetUnityColor(this ColorInteger c) => c != null ? new UnityEngine.Color(c.R, c.G, c.B, c.A) : UnityEngine.Color.black;
		public static ColorInteger GetUbiArtColorInteger(this UnityEngine.Color c) => new ColorInteger(c.r, c.g, c.b, c.a);
	}
}
