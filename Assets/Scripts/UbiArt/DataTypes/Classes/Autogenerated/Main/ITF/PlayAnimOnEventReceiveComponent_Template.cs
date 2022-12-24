namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PlayAnimOnEventReceiveComponent_Template : ActorComponent_Template {
		public CListO<Generic<Event>> listenEvents;
		public bool useForLoop;
		public StringID idleAnim;
		public StringID eventAnim;
		public StringID eventIdleAnim;
		public bool resetOnRetrigger = true;
		public bool stayOnEvent;
		public bool stayOnEventCheckpointSave;
		public bool disableAfterEvent;
		public bool useAnimatedComponentForAnimsFinish;
		public bool useMRKtoAllowRestart;
		public bool acceptOnlyChargedPunch;
		public Generic<Event> eventToSend;
		public bool restoreEventIdleOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				listenEvents = s.SerializeObject<CListO<Generic<Event>>>(listenEvents, name: "listenEvents");
				idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
				eventAnim = s.SerializeObject<StringID>(eventAnim, name: "eventAnim");
				eventIdleAnim = s.SerializeObject<StringID>(eventIdleAnim, name: "eventIdleAnim");
				resetOnRetrigger = s.Serialize<bool>(resetOnRetrigger, name: "resetOnRetrigger");
				stayOnEvent = s.Serialize<bool>(stayOnEvent, name: "stayOnEvent");
				stayOnEventCheckpointSave = s.Serialize<bool>(stayOnEventCheckpointSave, name: "stayOnEventCheckpointSave");
				disableAfterEvent = s.Serialize<bool>(disableAfterEvent, name: "disableAfterEvent");
				useAnimatedComponentForAnimsFinish = s.Serialize<bool>(useAnimatedComponentForAnimsFinish, name: "useAnimatedComponentForAnimsFinish");
			} else if (s.Settings.game == Settings.Game.RL) {
				listenEvents = s.SerializeObject<CListO<Generic<Event>>>(listenEvents, name: "listenEvents");
				idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
				eventAnim = s.SerializeObject<StringID>(eventAnim, name: "eventAnim");
				eventIdleAnim = s.SerializeObject<StringID>(eventIdleAnim, name: "eventIdleAnim");
				resetOnRetrigger = s.Serialize<bool>(resetOnRetrigger, name: "resetOnRetrigger");
				stayOnEvent = s.Serialize<bool>(stayOnEvent, name: "stayOnEvent");
				stayOnEventCheckpointSave = s.Serialize<bool>(stayOnEventCheckpointSave, name: "stayOnEventCheckpointSave");
				disableAfterEvent = s.Serialize<bool>(disableAfterEvent, name: "disableAfterEvent");
				useAnimatedComponentForAnimsFinish = s.Serialize<bool>(useAnimatedComponentForAnimsFinish, name: "useAnimatedComponentForAnimsFinish");
				useMRKtoAllowRestart = s.Serialize<bool>(useMRKtoAllowRestart, name: "useMRKtoAllowRestart");
				acceptOnlyChargedPunch = s.Serialize<bool>(acceptOnlyChargedPunch, name: "acceptOnlyChargedPunch");
				eventToSend = s.SerializeObject<Generic<Event>>(eventToSend, name: "eventToSend");
			} else if (s.Settings.game == Settings.Game.COL) {
				listenEvents = s.SerializeObject<CListO<Generic<Event>>>(listenEvents, name: "listenEvents");
				idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
				eventAnim = s.SerializeObject<StringID>(eventAnim, name: "eventAnim");
				eventIdleAnim = s.SerializeObject<StringID>(eventIdleAnim, name: "eventIdleAnim");
				resetOnRetrigger = s.Serialize<bool>(resetOnRetrigger, name: "resetOnRetrigger");
				stayOnEvent = s.Serialize<bool>(stayOnEvent, name: "stayOnEvent");
				stayOnEventCheckpointSave = s.Serialize<bool>(stayOnEventCheckpointSave, name: "stayOnEventCheckpointSave");
				disableAfterEvent = s.Serialize<bool>(disableAfterEvent, name: "disableAfterEvent");
				useAnimatedComponentForAnimsFinish = s.Serialize<bool>(useAnimatedComponentForAnimsFinish, name: "useAnimatedComponentForAnimsFinish");
				useMRKtoAllowRestart = s.Serialize<bool>(useMRKtoAllowRestart, name: "useMRKtoAllowRestart");
				acceptOnlyChargedPunch = s.Serialize<bool>(acceptOnlyChargedPunch, name: "acceptOnlyChargedPunch");
				restoreEventIdleOnCheckpoint = s.Serialize<bool>(restoreEventIdleOnCheckpoint, name: "restoreEventIdleOnCheckpoint");
				eventToSend = s.SerializeObject<Generic<Event>>(eventToSend, name: "eventToSend");
			} else {
				listenEvents = s.SerializeObject<CListO<Generic<Event>>>(listenEvents, name: "listenEvents");
				useForLoop = s.Serialize<bool>(useForLoop, name: "useForLoop");
				idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
				eventAnim = s.SerializeObject<StringID>(eventAnim, name: "eventAnim");
				eventIdleAnim = s.SerializeObject<StringID>(eventIdleAnim, name: "eventIdleAnim");
				resetOnRetrigger = s.Serialize<bool>(resetOnRetrigger, name: "resetOnRetrigger");
				stayOnEvent = s.Serialize<bool>(stayOnEvent, name: "stayOnEvent");
				stayOnEventCheckpointSave = s.Serialize<bool>(stayOnEventCheckpointSave, name: "stayOnEventCheckpointSave");
				disableAfterEvent = s.Serialize<bool>(disableAfterEvent, name: "disableAfterEvent");
				useAnimatedComponentForAnimsFinish = s.Serialize<bool>(useAnimatedComponentForAnimsFinish, name: "useAnimatedComponentForAnimsFinish");
				useMRKtoAllowRestart = s.Serialize<bool>(useMRKtoAllowRestart, name: "useMRKtoAllowRestart");
				acceptOnlyChargedPunch = s.Serialize<bool>(acceptOnlyChargedPunch, name: "acceptOnlyChargedPunch");
				eventToSend = s.SerializeObject<Generic<Event>>(eventToSend, name: "eventToSend");
			}
		}
		public override uint? ClassCRC => 0xD7767023;
	}
}

