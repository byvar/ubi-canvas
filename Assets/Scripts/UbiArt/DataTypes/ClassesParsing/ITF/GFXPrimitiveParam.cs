using System.Collections.Generic;
using System.Diagnostics;

namespace UbiArt.ITF {
	public partial class GFXPrimitiveParam {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					if (previousSettings.game == Settings.Game.RA && settings.game == Settings.Game.RL) {
						if (gfxOccludeInfo != GFX_OCCLUDE_INFO.ZPASS_ONLY) {
							gfxOccludeInfo2 = (GFX_OCCLUDE_INFO2)(int)gfxOccludeInfo;
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
