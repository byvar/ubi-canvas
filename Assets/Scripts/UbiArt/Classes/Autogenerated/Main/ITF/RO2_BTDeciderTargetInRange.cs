using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTDeciderTargetInRange : BTDecider {
		[Serialize("detectionRange")] public Generic<PhysShape> detectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectionRange));
		}
		public override uint? ClassCRC => 0x52D92A9C;
	}
}

