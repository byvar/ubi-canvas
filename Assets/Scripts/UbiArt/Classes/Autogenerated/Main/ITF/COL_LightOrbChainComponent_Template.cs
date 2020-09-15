using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbChainComponent_Template : CSerializable {
		[Serialize("chainCompletedNumRewardLum"       )] public uint chainCompletedNumRewardLum;
		[Serialize("detectionRadius"                  )] public float detectionRadius;
		[Serialize("detectionRadiusDRC"               )] public float detectionRadiusDRC;
		[Serialize("DRCOffset"                        )] public float DRCOffset;
		[Serialize("eyeDetectionRadius"               )] public float eyeDetectionRadius;
		[Serialize("linkBlend"                        )] public float linkBlend;
		[Serialize("playGenericPickupEffects"         )] public int playGenericPickupEffects;
		[Serialize("tinyStand"                        )] public StringID tinyStand;
		[Serialize("tinyStand2"                       )] public StringID tinyStand2;
		[Serialize("tinyStand3"                       )] public StringID tinyStand3;
		[Serialize("tinyToBig"                        )] public StringID tinyToBig;
		[Serialize("yellowStand"                      )] public StringID yellowStand;
		[Serialize("yellowToRed"                      )] public StringID yellowToRed;
		[Serialize("redStand"                         )] public StringID redStand;
		[Serialize("redToYellow"                      )] public StringID redToYellow;
		[Serialize("disappear"                        )] public StringID disappear;
		[Serialize("disappearRed"                     )] public StringID disappearRed;
		[Serialize("tinyRedStand"                     )] public StringID tinyRedStand;
		[Serialize("tinyRedToBig"                     )] public StringID tinyRedToBig;
		[Serialize("grabAttractiveForceValue"         )] public float grabAttractiveForceValue;
		[Serialize("grabAttractiveForceRange"         )] public float grabAttractiveForceRange;
		[Serialize("grabMaxRepulsiveForce"            )] public float grabMaxRepulsiveForce;
		[Serialize("grabRepulsionRadius"              )] public float grabRepulsionRadius;
		[Serialize("grabDampingFactor"                )] public float grabDampingFactor;
		[Serialize("arrivalDuration"                  )] public float arrivalDuration;
		[Serialize("timeBeforeTaken"                  )] public float timeBeforeTaken;
		[Serialize("followingOffset"                  )] public Vec2d followingOffset;
		[Serialize("spawningEffectPath"               )] public Path spawningEffectPath;
		[Serialize("timeBeforeStartDisappear"         )] public float timeBeforeStartDisappear;
		[Serialize("interactiveActorPath"             )] public Path interactiveActorPath;
		[Serialize("musicPerfectActivationDistance"   )] public float musicPerfectActivationDistance;
		[Serialize("musicFailedActivationDistance"    )] public float musicFailedActivationDistance;
		[Serialize("waitingTimeBeforePlayerActivation")] public float waitingTimeBeforePlayerActivation;
		[Serialize("interactiveActorOffsets"          )] public Placeholder interactiveActorOffsets;
		[Serialize("interactiveActorBgList"           )] public Placeholder interactiveActorBgList;
		[Serialize("bgZOffsets"                       )] public Placeholder bgZOffsets;
		[Serialize("displayEyeOnlyOnDRC"              )] public int displayEyeOnlyOnDRC;
		[Serialize("hitSemiClosedEyeGivesBonus"       )] public int hitSemiClosedEyeGivesBonus;
		[Serialize("fireflyCloudPlayerDetectionRadius")] public float fireflyCloudPlayerDetectionRadius;
		[Serialize("fireflyCloudPhantomShape"         )] public Placeholder fireflyCloudPhantomShape;
		[Serialize("fireflyCloudStandFX"              )] public StringID fireflyCloudStandFX;
		[Serialize("fireflyCloudActivationFX"         )] public StringID fireflyCloudActivationFX;
		[Serialize("fireflyCloudCollisionGroup"       )] public Enum_fireflyCloudCollisionGroup fireflyCloudCollisionGroup;
		[Serialize("orbSpawnPath"                     )] public Path orbSpawnPath;
		[Serialize("timeBeforeRefill"                 )] public float timeBeforeRefill;
		[Serialize("fluidFactor"                      )] public float fluidFactor;
		[Serialize("fluidRadius"                      )] public float fluidRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(chainCompletedNumRewardLum));
			SerializeField(s, nameof(detectionRadius));
			SerializeField(s, nameof(detectionRadiusDRC));
			SerializeField(s, nameof(DRCOffset));
			SerializeField(s, nameof(eyeDetectionRadius));
			SerializeField(s, nameof(linkBlend));
			SerializeField(s, nameof(playGenericPickupEffects));
			SerializeField(s, nameof(tinyStand));
			SerializeField(s, nameof(tinyStand2));
			SerializeField(s, nameof(tinyStand3));
			SerializeField(s, nameof(tinyToBig));
			SerializeField(s, nameof(yellowStand));
			SerializeField(s, nameof(yellowToRed));
			SerializeField(s, nameof(redStand));
			SerializeField(s, nameof(redToYellow));
			SerializeField(s, nameof(disappear));
			SerializeField(s, nameof(disappearRed));
			SerializeField(s, nameof(tinyRedStand));
			SerializeField(s, nameof(tinyRedToBig));
			SerializeField(s, nameof(grabAttractiveForceValue));
			SerializeField(s, nameof(grabAttractiveForceRange));
			SerializeField(s, nameof(grabMaxRepulsiveForce));
			SerializeField(s, nameof(grabRepulsionRadius));
			SerializeField(s, nameof(grabDampingFactor));
			SerializeField(s, nameof(arrivalDuration));
			SerializeField(s, nameof(timeBeforeTaken));
			SerializeField(s, nameof(followingOffset));
			SerializeField(s, nameof(spawningEffectPath));
			SerializeField(s, nameof(timeBeforeStartDisappear));
			SerializeField(s, nameof(interactiveActorPath));
			SerializeField(s, nameof(musicPerfectActivationDistance));
			SerializeField(s, nameof(musicFailedActivationDistance));
			SerializeField(s, nameof(waitingTimeBeforePlayerActivation));
			SerializeField(s, nameof(interactiveActorOffsets));
			SerializeField(s, nameof(interactiveActorBgList));
			SerializeField(s, nameof(bgZOffsets));
			SerializeField(s, nameof(displayEyeOnlyOnDRC));
			SerializeField(s, nameof(hitSemiClosedEyeGivesBonus));
			SerializeField(s, nameof(fireflyCloudPlayerDetectionRadius));
			SerializeField(s, nameof(fireflyCloudPhantomShape));
			SerializeField(s, nameof(fireflyCloudStandFX));
			SerializeField(s, nameof(fireflyCloudActivationFX));
			SerializeField(s, nameof(fireflyCloudCollisionGroup));
			SerializeField(s, nameof(orbSpawnPath));
			SerializeField(s, nameof(timeBeforeRefill));
			SerializeField(s, nameof(fluidFactor));
			SerializeField(s, nameof(fluidRadius));
		}
		public enum Enum_fireflyCloudCollisionGroup {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public override uint? ClassCRC => 0x3CB6C33C;
	}
}

