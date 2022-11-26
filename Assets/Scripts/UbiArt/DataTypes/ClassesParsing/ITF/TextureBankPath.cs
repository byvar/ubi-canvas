using UbiArt.Animation;

namespace UbiArt.ITF {
	public partial class TextureBankPath {
		public GenericFile<GFXMaterialShader_Template> shader;
		public AnimPatchBank pbk;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				l.LoadFile<GenericFile<GFXMaterialShader_Template>>(materialShader, result => shader = result);

				if (l.LoadAnimations) {
					l.LoadFile<AnimPatchBank>(patchBank, result => pbk = result);
				}
			}
		}
	}
}
