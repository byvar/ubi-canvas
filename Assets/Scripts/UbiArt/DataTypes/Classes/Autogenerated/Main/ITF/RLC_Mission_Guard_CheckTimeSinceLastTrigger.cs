namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_CheckTimeSinceLastTrigger : RLC_Mission_Guard {
		public float timeSinceLastTrigger;
		public uint successCondition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeSinceLastTrigger = s.Serialize<float>(timeSinceLastTrigger, name: "timeSinceLastTrigger");
			successCondition = s.Serialize<uint>(successCondition, name: "successCondition");
		}
		public override uint? ClassCRC => 0x4CBC170B;
	}
}

