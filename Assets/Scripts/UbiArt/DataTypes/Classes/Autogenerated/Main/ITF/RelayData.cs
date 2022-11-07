namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class RelayData : CSerializable {
		public Generic<Event> eventToListen;
		public Generic<Event> eventToRelay;
		public float delay;
		public bool triggerSelf;
		public bool triggerChildren;
		public bool triggerBroadcast;
		public bool replaceSender;
		public bool replaceSenderByActivator;
		public bool resetTimerOnRetrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eventToListen = s.SerializeObject<Generic<Event>>(eventToListen, name: "eventToListen");
			eventToRelay = s.SerializeObject<Generic<Event>>(eventToRelay, name: "eventToRelay");
			delay = s.Serialize<float>(delay, name: "delay");
			triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
			triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
			triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
			replaceSender = s.Serialize<bool>(replaceSender, name: "replaceSender");
			replaceSenderByActivator = s.Serialize<bool>(replaceSenderByActivator, name: "replaceSenderByActivator");
			resetTimerOnRetrigger = s.Serialize<bool>(resetTimerOnRetrigger, name: "resetTimerOnRetrigger");
		}
		public override uint? ClassCRC => 0xE5F9BFFB;
	}
}

