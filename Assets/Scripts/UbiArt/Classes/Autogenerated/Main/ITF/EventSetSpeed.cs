using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetSpeed : Event {
		public Vec2d speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.SerializeObject<Vec2d>(speed, name: "speed");
		}
		public override uint? ClassCRC => 0xAE569AD3;
	}
}

