using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerComponent_Template : ActorComponent_Template {
		[Serialize("onEnterEvent"        )] public Generic<Event> onEnterEvent;
		[Serialize("onExitEvent"         )] public Generic<Event> onExitEvent;
		[Serialize("resetOnExit"         )] public bool resetOnExit;
		[Serialize("triggerEachActor"    )] public bool triggerEachActor;
		[Serialize("triggerAllActors"    )] public bool triggerAllActors;
		[Serialize("sendEventEveryFrame" )] public bool sendEventEveryFrame;
		[Serialize("triggerOnDetector"   )] public bool triggerOnDetector;
		[Serialize("triggerOnHit"        )] public bool triggerOnHit;
		[Serialize("triggerOnCrush"      )] public bool triggerOnCrush;
		[Serialize("triggerable"         )] public bool triggerable;
		[Serialize("triggerSelf"         )] public bool triggerSelf;
		[Serialize("triggerChildren"     )] public bool triggerChildren;
		[Serialize("triggerBoundChildren")] public bool triggerBoundChildren;
		[Serialize("triggerParent"       )] public bool triggerParent;
		[Serialize("triggerActivator"    )] public bool triggerActivator;
		[Serialize("triggerGameManager"  )] public bool triggerGameManager;
		[Serialize("triggerBroadcast"    )] public bool triggerBroadcast;
		[Serialize("activateChildren"    )] public bool activateChildren;
		[Serialize("triggerOnce"         )] public bool triggerOnce;
		[Serialize("resetOnCheckpoint"   )] public bool resetOnCheckpoint;
		[Serialize("triggerOnWind"       )] public bool triggerOnWind;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(activateChildren));
				SerializeField(s, nameof(triggerOnce));
				SerializeField(s, nameof(resetOnCheckpoint));
				SerializeField(s, nameof(resetOnExit));
				SerializeField(s, nameof(triggerOnDetector));
				SerializeField(s, nameof(triggerOnHit));
				SerializeField(s, nameof(triggerOnWind));
				SerializeField(s, nameof(triggerOnCrush));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(triggerParent));
				SerializeField(s, nameof(triggerActivator));
				SerializeField(s, nameof(triggerGameManager));
				SerializeField(s, nameof(triggerBroadcast));
				SerializeField(s, nameof(triggerEachActor));
				SerializeField(s, nameof(triggerable));
				SerializeField(s, nameof(onEnterEvent));
				SerializeField(s, nameof(onExitEvent));
				SerializeField(s, nameof(sendEventEveryFrame));
			} else {
				SerializeField(s, nameof(onEnterEvent));
				SerializeField(s, nameof(onExitEvent));
				SerializeField(s, nameof(resetOnExit));
				SerializeField(s, nameof(triggerEachActor));
				SerializeField(s, nameof(triggerAllActors));
				SerializeField(s, nameof(sendEventEveryFrame));
				SerializeField(s, nameof(triggerOnDetector));
				SerializeField(s, nameof(triggerOnHit));
				SerializeField(s, nameof(triggerOnCrush));
				SerializeField(s, nameof(triggerable));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(triggerBoundChildren));
				SerializeField(s, nameof(triggerParent));
				SerializeField(s, nameof(triggerActivator));
				SerializeField(s, nameof(triggerGameManager));
				SerializeField(s, nameof(triggerBroadcast));
			}
		}
		public override uint? ClassCRC => 0x0ED9D88D;
	}
}

