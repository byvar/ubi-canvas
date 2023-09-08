namespace UbiArt.ITF {
	public partial class RO2_DisplayTutoIconComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if (newSettings.Game == Game.RL && oldSettings.Game != Game.RL) {
					tutoType2 = (TutoType2)(int)tutoType;
				}
			}
			return this;
		}
	}
}
