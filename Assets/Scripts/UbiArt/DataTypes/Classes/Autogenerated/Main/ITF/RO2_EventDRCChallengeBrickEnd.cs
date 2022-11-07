namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventDRCChallengeBrickEnd : Event {
		public bool success;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			success = s.Serialize<bool>(success, name: "success");
		}
		public override uint? ClassCRC => 0xB25AE89E;
	}
}

