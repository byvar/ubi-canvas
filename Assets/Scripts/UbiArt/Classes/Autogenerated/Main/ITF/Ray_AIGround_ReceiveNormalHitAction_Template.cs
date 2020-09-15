using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGround_ReceiveNormalHitAction_Template : Ray_AIGroundReceiveHitAction_Template {
		public float frictionMultiplier;
		public float gravityMultiplier;
		public float hitForce;
		public float verticalHitForce;
		public float randomHitForce;
		public Angle randomAngleMax;
		public float antigravRampUpTime;
		public float fullAntigravTime;
		public float antigravRampDownTime;
		public float pushBackForce;
		public int canBlockHits;
		public float minStunTime;
		public float maxStunTime;
		public float ejectAnimSpeed;
		public float brakeForce;
		public float brakeHeight;
		public float speedLimit;
		public int mustFinishWithHurtTimer;
		public int resetSpeedAtStart;
		public int orientVerticalForceToGround;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frictionMultiplier = s.Serialize<float>(frictionMultiplier, name: "frictionMultiplier");
			gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
			hitForce = s.Serialize<float>(hitForce, name: "hitForce");
			verticalHitForce = s.Serialize<float>(verticalHitForce, name: "verticalHitForce");
			randomHitForce = s.Serialize<float>(randomHitForce, name: "randomHitForce");
			randomAngleMax = s.SerializeObject<Angle>(randomAngleMax, name: "randomAngleMax");
			antigravRampUpTime = s.Serialize<float>(antigravRampUpTime, name: "antigravRampUpTime");
			fullAntigravTime = s.Serialize<float>(fullAntigravTime, name: "fullAntigravTime");
			antigravRampDownTime = s.Serialize<float>(antigravRampDownTime, name: "antigravRampDownTime");
			pushBackForce = s.Serialize<float>(pushBackForce, name: "pushBackForce");
			canBlockHits = s.Serialize<int>(canBlockHits, name: "canBlockHits");
			minStunTime = s.Serialize<float>(minStunTime, name: "minStunTime");
			maxStunTime = s.Serialize<float>(maxStunTime, name: "maxStunTime");
			ejectAnimSpeed = s.Serialize<float>(ejectAnimSpeed, name: "ejectAnimSpeed");
			brakeForce = s.Serialize<float>(brakeForce, name: "brakeForce");
			brakeHeight = s.Serialize<float>(brakeHeight, name: "brakeHeight");
			speedLimit = s.Serialize<float>(speedLimit, name: "speedLimit");
			mustFinishWithHurtTimer = s.Serialize<int>(mustFinishWithHurtTimer, name: "mustFinishWithHurtTimer");
			resetSpeedAtStart = s.Serialize<int>(resetSpeedAtStart, name: "resetSpeedAtStart");
			orientVerticalForceToGround = s.Serialize<int>(orientVerticalForceToGround, name: "orientVerticalForceToGround");
		}
		public override uint? ClassCRC => 0x849B68C6;
	}
}

