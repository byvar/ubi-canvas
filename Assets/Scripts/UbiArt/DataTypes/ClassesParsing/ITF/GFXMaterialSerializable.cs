using System.Collections.Generic;
using System.Diagnostics;

namespace UbiArt.ITF {
	public partial class GFXMaterialSerializable {
		public GenericFile<GFXMaterialShader_Template> shader;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				l.LoadFile<GenericFile<GFXMaterialShader_Template>>(shaderPath, result => shader = result);
			}
		}
	}
}
