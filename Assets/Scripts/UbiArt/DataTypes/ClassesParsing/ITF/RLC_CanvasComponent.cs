﻿namespace UbiArt.ITF {
	public partial class RLC_CanvasComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)) {
					return Merger.Merge<PlayAnimOnWeightChangeComponent>(this);
				}
			}
			return this;
		}
	}
}
