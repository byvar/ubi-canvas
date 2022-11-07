namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_OnlineEventStopGame : Event {
		public char gameType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gameType = s.Serialize<char>(gameType, name: "gameType");
		}
		public override uint? ClassCRC => 0x23078B67;
	}
}

