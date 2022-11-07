namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class TriggerComponent : ActorComponent {
		public Mode mode;
		public bool triggerOnceDone;
		public float countdown;
		public bool DBG_DrawCountdown;
		public bool AutoActivation;
		public Generic<Event> NoConditionEvent;
		public CListO<Event> onEnterMoreEvent;
		public CListO<Event> onExitMoreEvent;
		public bool moreEventSendBroadcast;
		public bool moreEventSendGameManager;
		public bool activatedOnGo;
		public bool specificTutoShieldDialog;
		public bool disableIfMapAlreadyCompleted;
		public bool triggerActivator;
		public int retriggerOnCheckpoint;
		public uint activator;

		public Generic<Event> onEnterEvent;
		public Generic<Event> onExitEvent;
		public bool resetOnExit;
		public bool triggerEachActor;
		public bool triggerAllActors;
		public bool sendEventEveryFrame;
		public bool triggerOnDetector;
		public bool triggerOnHit;
		public bool triggerOnCrush;
		public bool triggerable;
		public bool triggerSelf;
		public bool triggerChildren;
		public bool triggerBoundChildren;
		public bool triggerParent;
		public bool triggerGameManager;
		public bool triggerBroadcast;
		public bool triggerExitOnBecomeInactive;
		public uint version;
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					retriggerOnCheckpoint = s.Serialize<int>(retriggerOnCheckpoint, name: "retriggerOnCheckpoint");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone");
					activator = s.Serialize<uint>(activator, name: "activator");
				}
			} else if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					mode = s.Serialize<Mode>(mode, name: "mode");
				}
				if (s.Settings.isCatchThemAll) {
					triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone", options: CSerializerObject.Options.ForceAsByte);
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone");
					activator = s.Serialize<uint>(activator, name: "activator");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					mode = s.Serialize<Mode>(mode, name: "mode");
					onEnterEvent = s.SerializeObject<Generic<Event>>(onEnterEvent, name: "onEnterEvent");
					onExitEvent = s.SerializeObject<Generic<Event>>(onExitEvent, name: "onExitEvent");
					resetOnExit = s.Serialize<bool>(resetOnExit, name: "resetOnExit", options: CSerializerObject.Options.BoolAsByte);
					triggerEachActor = s.Serialize<bool>(triggerEachActor, name: "triggerEachActor", options: CSerializerObject.Options.BoolAsByte);
					triggerAllActors = s.Serialize<bool>(triggerAllActors, name: "triggerAllActors", options: CSerializerObject.Options.BoolAsByte);
					sendEventEveryFrame = s.Serialize<bool>(sendEventEveryFrame, name: "sendEventEveryFrame", options: CSerializerObject.Options.BoolAsByte);
					triggerOnDetector = s.Serialize<bool>(triggerOnDetector, name: "triggerOnDetector", options: CSerializerObject.Options.BoolAsByte);
					triggerOnHit = s.Serialize<bool>(triggerOnHit, name: "triggerOnHit", options: CSerializerObject.Options.BoolAsByte);
					triggerOnCrush = s.Serialize<bool>(triggerOnCrush, name: "triggerOnCrush", options: CSerializerObject.Options.BoolAsByte);
					triggerable = s.Serialize<bool>(triggerable, name: "triggerable", options: CSerializerObject.Options.BoolAsByte);
					triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf", options: CSerializerObject.Options.BoolAsByte);
					triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren", options: CSerializerObject.Options.BoolAsByte);
					triggerBoundChildren = s.Serialize<bool>(triggerBoundChildren, name: "triggerBoundChildren", options: CSerializerObject.Options.BoolAsByte);
					triggerParent = s.Serialize<bool>(triggerParent, name: "triggerParent", options: CSerializerObject.Options.BoolAsByte);
					triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator", options: CSerializerObject.Options.BoolAsByte);
					triggerGameManager = s.Serialize<bool>(triggerGameManager, name: "triggerGameManager", options: CSerializerObject.Options.BoolAsByte);
					triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast", options: CSerializerObject.Options.BoolAsByte);
					triggerExitOnBecomeInactive = s.Serialize<bool>(triggerExitOnBecomeInactive, name: "triggerExitOnBecomeInactive", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					version = s.Serialize<uint>(version, name: "version");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone", options: CSerializerObject.Options.BoolAsByte);
					activator = s.Serialize<uint>(activator, name: "activator");
				}
			} else if (s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					mode = s.Serialize<Mode>(mode, name: "mode");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone");
					activator = s.Serialize<uint>(activator, name: "activator");
				}
				countdown = s.Serialize<float>(countdown, name: "countdown");
				DBG_DrawCountdown = s.Serialize<bool>(DBG_DrawCountdown, name: "DBG_DrawCountdown");
				AutoActivation = s.Serialize<bool>(AutoActivation, name: "AutoActivation");
				NoConditionEvent = s.SerializeObject<Generic<Event>>(NoConditionEvent, name: "NoConditionEvent");
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					mode = s.Serialize<Mode>(mode, name: "mode");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone");
					activator = s.Serialize<uint>(activator, name: "activator");
				}
				countdown = s.Serialize<float>(countdown, name: "countdown");
				DBG_DrawCountdown = s.Serialize<bool>(DBG_DrawCountdown, name: "DBG_DrawCountdown");
				AutoActivation = s.Serialize<bool>(AutoActivation, name: "AutoActivation");
				NoConditionEvent = s.SerializeObject<Generic<Event>>(NoConditionEvent, name: "NoConditionEvent");
				onEnterMoreEvent = s.SerializeObject<CListO<Event>>(onEnterMoreEvent, name: "onEnterMoreEvent");
				onExitMoreEvent = s.SerializeObject<CListO<Event>>(onExitMoreEvent, name: "onExitMoreEvent");
				moreEventSendBroadcast = s.Serialize<bool>(moreEventSendBroadcast, name: "moreEventSendBroadcast");
				moreEventSendGameManager = s.Serialize<bool>(moreEventSendGameManager, name: "moreEventSendGameManager");
				activatedOnGo = s.Serialize<bool>(activatedOnGo, name: "activatedOnGo");
				specificTutoShieldDialog = s.Serialize<bool>(specificTutoShieldDialog, name: "specificTutoShieldDialog");
				disableIfMapAlreadyCompleted = s.Serialize<bool>(disableIfMapAlreadyCompleted, name: "disableIfMapAlreadyCompleted");
				triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator");
			}
		}
		public enum Mode {
			[Serialize("Mode_Once"            )] Once = 1,
			[Serialize("Mode_OnceAndRetrigger")] OnceAndRetrigger = 2,
			[Serialize("Mode_OnceAndReset"    )] OnceAndReset = 3,
			[Serialize("Mode_Multiple"        )] Multiple = 4,
		}
		public override uint? ClassCRC => 0x5E302A40;
	}
}

