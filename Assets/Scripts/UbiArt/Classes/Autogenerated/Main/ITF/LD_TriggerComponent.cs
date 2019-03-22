using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class LD_TriggerComponent : ActorComponent {
		[Serialize("mode"                     )] public Mode mode;
		[Serialize("modeAfterCP"              )] public ModeAfterCP modeAfterCP;
		[Serialize("triggerOnceDone"          )] public bool triggerOnceDone;
		[Serialize("onEnterEvent"             )] public Generic<Event> onEnterEvent;
		[Serialize("onEnterMoreEvent"         )] public CList<Generic<Event>> onEnterMoreEvent;
		[Serialize("onExitEvent"              )] public Generic<Event> onExitEvent;
		[Serialize("onExitMoreEvent"          )] public CList<Generic<Event>> onExitMoreEvent;
		[Serialize("sendEventEveryFrame"      )] public bool sendEventEveryFrame;
		[Serialize("sendEventEveryDelai"      )] public float sendEventEveryDelai;
		[Serialize("triggerOnDetector"        )] public bool triggerOnDetector;
		[Serialize("triggerSelf"              )] public bool triggerSelf;
		[Serialize("triggerChildren"          )] public bool triggerChildren;
		[Serialize("discardChildrenWithTag"   )] public bool discardChildrenWithTag;
		[Serialize("triggerBoundChildren"     )] public bool triggerBoundChildren;
		[Serialize("triggerParent"            )] public bool triggerParent;
		[Serialize("triggerActivator"         )] public bool triggerActivator;
		[Serialize("triggerBroadcast"         )] public bool triggerBroadcast;
		[Serialize("delaiBeforeValidation"    )] public float delaiBeforeValidation;
		[Serialize("countdown"                )] public float countdown;
		[Serialize("DBG_DrawCountdown"        )] public bool DBG_DrawCountdown;
		[Serialize("AutoActivation"           )] public bool AutoActivation;
		[Serialize("NoConditionEvent"         )] public Generic<Event> NoConditionEvent;

		[Serialize("bool__6"                  )] public bool bool__6;
		[Serialize("bool__7"                  )] public bool bool__7;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(mode));
				SerializeField(s, nameof(modeAfterCP));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
				}
				SerializeField(s, nameof(onEnterEvent));
				SerializeField(s, nameof(onEnterMoreEvent));
				SerializeField(s, nameof(onExitEvent));
				SerializeField(s, nameof(onExitMoreEvent));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(sendEventEveryDelai));
				SerializeField(s, nameof(triggerOnDetector));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(discardChildrenWithTag));
				SerializeField(s, nameof(triggerBoundChildren));
				SerializeField(s, nameof(triggerParent));
				SerializeField(s, nameof(triggerActivator));
				SerializeField(s, nameof(triggerBroadcast));
				SerializeField(s, nameof(delaiBeforeValidation));
				SerializeField(s, nameof(countdown));
				SerializeField(s, nameof(DBG_DrawCountdown));
				SerializeField(s, nameof(AutoActivation));
				SerializeField(s, nameof(NoConditionEvent));
			} else {
				SerializeField(s, nameof(mode));
				SerializeField(s, nameof(modeAfterCP));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
				}
				SerializeField(s, nameof(onEnterEvent));
				SerializeField(s, nameof(onEnterMoreEvent));
				SerializeField(s, nameof(onExitEvent));
				SerializeField(s, nameof(onExitMoreEvent));
				SerializeField(s, nameof(sendEventEveryFrame));
				SerializeField(s, nameof(sendEventEveryDelai));
				SerializeField(s, nameof(triggerOnDetector));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(discardChildrenWithTag));
				SerializeField(s, nameof(triggerBoundChildren));
				SerializeField(s, nameof(triggerParent));
				SerializeField(s, nameof(triggerActivator));
				SerializeField(s, nameof(triggerBroadcast));
				SerializeField(s, nameof(delaiBeforeValidation));
				SerializeField(s, nameof(countdown));
				SerializeField(s, nameof(DBG_DrawCountdown));
				SerializeField(s, nameof(AutoActivation));
				SerializeField(s, nameof(NoConditionEvent));
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

