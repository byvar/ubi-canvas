namespace UbiArt.ITF {
	public partial class PlayerDetectorComponent {
		public override ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (newSettings.Game == Game.RL) {
				var firstComponent = actor.GetComponent<PlayerDetectorComponent>();
				if (firstComponent != null && this != firstComponent) {
					return null;
				}
			}
			return this;
		}
	}
}
