namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBlowFishBehavior_Template : TemplateAIBehavior {
		public Placeholder idle;
		public Placeholder detect;
		public Placeholder inflatedIdle;
		public Placeholder inflate;
		public Placeholder deflate;
		public float detectionRange;
		public float detectionCloseRange;
		public float inflateDuration;
		public float inflatedScaleMultiplier;
		public float deflateDuration;
		public float minIdleDuration;
		public float minInflatedDuration;
		public float repulsionForce;
		public float attractionForce;
		public float friction;
		public float memorizedHitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Placeholder>(idle, name: "idle");
			detect = s.SerializeObject<Placeholder>(detect, name: "detect");
			inflatedIdle = s.SerializeObject<Placeholder>(inflatedIdle, name: "inflatedIdle");
			inflate = s.SerializeObject<Placeholder>(inflate, name: "inflate");
			deflate = s.SerializeObject<Placeholder>(deflate, name: "deflate");
			detectionRange = s.Serialize<float>(detectionRange, name: "detectionRange");
			detectionCloseRange = s.Serialize<float>(detectionCloseRange, name: "detectionCloseRange");
			inflateDuration = s.Serialize<float>(inflateDuration, name: "inflateDuration");
			inflatedScaleMultiplier = s.Serialize<float>(inflatedScaleMultiplier, name: "inflatedScaleMultiplier");
			deflateDuration = s.Serialize<float>(deflateDuration, name: "deflateDuration");
			minIdleDuration = s.Serialize<float>(minIdleDuration, name: "minIdleDuration");
			minInflatedDuration = s.Serialize<float>(minInflatedDuration, name: "minInflatedDuration");
			repulsionForce = s.Serialize<float>(repulsionForce, name: "repulsionForce");
			attractionForce = s.Serialize<float>(attractionForce, name: "attractionForce");
			friction = s.Serialize<float>(friction, name: "friction");
			memorizedHitTime = s.Serialize<float>(memorizedHitTime, name: "memorizedHitTime");
		}
		public override uint? ClassCRC => 0xB86B7B26;
	}
}

