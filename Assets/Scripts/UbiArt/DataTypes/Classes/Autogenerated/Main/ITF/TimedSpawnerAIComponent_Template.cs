namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TimedSpawnerAIComponent_Template : AIComponent_Template {
		public Generic<TemplateAIBehavior> disableBehavior;
		public Generic<TemplateAIBehavior> activateBehavior;
		public Generic<TemplateAIBehavior> anticipateBehavior;
		public Generic<TemplateAIBehavior> spawnBehavior;
		public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public TimedSpawnerComponent_Template timedSpawner;
		public float anticipateDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			disableBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(disableBehavior, name: "disableBehavior");
			activateBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(activateBehavior, name: "activateBehavior");
			anticipateBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(anticipateBehavior, name: "anticipateBehavior");
			spawnBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(spawnBehavior, name: "spawnBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			timedSpawner = s.SerializeObject<TimedSpawnerComponent_Template>(timedSpawner, name: "timedSpawner");
			anticipateDuration = s.Serialize<float>(anticipateDuration, name: "anticipateDuration");
		}
		public override uint? ClassCRC => 0xA226BD33;
	}
}

