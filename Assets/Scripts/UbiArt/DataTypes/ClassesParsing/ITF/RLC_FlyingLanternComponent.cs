namespace UbiArt.ITF {
	public partial class RLC_FlyingLanternComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL || newSettings.Game == Game.COL)) {
					return Merger.Merge<RO2_HangSpotComponent>(this);
				}
			}
			return this;
		}
	}
}
