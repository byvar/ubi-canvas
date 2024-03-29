namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_OnlineEventNewScore : Event {
		public char newScore;
		public char teamID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			newScore = s.Serialize<char>(newScore, name: "newScore");
			teamID = s.Serialize<char>(teamID, name: "teamID");
		}
		public override uint? ClassCRC => 0x48919D85;
	}
}

