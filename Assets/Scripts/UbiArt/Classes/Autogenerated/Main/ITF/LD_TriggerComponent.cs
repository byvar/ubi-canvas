using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class LD_TriggerComponent : ActorComponent {
		[Serialize("mode"                     )] public Mode_Valid mode;
		[Serialize("modeAfterCP"              )] public Mode_OnceAndRe modeAfterCP;
		[Serialize("triggerOnceDone"          )] public bool triggerOnceDone;
		[Serialize("onEnterEvent"             )] public Generic<Event> onEnterEvent;
		[Serialize("onEnterMoreEvent"         )] public CList<Event> onEnterMoreEvent;
		[Serialize("onExitEvent"              )] public Generic<Event> onExitEvent;
		[Serialize("onExitMoreEvent"          )] public CList<Event> onExitMoreEvent;
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
		[Serialize("Enum_VH_0__0"             )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("Enum_VH_1__1"             )] public Enum_VH_1 Enum_VH_1__1;
		[Serialize("Generic<Event>__2"        )] public Generic<Event> Generic_Event__2;
		[Serialize("CArray<Generic<Event>>__3")] public CArray<Generic<Event>> CArray_Generic_Event__3;
		[Serialize("Generic<Event>__4"        )] public Generic<Event> Generic_Event__4;
		[Serialize("CArray<Generic<Event>>__5")] public CArray<Generic<Event>> CArray_Generic_Event__5;
		[Serialize("bool__6"                  )] public bool bool__6;
		[Serialize("bool__7"                  )] public bool bool__7;
		[Serialize("float__8"                 )] public float float__8;
		[Serialize("bool__9"                  )] public bool bool__9;
		[Serialize("bool__10"                 )] public bool bool__10;
		[Serialize("bool__11"                 )] public bool bool__11;
		[Serialize("bool__12"                 )] public bool bool__12;
		[Serialize("bool__13"                 )] public bool bool__13;
		[Serialize("bool__14"                 )] public bool bool__14;
		[Serialize("bool__15"                 )] public bool bool__15;
		[Serialize("bool__16"                 )] public bool bool__16;
		[Serialize("float__17"                )] public float float__17;
		[Serialize("float__18"                )] public float float__18;
		[Serialize("bool__19"                 )] public bool bool__19;
		[Serialize("bool__20"                 )] public bool bool__20;
		[Serialize("Generic<Event>__21"       )] public Generic<Event> Generic_Event__21;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Enum_VH_0__0));
				SerializeField(s, nameof(Enum_VH_1__1));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
				}
				SerializeField(s, nameof(Generic_Event__2));
				SerializeField(s, nameof(CArray_Generic_Event__3));
				SerializeField(s, nameof(Generic_Event__4));
				SerializeField(s, nameof(CArray_Generic_Event__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(bool__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(bool__11));
				SerializeField(s, nameof(bool__12));
				SerializeField(s, nameof(bool__13));
				SerializeField(s, nameof(bool__14));
				SerializeField(s, nameof(bool__15));
				SerializeField(s, nameof(bool__16));
				SerializeField(s, nameof(float__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(bool__19));
				SerializeField(s, nameof(bool__20));
				SerializeField(s, nameof(Generic_Event__21));
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
		public enum Mode_Valid {
			[Serialize("Mode_ValidOnce"    )] Once = 0,
			[Serialize("Mode_ValidMultiple")] Multiple = 1,
		}
		public enum Mode_OnceAndRe {
			[Serialize("Mode_OnceAndRetriggerAfterCP")] triggerAfterCP = 0,
			[Serialize("Mode_OnceAndResetAfterCP"    )] setAfterCP = 1,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x0892B6A1;
	}
}

