﻿using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMaterialSerializable {
		public GenericFile<GFXMaterialShader_Template> shader;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(shaderPath, (extS) => {
					if (l.msh.ContainsKey(shaderPath.stringID)) {
						shader = l.msh[shaderPath.stringID];
					} else {
						extS.Serialize(ref shader);
						l.msh[shaderPath.stringID] = shader;
					}
				});
			}
		}
	}
}
