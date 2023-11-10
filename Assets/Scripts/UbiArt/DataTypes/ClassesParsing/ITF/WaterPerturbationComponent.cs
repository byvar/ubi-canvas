namespace UbiArt.ITF {
	public partial class WaterPerturbationComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL)) {
					return Merger.Merge<RO2_WaterPerturbationComponent>(this);
				}
			}
			return this;
		}
	}
}
