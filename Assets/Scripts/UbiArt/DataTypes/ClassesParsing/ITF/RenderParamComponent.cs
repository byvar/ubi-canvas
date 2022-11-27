namespace UbiArt.ITF {
	public partial class RenderParamComponent {
		public override ActorComponent Convert(Settings oldSettings, Settings newSettings) {
			base.Convert(oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)) {
					return new ClearColorComponent() {
						clearColor = ClearColor
					}.Convert(oldSettings, newSettings);
				}
			}
			return this;
		}
	}
}
