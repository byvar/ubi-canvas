using UnityEngine;

namespace UbiArt {
	public static class ColorExtensions {
		public static UnityEngine.Color GetUnityColor(this Color c) => c != null ? new UnityEngine.Color(c.r, c.g, c.b, c.a) : new UnityEngine.Color(0,0,0,0);
		public static Color GetUbiArtColor(this UnityEngine.Color c) => new Color(c.r, c.g, c.b, c.a);
	}
}
