using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BabyPiranhaAIComponent_Template : AIComponent_Template {
		[Serialize("speed"                  )] public float speed;
		[Serialize("detectionRange"         )] public float detectionRange;
		[Serialize("attackRange"            )] public float attackRange;
		[Serialize("attackTime"             )] public float attackTime;
		[Serialize("attackCooldown"         )] public float attackCooldown;
		[Serialize("idlePercent"            )] public float idlePercent;
		[Serialize("attackJumpPercent"      )] public float attackJumpPercent;
		[Serialize("attackDivePercent"      )] public float attackDivePercent;
		[Serialize("idlePerturbation"       )] public float idlePerturbation;
		[Serialize("attackPerturbation"     )] public float attackPerturbation;
		[Serialize("attackStartTime"        )] public float attackStartTime;
		[Serialize("escapeDst"              )] public float escapeDst;
		[Serialize("escapeTime"             )] public float escapeTime;
		[Serialize("hitLevel"               )] public uint hitLevel;
		[Serialize("bounceMultiplier"       )] public float bounceMultiplier;
		[Serialize("onlyAttackTargetInWater")] public int onlyAttackTargetInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(detectionRange));
			SerializeField(s, nameof(attackRange));
			SerializeField(s, nameof(attackTime));
			SerializeField(s, nameof(attackCooldown));
			SerializeField(s, nameof(idlePercent));
			SerializeField(s, nameof(attackJumpPercent));
			SerializeField(s, nameof(attackDivePercent));
			SerializeField(s, nameof(idlePerturbation));
			SerializeField(s, nameof(attackPerturbation));
			SerializeField(s, nameof(attackStartTime));
			SerializeField(s, nameof(escapeDst));
			SerializeField(s, nameof(escapeTime));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(bounceMultiplier));
			SerializeField(s, nameof(onlyAttackTargetInWater));
		}
		public override uint? ClassCRC => 0x8347B90E;
	}
}

