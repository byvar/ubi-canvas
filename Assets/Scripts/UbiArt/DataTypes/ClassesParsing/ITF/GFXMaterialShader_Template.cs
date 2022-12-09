using System.Collections.Generic;
using System.Diagnostics;

namespace UbiArt.ITF {
	public partial class GFXMaterialShader_Template {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					if ((previousSettings.game == Settings.Game.RA || previousSettings.game == Settings.Game.RM) && settings.game == Settings.Game.RL) {
						materialtype2 = (GFX_MAT2)(int)materialtype;

						// Some lighting parameters otherwise don't work in Legends
						lightingType = GFX_MAT_SHADER.LIGHT_LAYERED;
					}
				}
			}
			previousSettings = settings;
		}
	}
}
