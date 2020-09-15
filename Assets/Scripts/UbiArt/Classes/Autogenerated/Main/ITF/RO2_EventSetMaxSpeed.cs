using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventSetMaxSpeed : Event {
		public float speed;
		public bool restoreSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
			restoreSpeed = s.Serialize<bool>(restoreSpeed, name: "restoreSpeed");
		}
		public override uint? ClassCRC => 0x41157F75;
	}
}

