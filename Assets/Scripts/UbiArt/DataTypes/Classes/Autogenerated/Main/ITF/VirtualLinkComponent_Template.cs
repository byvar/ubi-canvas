namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class VirtualLinkComponent_Template : ActorComponent_Template {
		public StringID channelID;
		public bool emitter;
		public bool receiver;
		public CListO<Generic<Event>> broadcastEventList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			channelID = s.SerializeObject<StringID>(channelID, name: "channelID");
			emitter = s.Serialize<bool>(emitter, name: "emitter");
			receiver = s.Serialize<bool>(receiver, name: "receiver");
			broadcastEventList = s.SerializeObject<CListO<Generic<Event>>>(broadcastEventList, name: "broadcastEventList");
		}
		public override uint? ClassCRC => 0xF5BE9917;
	}
}

