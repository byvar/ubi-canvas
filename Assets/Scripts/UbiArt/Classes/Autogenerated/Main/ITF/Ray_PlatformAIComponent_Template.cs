using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PlatformAIComponent_Template : ActorComponent_Template {
		public int startActivated;
		public int startOpened;
		public Generic<Event> activateEvent;
		public StringID activateTransition;
		public StringID activateIdle;
		public Generic<Event> deactivateEvent;
		public StringID deactivateTransition;
		public StringID deactivateIdle;
		public float deactivateTimeHysteresis;
		public int synchronizeActivationTransitions;
		public Generic<Event> openEvent;
		public StringID openTransition;
		public StringID openIdle;
		public StringID openCarryingIdle;
		public Generic<Event> closeEvent;
		public StringID closeTransition;
		public int synchronizeOpenCloseTransitions;
		public float closeTimeHysteresis;
		public int closeOnHit;
		public StringID closeOnHitTransition;
		public float closeOnHitDuration;
		public Generic<Event> openFullEvent;
		public StringID openFullTransition;
		public StringID openFullIdle;
		public Generic<Event> closeFullEvent;
		public StringID closeFullTransition;
		public int synchronizeOpenCloseFullTransitions;
		public StringID weightIncreaseTransition;
		public StringID weightDecreaseTransition;
		public float weightThreshold;
		public int manageVacuum;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startActivated = s.Serialize<int>(startActivated, name: "startActivated");
			startOpened = s.Serialize<int>(startOpened, name: "startOpened");
			activateEvent = s.SerializeObject<Generic<Event>>(activateEvent, name: "activateEvent");
			activateTransition = s.SerializeObject<StringID>(activateTransition, name: "activateTransition");
			activateIdle = s.SerializeObject<StringID>(activateIdle, name: "activateIdle");
			deactivateEvent = s.SerializeObject<Generic<Event>>(deactivateEvent, name: "deactivateEvent");
			deactivateTransition = s.SerializeObject<StringID>(deactivateTransition, name: "deactivateTransition");
			deactivateIdle = s.SerializeObject<StringID>(deactivateIdle, name: "deactivateIdle");
			deactivateTimeHysteresis = s.Serialize<float>(deactivateTimeHysteresis, name: "deactivateTimeHysteresis");
			synchronizeActivationTransitions = s.Serialize<int>(synchronizeActivationTransitions, name: "synchronizeActivationTransitions");
			openEvent = s.SerializeObject<Generic<Event>>(openEvent, name: "openEvent");
			openTransition = s.SerializeObject<StringID>(openTransition, name: "openTransition");
			openIdle = s.SerializeObject<StringID>(openIdle, name: "openIdle");
			openCarryingIdle = s.SerializeObject<StringID>(openCarryingIdle, name: "openCarryingIdle");
			closeEvent = s.SerializeObject<Generic<Event>>(closeEvent, name: "closeEvent");
			closeTransition = s.SerializeObject<StringID>(closeTransition, name: "closeTransition");
			synchronizeOpenCloseTransitions = s.Serialize<int>(synchronizeOpenCloseTransitions, name: "synchronizeOpenCloseTransitions");
			closeTimeHysteresis = s.Serialize<float>(closeTimeHysteresis, name: "closeTimeHysteresis");
			closeOnHit = s.Serialize<int>(closeOnHit, name: "closeOnHit");
			closeOnHitTransition = s.SerializeObject<StringID>(closeOnHitTransition, name: "closeOnHitTransition");
			closeOnHitDuration = s.Serialize<float>(closeOnHitDuration, name: "closeOnHitDuration");
			openFullEvent = s.SerializeObject<Generic<Event>>(openFullEvent, name: "openFullEvent");
			openFullTransition = s.SerializeObject<StringID>(openFullTransition, name: "openFullTransition");
			openFullIdle = s.SerializeObject<StringID>(openFullIdle, name: "openFullIdle");
			closeFullEvent = s.SerializeObject<Generic<Event>>(closeFullEvent, name: "closeFullEvent");
			closeFullTransition = s.SerializeObject<StringID>(closeFullTransition, name: "closeFullTransition");
			synchronizeOpenCloseFullTransitions = s.Serialize<int>(synchronizeOpenCloseFullTransitions, name: "synchronizeOpenCloseFullTransitions");
			weightIncreaseTransition = s.SerializeObject<StringID>(weightIncreaseTransition, name: "weightIncreaseTransition");
			weightDecreaseTransition = s.SerializeObject<StringID>(weightDecreaseTransition, name: "weightDecreaseTransition");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			manageVacuum = s.Serialize<int>(manageVacuum, name: "manageVacuum");
		}
		public override uint? ClassCRC => 0xEA743761;
	}
}

