namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionUnlockReward_Template : CSerializable {
		public StringID rewardID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rewardID = s.SerializeObject<StringID>(rewardID, name: "rewardID");
		}
		public override uint? ClassCRC => 0xC98C99AD;
	}
}

