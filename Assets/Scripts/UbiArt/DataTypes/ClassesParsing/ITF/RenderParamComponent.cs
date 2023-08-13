namespace UbiArt.ITF {
	public partial class RenderParamComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)) {
					/*if (Lighting?.GlobalColor != null && Lighting.GlobalColor.a != 0f) {
						ClearColor.ClearFrontLightColor = Lighting.GlobalColor; // Hack
					}*/
					return new ClearColorComponent() {
						clearColor = ClearColor
					}.Convert(context, actor, oldSettings, newSettings);
				}
			}
			return this;
		}
	}
}
