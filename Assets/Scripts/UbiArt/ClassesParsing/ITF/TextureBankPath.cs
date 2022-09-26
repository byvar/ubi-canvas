using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class TextureBankPath {
		public GenericFile<GFXMaterialShader_Template> shader;
		public AnimPatchBank pbk;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Context l = s.Context;
				l.Load(materialShader, (extS) => {
					if (l.msh.ContainsKey(materialShader.stringID)) {
						shader = l.msh[materialShader.stringID];
					} else {
						shader = extS.SerializeObject<GenericFile<GFXMaterialShader_Template>>(shader);
						l.msh[materialShader.stringID] = shader;
					}
				});
				if (l.loadAnimations) {
					l.Load(patchBank, (extS) => {
						if (l.pbk.ContainsKey(patchBank.stringID)) {
							pbk = l.pbk[patchBank.stringID];
						} else {
							pbk = extS.SerializeObject<AnimPatchBank>(pbk);
							l.pbk[patchBank.stringID] = pbk;
							if (extS.CurrentPointer != extS.Length) {
								l.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
							}
						}
					});
				}
			}
		}
	}
}
