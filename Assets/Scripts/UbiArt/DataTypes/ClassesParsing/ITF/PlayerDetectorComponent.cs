﻿namespace UbiArt.ITF {
	public partial class PlayerDetectorComponent {
		public override ActorComponent Convert(Actor actor, Settings oldSettings, Settings newSettings) {
			if (newSettings.game == Settings.Game.RL) {
				foreach (var comp in actor.COMPONENTS) {
					if (comp?.obj is PlayerDetectorComponent pdc) {
						return (this == pdc) ? this : null;
					}
				}
			}
			return this;
		}
	}
}