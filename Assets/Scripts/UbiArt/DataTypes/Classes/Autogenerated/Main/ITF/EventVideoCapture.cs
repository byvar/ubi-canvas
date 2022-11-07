namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventVideoCapture : Event {
		public bool start;
		public Path path;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				start = s.Serialize<bool>(start, name: "start");
			} else {
				start = s.Serialize<bool>(start, name: "start");
				path = s.SerializeObject<Path>(path, name: "path");
			}
		}
		public override uint? ClassCRC => 0x7292D0DF;
	}
}

