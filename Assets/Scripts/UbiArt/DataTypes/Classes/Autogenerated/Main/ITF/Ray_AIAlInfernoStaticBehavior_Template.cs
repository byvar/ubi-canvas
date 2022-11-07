namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIAlInfernoStaticBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> idle;
		public Generic<AIAction_Template> uturn;
		public Generic<AIAction_Template> attack;
		public Generic<AIAction_Template> cycleUturn;
		public float idleTime;
		public AABB detectionRange;
		public int attackOnDetection;
		public int stickOnWalls;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIAction_Template>>(idle, name: "idle");
			uturn = s.SerializeObject<Generic<AIAction_Template>>(uturn, name: "uturn");
			attack = s.SerializeObject<Generic<AIAction_Template>>(attack, name: "attack");
			cycleUturn = s.SerializeObject<Generic<AIAction_Template>>(cycleUturn, name: "cycleUturn");
			idleTime = s.Serialize<float>(idleTime, name: "idleTime");
			detectionRange = s.SerializeObject<AABB>(detectionRange, name: "detectionRange");
			attackOnDetection = s.Serialize<int>(attackOnDetection, name: "attackOnDetection");
			stickOnWalls = s.Serialize<int>(stickOnWalls, name: "stickOnWalls");
		}
		public override uint? ClassCRC => 0x0B61346E;
	}
}

