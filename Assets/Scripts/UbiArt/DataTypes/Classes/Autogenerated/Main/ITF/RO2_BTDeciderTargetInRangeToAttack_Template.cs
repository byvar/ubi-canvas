using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTDeciderTargetInRangeToAttack_Template : BTDecider_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public float timeBeforeAttack;
		public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			timeBeforeAttack = s.Serialize<float>(timeBeforeAttack, name: "timeBeforeAttack");
			debug = s.Serialize<bool>(debug, name: "debug");
		}
		public override uint? ClassCRC => 0x9BA90A53;
	}
}

