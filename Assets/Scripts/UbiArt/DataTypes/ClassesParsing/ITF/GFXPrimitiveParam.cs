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
				if (previousSettings.Game != settings.Game) {
					if ((previousSettings.Game == Game.RA || previousSettings.Game == Game.RM) && settings.Game == Game.RL) {
						if (gfxOccludeInfo != GFX_OCCLUDE_INFO.ZPASS_ONLY) {
							gfxOccludeInfo2 = (GFX_OCCLUDE_INFO2)(int)gfxOccludeInfo;
						}
						//FrontLightBrightness = 5f;
						/*colorFactor = new Color(
							colorFactor.r * FrontLightBrightness,
							colorFactor.g * FrontLightBrightness,
							colorFactor.b * FrontLightBrightness,
							colorFactor.a);*/
						/*if (colorFog != null) {
							BackLightBrightness = 1;
							//colorFog = new Color(colorFog.r, colorFog.g, colorFog.b, System.MathF.Min(colorFog.a * 2f, 1f));
						}*/
						/*if (useStaticFog && colorFog != null && colorFog.r == 0 && colorFog.g == 0 && colorFog.b == 0) {
							colorFog = null;
						}*/
					}
				}
			}
			previousSettings = settings;
		}
	}
}
