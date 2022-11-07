namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_RewardsUserData : CSerializable {
		public StringID blackQueenName;
		public StringID bigSpiderName;
		public uint partnersLevelToReach;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blackQueenName = s.SerializeObject<StringID>(blackQueenName, name: "blackQueenName");
			bigSpiderName = s.SerializeObject<StringID>(bigSpiderName, name: "bigSpiderName");
			partnersLevelToReach = s.Serialize<uint>(partnersLevelToReach, name: "partnersLevelToReach");
		}
		public override uint? ClassCRC => 0xAED7767F;
	}
}

