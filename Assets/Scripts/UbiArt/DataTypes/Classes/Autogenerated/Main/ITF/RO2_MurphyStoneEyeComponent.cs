namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MurphyStoneEyeComponent : RO2_AIComponent {
		public bool activeOnTrigger;
		public bool activated;
		public float TimeToRumble;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				activeOnTrigger = s.Serialize<bool>(activeOnTrigger, name: "activeOnTrigger");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				activated = s.Serialize<bool>(activated, name: "activated");
				TimeToRumble = s.Serialize<float>(TimeToRumble, name: "TimeToRumble");
			}
		}
		public override uint? ClassCRC => 0xB835246A;
	}
}

