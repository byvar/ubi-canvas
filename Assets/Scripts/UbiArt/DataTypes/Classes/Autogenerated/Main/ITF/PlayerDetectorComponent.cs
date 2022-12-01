namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PlayerDetectorComponent : ShapeDetectorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x28C01093;

		public override ActorComponent Convert(Actor actor, Settings oldSettings, Settings newSettings) {
			if (newSettings.game == Settings.Game.RL) {
				foreach (var comp in actor.COMPONENTS) {
					if (comp?.obj is PlayerDetectorComponent pdc) {
						return (this == pdc) ? this : null;
					}
				}
			}
			return this;
		}
	}
}

