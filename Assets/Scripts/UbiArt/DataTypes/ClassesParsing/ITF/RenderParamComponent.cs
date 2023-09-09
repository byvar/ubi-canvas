namespace UbiArt.ITF {
	public partial class RenderParamComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL || newSettings.Game == Game.COL)) {
					/*if (Lighting?.GlobalColor != null && Lighting.GlobalColor.a != 0f) {
						ClearColor.ClearFrontLightColor = Lighting.GlobalColor; // Hack
					}*/

					// TODO: Try to fix lighting by creating a subscene under this actor (if it doesn't already exist).
					// To that subscene, add a lighting frise using the size from the BoxInterpolator (if that exists, otherwise 1)

					return new ClearColorComponent() {
						clearColor = ClearColor
					}.Convert(context, actor, oldSettings, newSettings);
				}
			}
			return this;
		}
	}
}
