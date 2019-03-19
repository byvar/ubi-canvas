using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGroundAttackBehavior_Template : Ray_AIGroundBaseMovementAttackBehavior_Template {
		[Serialize("detect"             )] public Generic<AIAction_Template> detect;
		[Serialize("backDetect"         )] public Generic<AIAction_Template> backDetect;
		[Serialize("jump"               )] public Generic<AIJumpAction_Template> jump;
		[Serialize("fall"               )] public Generic<AIFallAction_Template> fall;
		[Serialize("giveUp"             )] public Generic<AIPlayAnimAction_Template> giveUp;
		[Serialize("outOfRange"         )] public Generic<AIAction_Template> outOfRange;
		[Serialize("attacks"            )] public CList<Ray_AIGroundAttackBehavior_Template.AttackData> attacks;
		[Serialize("slopeDetectionRange")] public float slopeDetectionRange;
		[Serialize("maxSlopeAngleUp"    )] public Angle maxSlopeAngleUp;
		[Serialize("maxSlopeAngleDown"  )] public Angle maxSlopeAngleDown;
		[Serialize("giveUpDistance"     )] public float giveUpDistance;
		[Serialize("minIdleTime"        )] public float minIdleTime;
		[Serialize("minWalkTime"        )] public float minWalkTime;
		[Serialize("moveRanges"         )] public CArray<Ray_AIGroundAttackBehavior_Template.MoveRange> moveRanges;
		[Serialize("hackFlip"           )] public int hackFlip;
		[Serialize("outOfRangeAngle"    )] public Angle outOfRangeAngle;
		[Serialize("outOfRangeDistance" )] public float outOfRangeDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detect));
			SerializeField(s, nameof(backDetect));
			SerializeField(s, nameof(jump));
			SerializeField(s, nameof(fall));
			SerializeField(s, nameof(giveUp));
			SerializeField(s, nameof(outOfRange));
			SerializeField(s, nameof(attacks));
			SerializeField(s, nameof(slopeDetectionRange));
			SerializeField(s, nameof(maxSlopeAngleUp));
			SerializeField(s, nameof(maxSlopeAngleDown));
			SerializeField(s, nameof(giveUpDistance));
			SerializeField(s, nameof(minIdleTime));
			SerializeField(s, nameof(minWalkTime));
			SerializeField(s, nameof(moveRanges));
			SerializeField(s, nameof(hackFlip));
			SerializeField(s, nameof(outOfRangeAngle));
			SerializeField(s, nameof(outOfRangeDistance));
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class MoveRange : CSerializable {
			[Serialize("float__0")] public float float__0;
			[Serialize("float__1")] public float float__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class AttackData : CSerializable {
			[Serialize("AABB__0"                                )] public AABB AABB__0;
			[Serialize("float__1"                               )] public float float__1;
			[Serialize("Generic<AIPerformHitAction_Template>__2")] public Generic<AIPerformHitAction_Template> Generic_AIPerformHitAction_Template__2;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(AABB__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(Generic_AIPerformHitAction_Template__2));
			}
		}
		public override uint? ClassCRC => 0x2451FFFE;
	}
}

