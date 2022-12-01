using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class SoundComponent {
		public override ActorComponent Convert(Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				soundList = null;
			}
			return this;
		}
	}
}
