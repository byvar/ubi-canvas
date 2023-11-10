namespace UbiArt.ITF {
	public partial class WaterPerturbationComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL)) {
					return Merger.Merge<RO2_WaterPerturbationComponent_Template>(this);
				}
			}
			return this;
		}
	}
}
