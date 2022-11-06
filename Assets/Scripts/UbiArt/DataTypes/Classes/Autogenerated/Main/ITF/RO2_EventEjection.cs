using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventEjection : Event {
		public Vec2d speed;
		public bool immuneDrag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.SerializeObject<Vec2d>(speed, name: "speed");
			immuneDrag = s.Serialize<bool>(immuneDrag, name: "immuneDrag");
		}
		public override uint? ClassCRC => 0x0C37395B;
	}
}

