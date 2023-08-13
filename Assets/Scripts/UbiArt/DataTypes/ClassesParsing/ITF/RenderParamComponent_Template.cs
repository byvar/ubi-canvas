namespace UbiArt.ITF {
	public partial class RenderParamComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)) {
					return new ClearColorComponent_Template().Convert(context, actor, oldSettings, newSettings);
				}
			}
			return this;
		}
	}
}
