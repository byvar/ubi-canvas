using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class GraphicComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (newSettings.Game == Game.RL) {
				var firstComponent = actor.GetComponent<GraphicComponent>();
				if (firstComponent != null && this != firstComponent) {
					//return null;
				}
			}
			return this;
		}
	}
}
