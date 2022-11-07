namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_OnlineEventTeamAllocation : Event {
		public uint playerOnlineID;
		public char teamID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerOnlineID = s.Serialize<uint>(playerOnlineID, name: "playerOnlineID");
			teamID = s.Serialize<char>(teamID, name: "teamID");
		}
		public override uint? ClassCRC => 0x3F76C504;
	}
}

