using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionLookAtAttack : BTAction {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("enemyAttackRange"   )] public Generic<PhysShape> enemyAttackRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(enemyAttackRange));
		}
		public override uint? ClassCRC => 0xEE3BD0D7;
	}
}

