using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class SoundComponent {
		public override ActorComponent Convert(Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				soundList = null;
			}
			if (newSettings.game == Settings.Game.RL) {
				foreach (var comp in actor.COMPONENTS) {
					if (comp?.obj is SoundComponent c) {
						return (this == c) ? this : null;
					}
				}
			}
			return this;
		}
	}
}
