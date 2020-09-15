using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_385_sub_AEBF60 : CSerializable {
		public Placeholder sentBackBehavior;
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
			sentBackBehavior = s.SerializeObject<Placeholder>(sentBackBehavior, name: "sentBackBehavior");
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

