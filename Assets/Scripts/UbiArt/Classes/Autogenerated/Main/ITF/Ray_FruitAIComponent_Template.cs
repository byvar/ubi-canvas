using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_FruitAIComponent_Template : Ray_AIComponent_Template {
		public Generic<Ray_AIFruitRoamingBehavior_Template> roamBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public Generic<Ray_AIWaterBaseBehavior_Template> floatingBehavior;
		public Generic<Ray_AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<Ray_AISleepBehavior_Template> sleepBehavior;
		public Generic<TemplateAIBehavior> stuckBehavior;
		public Generic<TemplateAIBehavior> snappedBehavior;
		public int isHanging;
		public float nonStickableTime;
		public int reinitWhenBecomesInactive;
		public int canReceiveHit;
		public float shooterHitForce;
		public float shooterHitSpeedMultiplier;
		public float squashPenetrationRadiusPercent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			roamBehavior = s.SerializeObject<Generic<Ray_AIFruitRoamingBehavior_Template>>(roamBehavior, name: "roamBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			floatingBehavior = s.SerializeObject<Generic<Ray_AIWaterBaseBehavior_Template>>(floatingBehavior, name: "floatingBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<Ray_AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
			sleepBehavior = s.SerializeObject<Generic<Ray_AISleepBehavior_Template>>(sleepBehavior, name: "sleepBehavior");
			stuckBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(stuckBehavior, name: "stuckBehavior");
			snappedBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(snappedBehavior, name: "snappedBehavior");
			isHanging = s.Serialize<int>(isHanging, name: "isHanging");
			nonStickableTime = s.Serialize<float>(nonStickableTime, name: "nonStickableTime");
			reinitWhenBecomesInactive = s.Serialize<int>(reinitWhenBecomesInactive, name: "reinitWhenBecomesInactive");
			canReceiveHit = s.Serialize<int>(canReceiveHit, name: "canReceiveHit");
			shooterHitForce = s.Serialize<float>(shooterHitForce, name: "shooterHitForce");
			shooterHitSpeedMultiplier = s.Serialize<float>(shooterHitSpeedMultiplier, name: "shooterHitSpeedMultiplier");
			squashPenetrationRadiusPercent = s.Serialize<float>(squashPenetrationRadiusPercent, name: "squashPenetrationRadiusPercent");
		}
		public override uint? ClassCRC => 0x1769E45A;
	}
}

