namespace UbiArt.ITF {
	public partial class RLC_FlyingLanternComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL || newSettings.Game == Game.COL)) {
					return Merger.Merge<RO2_HangSpotComponent_Template>(this);
				}
			}
			return this;
		}
	}
}
