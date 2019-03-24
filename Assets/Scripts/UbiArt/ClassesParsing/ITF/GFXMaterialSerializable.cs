using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMaterialSerializable {
		bool loaded = false;
		public CList<Generic<GFXMaterialShader_Template>> shader;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (!loaded) {
				MapLoader l = MapLoader.Loader;
				l.Load(shaderPath, (extS) => {
					if (l.msh.ContainsKey(shaderPath.stringID)) {
						shader = l.msh[shaderPath.stringID];
					} else {
						extS.flags |= SerializeFlags.StoreObjectSizes;
						extS.Serialize(ref shader);
						l.msh[shaderPath.stringID] = shader;
						l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
					}
				});
				loaded = true;
			}
		}
	}
}
