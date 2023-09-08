namespace UbiArt.ITF {
	public partial class ClearColorComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL || newSettings.Game == Game.COL)
					&& !(oldSettings.Game == Game.RL || oldSettings.Game == Game.COL)) {
					if (clearColor != null) {
						clearColor2 = clearColor.ClearColor;
						clearBackLightColor = clearColor.ClearBackLightColor;
						clearFrontLightColor = clearColor.ClearFrontLightColor;
					}
				}
			}
			return this;
		}
	}
}
