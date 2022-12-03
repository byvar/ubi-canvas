namespace UbiArt.ITF {
	public partial class SoundComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				/*soundList = null;
				inputs = null;
				defaultSound = null;*/
			}
			if (newSettings.game == Settings.Game.RL) {
				foreach (var comp in actor.COMPONENTS) {
					if (comp?.obj is SoundComponent_Template c) {
						return (this == c) ? this : null;
					}
				}
			}
			return this;
		}
	}
}
