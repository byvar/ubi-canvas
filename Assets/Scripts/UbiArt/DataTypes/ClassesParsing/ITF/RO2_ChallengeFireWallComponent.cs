namespace UbiArt.ITF {
	public partial class RO2_ChallengeFireWallComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if (newSettings.Game == Game.RL && oldSettings.Game != Game.RL) {
					// A bit hacky, but let's do this
					useScreenPos = useScreenPos || (oldSettings.Game == Game.RM && (screenPosition != new Vec2d(0.5f, 0.5f)));
				}
			}
			return this;
		}
	}
}
