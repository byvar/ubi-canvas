using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventPushForce : Event {
		public Vec2d force;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			force = s.SerializeObject<Vec2d>(force, name: "force");
		}
		public override uint? ClassCRC => 0xFC2EE7A0;
	}
}

