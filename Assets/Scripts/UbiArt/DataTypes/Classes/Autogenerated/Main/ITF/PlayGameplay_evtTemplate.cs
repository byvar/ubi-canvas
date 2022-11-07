namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlayGameplay_evtTemplate : SequenceEventWithActor_Template {
		public string onEnterEventName;
		public Generic<Event> onEnterEvent;
		public string onExitEventName;
		public Generic<Event> onExitEvent;
		public bool executeOnce;
		public bool broadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onEnterEventName = s.Serialize<string>(onEnterEventName, name: "onEnterEventName");
			onEnterEvent = s.SerializeObject<Generic<Event>>(onEnterEvent, name: "onEnterEvent");
			onExitEventName = s.Serialize<string>(onExitEventName, name: "onExitEventName");
			onExitEvent = s.SerializeObject<Generic<Event>>(onExitEvent, name: "onExitEvent");
			executeOnce = s.Serialize<bool>(executeOnce, name: "executeOnce");
			broadcast = s.Serialize<bool>(broadcast, name: "broadcast");
		}
		public override uint? ClassCRC => 0x58127C88;
	}
}

