using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class GraphicComponent {
		public override ActorComponent Convert(Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (newSettings.game == Settings.Game.RL) {
				foreach (var comp in actor.COMPONENTS) {
					if (comp?.obj is GraphicComponent c) {
						//return (this == c) ? this : null;
					}
				}
			}
			return this;
		}
	}
}
