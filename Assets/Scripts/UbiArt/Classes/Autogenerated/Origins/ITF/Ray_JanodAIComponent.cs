using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_JanodAIComponent : Ray_BigMamaAIComponent {
		[Serialize("startsAtApex"       )] public bool startsAtApex;
		[Serialize("delayBeforeStarting")] public float delayBeforeStarting;
		[Serialize("mustWaitForTrigger" )] public bool mustWaitForTrigger;
		[Serialize("canFallWhenSleeping")] public bool canFallWhenSleeping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startsAtApex));
				SerializeField(s, nameof(delayBeforeStarting));
				SerializeField(s, nameof(mustWaitForTrigger));
				SerializeField(s, nameof(canFallWhenSleeping));
			}
		}
		public override uint? ClassCRC => 0x53C00052;
	}
}

