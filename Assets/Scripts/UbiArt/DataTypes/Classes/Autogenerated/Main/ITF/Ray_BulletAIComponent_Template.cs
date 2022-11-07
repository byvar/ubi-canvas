namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_BulletAIComponent_Template : Ray_AIComponent_Template {
		public Generic<TemplateAIBehavior> launchBehavior;
		public Generic<TemplateAIBehavior> genericBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public Generic<TemplateAIBehavior> deathNoStimBehavior;
		public float speed;
		public float lifeTime;
		public int collideWithEnvironment;
		public int collideWithPhantoms;
		public float activateNoCollDuration;
		public int sendDeathStim;
		public int isCameraRelative;
		public int collideWithSolidEdges;
		public int disablePolylineOnDeath;
		public int destroyOnExitScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			launchBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(launchBehavior, name: "launchBehavior");
			genericBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(genericBehavior, name: "genericBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			deathNoStimBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathNoStimBehavior, name: "deathNoStimBehavior");
			speed = s.Serialize<float>(speed, name: "speed");
			lifeTime = s.Serialize<float>(lifeTime, name: "lifeTime");
			collideWithEnvironment = s.Serialize<int>(collideWithEnvironment, name: "collideWithEnvironment");
			collideWithPhantoms = s.Serialize<int>(collideWithPhantoms, name: "collideWithPhantoms");
			activateNoCollDuration = s.Serialize<float>(activateNoCollDuration, name: "activateNoCollDuration");
			sendDeathStim = s.Serialize<int>(sendDeathStim, name: "sendDeathStim");
			isCameraRelative = s.Serialize<int>(isCameraRelative, name: "isCameraRelative");
			collideWithSolidEdges = s.Serialize<int>(collideWithSolidEdges, name: "collideWithSolidEdges");
			disablePolylineOnDeath = s.Serialize<int>(disablePolylineOnDeath, name: "disablePolylineOnDeath");
			destroyOnExitScreen = s.Serialize<int>(destroyOnExitScreen, name: "destroyOnExitScreen");
			destroyOnExitScreen = s.Serialize<int>(destroyOnExitScreen, name: "destroyOnExitScreen");
		}
		public override uint? ClassCRC => 0x18FDE236;
	}
}

