namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class EventStickOnPolyline : Event {
		public bool sticked;
		public Vec2d speed;
		public uint polylineRef;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				sticked = s.Serialize<bool>(sticked, name: "sticked");
			} else if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				sticked = s.Serialize<bool>(sticked, name: "sticked");
				speed = s.SerializeObject<Vec2d>(speed, name: "speed");
				polylineRef = s.Serialize<uint>(polylineRef, name: "polylineRef");
			} else {
				sticked = s.Serialize<bool>(sticked, name: "sticked");
				speed = s.SerializeObject<Vec2d>(speed, name: "speed");
			}
		}
		public override uint? ClassCRC => 0x1C166A64;
	}
}

