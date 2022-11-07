namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MrDarkStuckComponent_Template : ActorComponent_Template {
		public CListO<Generic<Event>> listenEvents;
		public StringID idleAnim;
		public StringID eventAnim;
		public StringID eventIdleAnim;
		public StringID reactionAnim;
		public bool resetOnRetrigger;
		public bool stayOnEvent;
		public bool stayOnEventCheckpointSave;
		public bool disableAfterEvent;
		public bool useAnimatedComponentForAnimsFinish;
		public bool useMRKtoAllowRestart;
		public bool acceptOnlyChargedPunch;
		public Generic<Event> eventToSend;
		public float swipeDotMin;
		public float swipeNormMin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			listenEvents = s.SerializeObject<CListO<Generic<Event>>>(listenEvents, name: "listenEvents");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			eventAnim = s.SerializeObject<StringID>(eventAnim, name: "eventAnim");
			eventIdleAnim = s.SerializeObject<StringID>(eventIdleAnim, name: "eventIdleAnim");
			reactionAnim = s.SerializeObject<StringID>(reactionAnim, name: "reactionAnim");
			resetOnRetrigger = s.Serialize<bool>(resetOnRetrigger, name: "resetOnRetrigger");
			stayOnEvent = s.Serialize<bool>(stayOnEvent, name: "stayOnEvent");
			stayOnEventCheckpointSave = s.Serialize<bool>(stayOnEventCheckpointSave, name: "stayOnEventCheckpointSave");
			disableAfterEvent = s.Serialize<bool>(disableAfterEvent, name: "disableAfterEvent");
			useAnimatedComponentForAnimsFinish = s.Serialize<bool>(useAnimatedComponentForAnimsFinish, name: "useAnimatedComponentForAnimsFinish");
			useMRKtoAllowRestart = s.Serialize<bool>(useMRKtoAllowRestart, name: "useMRKtoAllowRestart");
			acceptOnlyChargedPunch = s.Serialize<bool>(acceptOnlyChargedPunch, name: "acceptOnlyChargedPunch");
			eventToSend = s.SerializeObject<Generic<Event>>(eventToSend, name: "eventToSend");
			swipeDotMin = s.Serialize<float>(swipeDotMin, name: "swipeDotMin");
			swipeNormMin = s.Serialize<float>(swipeNormMin, name: "swipeNormMin");
		}
		public override uint? ClassCRC => 0x782BE8F8;
	}
}

