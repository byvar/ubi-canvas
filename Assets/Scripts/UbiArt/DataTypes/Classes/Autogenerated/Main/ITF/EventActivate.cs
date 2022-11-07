namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RAVersion)]
	public partial class EventActivate : Event {
		public int activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				activated = s.Serialize<int>(activated, name: "activated");
			} else {
			}
		}
		public override uint? ClassCRC => 0x9D550A44;
	}
}

