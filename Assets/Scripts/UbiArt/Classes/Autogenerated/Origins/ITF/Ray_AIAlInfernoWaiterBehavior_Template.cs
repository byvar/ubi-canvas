using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIAlInfernoWaiterBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("fall"                         )] public Placeholder fall;
		[Serialize("patrol"                       )] public Placeholder patrol;
		[Serialize("longRangeAttack"              )] public Placeholder longRangeAttack;
		[Serialize("crushed"                      )] public Placeholder crushed;
		[Serialize("uturn_walk"                   )] public Placeholder uturn_walk;
		[Serialize("longRangeAttackDetectionRange")] public Placeholder longRangeAttackDetectionRange;
		[Serialize("flamesFXName"                 )] public StringID flamesFXName;
		[Serialize("catchWalkAnimation"           )] public StringID catchWalkAnimation;
		[Serialize("crushedVerticalSpeedThreshold")] public float crushedVerticalSpeedThreshold;
		[Serialize("attackTimeThreshold"          )] public float attackTimeThreshold;
		[Serialize("brakingForce"                 )] public float brakingForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fall));
			SerializeField(s, nameof(patrol));
			SerializeField(s, nameof(longRangeAttack));
			SerializeField(s, nameof(crushed));
			SerializeField(s, nameof(uturn_walk));
			SerializeField(s, nameof(longRangeAttackDetectionRange));
			SerializeField(s, nameof(flamesFXName));
			SerializeField(s, nameof(catchWalkAnimation));
			SerializeField(s, nameof(crushedVerticalSpeedThreshold));
			SerializeField(s, nameof(attackTimeThreshold));
			SerializeField(s, nameof(brakingForce));
		}
		public override uint? ClassCRC => 0xC586D512;
	}
}

