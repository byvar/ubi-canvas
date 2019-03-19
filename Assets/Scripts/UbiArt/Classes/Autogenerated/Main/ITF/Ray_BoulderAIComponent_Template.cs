using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BoulderAIComponent_Template : Ray_FruitAIComponent_Template {
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
		}
		public override uint? ClassCRC => 0x3C149C2F;
	}
}

