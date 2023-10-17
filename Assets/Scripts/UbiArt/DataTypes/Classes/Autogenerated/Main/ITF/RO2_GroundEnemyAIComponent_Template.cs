namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_GroundEnemyAIComponent_Template : RO2_AIComponent_Template {
		public Generic<TemplateAIBehavior> roamBehavior;
		public Generic<RO2_AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public Generic<TemplateAIBehavior> crushedBehavior;
		public Generic<TemplateAIBehavior> spawnBehavior;
		public Generic<TemplateAIBehavior> closeRangeAttackBehavior;
		public Generic<RO2_AIHitWallBehavior_Template> hitWallBehavior;
		public Generic<RO2_AISleepBehavior_Template> sleepBehavior;
		public Generic<PhysShape> closeRangeDetectionShape;
		public float closeRangeAttackPushBackForce = 600f;
		public float squashPenetrationRadius = 0.6f;
		public bool dieInWater = true;
		public float rayCastDist = 5f;
		public bool checkSquash = true;
		public bool unbindChildrenOnHit;
		public bool checkStickForCloseRangeAttack;
		public bool detectHunterOwnBullet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			roamBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(roamBehavior, name: "roamBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<RO2_AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			crushedBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(crushedBehavior, name: "crushedBehavior");
			spawnBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(spawnBehavior, name: "spawnBehavior");
			closeRangeAttackBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(closeRangeAttackBehavior, name: "closeRangeAttackBehavior");
			hitWallBehavior = s.SerializeObject<Generic<RO2_AIHitWallBehavior_Template>>(hitWallBehavior, name: "hitWallBehavior");
			sleepBehavior = s.SerializeObject<Generic<RO2_AISleepBehavior_Template>>(sleepBehavior, name: "sleepBehavior");
			closeRangeDetectionShape = s.SerializeObject<Generic<PhysShape>>(closeRangeDetectionShape, name: "closeRangeDetectionShape");
			closeRangeAttackPushBackForce = s.Serialize<float>(closeRangeAttackPushBackForce, name: "closeRangeAttackPushBackForce");
			squashPenetrationRadius = s.Serialize<float>(squashPenetrationRadius, name: "squashPenetrationRadius");
			dieInWater = s.Serialize<bool>(dieInWater, name: "dieInWater");
			rayCastDist = s.Serialize<float>(rayCastDist, name: "rayCastDist");
			checkSquash = s.Serialize<bool>(checkSquash, name: "checkSquash");
			unbindChildrenOnHit = s.Serialize<bool>(unbindChildrenOnHit, name: "unbindChildrenOnHit");
			checkStickForCloseRangeAttack = s.Serialize<bool>(checkStickForCloseRangeAttack, name: "checkStickForCloseRangeAttack");
			detectHunterOwnBullet = s.Serialize<bool>(detectHunterOwnBullet, name: "detectHunterOwnBullet");
		}
		public override uint? ClassCRC => 0x5E424511;
	}
}

