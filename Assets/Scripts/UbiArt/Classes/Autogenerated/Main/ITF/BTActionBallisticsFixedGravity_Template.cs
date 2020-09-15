using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BTActionBallisticsFixedGravity_Template : BTActionBallistics_Template {
		public bool usePhysicsGravity;
		public float fixedGravity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			usePhysicsGravity = s.Serialize<bool>(usePhysicsGravity, name: "usePhysicsGravity");
			fixedGravity = s.Serialize<float>(fixedGravity, name: "fixedGravity");
		}
		public override uint? ClassCRC => 0x51F4D764;
	}
}

