namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class EventReceivePlayAnimComponent : ActorComponent {
		public float startValue;
		public bool displayPhantom;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO) {
				startValue = s.Serialize<float>(startValue, name: "startValue");
				if (s.HasFlags(SerializeFlags.Editor)) {
					displayPhantom = s.Serialize<bool>(displayPhantom, name: "displayPhantom");
				}
			} else {
				startValue = s.Serialize<float>(startValue, name: "startValue");
			}
		}
		public override uint? ClassCRC => 0xD945CA93;
	}
}

