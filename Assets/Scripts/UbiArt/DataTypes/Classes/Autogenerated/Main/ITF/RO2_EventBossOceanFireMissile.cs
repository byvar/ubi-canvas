namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventBossOceanFireMissile : Event {
		public uint regionIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			regionIndex = s.Serialize<uint>(regionIndex, name: "regionIndex");
		}
		public override uint? ClassCRC => 0x1511D2A6;
	}
}

