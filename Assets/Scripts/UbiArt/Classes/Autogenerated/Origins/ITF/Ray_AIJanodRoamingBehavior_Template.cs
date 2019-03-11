using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIJanodRoamingBehavior_Template : Ray_AIJanodRoamingBaseBehavior_Template {
		[Serialize("apexTypicalHeight"             )] public float apexTypicalHeight;
		[Serialize("detectionDistance"             )] public float detectionDistance;
		[Serialize("delayBeforeHurts"              )] public float delayBeforeHurts;
		[Serialize("startToFloatTime"              )] public float startToFloatTime;
		[Serialize("floatTimeBeforeFalling"        )] public float floatTimeBeforeFalling;
		[Serialize("speedThatTriggersFloating"     )] public float speedThatTriggersFloating;
		[Serialize("bristingAirMultiplier"         )] public float bristingAirMultiplier;
		[Serialize("floatConstantForceDuration"    )] public float floatConstantForceDuration;
		[Serialize("bristlingConstantForceDuration")] public float bristlingConstantForceDuration;
		[Serialize("floatMaxForce"                 )] public float floatMaxForce;
		[Serialize("fallToVictimInitialSpeed"      )] public float fallToVictimInitialSpeed;
		[Serialize("mustTrackVictim"               )] public bool mustTrackVictim;
		[Serialize("stimFeedback"                  )] public float stimFeedback;
		[Serialize("stimFeedbackDist"              )] public float stimFeedbackDist;
		[Serialize("interJanodForce"               )] public float interJanodForce;
		[Serialize("sideForce"                     )] public float sideForce;
		[Serialize("maxBounceAngleFromVertical"    )] public Angle maxBounceAngleFromVertical;
		[Serialize("smallAngleForBounceOnlyForce"  )] public Angle smallAngleForBounceOnlyForce;
		[Serialize("isAsleep"                      )] public bool isAsleep;
		[Serialize("hasConstantX"                  )] public bool hasConstantX;
		[Serialize("hasContantCoordinate_Force"    )] public float hasContantCoordinate_Force;
		[Serialize("isCycleBased"                  )] public bool isCycleBased;
		[Serialize("totalCycleDuration"            )] public float totalCycleDuration;
		[Serialize("anticipationAnimationDuration" )] public float anticipationAnimationDuration;
		[Serialize("durationForNormalFallAnimSpeed")] public float durationForNormalFallAnimSpeed;
		[Serialize("minFallAnimSpeedRatio"         )] public float minFallAnimSpeedRatio;
		[Serialize("maxFallAnimSpeedRatio"         )] public float maxFallAnimSpeedRatio;
		[Serialize("freeFallMinSpeed"              )] public float freeFallMinSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(apexTypicalHeight));
			SerializeField(s, nameof(detectionDistance));
			SerializeField(s, nameof(delayBeforeHurts));
			SerializeField(s, nameof(startToFloatTime));
			SerializeField(s, nameof(floatTimeBeforeFalling));
			SerializeField(s, nameof(speedThatTriggersFloating));
			SerializeField(s, nameof(bristingAirMultiplier));
			SerializeField(s, nameof(floatConstantForceDuration));
			SerializeField(s, nameof(bristlingConstantForceDuration));
			SerializeField(s, nameof(floatMaxForce));
			SerializeField(s, nameof(fallToVictimInitialSpeed));
			SerializeField(s, nameof(mustTrackVictim));
			SerializeField(s, nameof(stimFeedback));
			SerializeField(s, nameof(stimFeedbackDist));
			SerializeField(s, nameof(interJanodForce));
			SerializeField(s, nameof(sideForce));
			SerializeField(s, nameof(maxBounceAngleFromVertical));
			SerializeField(s, nameof(smallAngleForBounceOnlyForce));
			SerializeField(s, nameof(isAsleep));
			SerializeField(s, nameof(hasConstantX));
			SerializeField(s, nameof(hasContantCoordinate_Force));
			SerializeField(s, nameof(isCycleBased));
			SerializeField(s, nameof(totalCycleDuration));
			SerializeField(s, nameof(anticipationAnimationDuration));
			SerializeField(s, nameof(durationForNormalFallAnimSpeed));
			SerializeField(s, nameof(minFallAnimSpeedRatio));
			SerializeField(s, nameof(maxFallAnimSpeedRatio));
			SerializeField(s, nameof(freeFallMinSpeed));
		}
		public override uint? ClassCRC => 0x3FE24F9A;
	}
}

