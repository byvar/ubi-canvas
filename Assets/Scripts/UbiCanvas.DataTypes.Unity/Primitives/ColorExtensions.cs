using UnityEngine;

namespace UbiArt {
	public static class ColorExtensions {
		public static UnityEngine.Color GetUnityColor(this Color c) => c != null ? new UnityEngine.Color(c.r, c.g, c.b, c.a) : UnityEngine.Color.black;
		public static Color GetUbiArtColor(this UnityEngine.Color c) => new Color(c.r, c.g, c.b, c.a);
	}
}
