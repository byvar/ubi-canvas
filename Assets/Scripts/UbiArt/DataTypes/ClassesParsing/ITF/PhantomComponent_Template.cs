namespace UbiArt.ITF {
	public partial class PhantomComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.Game != newSettings.Game) {
				if (oldSettings.Game == Game.RA || oldSettings.Game == Game.RM) {
					collisionGroup = (ECOLLISIONGROUP)collisionGroup2;
				} else {
					collisionGroup2 = (uint)collisionGroup;
				}
			}
			return this;
		}
	}
}
