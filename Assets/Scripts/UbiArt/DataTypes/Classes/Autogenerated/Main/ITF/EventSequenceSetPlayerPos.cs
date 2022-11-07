namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSequenceSetPlayerPos : Event {
		public string actor;
		public uint playerId;
		public uint playerMode;
		public bool useBaseAdjust;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actor = s.Serialize<string>(actor, name: "actor");
			playerId = s.Serialize<uint>(playerId, name: "playerId");
			playerMode = s.Serialize<uint>(playerMode, name: "playerMode");
			useBaseAdjust = s.Serialize<bool>(useBaseAdjust, name: "useBaseAdjust");
		}
		public override uint? ClassCRC => 0xCB3E87E9;
	}
}

