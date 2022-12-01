namespace UbiArt.ITF {
	public partial class PhantomComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if (oldSettings.game == Settings.Game.RA || oldSettings.game == Settings.Game.RM) {
					collisionGroup = (Enum_collisionGroup)collisionGroup2;
				} else {
					collisionGroup2 = (uint)collisionGroup;
				}
			}
			return this;
		}
	}
}
