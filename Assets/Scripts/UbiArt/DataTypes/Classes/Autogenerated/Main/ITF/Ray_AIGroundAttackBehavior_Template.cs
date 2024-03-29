namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIGroundAttackBehavior_Template : Ray_AIGroundBaseMovementAttackBehavior_Template {
		public Generic<AIAction_Template> detect;
		public Generic<AIAction_Template> backDetect;
		public Generic<AIJumpAction_Template> jump;
		public Generic<AIFallAction_Template> fall;
		public Generic<AIPlayAnimAction_Template> giveUp;
		public Generic<AIAction_Template> outOfRange;
		public CListO<Ray_AIGroundAttackBehavior_Template.AttackData> attacks;
		public float slopeDetectionRange;
		public Angle maxSlopeAngleUp;
		public Angle maxSlopeAngleDown;
		public float giveUpDistance;
		public float minIdleTime;
		public float minWalkTime;
		public CArrayO<Ray_AIGroundAttackBehavior_Template.MoveRange> moveRanges;
		public int hackFlip;
		public Angle outOfRangeAngle;
		public float outOfRangeDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detect = s.SerializeObject<Generic<AIAction_Template>>(detect, name: "detect");
			backDetect = s.SerializeObject<Generic<AIAction_Template>>(backDetect, name: "backDetect");
			jump = s.SerializeObject<Generic<AIJumpAction_Template>>(jump, name: "jump");
			fall = s.SerializeObject<Generic<AIFallAction_Template>>(fall, name: "fall");
			giveUp = s.SerializeObject<Generic<AIPlayAnimAction_Template>>(giveUp, name: "giveUp");
			outOfRange = s.SerializeObject<Generic<AIAction_Template>>(outOfRange, name: "outOfRange");
			attacks = s.SerializeObject<CListO<Ray_AIGroundAttackBehavior_Template.AttackData>>(attacks, name: "attacks");
			slopeDetectionRange = s.Serialize<float>(slopeDetectionRange, name: "slopeDetectionRange");
			maxSlopeAngleUp = s.SerializeObject<Angle>(maxSlopeAngleUp, name: "maxSlopeAngleUp");
			maxSlopeAngleDown = s.SerializeObject<Angle>(maxSlopeAngleDown, name: "maxSlopeAngleDown");
			giveUpDistance = s.Serialize<float>(giveUpDistance, name: "giveUpDistance");
			minIdleTime = s.Serialize<float>(minIdleTime, name: "minIdleTime");
			minWalkTime = s.Serialize<float>(minWalkTime, name: "minWalkTime");
			moveRanges = s.SerializeObject<CArrayO<Ray_AIGroundAttackBehavior_Template.MoveRange>>(moveRanges, name: "moveRanges");
			hackFlip = s.Serialize<int>(hackFlip, name: "hackFlip");
			outOfRangeAngle = s.SerializeObject<Angle>(outOfRangeAngle, name: "outOfRangeAngle");
			outOfRangeDistance = s.Serialize<float>(outOfRangeDistance, name: "outOfRangeDistance");
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class MoveRange : CSerializable {
			public float float__0;
			public float float__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class AttackData : CSerializable {
			public AABB Range;
			public float cooldown;
			public Generic<AIAction_Template> action;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Range = s.SerializeObject<AABB>(Range, name: "Range");
				cooldown = s.Serialize<float>(cooldown, name: "cooldown");
				action = s.SerializeObject<Generic<AIAction_Template>>(action, name: "action");
			}
		}
		public override uint? ClassCRC => 0x2451FFFE;
	}
}

