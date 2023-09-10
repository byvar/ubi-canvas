namespace UbiArt.ITF {
	public partial class RenderParamComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL || newSettings.Game == Game.COL)) {
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
