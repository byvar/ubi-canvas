using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SteeringComponent_Template : ActorComponent_Template {
		public float walkSpeed;
		public float runSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			walkSpeed = s.Serialize<float>(walkSpeed, name: "walkSpeed");
			runSpeed = s.Serialize<float>(runSpeed, name: "runSpeed");
		}
		public override uint? ClassCRC => 0x7D7DAF2F;
	}
}

