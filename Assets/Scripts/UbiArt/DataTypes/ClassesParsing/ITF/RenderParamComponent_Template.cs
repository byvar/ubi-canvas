namespace UbiArt.ITF {
	public partial class RenderParamComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL || newSettings.Game == Game.COL)) {
					return new ClearColorComponent_Template().Convert(context, actor, oldSettings, newSettings);
				}
			}
			return this;
		}
	}
}
