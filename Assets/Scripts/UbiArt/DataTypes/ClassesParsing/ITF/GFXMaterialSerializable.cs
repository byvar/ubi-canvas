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
							if (shaderPath == null || shaderPath.IsNull) {
								shaderPath = new Path("world/common/matshader/regularbuffer/backlighted.msh");
							}
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
