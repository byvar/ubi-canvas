namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSequenceActivatePlayers : Event {
		public bool activate;
		public bool playStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				activate = s.Serialize<bool>(activate, name: "activate");
			} else {
				activate = s.Serialize<bool>(activate, name: "activate");
				playStart = s.Serialize<bool>(playStart, name: "playStart");
			}
		}
		public override uint? ClassCRC => 0xC1B4AADE;
	}
}

