using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTDeciderTargetInRangeToAttack_Template : BTDecider_Template {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("timeBeforeAttack"   )] public float timeBeforeAttack;
		[Serialize("debug"              )] public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(timeBeforeAttack));
			SerializeField(s, nameof(debug));
		}
		public override uint? ClassCRC => 0x9BA90A53;
	}
}

