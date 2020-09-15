using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonAttackBehavior_Template : Ray_AIGroundBaseMovementAttackBehavior_Template {
		public Placeholder detect;
		public Placeholder backDetect;
		public Placeholder fall;
		public Placeholder giveUp;
		public Placeholder outOfRange;
		public Placeholder attack;
		public Placeholder jumpAttack;
		public float minIdleTime;
		public float minWalkTime;
		public float slopeDetectionRange;
		public Angle maxSlopeAngleUp;
		public Angle maxSlopeAngleDown;
		public float giveUpDistance;
		public Placeholder moveRanges;
		public Angle outOfRangeAngle;
		public float outOfRangeDistance;
		public float moveCycleTime;
		public float attackDetectionRange;
		public int setVictim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detect = s.SerializeObject<Placeholder>(detect, name: "detect");
			backDetect = s.SerializeObject<Placeholder>(backDetect, name: "backDetect");
			fall = s.SerializeObject<Placeholder>(fall, name: "fall");
			giveUp = s.SerializeObject<Placeholder>(giveUp, name: "giveUp");
			outOfRange = s.SerializeObject<Placeholder>(outOfRange, name: "outOfRange");
			attack = s.SerializeObject<Placeholder>(attack, name: "attack");
			jumpAttack = s.SerializeObject<Placeholder>(jumpAttack, name: "jumpAttack");
			minIdleTime = s.Serialize<float>(minIdleTime, name: "minIdleTime");
			minWalkTime = s.Serialize<float>(minWalkTime, name: "minWalkTime");
			slopeDetectionRange = s.Serialize<float>(slopeDetectionRange, name: "slopeDetectionRange");
			maxSlopeAngleUp = s.SerializeObject<Angle>(maxSlopeAngleUp, name: "maxSlopeAngleUp");
			maxSlopeAngleDown = s.SerializeObject<Angle>(maxSlopeAngleDown, name: "maxSlopeAngleDown");
			giveUpDistance = s.Serialize<float>(giveUpDistance, name: "giveUpDistance");
			moveRanges = s.SerializeObject<Placeholder>(moveRanges, name: "moveRanges");
			outOfRangeAngle = s.SerializeObject<Angle>(outOfRangeAngle, name: "outOfRangeAngle");
			outOfRangeDistance = s.Serialize<float>(outOfRangeDistance, name: "outOfRangeDistance");
			moveCycleTime = s.Serialize<float>(moveCycleTime, name: "moveCycleTime");
			attackDetectionRange = s.Serialize<float>(attackDetectionRange, name: "attackDetectionRange");
			setVictim = s.Serialize<int>(setVictim, name: "setVictim");
		}
		public override uint? ClassCRC => 0xFF433DE5;
	}
}

