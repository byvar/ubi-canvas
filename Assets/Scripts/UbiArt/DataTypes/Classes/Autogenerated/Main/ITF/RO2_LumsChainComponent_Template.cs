using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LumsChainComponent_Template : ActorComponent_Template {
		public uint chainCompletedNumRewardLum;
		public float detectionRadius;
		public float detectionRadiusDRC;
		public float DRCOffset;
		public float eyeDetectionRadius;
		public float linkBlend;
		public bool playGenericPickupEffects;
		public StringID tinyStand;
		public StringID tinyStand2;
		public StringID tinyStand3;
		public StringID tinyToBig;
		public StringID yellowStand;
		public StringID yellowToRed;
		public StringID redStand;
		public StringID redToYellow;
		public StringID disappear;
		public StringID disappearRed;
		public StringID tinyRedStand;
		public StringID tinyRedToBig;
		public float grabAttractiveForceValue;
		public float grabAttractiveForceRange;
		public float grabMaxRepulsiveForce;
		public float grabRepulsionRadius;
		public float grabDampingFactor;
		public float arrivalDuration;
		public float timeBeforeTaken;
		public Vec2d followingOffset;
		public Path spawningEffectPath;
		public float timeBeforeStartDisappear;
		public Path interactiveActorPath;
		public float musicPerfectActivationDistance;
		public float musicFailedActivationDistance;
		public float waitingTimeBeforePlayerActivation;
		public CArrayO<Vec3d> interactiveActorOffsets;
		public CArrayO<Path> interactiveActorBgList;
		public CListP<float> bgZOffsets;
		public bool displayEyeOnlyOnDRC;
		public bool hitSemiClosedEyeGivesBonus;
		public float fireflyCloudPlayerDetectionRadius;
		public Generic<PhysShape> fireflyCloudPhantomShape;
		public StringID fireflyCloudStandFX;
		public StringID fireflyCloudActivationFX;
		public ECOLLISIONGROUP fireflyCloudCollisionGroup;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			chainCompletedNumRewardLum = s.Serialize<uint>(chainCompletedNumRewardLum, name: "chainCompletedNumRewardLum");
			detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
			detectionRadiusDRC = s.Serialize<float>(detectionRadiusDRC, name: "detectionRadiusDRC");
			DRCOffset = s.Serialize<float>(DRCOffset, name: "DRCOffset");
			eyeDetectionRadius = s.Serialize<float>(eyeDetectionRadius, name: "eyeDetectionRadius");
			linkBlend = s.Serialize<float>(linkBlend, name: "linkBlend");
			playGenericPickupEffects = s.Serialize<bool>(playGenericPickupEffects, name: "playGenericPickupEffects");
			tinyStand = s.SerializeObject<StringID>(tinyStand, name: "tinyStand");
			tinyStand2 = s.SerializeObject<StringID>(tinyStand2, name: "tinyStand2");
			tinyStand3 = s.SerializeObject<StringID>(tinyStand3, name: "tinyStand3");
			tinyToBig = s.SerializeObject<StringID>(tinyToBig, name: "tinyToBig");
			yellowStand = s.SerializeObject<StringID>(yellowStand, name: "yellowStand");
			yellowToRed = s.SerializeObject<StringID>(yellowToRed, name: "yellowToRed");
			redStand = s.SerializeObject<StringID>(redStand, name: "redStand");
			redToYellow = s.SerializeObject<StringID>(redToYellow, name: "redToYellow");
			disappear = s.SerializeObject<StringID>(disappear, name: "disappear");
			disappearRed = s.SerializeObject<StringID>(disappearRed, name: "disappearRed");
			tinyRedStand = s.SerializeObject<StringID>(tinyRedStand, name: "tinyRedStand");
			tinyRedToBig = s.SerializeObject<StringID>(tinyRedToBig, name: "tinyRedToBig");
			grabAttractiveForceValue = s.Serialize<float>(grabAttractiveForceValue, name: "grabAttractiveForceValue");
			grabAttractiveForceRange = s.Serialize<float>(grabAttractiveForceRange, name: "grabAttractiveForceRange");
			grabMaxRepulsiveForce = s.Serialize<float>(grabMaxRepulsiveForce, name: "grabMaxRepulsiveForce");
			grabRepulsionRadius = s.Serialize<float>(grabRepulsionRadius, name: "grabRepulsionRadius");
			grabDampingFactor = s.Serialize<float>(grabDampingFactor, name: "grabDampingFactor");
			arrivalDuration = s.Serialize<float>(arrivalDuration, name: "arrivalDuration");
			timeBeforeTaken = s.Serialize<float>(timeBeforeTaken, name: "timeBeforeTaken");
			followingOffset = s.SerializeObject<Vec2d>(followingOffset, name: "followingOffset");
			spawningEffectPath = s.SerializeObject<Path>(spawningEffectPath, name: "spawningEffectPath");
			timeBeforeStartDisappear = s.Serialize<float>(timeBeforeStartDisappear, name: "timeBeforeStartDisappear");
			interactiveActorPath = s.SerializeObject<Path>(interactiveActorPath, name: "interactiveActorPath");
			musicPerfectActivationDistance = s.Serialize<float>(musicPerfectActivationDistance, name: "musicPerfectActivationDistance");
			musicFailedActivationDistance = s.Serialize<float>(musicFailedActivationDistance, name: "musicFailedActivationDistance");
			waitingTimeBeforePlayerActivation = s.Serialize<float>(waitingTimeBeforePlayerActivation, name: "waitingTimeBeforePlayerActivation");
			interactiveActorOffsets = s.SerializeObject<CArrayO<Vec3d>>(interactiveActorOffsets, name: "interactiveActorOffsets");
			interactiveActorBgList = s.SerializeObject<CArrayO<Path>>(interactiveActorBgList, name: "interactiveActorBgList");
			bgZOffsets = s.SerializeObject<CListP<float>>(bgZOffsets, name: "bgZOffsets");
			displayEyeOnlyOnDRC = s.Serialize<bool>(displayEyeOnlyOnDRC, name: "displayEyeOnlyOnDRC");
			hitSemiClosedEyeGivesBonus = s.Serialize<bool>(hitSemiClosedEyeGivesBonus, name: "hitSemiClosedEyeGivesBonus");
			fireflyCloudPlayerDetectionRadius = s.Serialize<float>(fireflyCloudPlayerDetectionRadius, name: "fireflyCloudPlayerDetectionRadius");
			fireflyCloudPhantomShape = s.SerializeObject<Generic<PhysShape>>(fireflyCloudPhantomShape, name: "fireflyCloudPhantomShape");
			fireflyCloudStandFX = s.SerializeObject<StringID>(fireflyCloudStandFX, name: "fireflyCloudStandFX");
			fireflyCloudActivationFX = s.SerializeObject<StringID>(fireflyCloudActivationFX, name: "fireflyCloudActivationFX");
			fireflyCloudCollisionGroup = s.Serialize<ECOLLISIONGROUP>(fireflyCloudCollisionGroup, name: "fireflyCloudCollisionGroup");
		}
		[Flags]
		public enum ECOLLISIONGROUP {
			[Serialize("ECOLLISIONGROUP_NONE"     )] NONE = 1,
			[Serialize("ECOLLISIONGROUP_POLYLINE" )] POLYLINE = 2,
			[Serialize("ECOLLISIONGROUP_CHARACTER")] CHARACTER = 4,
			[Serialize("ECOLLISIONGROUP_ITEMS"    )] ITEMS = 8,
		}
		public override uint? ClassCRC => 0x30492D29;
	}
}

