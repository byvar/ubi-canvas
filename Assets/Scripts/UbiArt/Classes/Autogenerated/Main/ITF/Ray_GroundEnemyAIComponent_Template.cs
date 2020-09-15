using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_GroundEnemyAIComponent_Template : Ray_AIComponent_Template {
		public Generic<TemplateAIBehavior> roamBehavior;
		public Generic<Ray_AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public Generic<TemplateAIBehavior> crushedBehavior;
		public Generic<TemplateAIBehavior> spawnBehavior;
		public Generic<TemplateAIBehavior> closeRangeAttackBehavior;
		public Generic<Ray_AIHitWallBehavior_Template> hitWallBehavior;
		public Generic<Ray_AISleepBehavior_Template> sleepBehavior;
		public Generic<PhysShape> closeRangeDetectionShape;
		public float closeRangeAttackPushBackForce;
		public float squashPenetrationRadius;
		public int dieInWater;
		public float rayCastDist;
		public int checkSquash;
		public int unbindChildrenOnHit;
		public int checkStickForCloseRangeAttack;
		public int detectHunterOwnBullet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			roamBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(roamBehavior, name: "roamBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<Ray_AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			crushedBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(crushedBehavior, name: "crushedBehavior");
			spawnBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(spawnBehavior, name: "spawnBehavior");
			closeRangeAttackBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(closeRangeAttackBehavior, name: "closeRangeAttackBehavior");
			hitWallBehavior = s.SerializeObject<Generic<Ray_AIHitWallBehavior_Template>>(hitWallBehavior, name: "hitWallBehavior");
			sleepBehavior = s.SerializeObject<Generic<Ray_AISleepBehavior_Template>>(sleepBehavior, name: "sleepBehavior");
			closeRangeDetectionShape = s.SerializeObject<Generic<PhysShape>>(closeRangeDetectionShape, name: "closeRangeDetectionShape");
			closeRangeAttackPushBackForce = s.Serialize<float>(closeRangeAttackPushBackForce, name: "closeRangeAttackPushBackForce");
			squashPenetrationRadius = s.Serialize<float>(squashPenetrationRadius, name: "squashPenetrationRadius");
			dieInWater = s.Serialize<int>(dieInWater, name: "dieInWater");
			rayCastDist = s.Serialize<float>(rayCastDist, name: "rayCastDist");
			checkSquash = s.Serialize<int>(checkSquash, name: "checkSquash");
			unbindChildrenOnHit = s.Serialize<int>(unbindChildrenOnHit, name: "unbindChildrenOnHit");
			checkStickForCloseRangeAttack = s.Serialize<int>(checkStickForCloseRangeAttack, name: "checkStickForCloseRangeAttack");
			detectHunterOwnBullet = s.Serialize<int>(detectHunterOwnBullet, name: "detectHunterOwnBullet");
		}
		public override uint? ClassCRC => 0x4053D4E8;
	}
}

