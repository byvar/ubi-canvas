﻿namespace UbiArt.ITF {
	public partial class SoundComponent_Template {
		public override ActorComponent_Template Convert(Settings oldSettings, Settings newSettings) {
			base.Convert(oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				soundList = null;
				inputs = null;
				defaultSound = null;
			}
			return this;
		}
	}
}
