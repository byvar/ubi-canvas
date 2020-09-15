using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIJanodRoamingBehavior_Template : Ray_AIJanodRoamingBaseBehavior_Template {
		public float apexTypicalHeight;
		public float detectionDistance;
		public float delayBeforeHurts;
		public float startToFloatTime;
		public float floatTimeBeforeFalling;
		public float speedThatTriggersFloating;
		public float bristingAirMultiplier;
		public float floatConstantForceDuration;
		public float bristlingConstantForceDuration;
		public float floatMaxForce;
		public float fallToVictimInitialSpeed;
		public int mustTrackVictim;
		public float stimFeedback;
		public float stimFeedbackDist;
		public float interJanodForce;
		public float sideForce;
		public Angle maxBounceAngleFromVertical;
		public Angle smallAngleForBounceOnlyForce;
		public int isAsleep;
		public int hasConstantX;
		public float hasContantCoordinate_Force;
		public int isCycleBased;
		public float totalCycleDuration;
		public float anticipationAnimationDuration;
		public float durationForNormalFallAnimSpeed;
		public float minFallAnimSpeedRatio;
		public float maxFallAnimSpeedRatio;
		public float freeFallMinSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			apexTypicalHeight = s.Serialize<float>(apexTypicalHeight, name: "apexTypicalHeight");
			detectionDistance = s.Serialize<float>(detectionDistance, name: "detectionDistance");
			delayBeforeHurts = s.Serialize<float>(delayBeforeHurts, name: "delayBeforeHurts");
			startToFloatTime = s.Serialize<float>(startToFloatTime, name: "startToFloatTime");
			floatTimeBeforeFalling = s.Serialize<float>(floatTimeBeforeFalling, name: "floatTimeBeforeFalling");
			speedThatTriggersFloating = s.Serialize<float>(speedThatTriggersFloating, name: "speedThatTriggersFloating");
			bristingAirMultiplier = s.Serialize<float>(bristingAirMultiplier, name: "bristingAirMultiplier");
			floatConstantForceDuration = s.Serialize<float>(floatConstantForceDuration, name: "floatConstantForceDuration");
			bristlingConstantForceDuration = s.Serialize<float>(bristlingConstantForceDuration, name: "bristlingConstantForceDuration");
			floatMaxForce = s.Serialize<float>(floatMaxForce, name: "floatMaxForce");
			fallToVictimInitialSpeed = s.Serialize<float>(fallToVictimInitialSpeed, name: "fallToVictimInitialSpeed");
			mustTrackVictim = s.Serialize<int>(mustTrackVictim, name: "mustTrackVictim");
			stimFeedback = s.Serialize<float>(stimFeedback, name: "stimFeedback");
			stimFeedbackDist = s.Serialize<float>(stimFeedbackDist, name: "stimFeedbackDist");
			interJanodForce = s.Serialize<float>(interJanodForce, name: "interJanodForce");
			sideForce = s.Serialize<float>(sideForce, name: "sideForce");
			maxBounceAngleFromVertical = s.SerializeObject<Angle>(maxBounceAngleFromVertical, name: "maxBounceAngleFromVertical");
			smallAngleForBounceOnlyForce = s.SerializeObject<Angle>(smallAngleForBounceOnlyForce, name: "smallAngleForBounceOnlyForce");
			isAsleep = s.Serialize<int>(isAsleep, name: "isAsleep");
			hasConstantX = s.Serialize<int>(hasConstantX, name: "hasConstantX");
			hasContantCoordinate_Force = s.Serialize<float>(hasContantCoordinate_Force, name: "hasContantCoordinate_Force");
			isCycleBased = s.Serialize<int>(isCycleBased, name: "isCycleBased");
			totalCycleDuration = s.Serialize<float>(totalCycleDuration, name: "totalCycleDuration");
			anticipationAnimationDuration = s.Serialize<float>(anticipationAnimationDuration, name: "anticipationAnimationDuration");
			durationForNormalFallAnimSpeed = s.Serialize<float>(durationForNormalFallAnimSpeed, name: "durationForNormalFallAnimSpeed");
			minFallAnimSpeedRatio = s.Serialize<float>(minFallAnimSpeedRatio, name: "minFallAnimSpeedRatio");
			maxFallAnimSpeedRatio = s.Serialize<float>(maxFallAnimSpeedRatio, name: "maxFallAnimSpeedRatio");
			freeFallMinSpeed = s.Serialize<float>(freeFallMinSpeed, name: "freeFallMinSpeed");
		}
		public override uint? ClassCRC => 0x3FE24F9A;
	}
}

