namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_JanodAIComponent : Ray_FixedAIComponent {
		public int startsAtApex;
		public float delayBeforeStarting;
		public int mustWaitForTrigger;
		public int canFallWhenSleeping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startsAtApex = s.Serialize<int>(startsAtApex, name: "startsAtApex");
				delayBeforeStarting = s.Serialize<float>(delayBeforeStarting, name: "delayBeforeStarting");
				mustWaitForTrigger = s.Serialize<int>(mustWaitForTrigger, name: "mustWaitForTrigger");
				canFallWhenSleeping = s.Serialize<int>(canFallWhenSleeping, name: "canFallWhenSleeping");
			}
		}
		public override uint? ClassCRC => 0x53C00052;
	}
}

