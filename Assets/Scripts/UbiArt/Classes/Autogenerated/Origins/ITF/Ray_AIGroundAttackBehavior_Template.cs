using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIGroundAttackBehavior_Template : Ray_AIGroundBaseMovementAttackBehavior_Template {
		[Serialize("detect"             )] public Placeholder detect;
		[Serialize("backDetect"         )] public Placeholder backDetect;
		[Serialize("jump"               )] public Placeholder jump;
		[Serialize("fall"               )] public Placeholder fall;
		[Serialize("giveUp"             )] public Placeholder giveUp;
		[Serialize("outOfRange"         )] public Placeholder outOfRange;
		[Serialize("attacks"            )] public Placeholder attacks;
		[Serialize("slopeDetectionRange")] public float slopeDetectionRange;
		[Serialize("maxSlopeAngleUp"    )] public Angle maxSlopeAngleUp;
		[Serialize("maxSlopeAngleDown"  )] public Angle maxSlopeAngleDown;
		[Serialize("giveUpDistance"     )] public float giveUpDistance;
		[Serialize("minIdleTime"        )] public float minIdleTime;
		[Serialize("minWalkTime"        )] public float minWalkTime;
		[Serialize("moveRanges"         )] public Placeholder moveRanges;
		[Serialize("hackFlip"           )] public bool hackFlip;
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
		public override uint? ClassCRC => 0x2451FFFE;
	}
}

