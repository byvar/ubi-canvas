using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class SoundComponent {
		public override ActorComponent Convert(Settings oldSettings, Settings newSettings) {
			base.Convert(oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				soundList = null;
			}
			return this;
		}
	}
}
