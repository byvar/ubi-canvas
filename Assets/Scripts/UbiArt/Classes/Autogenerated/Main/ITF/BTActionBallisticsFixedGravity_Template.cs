using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BTActionBallisticsFixedGravity_Template : BTActionBallistics_Template {
		[Serialize("usePhysicsGravity")] public bool usePhysicsGravity;
		[Serialize("fixedGravity"     )] public float fixedGravity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(usePhysicsGravity));
			SerializeField(s, nameof(fixedGravity));
		}
		public override uint? ClassCRC => 0x51F4D764;
	}
}

