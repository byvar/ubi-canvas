namespace UbiArt.ITF {
	public partial class SoundComponent_Template {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					soundList = null;
					inputs = null;
					defaultSound = null;
				}
			}
			previousSettings = settings;
		}
	}
}
