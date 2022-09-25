using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TriggerComponent_Template : ActorComponent_Template {
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
		public bool triggerActivator;
		public bool triggerGameManager;
		public bool triggerBroadcast;
		public int activateChildren;
		public int triggerOnce;
		public bool resetOnCheckpoint;
		public bool triggerOnWind;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				activateChildren = s.Serialize<int>(activateChildren, name: "activateChildren");
				triggerOnce = s.Serialize<int>(triggerOnce, name: "triggerOnce");
				resetOnCheckpoint = s.Serialize<bool>(resetOnCheckpoint, name: "resetOnCheckpoint");
				resetOnExit = s.Serialize<bool>(resetOnExit, name: "resetOnExit");
				triggerOnDetector = s.Serialize<bool>(triggerOnDetector, name: "triggerOnDetector");
				triggerOnHit = s.Serialize<bool>(triggerOnHit, name: "triggerOnHit");
				triggerOnWind = s.Serialize<bool>(triggerOnWind, name: "triggerOnWind");
				triggerOnCrush = s.Serialize<bool>(triggerOnCrush, name: "triggerOnCrush");
				triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
				triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
				triggerParent = s.Serialize<bool>(triggerParent, name: "triggerParent");
				triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator");
				triggerGameManager = s.Serialize<bool>(triggerGameManager, name: "triggerGameManager");
				triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
				triggerEachActor = s.Serialize<bool>(triggerEachActor, name: "triggerEachActor");
				triggerable = s.Serialize<bool>(triggerable, name: "triggerable");
				onEnterEvent = s.SerializeObject<Generic<Event>>(onEnterEvent, name: "onEnterEvent");
				onExitEvent = s.SerializeObject<Generic<Event>>(onExitEvent, name: "onExitEvent");
				sendEventEveryFrame = s.Serialize<bool>(sendEventEveryFrame, name: "sendEventEveryFrame");
			} else {
				onEnterEvent = s.SerializeObject<Generic<Event>>(onEnterEvent, name: "onEnterEvent");
				onExitEvent = s.SerializeObject<Generic<Event>>(onExitEvent, name: "onExitEvent");
				resetOnExit = s.Serialize<bool>(resetOnExit, name: "resetOnExit");
				triggerEachActor = s.Serialize<bool>(triggerEachActor, name: "triggerEachActor");
				triggerAllActors = s.Serialize<bool>(triggerAllActors, name: "triggerAllActors");
				sendEventEveryFrame = s.Serialize<bool>(sendEventEveryFrame, name: "sendEventEveryFrame");
				triggerOnDetector = s.Serialize<bool>(triggerOnDetector, name: "triggerOnDetector");
				triggerOnHit = s.Serialize<bool>(triggerOnHit, name: "triggerOnHit");
				triggerOnCrush = s.Serialize<bool>(triggerOnCrush, name: "triggerOnCrush");
				triggerable = s.Serialize<bool>(triggerable, name: "triggerable");
				triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
				triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
				triggerBoundChildren = s.Serialize<bool>(triggerBoundChildren, name: "triggerBoundChildren");
				triggerParent = s.Serialize<bool>(triggerParent, name: "triggerParent");
				triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator");
				triggerGameManager = s.Serialize<bool>(triggerGameManager, name: "triggerGameManager");
				triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
			}
		}
		public override uint? ClassCRC => 0x0ED9D88D;
	}
}

