namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_FruitAIComponent_Template : RO2_AIComponent_Template {
		public Generic<TemplateAIBehavior> roamBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public Generic<TemplateAIBehavior> floatingBehavior;
		public Generic<TemplateAIBehavior> receiveHitBehavior;
		public Generic<TemplateAIBehavior> sleepBehavior;
		public Generic<TemplateAIBehavior> stuckBehavior;
		public Generic<TemplateAIBehavior> snappedBehavior;
		public int isHanging;
		public float nonStickableTime;
		public int reinitWhenBecomesInactive;
		public int canReceiveHit;
		public float shooterHitForce;
		public float shooterHitSpeedMultiplier;
		public float squashPenetrationRadiusPercent;
		public int fruitsOverlap;
		public float jamMaxTime;
		public Path eyePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			roamBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(roamBehavior, name: "roamBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			floatingBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(floatingBehavior, name: "floatingBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(receiveHitBehavior, name: "receiveHitBehavior");
			sleepBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(sleepBehavior, name: "sleepBehavior");
			stuckBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(stuckBehavior, name: "stuckBehavior");
			snappedBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(snappedBehavior, name: "snappedBehavior");
			isHanging = s.Serialize<int>(isHanging, name: "isHanging");
			nonStickableTime = s.Serialize<float>(nonStickableTime, name: "nonStickableTime");
			reinitWhenBecomesInactive = s.Serialize<int>(reinitWhenBecomesInactive, name: "reinitWhenBecomesInactive");
			canReceiveHit = s.Serialize<int>(canReceiveHit, name: "canReceiveHit");
			shooterHitForce = s.Serialize<float>(shooterHitForce, name: "shooterHitForce");
			shooterHitSpeedMultiplier = s.Serialize<float>(shooterHitSpeedMultiplier, name: "shooterHitSpeedMultiplier");
			squashPenetrationRadiusPercent = s.Serialize<float>(squashPenetrationRadiusPercent, name: "squashPenetrationRadiusPercent");
			fruitsOverlap = s.Serialize<int>(fruitsOverlap, name: "fruitsOverlap");
			jamMaxTime = s.Serialize<float>(jamMaxTime, name: "jamMaxTime");
			eyePath = s.SerializeObject<Path>(eyePath, name: "eyePath");
		}
		public override uint? ClassCRC => 0xCB7548C5;
	}
}

