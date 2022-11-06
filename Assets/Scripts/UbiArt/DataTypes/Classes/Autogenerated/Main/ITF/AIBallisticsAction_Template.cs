using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RL | GameFlags.RAVersion)]
	public partial class AIBallisticsAction_Template : AIAction_Template {
		public float duration;
		public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.Serialize<float>(duration, name: "duration");
			speed = s.Serialize<float>(speed, name: "speed");
		}
		public override uint? ClassCRC => 0x60637C23;
	}
}

