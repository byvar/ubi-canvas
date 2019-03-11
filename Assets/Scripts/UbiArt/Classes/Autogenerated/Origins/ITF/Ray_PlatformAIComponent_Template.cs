using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_PlatformAIComponent_Template : CSerializable {
		[Serialize("startActivated"                     )] public bool startActivated;
		[Serialize("startOpened"                        )] public bool startOpened;
		[Serialize("activateEvent"                      )] public Placeholder activateEvent;
		[Serialize("activateTransition"                 )] public StringID activateTransition;
		[Serialize("activateIdle"                       )] public StringID activateIdle;
		[Serialize("deactivateEvent"                    )] public Placeholder deactivateEvent;
		[Serialize("deactivateTransition"               )] public StringID deactivateTransition;
		[Serialize("deactivateIdle"                     )] public StringID deactivateIdle;
		[Serialize("deactivateTimeHysteresis"           )] public float deactivateTimeHysteresis;
		[Serialize("synchronizeActivationTransitions"   )] public bool synchronizeActivationTransitions;
		[Serialize("openEvent"                          )] public Placeholder openEvent;
		[Serialize("openTransition"                     )] public StringID openTransition;
		[Serialize("openIdle"                           )] public StringID openIdle;
		[Serialize("openCarryingIdle"                   )] public StringID openCarryingIdle;
		[Serialize("closeEvent"                         )] public Placeholder closeEvent;
		[Serialize("closeTransition"                    )] public StringID closeTransition;
		[Serialize("synchronizeOpenCloseTransitions"    )] public bool synchronizeOpenCloseTransitions;
		[Serialize("closeTimeHysteresis"                )] public float closeTimeHysteresis;
		[Serialize("closeOnHit"                         )] public bool closeOnHit;
		[Serialize("closeOnHitTransition"               )] public StringID closeOnHitTransition;
		[Serialize("closeOnHitDuration"                 )] public float closeOnHitDuration;
		[Serialize("openFullEvent"                      )] public Placeholder openFullEvent;
		[Serialize("openFullTransition"                 )] public StringID openFullTransition;
		[Serialize("openFullIdle"                       )] public StringID openFullIdle;
		[Serialize("closeFullEvent"                     )] public Placeholder closeFullEvent;
		[Serialize("closeFullTransition"                )] public StringID closeFullTransition;
		[Serialize("synchronizeOpenCloseFullTransitions")] public bool synchronizeOpenCloseFullTransitions;
		[Serialize("weightIncreaseTransition"           )] public StringID weightIncreaseTransition;
		[Serialize("weightDecreaseTransition"           )] public StringID weightDecreaseTransition;
		[Serialize("weightThreshold"                    )] public float weightThreshold;
		[Serialize("manageVacuum"                       )] public bool manageVacuum;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startActivated));
			SerializeField(s, nameof(startOpened));
			SerializeField(s, nameof(activateEvent));
			SerializeField(s, nameof(activateTransition));
			SerializeField(s, nameof(activateIdle));
			SerializeField(s, nameof(deactivateEvent));
			SerializeField(s, nameof(deactivateTransition));
			SerializeField(s, nameof(deactivateIdle));
			SerializeField(s, nameof(deactivateTimeHysteresis));
			SerializeField(s, nameof(synchronizeActivationTransitions));
			SerializeField(s, nameof(openEvent));
			SerializeField(s, nameof(openTransition));
			SerializeField(s, nameof(openIdle));
			SerializeField(s, nameof(openCarryingIdle));
			SerializeField(s, nameof(closeEvent));
			SerializeField(s, nameof(closeTransition));
			SerializeField(s, nameof(synchronizeOpenCloseTransitions));
			SerializeField(s, nameof(closeTimeHysteresis));
			SerializeField(s, nameof(closeOnHit));
			SerializeField(s, nameof(closeOnHitTransition));
			SerializeField(s, nameof(closeOnHitDuration));
			SerializeField(s, nameof(openFullEvent));
			SerializeField(s, nameof(openFullTransition));
			SerializeField(s, nameof(openFullIdle));
			SerializeField(s, nameof(closeFullEvent));
			SerializeField(s, nameof(closeFullTransition));
			SerializeField(s, nameof(synchronizeOpenCloseFullTransitions));
			SerializeField(s, nameof(weightIncreaseTransition));
			SerializeField(s, nameof(weightDecreaseTransition));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(manageVacuum));
		}
		public override uint? ClassCRC => 0xEA743761;
	}
}

