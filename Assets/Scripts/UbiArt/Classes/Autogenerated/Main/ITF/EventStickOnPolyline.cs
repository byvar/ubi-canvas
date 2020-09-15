using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventStickOnPolyline : Event {
		public bool sticked;
		public Vec2d speed;
		public uint polylineRef;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				sticked = s.Serialize<bool>(sticked, name: "sticked");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
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

