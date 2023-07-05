namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonAttackBehavior_Template : Ray_AIGroundBaseMovementAttackBehavior_Template {
		public Generic<AIAction_Template> detect;
		public Generic<AIAction_Template> backDetect;
		public Generic<AIAction_Template> fall;
		public Generic<AIAction_Template> giveUp;
		public Generic<AIAction_Template> outOfRange;
		public Generic<AIAction_Template> attack;
		public Generic<AIAction_Template> jumpAttack;
		public float minIdleTime;
		public float minWalkTime;
		public float slopeDetectionRange;
		public Angle maxSlopeAngleUp;
		public Angle maxSlopeAngleDown;
		public float giveUpDistance;
		public CArrayO<Ray_AIDarktoonAttackBehavior_Template.MoveRange> moveRanges;
		public Angle outOfRangeAngle;
		public float outOfRangeDistance;
		public float moveCycleTime;
		public float attackDetectionRange;
		public int setVictim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detect = s.SerializeObject<Generic<AIAction_Template>>(detect, name: "detect");
			backDetect = s.SerializeObject<Generic<AIAction_Template>>(backDetect, name: "backDetect");
			fall = s.SerializeObject<Generic<AIAction_Template>>(fall, name: "fall");
			giveUp = s.SerializeObject<Generic<AIAction_Template>>(giveUp, name: "giveUp");
			outOfRange = s.SerializeObject<Generic<AIAction_Template>>(outOfRange, name: "outOfRange");
			attack = s.SerializeObject<Generic<AIAction_Template>>(attack, name: "attack");
			jumpAttack = s.SerializeObject<Generic<AIAction_Template>>(jumpAttack, name: "jumpAttack");
			minIdleTime = s.Serialize<float>(minIdleTime, name: "minIdleTime");
			minWalkTime = s.Serialize<float>(minWalkTime, name: "minWalkTime");
			slopeDetectionRange = s.Serialize<float>(slopeDetectionRange, name: "slopeDetectionRange");
			maxSlopeAngleUp = s.SerializeObject<Angle>(maxSlopeAngleUp, name: "maxSlopeAngleUp");
			maxSlopeAngleDown = s.SerializeObject<Angle>(maxSlopeAngleDown, name: "maxSlopeAngleDown");
			giveUpDistance = s.Serialize<float>(giveUpDistance, name: "giveUpDistance");
			moveRanges = s.SerializeObject<CArrayO<Ray_AIDarktoonAttackBehavior_Template.MoveRange>>(moveRanges, name: "moveRanges");
			outOfRangeAngle = s.SerializeObject<Angle>(outOfRangeAngle, name: "outOfRangeAngle");
			outOfRangeDistance = s.Serialize<float>(outOfRangeDistance, name: "outOfRangeDistance");
			moveCycleTime = s.Serialize<float>(moveCycleTime, name: "moveCycleTime");
			attackDetectionRange = s.Serialize<float>(attackDetectionRange, name: "attackDetectionRange");
			setVictim = s.Serialize<int>(setVictim, name: "setVictim");
		}
		[Games(GameFlags.ROVersion)]
		public partial class MoveRange : CSerializable {
			public float maxDistance;
			public float walkForce;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				maxDistance = s.Serialize<float>(maxDistance, name: "maxDistance");
				walkForce = s.Serialize<float>(walkForce, name: "walkForce");
			}
		}
		public override uint? ClassCRC => 0xFF433DE5;
	}
}

