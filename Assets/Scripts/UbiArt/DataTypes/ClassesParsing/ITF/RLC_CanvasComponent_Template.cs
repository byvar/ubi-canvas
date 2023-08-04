namespace UbiArt.ITF {
	public partial class RLC_CanvasComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if ((newSettings.game == Settings.Game.RL || newSettings.game == Settings.Game.COL)) {
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
