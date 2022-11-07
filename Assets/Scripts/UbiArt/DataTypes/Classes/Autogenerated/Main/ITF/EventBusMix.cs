namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.RA | GameFlags.RM)]
	public partial class EventBusMix : Event {
		public int activate;
		public BusMix busMix;
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.engineVersion == Settings.EngineVersion.RO) {
				activate = s.Serialize<int>(activate, name: "activate");
				busMix = s.SerializeObject<BusMix>(busMix, name: "busMix");
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				activate = s.Serialize<int>(activate, name: "activate");
				busMix = s.SerializeObject<BusMix>(busMix, name: "busMix");
			} else {
			}
		}
		public override uint? ClassCRC => 0xAEA6BBF0;
	}
}

