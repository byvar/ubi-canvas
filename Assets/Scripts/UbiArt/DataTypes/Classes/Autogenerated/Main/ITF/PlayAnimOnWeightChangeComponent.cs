namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlayAnimOnWeightChangeComponent : ActorComponent {
		public int isActive = 1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				if (s.Settings.Platform != GamePlatform.Vita) {
					isActive = s.Serialize<int>(isActive, name: "isActive");
				}
			} else {
			}
		}
		public override uint? ClassCRC => 0x8F988441;
	}
}

