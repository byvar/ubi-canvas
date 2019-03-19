using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_JanodAIComponent : Ray_FixedAIComponent {
		[Serialize("startsAtApex"       )] public int startsAtApex;
		[Serialize("delayBeforeStarting")] public float delayBeforeStarting;
		[Serialize("mustWaitForTrigger" )] public int mustWaitForTrigger;
		[Serialize("canFallWhenSleeping")] public int canFallWhenSleeping;
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

