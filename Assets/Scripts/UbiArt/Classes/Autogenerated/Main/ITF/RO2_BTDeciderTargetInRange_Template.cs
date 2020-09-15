using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTDeciderTargetInRange_Template : BTDecider_Template {
		public Generic<PhysShape> detectionRange;
		public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectionRange = s.SerializeObject<Generic<PhysShape>>(detectionRange, name: "detectionRange");
			debug = s.Serialize<bool>(debug, name: "debug");
		}
		public override uint? ClassCRC => 0x37039AD1;
	}
}

