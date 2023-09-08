namespace UbiArt.ITF {
	public partial class RLC_CanvasComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if ((newSettings.Game == Game.RL || newSettings.Game == Game.COL)) {
					var weightChange = Merger.Merge<PlayAnimOnWeightChangeComponent_Template>(this);
					weightChange.enterAnim = new StringID("bounce");
					weightChange.listenToTrigger = false;
					weightChange.weightThreshold = 0.5f;
					return weightChange;
				}
			}
			return this;
		}
	}
}
