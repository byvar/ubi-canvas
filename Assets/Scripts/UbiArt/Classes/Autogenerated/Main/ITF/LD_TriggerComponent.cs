using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class LD_TriggerComponent : ActorComponent {
		public Mode mode;
		public ModeAfterCP modeAfterCP;
		public bool triggerOnceDone;
		public Generic<Event> onEnterEvent;
		public CList<Generic<Event>> onEnterMoreEvent;
		public Generic<Event> onExitEvent;
		public CList<Generic<Event>> onExitMoreEvent;
		public bool sendEventEveryFrame;
		public float sendEventEveryDelai;
		public bool triggerOnDetector;
		public bool triggerSelf;
		public bool triggerChildren;
		public bool discardChildrenWithTag;
		public bool triggerBoundChildren;
		public bool triggerParent;
		public bool triggerActivator;
		public bool triggerBroadcast;
		public float delaiBeforeValidation;
		public float countdown;
		public bool DBG_DrawCountdown;
		public bool AutoActivation;
		public Generic<Event> NoConditionEvent;

		public bool bool__6;
		public bool bool__7;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				mode = s.Serialize<Mode>(mode, name: "mode");
				modeAfterCP = s.Serialize<ModeAfterCP>(modeAfterCP, name: "modeAfterCP");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone");
				}
				onEnterEvent = s.SerializeObject<Generic<Event>>(onEnterEvent, name: "onEnterEvent");
				onEnterMoreEvent = s.SerializeObject<CList<Generic<Event>>>(onEnterMoreEvent, name: "onEnterMoreEvent");
				onExitEvent = s.SerializeObject<Generic<Event>>(onExitEvent, name: "onExitEvent");
				onExitMoreEvent = s.SerializeObject<CList<Generic<Event>>>(onExitMoreEvent, name: "onExitMoreEvent");
				bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
				bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
				sendEventEveryDelai = s.Serialize<float>(sendEventEveryDelai, name: "sendEventEveryDelai");
				triggerOnDetector = s.Serialize<bool>(triggerOnDetector, name: "triggerOnDetector");
				triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
				triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
				discardChildrenWithTag = s.Serialize<bool>(discardChildrenWithTag, name: "discardChildrenWithTag");
				triggerBoundChildren = s.Serialize<bool>(triggerBoundChildren, name: "triggerBoundChildren");
				triggerParent = s.Serialize<bool>(triggerParent, name: "triggerParent");
				triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator");
				triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
				delaiBeforeValidation = s.Serialize<float>(delaiBeforeValidation, name: "delaiBeforeValidation");
				countdown = s.Serialize<float>(countdown, name: "countdown");
				DBG_DrawCountdown = s.Serialize<bool>(DBG_DrawCountdown, name: "DBG_DrawCountdown");
				AutoActivation = s.Serialize<bool>(AutoActivation, name: "AutoActivation");
				NoConditionEvent = s.SerializeObject<Generic<Event>>(NoConditionEvent, name: "NoConditionEvent");
			} else {
				mode = s.Serialize<Mode>(mode, name: "mode");
				modeAfterCP = s.Serialize<ModeAfterCP>(modeAfterCP, name: "modeAfterCP");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone");
				}
				onEnterEvent = s.SerializeObject<Generic<Event>>(onEnterEvent, name: "onEnterEvent");
				onEnterMoreEvent = s.SerializeObject<CList<Generic<Event>>>(onEnterMoreEvent, name: "onEnterMoreEvent");
				onExitEvent = s.SerializeObject<Generic<Event>>(onExitEvent, name: "onExitEvent");
				onExitMoreEvent = s.SerializeObject<CList<Generic<Event>>>(onExitMoreEvent, name: "onExitMoreEvent");
				sendEventEveryFrame = s.Serialize<bool>(sendEventEveryFrame, name: "sendEventEveryFrame");
				sendEventEveryDelai = s.Serialize<float>(sendEventEveryDelai, name: "sendEventEveryDelai");
				triggerOnDetector = s.Serialize<bool>(triggerOnDetector, name: "triggerOnDetector");
				triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
				triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
				discardChildrenWithTag = s.Serialize<bool>(discardChildrenWithTag, name: "discardChildrenWithTag");
				triggerBoundChildren = s.Serialize<bool>(triggerBoundChildren, name: "triggerBoundChildren");
				triggerParent = s.Serialize<bool>(triggerParent, name: "triggerParent");
				triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator");
				triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
				delaiBeforeValidation = s.Serialize<float>(delaiBeforeValidation, name: "delaiBeforeValidation");
				countdown = s.Serialize<float>(countdown, name: "countdown");
				DBG_DrawCountdown = s.Serialize<bool>(DBG_DrawCountdown, name: "DBG_DrawCountdown");
				AutoActivation = s.Serialize<bool>(AutoActivation, name: "AutoActivation");
				NoConditionEvent = s.SerializeObject<Generic<Event>>(NoConditionEvent, name: "NoConditionEvent");
			}
		}
		public enum Mode {
			[Serialize("Mode_ValidOnce"    )] ValidOnce = 0,
			[Serialize("Mode_ValidMultiple")] ValidMultiple = 1,
		}
		public enum ModeAfterCP {
			[Serialize("Mode_OnceAndRetriggerAfterCP")] OnceAndRetriggerAfterCP = 0,
			[Serialize("Mode_OnceAndResetAfterCP"    )] OnceAndResetAfterCP = 1,
		}
		public override uint? ClassCRC => 0x0892B6A1;
	}
}

