namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterTurretAIComponent_Template : Ray_MultiPiecesActorAIComponent_Template {
		public Placeholder idleBehavior;
		public Placeholder attackBehavior;
		public Placeholder receiveHitBehavior;
		public Placeholder deathBehavior;
		public Placeholder crushedBehavior;
		public Placeholder activateBehavior;
		public Placeholder desactivateBehavior;
		public Placeholder closedBehavior;
		public float findEnemyRadius;
		public float closeRadius;
		public int useRadius;
		public Placeholder detectionRange;
		public Placeholder detectionCloseRange;
		public int triggerable;
		public int forceLookDir;
		public int forceLookDirRight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleBehavior = s.SerializeObject<Placeholder>(idleBehavior, name: "idleBehavior");
			attackBehavior = s.SerializeObject<Placeholder>(attackBehavior, name: "attackBehavior");
			receiveHitBehavior = s.SerializeObject<Placeholder>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Placeholder>(deathBehavior, name: "deathBehavior");
			crushedBehavior = s.SerializeObject<Placeholder>(crushedBehavior, name: "crushedBehavior");
			activateBehavior = s.SerializeObject<Placeholder>(activateBehavior, name: "activateBehavior");
			desactivateBehavior = s.SerializeObject<Placeholder>(desactivateBehavior, name: "desactivateBehavior");
			closedBehavior = s.SerializeObject<Placeholder>(closedBehavior, name: "closedBehavior");
			findEnemyRadius = s.Serialize<float>(findEnemyRadius, name: "findEnemyRadius");
			closeRadius = s.Serialize<float>(closeRadius, name: "closeRadius");
			useRadius = s.Serialize<int>(useRadius, name: "useRadius");
			detectionRange = s.SerializeObject<Placeholder>(detectionRange, name: "detectionRange");
			detectionCloseRange = s.SerializeObject<Placeholder>(detectionCloseRange, name: "detectionCloseRange");
			triggerable = s.Serialize<int>(triggerable, name: "triggerable");
			forceLookDir = s.Serialize<int>(forceLookDir, name: "forceLookDir");
			forceLookDirRight = s.Serialize<int>(forceLookDirRight, name: "forceLookDirRight");
		}
		public override uint? ClassCRC => 0xCA358020;
	}
}

