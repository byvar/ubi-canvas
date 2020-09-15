using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AIBallisticsFixedGravityAction_Template : AIBallisticsAction_Template {
		public bool usePhysicsGravity;
		public float fixedGravity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			usePhysicsGravity = s.Serialize<bool>(usePhysicsGravity, name: "usePhysicsGravity");
			fixedGravity = s.Serialize<float>(fixedGravity, name: "fixedGravity");
		}
		public override uint? ClassCRC => 0x31EF148E;
	}
}

