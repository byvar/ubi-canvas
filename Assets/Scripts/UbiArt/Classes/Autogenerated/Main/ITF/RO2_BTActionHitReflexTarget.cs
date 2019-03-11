using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionHitReflexTarget : BTAction {
		[Serialize("enemyDetectionRange"              )] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("enemyDetectionRangeInCharge"      )] public Generic<PhysShape> enemyDetectionRangeInCharge;
		[Serialize("enemyDetectionRangeInRangedAttack")] public Generic<PhysShape> enemyDetectionRangeInRangedAttack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(enemyDetectionRangeInCharge));
			SerializeField(s, nameof(enemyDetectionRangeInRangedAttack));
		}
		public override uint? ClassCRC => 0x2C4D12BC;
	}
}

