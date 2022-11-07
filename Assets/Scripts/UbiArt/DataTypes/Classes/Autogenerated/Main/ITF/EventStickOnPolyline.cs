namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class EventStickOnPolyline : Event {
		public bool sticked;
		public Vec2d speed;
		public uint polylineRef;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				sticked = s.Serialize<bool>(sticked, name: "sticked");
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
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

