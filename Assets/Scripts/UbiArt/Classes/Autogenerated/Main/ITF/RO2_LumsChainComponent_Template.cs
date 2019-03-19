using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LumsChainComponent_Template : ActorComponent_Template {
		[Serialize("chainCompletedNumRewardLum"       )] public uint chainCompletedNumRewardLum;
		[Serialize("detectionRadius"                  )] public float detectionRadius;
		[Serialize("detectionRadiusDRC"               )] public float detectionRadiusDRC;
		[Serialize("DRCOffset"                        )] public float DRCOffset;
		[Serialize("eyeDetectionRadius"               )] public float eyeDetectionRadius;
		[Serialize("linkBlend"                        )] public float linkBlend;
		[Serialize("playGenericPickupEffects"         )] public bool playGenericPickupEffects;
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
		[Serialize("followingOffset"                  )] public Vector2 followingOffset;
		[Serialize("spawningEffectPath"               )] public Path spawningEffectPath;
		[Serialize("timeBeforeStartDisappear"         )] public float timeBeforeStartDisappear;
		[Serialize("interactiveActorPath"             )] public Path interactiveActorPath;
		[Serialize("musicPerfectActivationDistance"   )] public float musicPerfectActivationDistance;
		[Serialize("musicFailedActivationDistance"    )] public float musicFailedActivationDistance;
		[Serialize("waitingTimeBeforePlayerActivation")] public float waitingTimeBeforePlayerActivation;
		[Serialize("interactiveActorOffsets"          )] public CArray<Vector3> interactiveActorOffsets;
		[Serialize("interactiveActorBgList"           )] public CArray<Path> interactiveActorBgList;
		[Serialize("bgZOffsets"                       )] public CList<float> bgZOffsets;
		[Serialize("displayEyeOnlyOnDRC"              )] public bool displayEyeOnlyOnDRC;
		[Serialize("hitSemiClosedEyeGivesBonus"       )] public bool hitSemiClosedEyeGivesBonus;
		[Serialize("fireflyCloudPlayerDetectionRadius")] public float fireflyCloudPlayerDetectionRadius;
		[Serialize("fireflyCloudPhantomShape"         )] public Generic<PhysShape> fireflyCloudPhantomShape;
		[Serialize("fireflyCloudStandFX"              )] public StringID fireflyCloudStandFX;
		[Serialize("fireflyCloudActivationFX"         )] public StringID fireflyCloudActivationFX;
		[Serialize("fireflyCloudCollisionGroup"       )] public ECOLLISIONGROUP fireflyCloudCollisionGroup;
		[Serialize("fireflyCloudCollisionGroup"       )] public Enum_fireflyCloudCollisionGroup fireflyCloudCollisionGroup;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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
			} else {
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
				SerializeField(s, nameof(interactiveActorOffsets));
				SerializeField(s, nameof(interactiveActorBgList));
				SerializeField(s, nameof(interactiveActorBgList));
				SerializeField(s, nameof(bgZOffsets));
				SerializeField(s, nameof(displayEyeOnlyOnDRC));
				SerializeField(s, nameof(hitSemiClosedEyeGivesBonus));
				SerializeField(s, nameof(fireflyCloudPlayerDetectionRadius));
				SerializeField(s, nameof(fireflyCloudPhantomShape));
				SerializeField(s, nameof(fireflyCloudStandFX));
				SerializeField(s, nameof(fireflyCloudActivationFX));
				SerializeField(s, nameof(fireflyCloudCollisionGroup));
			}
		}
		public enum ECOLLISIONGROUP {
			[Serialize("ECOLLISIONGROUP_NONE"     )] NONE = 1,
			[Serialize("ECOLLISIONGROUP_POLYLINE" )] POLYLINE = 2,
			[Serialize("ECOLLISIONGROUP_CHARACTER")] CHARACTER = 4,
			[Serialize("ECOLLISIONGROUP_ITEMS"    )] ITEMS = 8,
		}
		public enum Enum_fireflyCloudCollisionGroup {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public override uint? ClassCRC => 0x30492D29;
	}
}

