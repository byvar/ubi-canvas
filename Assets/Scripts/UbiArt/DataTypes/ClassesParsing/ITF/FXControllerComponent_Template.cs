using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class FXControllerComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
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
