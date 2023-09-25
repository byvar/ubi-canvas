namespace UbiArt.ITF {
	public partial class RO2_CheckpointComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL || newSettings.Game == Game.COL)) {
					return Merger.Merge<CheckpointComponent>(this);
				}
			}
			return this;
		}
	}
}
