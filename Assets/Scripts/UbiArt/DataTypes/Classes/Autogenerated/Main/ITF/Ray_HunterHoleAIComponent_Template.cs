namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_HunterHoleAIComponent_Template : AIComponent_Template {
		public float findEnemyRadius;
		public int useRadius;
		public Placeholder detectionRange;
		public Placeholder idleBehavior;
		public Placeholder attackBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			findEnemyRadius = s.Serialize<float>(findEnemyRadius, name: "findEnemyRadius");
			useRadius = s.Serialize<int>(useRadius, name: "useRadius");
			detectionRange = s.SerializeObject<Placeholder>(detectionRange, name: "detectionRange");
			idleBehavior = s.SerializeObject<Placeholder>(idleBehavior, name: "idleBehavior");
			attackBehavior = s.SerializeObject<Placeholder>(attackBehavior, name: "attackBehavior");
		}
		public override uint? ClassCRC => 0x6165B732;
	}
}

