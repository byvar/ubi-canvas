namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TreeRewardList : CSerializable {
		public CListO<RLC_TreeReward> TreeRewards;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TreeRewards = s.SerializeObject<CListO<RLC_TreeReward>>(TreeRewards, name: "TreeRewards");
		}
		public override uint? ClassCRC => 0x79CEE39A;
	}
}

