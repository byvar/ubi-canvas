using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionHitReflexTarget_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public Generic<PhysShape> enemyDetectionRangeInCharge;
		public Generic<PhysShape> enemyDetectionRangeInRangedAttack;
		public StringID anim;
		public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			enemyDetectionRangeInCharge = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRangeInCharge, name: "enemyDetectionRangeInCharge");
			enemyDetectionRangeInRangedAttack = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRangeInRangedAttack, name: "enemyDetectionRangeInRangedAttack");
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			debug = s.Serialize<bool>(debug, name: "debug");
		}
		public override uint? ClassCRC => 0xF3F935B9;
	}
}

