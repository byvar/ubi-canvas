namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimGameplayEvent : AnimMarkerEvent {
		public bool value;
		public float valueFloat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
			} else if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL || s.Settings.Game == Game.VH) {
				value = s.Serialize<bool>(value, name: "value");
			} else {
				value = s.Serialize<bool>(value, name: "value");
				valueFloat = s.Serialize<float>(valueFloat, name: "valueFloat");
			}
		}
		public override uint? ClassCRC => 0xA2242335;
	}
}

