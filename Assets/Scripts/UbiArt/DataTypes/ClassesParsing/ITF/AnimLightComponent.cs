namespace UbiArt.ITF {
	public partial class AnimLightComponent {
		public GenericFile<GFXMaterialShader_Template> shader;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
					l.LoadFile<GenericFile<GFXMaterialShader_Template>>(MatShader, result => shader = result);
				}
			}
		}
	}
}
