namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_LuckyTicketRewardWeight : CSerializable {
		public RLC_LuckyTicketReward luckyTicketReward;
		public uint weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			luckyTicketReward = s.SerializeObject<RLC_LuckyTicketReward>(luckyTicketReward, name: "luckyTicketReward");
			weight = s.Serialize<uint>(weight, name: "weight");
		}
	}
}

