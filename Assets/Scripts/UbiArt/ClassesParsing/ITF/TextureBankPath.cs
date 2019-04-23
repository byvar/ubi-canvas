using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class TextureBankPath {
		public GenericFile<GFXMaterialShader_Template> shader;
		public AnimPatchBank pbk;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(materialShader, (extS) => {
					if (l.msh.ContainsKey(materialShader.stringID)) {
						shader = l.msh[materialShader.stringID];
					} else {
						extS.Serialize(ref shader);
						l.msh[materialShader.stringID] = shader;
					}
				});
				if (l.loadAnimations) {
					l.Load(patchBank, (extS) => {
						if (l.pbk.ContainsKey(patchBank.stringID)) {
							pbk = l.pbk[patchBank.stringID];
						} else {
							extS.log = l.logEnabled;
							extS.Serialize(ref pbk);
							l.pbk[patchBank.stringID] = pbk;
							l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
						}
					});
				}
			}
		}
	}
}
