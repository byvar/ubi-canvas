using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class FXControllerComponent_Template {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					/*feedbackTags = null;
					fxControlList = null;
					triggerFx = null;
					defaultFx = null;
					FXSwitch = null;*/
				}
			}
			previousSettings = settings;
		}
	}
}
