using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTDeciderTargetInRange : BTDecider {
		public Generic<PhysShape> detectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectionRange = s.SerializeObject<Generic<PhysShape>>(detectionRange, name: "detectionRange");
		}
		public override uint? ClassCRC => 0x52D92A9C;
	}
}

