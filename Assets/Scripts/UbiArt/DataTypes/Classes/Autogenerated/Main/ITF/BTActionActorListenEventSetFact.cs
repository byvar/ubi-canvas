namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BTActionActorListenEventSetFact : BTAction {
		public Generic<Event> ListenEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ListenEvent = s.SerializeObject<Generic<Event>>(ListenEvent, name: "ListenEvent");
		}
		public override uint? ClassCRC => 0xE5787CFF;
	}
}

