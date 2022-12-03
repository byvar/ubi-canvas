namespace UbiArt.ITF {
	public partial class RLC_FlyingLanternComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)) {
					return Merger.Merge<RO2_HangSpotComponent_Template>(this);
				}
			}
			return this;
		}
	}
}
