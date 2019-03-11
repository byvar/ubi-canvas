using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossLuchadoreComponent_Template : ActorComponent_Template {
		[Serialize("phases"                        )] public CList<RO2_BossLuchadoreComponent_Template.SequencePhase> phases;
		[Serialize("opportunityInputLockedDuration")] public float opportunityInputLockedDuration;
		[Serialize("recoverTargetBlendSpeed"       )] public float recoverTargetBlendSpeed;
		[Serialize("minAdditiveAnimAngle"          )] public Angle minAdditiveAnimAngle;
		[Serialize("maxAdditiveAnimAngle"          )] public Angle maxAdditiveAnimAngle;
		[Serialize("animAppear"                    )] public StringID animAppear;
		[Serialize("animAppearStand"               )] public StringID animAppearStand;
		[Serialize("animOutro"                     )] public StringID animOutro;
		[Serialize("headBoneName"                  )] public StringID headBoneName;
		[Serialize("leftHandBoneName"              )] public StringID leftHandBoneName;
		[Serialize("rightHandBoneName"             )] public StringID rightHandBoneName;
		[Serialize("headActorName"                 )] public StringID headActorName;
		[Serialize("leftHandActorName"             )] public StringID leftHandActorName;
		[Serialize("rightHandActorName"            )] public StringID rightHandActorName;
		[Serialize("lifePointsCount"               )] public uint lifePointsCount;
		[Serialize("minHandHitZ"                   )] public float minHandHitZ;
		[Serialize("shadowAlphaMinZ"               )] public float shadowAlphaMinZ;
		[Serialize("shadowAlphaMaxZ"               )] public float shadowAlphaMaxZ;
		[Serialize("hasTargetDistanceTolerence"    )] public float hasTargetDistanceTolerence;
		[Serialize("disableInputOnHit"             )] public bool disableInputOnHit;
		[Serialize("minAimingHandOffset"           )] public float minAimingHandOffset;
		[Serialize("maxAimingHandOffset"           )] public float maxAimingHandOffset;
		[Serialize("minAimingPosX"                 )] public float minAimingPosX;
		[Serialize("maxAimingPosX"                 )] public float maxAimingPosX;
		[Serialize("shakeDuration"                 )] public float shakeDuration;
		[Serialize("shakePeriod"                   )] public float shakePeriod;
		[Serialize("shakeSpeed"                    )] public float shakeSpeed;
		[Serialize("shakeAmplitude"                )] public float shakeAmplitude;
		[Serialize("tweenEvent"                    )] public Generic<Event> tweenEvent;
		[Serialize("leftEyeBoneName"               )] public StringID leftEyeBoneName;
		[Serialize("rightEyeBoneName"              )] public StringID rightEyeBoneName;
		[Serialize("leftBumperName"                )] public StringID leftBumperName;
		[Serialize("rightBumperName"               )] public StringID rightBumperName;
		[Serialize("lookAtBlendFactor"             )] public float lookAtBlendFactor;
		[Serialize("lookAtCapAngle"                )] public float lookAtCapAngle;
		[Serialize("stunStarsActorPath"            )] public Path stunStarsActorPath;
		[Serialize("stunStarsOffset"               )] public Vector3 stunStarsOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(phases));
				SerializeField(s, nameof(opportunityInputLockedDuration));
				SerializeField(s, nameof(recoverTargetBlendSpeed));
				SerializeField(s, nameof(minAdditiveAnimAngle));
				SerializeField(s, nameof(maxAdditiveAnimAngle));
				SerializeField(s, nameof(animAppear));
				SerializeField(s, nameof(animAppearStand));
				SerializeField(s, nameof(animOutro));
				SerializeField(s, nameof(headBoneName));
				SerializeField(s, nameof(leftHandBoneName));
				SerializeField(s, nameof(rightHandBoneName));
				SerializeField(s, nameof(headActorName));
				SerializeField(s, nameof(leftHandActorName));
				SerializeField(s, nameof(rightHandActorName));
				SerializeField(s, nameof(leftEyeBoneName));
				SerializeField(s, nameof(rightEyeBoneName));
				SerializeField(s, nameof(leftBumperName));
				SerializeField(s, nameof(rightBumperName));
				SerializeField(s, nameof(lifePointsCount));
				SerializeField(s, nameof(minHandHitZ));
				SerializeField(s, nameof(shadowAlphaMinZ));
				SerializeField(s, nameof(shadowAlphaMaxZ));
				SerializeField(s, nameof(hasTargetDistanceTolerence));
				SerializeField(s, nameof(disableInputOnHit));
				SerializeField(s, nameof(minAimingHandOffset));
				SerializeField(s, nameof(maxAimingHandOffset));
				SerializeField(s, nameof(minAimingPosX));
				SerializeField(s, nameof(maxAimingPosX));
				SerializeField(s, nameof(shakeDuration));
				SerializeField(s, nameof(shakePeriod));
				SerializeField(s, nameof(shakeSpeed));
				SerializeField(s, nameof(shakeAmplitude));
				SerializeField(s, nameof(lookAtBlendFactor));
				SerializeField(s, nameof(lookAtCapAngle));
				SerializeField(s, nameof(stunStarsActorPath));
				SerializeField(s, nameof(stunStarsOffset));
				SerializeField(s, nameof(tweenEvent));
			} else {
				SerializeField(s, nameof(phases));
				SerializeField(s, nameof(opportunityInputLockedDuration));
				SerializeField(s, nameof(recoverTargetBlendSpeed));
				SerializeField(s, nameof(minAdditiveAnimAngle));
				SerializeField(s, nameof(maxAdditiveAnimAngle));
				SerializeField(s, nameof(animAppear));
				SerializeField(s, nameof(animAppearStand));
				SerializeField(s, nameof(animOutro));
				SerializeField(s, nameof(headBoneName));
				SerializeField(s, nameof(leftHandBoneName));
				SerializeField(s, nameof(rightHandBoneName));
				SerializeField(s, nameof(headActorName));
				SerializeField(s, nameof(leftHandActorName));
				SerializeField(s, nameof(rightHandActorName));
				SerializeField(s, nameof(lifePointsCount));
				SerializeField(s, nameof(minHandHitZ));
				SerializeField(s, nameof(shadowAlphaMinZ));
				SerializeField(s, nameof(shadowAlphaMaxZ));
				SerializeField(s, nameof(hasTargetDistanceTolerence));
				SerializeField(s, nameof(disableInputOnHit));
				SerializeField(s, nameof(minAimingHandOffset));
				SerializeField(s, nameof(maxAimingHandOffset));
				SerializeField(s, nameof(minAimingPosX));
				SerializeField(s, nameof(maxAimingPosX));
				SerializeField(s, nameof(shakeDuration));
				SerializeField(s, nameof(shakePeriod));
				SerializeField(s, nameof(shakeSpeed));
				SerializeField(s, nameof(shakeAmplitude));
				SerializeField(s, nameof(tweenEvent));
			}
		}
		public partial class ForbiddenZone : CSerializable {
			[Serialize("posX")] public float posX;
			[Serialize("size")] public float size;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(posX));
				SerializeField(s, nameof(size));
			}
		}
		public partial class SequenceInstruction : CSerializable {
			[Serialize("tag"                         )] public StringID tag;
			[Serialize("duration"                    )] public float duration;
			[Serialize("durationMin"                 )] public float durationMin;
			[Serialize("anim"                        )] public StringID anim;
			[Serialize("playRate"                    )] public float playRate;
			[Serialize("targetBlendSpeed"            )] public float targetBlendSpeed;
			[Serialize("sensitiveTriggerName"        )] public StringID sensitiveTriggerName;
			[Serialize("activateTweenName"           )] public StringID activateTweenName;
			[Serialize("activateTweenOnHole"         )] public bool activateTweenOnHole;
			[Serialize("secondaryActivateTweenName"  )] public StringID secondaryActivateTweenName;
			[Serialize("secondaryActivateTweenOnHole")] public bool secondaryActivateTweenOnHole;
			[Serialize("flags"                       )] public LF flags;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(durationMin));
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(playRate));
				SerializeField(s, nameof(targetBlendSpeed));
				SerializeField(s, nameof(sensitiveTriggerName));
				SerializeField(s, nameof(activateTweenName));
				SerializeField(s, nameof(activateTweenOnHole));
				SerializeField(s, nameof(secondaryActivateTweenName));
				SerializeField(s, nameof(secondaryActivateTweenOnHole));
				SerializeField(s, nameof(flags));
			}
			public enum LF {
				[Serialize("LF_None"                     )] None = 0,
				[Serialize("LF_WaitOutForbiddenZoneToEnd")] WaitOutForbiddenZoneToEnd = 1,
				[Serialize("LF_Aiming"                   )] Aiming = 2,
			}
		}
		public partial class SequencePhase : CSerializable {
			[Serialize("tag"           )] public StringID tag;
			[Serialize("animStand"     )] public StringID animStand;
			[Serialize("animOnHead"    )] public StringID animOnHead;
			[Serialize("animHit"       )] public StringID animHit;
			[Serialize("instructions"  )] public CList<RO2_BossLuchadoreComponent_Template.SequenceInstruction> instructions;
			[Serialize("forbiddenZones")] public CList<RO2_BossLuchadoreComponent_Template.ForbiddenZone> forbiddenZones;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(animStand));
				SerializeField(s, nameof(animOnHead));
				SerializeField(s, nameof(animHit));
				SerializeField(s, nameof(instructions));
				SerializeField(s, nameof(forbiddenZones));
			}
		}
		public override uint? ClassCRC => 0x4CC59F4C;
	}
}

