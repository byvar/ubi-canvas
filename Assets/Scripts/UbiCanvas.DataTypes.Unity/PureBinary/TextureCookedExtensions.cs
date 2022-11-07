using UbiCanvas;
using UnityEngine;

namespace UbiArt {
	public static class TextureCookedExtensions {
		public static UnityData_TextureCooked GetUnityTexture(this TextureCooked tex, Context c) => c.GetUnityDataStorage().GetUnityData<UnityData_TextureCooked, TextureCooked>(tex);
	}
}
