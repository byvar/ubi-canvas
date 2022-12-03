﻿namespace UbiArt.ITF {
	public partial class RLC_FlyingLanternComponent {
		public override ActorComponent Convert(Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)) {
					return Merger.Merge<RO2_HangSpotComponent>(this);
				}
			}
			return this;
		}
	}
}
