using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossLuchadoreComponent_Template : ActorComponent_Template {
		public CListO<RO2_BossLuchadoreComponent_Template.SequencePhase> phases;
		public float opportunityInputLockedDuration;
		public float recoverTargetBlendSpeed;
		public Angle minAdditiveAnimAngle;
		public Angle maxAdditiveAnimAngle;
		public StringID animAppear;
		public StringID animAppearStand;
		public StringID animOutro;
		public StringID headBoneName;
		public StringID leftHandBoneName;
		public StringID rightHandBoneName;
		public StringID headActorName;
		public StringID leftHandActorName;
		public StringID rightHandActorName;
		public uint lifePointsCount;
		public float minHandHitZ;
		public float shadowAlphaMinZ;
		public float shadowAlphaMaxZ;
		public float hasTargetDistanceTolerence;
		public bool disableInputOnHit;
		public float minAimingHandOffset;
		public float maxAimingHandOffset;
		public float minAimingPosX;
		public float maxAimingPosX;
		public float shakeDuration;
		public float shakePeriod;
		public float shakeSpeed;
		public float shakeAmplitude;
		public Generic<Event> tweenEvent;
		public StringID leftEyeBoneName;
		public StringID rightEyeBoneName;
		public StringID leftBumperName;
		public StringID rightBumperName;
		public float lookAtBlendFactor;
		public float lookAtCapAngle;
		public Path stunStarsActorPath;
		public Vec3d stunStarsOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				phases = s.SerializeObject<CListO<RO2_BossLuchadoreComponent_Template.SequencePhase>>(phases, name: "phases");
				opportunityInputLockedDuration = s.Serialize<float>(opportunityInputLockedDuration, name: "opportunityInputLockedDuration");
				recoverTargetBlendSpeed = s.Serialize<float>(recoverTargetBlendSpeed, name: "recoverTargetBlendSpeed");
				minAdditiveAnimAngle = s.SerializeObject<Angle>(minAdditiveAnimAngle, name: "minAdditiveAnimAngle");
				maxAdditiveAnimAngle = s.SerializeObject<Angle>(maxAdditiveAnimAngle, name: "maxAdditiveAnimAngle");
				animAppear = s.SerializeObject<StringID>(animAppear, name: "animAppear");
				animAppearStand = s.SerializeObject<StringID>(animAppearStand, name: "animAppearStand");
				animOutro = s.SerializeObject<StringID>(animOutro, name: "animOutro");
				headBoneName = s.SerializeObject<StringID>(headBoneName, name: "headBoneName");
				leftHandBoneName = s.SerializeObject<StringID>(leftHandBoneName, name: "leftHandBoneName");
				rightHandBoneName = s.SerializeObject<StringID>(rightHandBoneName, name: "rightHandBoneName");
				headActorName = s.SerializeObject<StringID>(headActorName, name: "headActorName");
				leftHandActorName = s.SerializeObject<StringID>(leftHandActorName, name: "leftHandActorName");
				rightHandActorName = s.SerializeObject<StringID>(rightHandActorName, name: "rightHandActorName");
				leftEyeBoneName = s.SerializeObject<StringID>(leftEyeBoneName, name: "leftEyeBoneName");
				rightEyeBoneName = s.SerializeObject<StringID>(rightEyeBoneName, name: "rightEyeBoneName");
				leftBumperName = s.SerializeObject<StringID>(leftBumperName, name: "leftBumperName");
				rightBumperName = s.SerializeObject<StringID>(rightBumperName, name: "rightBumperName");
				lifePointsCount = s.Serialize<uint>(lifePointsCount, name: "lifePointsCount");
				minHandHitZ = s.Serialize<float>(minHandHitZ, name: "minHandHitZ");
				shadowAlphaMinZ = s.Serialize<float>(shadowAlphaMinZ, name: "shadowAlphaMinZ");
				shadowAlphaMaxZ = s.Serialize<float>(shadowAlphaMaxZ, name: "shadowAlphaMaxZ");
				hasTargetDistanceTolerence = s.Serialize<float>(hasTargetDistanceTolerence, name: "hasTargetDistanceTolerence");
				disableInputOnHit = s.Serialize<bool>(disableInputOnHit, name: "disableInputOnHit");
				minAimingHandOffset = s.Serialize<float>(minAimingHandOffset, name: "minAimingHandOffset");
				maxAimingHandOffset = s.Serialize<float>(maxAimingHandOffset, name: "maxAimingHandOffset");
				minAimingPosX = s.Serialize<float>(minAimingPosX, name: "minAimingPosX");
				maxAimingPosX = s.Serialize<float>(maxAimingPosX, name: "maxAimingPosX");
				shakeDuration = s.Serialize<float>(shakeDuration, name: "shakeDuration");
				shakePeriod = s.Serialize<float>(shakePeriod, name: "shakePeriod");
				shakeSpeed = s.Serialize<float>(shakeSpeed, name: "shakeSpeed");
				shakeAmplitude = s.Serialize<float>(shakeAmplitude, name: "shakeAmplitude");
				lookAtBlendFactor = s.Serialize<float>(lookAtBlendFactor, name: "lookAtBlendFactor");
				lookAtCapAngle = s.Serialize<float>(lookAtCapAngle, name: "lookAtCapAngle");
				stunStarsActorPath = s.SerializeObject<Path>(stunStarsActorPath, name: "stunStarsActorPath");
				stunStarsOffset = s.SerializeObject<Vec3d>(stunStarsOffset, name: "stunStarsOffset");
				tweenEvent = s.SerializeObject<Generic<Event>>(tweenEvent, name: "tweenEvent");
			} else {
				phases = s.SerializeObject<CListO<RO2_BossLuchadoreComponent_Template.SequencePhase>>(phases, name: "phases");
				opportunityInputLockedDuration = s.Serialize<float>(opportunityInputLockedDuration, name: "opportunityInputLockedDuration");
				recoverTargetBlendSpeed = s.Serialize<float>(recoverTargetBlendSpeed, name: "recoverTargetBlendSpeed");
				minAdditiveAnimAngle = s.SerializeObject<Angle>(minAdditiveAnimAngle, name: "minAdditiveAnimAngle");
				maxAdditiveAnimAngle = s.SerializeObject<Angle>(maxAdditiveAnimAngle, name: "maxAdditiveAnimAngle");
				animAppear = s.SerializeObject<StringID>(animAppear, name: "animAppear");
				animAppearStand = s.SerializeObject<StringID>(animAppearStand, name: "animAppearStand");
				animOutro = s.SerializeObject<StringID>(animOutro, name: "animOutro");
				headBoneName = s.SerializeObject<StringID>(headBoneName, name: "headBoneName");
				leftHandBoneName = s.SerializeObject<StringID>(leftHandBoneName, name: "leftHandBoneName");
				rightHandBoneName = s.SerializeObject<StringID>(rightHandBoneName, name: "rightHandBoneName");
				headActorName = s.SerializeObject<StringID>(headActorName, name: "headActorName");
				leftHandActorName = s.SerializeObject<StringID>(leftHandActorName, name: "leftHandActorName");
				rightHandActorName = s.SerializeObject<StringID>(rightHandActorName, name: "rightHandActorName");
				lifePointsCount = s.Serialize<uint>(lifePointsCount, name: "lifePointsCount");
				minHandHitZ = s.Serialize<float>(minHandHitZ, name: "minHandHitZ");
				shadowAlphaMinZ = s.Serialize<float>(shadowAlphaMinZ, name: "shadowAlphaMinZ");
				shadowAlphaMaxZ = s.Serialize<float>(shadowAlphaMaxZ, name: "shadowAlphaMaxZ");
				hasTargetDistanceTolerence = s.Serialize<float>(hasTargetDistanceTolerence, name: "hasTargetDistanceTolerence");
				disableInputOnHit = s.Serialize<bool>(disableInputOnHit, name: "disableInputOnHit");
				minAimingHandOffset = s.Serialize<float>(minAimingHandOffset, name: "minAimingHandOffset");
				maxAimingHandOffset = s.Serialize<float>(maxAimingHandOffset, name: "maxAimingHandOffset");
				minAimingPosX = s.Serialize<float>(minAimingPosX, name: "minAimingPosX");
				maxAimingPosX = s.Serialize<float>(maxAimingPosX, name: "maxAimingPosX");
				shakeDuration = s.Serialize<float>(shakeDuration, name: "shakeDuration");
				shakePeriod = s.Serialize<float>(shakePeriod, name: "shakePeriod");
				shakeSpeed = s.Serialize<float>(shakeSpeed, name: "shakeSpeed");
				shakeAmplitude = s.Serialize<float>(shakeAmplitude, name: "shakeAmplitude");
				tweenEvent = s.SerializeObject<Generic<Event>>(tweenEvent, name: "tweenEvent");
			}
		}
		[Games(GameFlags.RA)]
		public partial class ForbiddenZone : CSerializable {
			public float posX;
			public float size;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				posX = s.Serialize<float>(posX, name: "posX");
				size = s.Serialize<float>(size, name: "size");
			}
		}
		[Games(GameFlags.RA)]
		public partial class SequenceInstruction : CSerializable {
			public StringID tag;
			public float duration;
			public float durationMin;
			public StringID anim;
			public float playRate;
			public float targetBlendSpeed;
			public StringID sensitiveTriggerName;
			public StringID activateTweenName;
			public bool activateTweenOnHole;
			public StringID secondaryActivateTweenName;
			public bool secondaryActivateTweenOnHole;
			public Vec2d handHitShapeOffset;
			public float handHitShapeScale;
			public LF flags;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				duration = s.Serialize<float>(duration, name: "duration");
				durationMin = s.Serialize<float>(durationMin, name: "durationMin");
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				playRate = s.Serialize<float>(playRate, name: "playRate");
				targetBlendSpeed = s.Serialize<float>(targetBlendSpeed, name: "targetBlendSpeed");
				sensitiveTriggerName = s.SerializeObject<StringID>(sensitiveTriggerName, name: "sensitiveTriggerName");
				activateTweenName = s.SerializeObject<StringID>(activateTweenName, name: "activateTweenName");
				activateTweenOnHole = s.Serialize<bool>(activateTweenOnHole, name: "activateTweenOnHole");
				secondaryActivateTweenName = s.SerializeObject<StringID>(secondaryActivateTweenName, name: "secondaryActivateTweenName");
				secondaryActivateTweenOnHole = s.Serialize<bool>(secondaryActivateTweenOnHole, name: "secondaryActivateTweenOnHole");
				if (Settings.s.game == Settings.Game.RL) {
					handHitShapeOffset = s.SerializeObject<Vec2d>(handHitShapeOffset, name: "handHitShapeOffset");
					handHitShapeScale = s.Serialize<float>(handHitShapeScale, name: "handHitShapeScale");
				}
				flags = s.Serialize<LF>(flags, name: "flags");
			}
			public enum LF {
				[Serialize("LF_None"                     )] None = 0,
				[Serialize("LF_WaitOutForbiddenZoneToEnd")] WaitOutForbiddenZoneToEnd = 1,
				[Serialize("LF_Aiming"                   )] Aiming = 2,
			}
		}
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class SequencePhase : CSerializable {
			public StringID tag;
			public StringID animStand;
			public StringID animOnHead;
			public StringID animHit;
			public CListO<RO2_BossLuchadoreComponent_Template.SequenceInstruction> instructions;
			public CListO<RO2_BossLuchadoreComponent_Template.ForbiddenZone> forbiddenZones;
			public uint changedHitMaterialTarget;
			public uint changedHitMaterialSource;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				animStand = s.SerializeObject<StringID>(animStand, name: "animStand");
				animOnHead = s.SerializeObject<StringID>(animOnHead, name: "animOnHead");
				animHit = s.SerializeObject<StringID>(animHit, name: "animHit");
				instructions = s.SerializeObject<CListO<RO2_BossLuchadoreComponent_Template.SequenceInstruction>>(instructions, name: "instructions");
				forbiddenZones = s.SerializeObject<CListO<RO2_BossLuchadoreComponent_Template.ForbiddenZone>>(forbiddenZones, name: "forbiddenZones");
				if (Settings.s.game == Settings.Game.RL) {
					changedHitMaterialTarget = s.Serialize<uint>(changedHitMaterialTarget, name: "changedHitMaterialTarget");
					changedHitMaterialSource = s.Serialize<uint>(changedHitMaterialSource, name: "changedHitMaterialSource");
				}
			}
		}
		public override uint? ClassCRC => 0x4CC59F4C;
	}
}

