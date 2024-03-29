namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventTweeningFullReset : Event {
		public bool resetSelectedSet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				resetSelectedSet = s.Serialize<bool>(resetSelectedSet, name: "resetSelectedSet", options: CSerializerObject.Options.BoolAsByte);
			} else {
			}
		}
		public override uint? ClassCRC => 0xA162DBE0;
	}
}

