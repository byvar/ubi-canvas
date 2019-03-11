using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionHitReflexTarget_Template : BTAction_Template {
		[Serialize("enemyDetectionRange"              )] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("enemyDetectionRangeInCharge"      )] public Generic<PhysShape> enemyDetectionRangeInCharge;
		[Serialize("enemyDetectionRangeInRangedAttack")] public Generic<PhysShape> enemyDetectionRangeInRangedAttack;
		[Serialize("anim"                             )] public StringID anim;
		[Serialize("debug"                            )] public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(enemyDetectionRangeInCharge));
			SerializeField(s, nameof(enemyDetectionRangeInRangedAttack));
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(debug));
		}
		public override uint? ClassCRC => 0xF3F935B9;
	}
}

