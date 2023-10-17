using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class GraphicComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (newSettings.Game == Game.RL) {
				var firstComponent = actor.GetComponent<GraphicComponent_Template>();
				if (firstComponent != null && this != firstComponent) {
					//return null;
				}
			}
			return this;
		}
	}
}
