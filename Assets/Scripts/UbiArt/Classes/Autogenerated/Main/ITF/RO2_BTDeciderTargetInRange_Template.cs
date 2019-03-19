using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTDeciderTargetInRange_Template : BTDecider_Template {
		[Serialize("detectionRange")] public Generic<PhysShape> detectionRange;
		[Serialize("debug"         )] public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectionRange));
			SerializeField(s, nameof(debug));
		}
		public override uint? ClassCRC => 0x37039AD1;
	}
}

