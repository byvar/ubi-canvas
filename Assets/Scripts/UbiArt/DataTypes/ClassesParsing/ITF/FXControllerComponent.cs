using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class FXControllerComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((oldSettings.Game == Game.RA || oldSettings.Game == Game.RM) && newSettings.Game == Game.RL) {
					var tpl = actor?.template?.obj?.GetComponent<FXControllerComponent_Template>();
					if (tpl != null) {
						defaultFx = tpl.defaultFx;
						triggerFx = tpl.triggerFx;
					}
				}
			}
			return this;
		}
	}
}
