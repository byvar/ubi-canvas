using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class FXControllerComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				/*feedbackTags = null;
				fxControlList = null;
				triggerFx = null;
				defaultFx = null;
				FXSwitch = null;*/
			}
			return this;
		}
	}
}
