namespace UbiArt.ITF {
	public partial class ClearColorComponent {
		public override ActorComponent Convert(Settings oldSettings, Settings newSettings) {
			base.Convert(oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)
					&& !(oldSettings.game == Settings.Game.RL || oldSettings.game == Settings.Game.COL)) {
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
