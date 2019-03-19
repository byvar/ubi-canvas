using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonAttackBehavior_Template : Ray_AIGroundBaseMovementAttackBehavior_Template {
		[Serialize("detect"              )] public Placeholder detect;
		[Serialize("backDetect"          )] public Placeholder backDetect;
		[Serialize("fall"                )] public Placeholder fall;
		[Serialize("giveUp"              )] public Placeholder giveUp;
		[Serialize("outOfRange"          )] public Placeholder outOfRange;
		[Serialize("attack"              )] public Placeholder attack;
		[Serialize("jumpAttack"          )] public Placeholder jumpAttack;
		[Serialize("minIdleTime"         )] public float minIdleTime;
		[Serialize("minWalkTime"         )] public float minWalkTime;
		[Serialize("slopeDetectionRange" )] public float slopeDetectionRange;
		[Serialize("maxSlopeAngleUp"     )] public Angle maxSlopeAngleUp;
		[Serialize("maxSlopeAngleDown"   )] public Angle maxSlopeAngleDown;
		[Serialize("giveUpDistance"      )] public float giveUpDistance;
		[Serialize("moveRanges"          )] public Placeholder moveRanges;
		[Serialize("outOfRangeAngle"     )] public Angle outOfRangeAngle;
		[Serialize("outOfRangeDistance"  )] public float outOfRangeDistance;
		[Serialize("moveCycleTime"       )] public float moveCycleTime;
		[Serialize("attackDetectionRange")] public float attackDetectionRange;
		[Serialize("setVictim"           )] public int setVictim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detect));
			SerializeField(s, nameof(backDetect));
			SerializeField(s, nameof(fall));
			SerializeField(s, nameof(giveUp));
			SerializeField(s, nameof(outOfRange));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(jumpAttack));
			SerializeField(s, nameof(minIdleTime));
			SerializeField(s, nameof(minWalkTime));
			SerializeField(s, nameof(slopeDetectionRange));
			SerializeField(s, nameof(maxSlopeAngleUp));
			SerializeField(s, nameof(maxSlopeAngleDown));
			SerializeField(s, nameof(giveUpDistance));
			SerializeField(s, nameof(moveRanges));
			SerializeField(s, nameof(outOfRangeAngle));
			SerializeField(s, nameof(outOfRangeDistance));
			SerializeField(s, nameof(moveCycleTime));
			SerializeField(s, nameof(attackDetectionRange));
			SerializeField(s, nameof(setVictim));
		}
		public override uint? ClassCRC => 0xFF433DE5;
	}
}

