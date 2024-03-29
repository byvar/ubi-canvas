namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.RAVersion)]
	public partial class EventGeneric : Event {
		public StringID id;
		public bool On_Off;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR
			                                || s.Settings.Game == Game.RO || s.Settings.Game == Game.RL) {
				id = s.SerializeObject<StringID>(id, name: "id");
			} else {
				id = s.SerializeObject<StringID>(id, name: "id");
				On_Off = s.Serialize<bool>(On_Off, name: "On_Off");
			}
		}
		public override uint? ClassCRC => 0xF23941DF;
	}
}

