namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlayAnimOnWeightChangeComponent : ActorComponent {
		public int isActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				if (s.Settings.platform != Settings.Platform.Vita) {
					isActive = s.Serialize<int>(isActive, name: "isActive");
				}
			} else {
			}
		}
		public override uint? ClassCRC => 0x8F988441;
	}
}

