using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_385_sub_AEBF60 : CSerializable {
		[Serialize("sentBackBehavior"                     )] public Placeholder sentBackBehavior;
		[Serialize("maxSentBackDuration"                  )] public float maxSentBackDuration;
		[Serialize("maxBouncesCount"                      )] public float maxBouncesCount;
		[Serialize("timeAfterLastBounce"                  )] public float timeAfterLastBounce;
		[Serialize("maxTimeWithoutBounce"                 )] public float maxTimeWithoutBounce;
		[Serialize("maxTimeAfterSenderDeath"              )] public float maxTimeAfterSenderDeath;
		[Serialize("immediateExplosionOnSenderDeathPeriod")] public float immediateExplosionOnSenderDeathPeriod;
		[Serialize("noStimPeriod"                         )] public float noStimPeriod;
		[Serialize("sentbackNormalSpeed"                  )] public float sentbackNormalSpeed;
		[Serialize("sentbackTornadoSpeed"                 )] public float sentbackTornadoSpeed;
		[Serialize("sentBackOnHit"                        )] public int sentBackOnHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sentBackBehavior));
			SerializeField(s, nameof(maxSentBackDuration));
			SerializeField(s, nameof(maxBouncesCount));
			SerializeField(s, nameof(timeAfterLastBounce));
			SerializeField(s, nameof(maxTimeWithoutBounce));
			SerializeField(s, nameof(maxTimeAfterSenderDeath));
			SerializeField(s, nameof(immediateExplosionOnSenderDeathPeriod));
			SerializeField(s, nameof(noStimPeriod));
			SerializeField(s, nameof(sentbackNormalSpeed));
			SerializeField(s, nameof(sentbackTornadoSpeed));
			SerializeField(s, nameof(sentBackOnHit));
		}
		public override uint? ClassCRC => 0xECE738DC;
	}
}

