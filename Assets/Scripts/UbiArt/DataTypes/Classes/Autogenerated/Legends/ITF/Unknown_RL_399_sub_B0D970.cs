namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_399_sub_B0D970 : DetectorComponent_Template {
		public int playerId;
		public int allowDeadActors;
		public int firstPlayerOnly;
		public uint allPlayerInMode;
		public int allowTouchScreenPlayer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerId = s.Serialize<int>(playerId, name: "playerId");
			allowDeadActors = s.Serialize<int>(allowDeadActors, name: "allowDeadActors");
			firstPlayerOnly = s.Serialize<int>(firstPlayerOnly, name: "firstPlayerOnly");
			allPlayerInMode = s.Serialize<uint>(allPlayerInMode, name: "allPlayerInMode");
			allowTouchScreenPlayer = s.Serialize<int>(allowTouchScreenPlayer, name: "allowTouchScreenPlayer");
		}
		public override uint? ClassCRC => 0x193EE9ED;
	}
}

