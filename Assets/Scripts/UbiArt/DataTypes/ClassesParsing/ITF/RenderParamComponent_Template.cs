namespace UbiArt.ITF {
	public partial class RenderParamComponent_Template {
		public override ActorComponent_Template Convert(Settings oldSettings, Settings newSettings) {
			base.Convert(oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)) {
					return new ClearColorComponent_Template().Convert(oldSettings, newSettings);
				}
			}
			return this;
		}
	}
}
