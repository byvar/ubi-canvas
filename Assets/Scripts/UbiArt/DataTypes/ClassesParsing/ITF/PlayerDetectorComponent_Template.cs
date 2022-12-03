namespace UbiArt.ITF {
	public partial class PlayerDetectorComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			if (newSettings.game == Settings.Game.RL) {
				foreach (var comp in actor.COMPONENTS) {
					if (comp?.obj is PlayerDetectorComponent_Template pdc) {
						return (this == pdc) ? this : null;
					}
				}
			}
			return this;
		}
	}
}
