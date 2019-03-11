using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTDeciderTargetInRangeToAttack : BTDecider {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
		}
		public override uint? ClassCRC => 0x342660B3;
	}
}

