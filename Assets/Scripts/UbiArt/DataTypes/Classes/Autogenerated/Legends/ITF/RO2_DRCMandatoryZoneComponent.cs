namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRCMandatoryZoneComponent : ActorComponent {
		public bool AMDisplayTuto;
		public StringID AM_MapId;
		public bool activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.platform == Settings.Platform.Vita) return;
			if (s.HasFlags(SerializeFlags.Default)) {
				AMDisplayTuto = s.Serialize<bool>(AMDisplayTuto, name: "AMDisplayTuto", options: CSerializerObject.Options.BoolAsByte);
				if (s.HasFlags(SerializeFlags.Editor)) {
					AM_MapId = s.SerializeChoiceListObject<StringID>(AM_MapId, name: "AM_MapId", empty: "invalid");
				} else {
					AM_MapId = s.SerializeObject<StringID>(AM_MapId, name: "AM_MapId");
				}
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				activated = s.Serialize<bool>(activated, name: "activated");
			}
		}
		public override uint? ClassCRC => 0xF84EA47C;
	}
}

