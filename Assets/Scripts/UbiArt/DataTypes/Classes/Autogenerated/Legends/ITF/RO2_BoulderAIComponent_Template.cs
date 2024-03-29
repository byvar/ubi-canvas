namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_BoulderAIComponent_Template : RO2_FruitAIComponent_Template {
		public Generic<TemplateAIBehavior> sentBackBehavior;
		public float maxSentBackDuration;
		public float maxBouncesCount;
		public float timeAfterLastBounce;
		public float maxTimeWithoutBounce;
		public float maxTimeAfterSenderDeath;
		public float immediateExplosionOnSenderDeathPeriod;
		public float noStimPeriod;
		public float sentbackNormalSpeed;
		public float sentbackTornadoSpeed;
		public int sentBackOnHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sentBackBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(sentBackBehavior, name: "sentBackBehavior");
			maxSentBackDuration = s.Serialize<float>(maxSentBackDuration, name: "maxSentBackDuration");
			maxBouncesCount = s.Serialize<float>(maxBouncesCount, name: "maxBouncesCount");
			timeAfterLastBounce = s.Serialize<float>(timeAfterLastBounce, name: "timeAfterLastBounce");
			maxTimeWithoutBounce = s.Serialize<float>(maxTimeWithoutBounce, name: "maxTimeWithoutBounce");
			maxTimeAfterSenderDeath = s.Serialize<float>(maxTimeAfterSenderDeath, name: "maxTimeAfterSenderDeath");
			immediateExplosionOnSenderDeathPeriod = s.Serialize<float>(immediateExplosionOnSenderDeathPeriod, name: "immediateExplosionOnSenderDeathPeriod");
			noStimPeriod = s.Serialize<float>(noStimPeriod, name: "noStimPeriod");
			sentbackNormalSpeed = s.Serialize<float>(sentbackNormalSpeed, name: "sentbackNormalSpeed");
			sentbackTornadoSpeed = s.Serialize<float>(sentbackTornadoSpeed, name: "sentbackTornadoSpeed");
			sentBackOnHit = s.Serialize<int>(sentBackOnHit, name: "sentBackOnHit");
		}
		public override uint? ClassCRC => 0xECE738DC;
	}
}

