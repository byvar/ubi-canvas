namespace UbiArt.ITF {
	public partial class RO2_DisplayTutoIconComponent {
		public override ActorComponent Convert(Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if (newSettings.game == Settings.Game.RL && oldSettings.game != Settings.Game.RL) {
					tutoType2 = (TutoType2)(int)tutoType;
				}
			}
			return this;
		}
	}
}
