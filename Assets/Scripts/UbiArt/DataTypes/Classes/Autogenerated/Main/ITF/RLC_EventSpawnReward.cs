namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_EventSpawnReward : RO2_EventSpawnReward {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF002ECBF;
	}
}

