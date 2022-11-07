using UbiCanvas;
using UnityEngine;

namespace UbiArt {
	public static class TextureCookedExtensions {
		public static Unity_TextureCooked GetUnityTexture(this TextureCooked tex, Context c) => c.GetUnityDataStorage().GetUnityData<Unity_TextureCooked, TextureCooked>(tex);
	}
}
