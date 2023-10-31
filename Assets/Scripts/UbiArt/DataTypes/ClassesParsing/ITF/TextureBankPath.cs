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

		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.Game != settings.Game) {
					if ((previousSettings.Game == Game.RA || previousSettings.Game == Game.RM) && settings.Game == Game.RL) {
						if (!(textureSet?.diffuse?.IsNull ?? true)) {
							if (materialShader == null || materialShader.IsNull) {
								materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh");
							}
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
