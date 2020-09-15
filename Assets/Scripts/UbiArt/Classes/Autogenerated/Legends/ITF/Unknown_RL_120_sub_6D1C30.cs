using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_120_sub_6D1C30 : ActorComponent_Template {
		[Serialize("DrawDebugHit"                 )] public int DrawDebugHit;
		[Serialize("BodyPath"                     )] public Path BodyPath;
		[Serialize("TailPath"                     )] public Path TailPath;
		[Serialize("modulesAnimOffset"            )] public float modulesAnimOffset;
		[Serialize("vulnerabilityDuration"        )] public float vulnerabilityDuration;
		[Serialize("hitCooldownDuration"          )] public float hitCooldownDuration;
		[Serialize("maxBashingHitcount"           )] public uint maxBashingHitcount;
		[Serialize("attackHitDuration"            )] public float attackHitDuration;
		[Serialize("projectilesEnabled"           )] public int projectilesEnabled;
		[Serialize("projectilesPath"              )] public Path projectilesPath;
		[Serialize("projectilesTrajectoryCount"   )] public uint projectilesTrajectoryCount;
		[Serialize("projectilesTrajectoryAngleMax")] public Angle projectilesTrajectoryAngleMax;
		[Serialize("projectileWaveCount"          )] public uint projectileWaveCount;
		[Serialize("projectileWaveTime"           )] public float projectileWaveTime;
		[Serialize("projetileLaunchOffset"        )] public Vec3d projetileLaunchOffset;
		[Serialize("attackWaitDuration"           )] public float attackWaitDuration;
		[Serialize("laserShootDuration"           )] public float laserShootDuration;
		[Serialize("laserMax"                     )] public uint laserMax;
		[Serialize("cameraSpeedFactorMin"         )] public float cameraSpeedFactorMin;
		[Serialize("cameraSpeedFactorMax"         )] public float cameraSpeedFactorMax;
		[Serialize("cameraSpeedBlendFactor"       )] public float cameraSpeedBlendFactor;
		[Serialize("SlowDownDist"                 )] public float SlowDownDist;
		[Serialize("headRotationBlend"            )] public float headRotationBlend;
		[Serialize("faction"                      )] public uint faction;
		[Serialize("receivedHitType"              )] public Enum_receivedHitType receivedHitType;
		[Serialize("laserMaxlength"               )] public float laserMaxlength;
		[Serialize("laserHarmlessPath"            )] public Path laserHarmlessPath;
		[Serialize("laserHarmfullPart01Path"      )] public Path laserHarmfullPart01Path;
		[Serialize("laserHarmfullPart02Path"      )] public Path laserHarmfullPart02Path;
		[Serialize("laserHarmfullPart03Path"      )] public Path laserHarmfullPart03Path;
		[Serialize("laserHarmfullPart04Path"      )] public Path laserHarmfullPart04Path;
		[Serialize("laserHarmfullScaleX"          )] public float laserHarmfullScaleX;
		[Serialize("laserHarmlessScaleX"          )] public float laserHarmlessScaleX;
		[Serialize("laserLaunchOffset"            )] public Vec3d laserLaunchOffset;
		[Serialize("laserShapeThickness"          )] public float laserShapeThickness;
		[Serialize("immuneHitDuration"            )] public float immuneHitDuration;
		[Serialize("hurtMaxPerPhase"              )] public uint hurtMaxPerPhase;
		[Serialize("moduleGap"                    )] public float moduleGap;
		[Serialize("headGap"                      )] public float headGap;
		[Serialize("diamondShape"                 )] public Generic<PhysShape> diamondShape;
		[Serialize("jawUpShape"                   )] public Generic<PhysShape> jawUpShape;
		[Serialize("jawLowShape"                  )] public Generic<PhysShape> jawLowShape;
		[Serialize("laserShape"                   )] public Generic<PhysShape> laserShape;
		[Serialize("minTimeToSetPlayRate"         )] public float minTimeToSetPlayRate;
		[Serialize("wakeUpModuleDelay"            )] public float wakeUpModuleDelay;
		[Serialize("hurtModuleDelay"              )] public float hurtModuleDelay;
		[Serialize("explodePart01Path"            )] public Path explodePart01Path;
		[Serialize("explodePart02Path"            )] public Path explodePart02Path;
		[Serialize("explodePart03Path"            )] public Path explodePart03Path;
		[Serialize("explodePartLifeTime"          )] public float explodePartLifeTime;
		[Serialize("explodePartPhaseModuleCount"  )] public uint explodePartPhaseModuleCount;
		[Serialize("biteMinTime"                  )] public float biteMinTime;
		[Serialize("biteMaxTime"                  )] public float biteMaxTime;
		[Serialize("timeToReachMaxAcceleration"   )] public float timeToReachMaxAcceleration;
		[Serialize("minDistToMove"                )] public float minDistToMove;
		[Serialize("minDistToStop"                )] public float minDistToStop;
		[Serialize("minDistToOrient"              )] public float minDistToOrient;
		[Serialize("orientBlend"                  )] public float orientBlend;
		[Serialize("fxOffsetLaserStart"           )] public Vec3d fxOffsetLaserStart;
		[Serialize("fxOffsetLaserImpact"          )] public Vec3d fxOffsetLaserImpact;
		[Serialize("fxOffsetGrowlSmokePhase01"    )] public Vec3d fxOffsetGrowlSmokePhase01;
		[Serialize("fxOffsetGrowlSmokePhase02"    )] public Vec3d fxOffsetGrowlSmokePhase02;
		[Serialize("fxOffsetGrowlSmokePhase03"    )] public Vec3d fxOffsetGrowlSmokePhase03;
		[Serialize("fxOffsetEyeR"                 )] public Vec3d fxOffsetEyeR;
		[Serialize("fxOffsetEyeL"                 )] public Vec3d fxOffsetEyeL;
		[Serialize("fxOffsetDiamond"              )] public Vec3d fxOffsetDiamond;
		[Serialize("fxOffsetScanLPhase01"         )] public Vec3d fxOffsetScanLPhase01;
		[Serialize("fxOffsetScanLPhase02"         )] public Vec3d fxOffsetScanLPhase02;
		[Serialize("fxOffsetScanLPhase03"         )] public Vec3d fxOffsetScanLPhase03;
		[Serialize("fxOffsetScanRPhase01"         )] public Vec3d fxOffsetScanRPhase01;
		[Serialize("fxOffsetScanRPhase02"         )] public Vec3d fxOffsetScanRPhase02;
		[Serialize("fxOffsetScanRPhase03"         )] public Vec3d fxOffsetScanRPhase03;
		[Serialize("fxOffsetScanLFlippedPhase01"  )] public Vec3d fxOffsetScanLFlippedPhase01;
		[Serialize("fxOffsetScanLFlippedPhase02"  )] public Vec3d fxOffsetScanLFlippedPhase02;
		[Serialize("fxOffsetScanLFlippedPhase03"  )] public Vec3d fxOffsetScanLFlippedPhase03;
		[Serialize("fxOffsetScanRFlippedPhase01"  )] public Vec3d fxOffsetScanRFlippedPhase01;
		[Serialize("fxOffsetScanRFlippedPhase02"  )] public Vec3d fxOffsetScanRFlippedPhase02;
		[Serialize("fxOffsetScanRFlippedPhase03"  )] public Vec3d fxOffsetScanRFlippedPhase03;
		[Serialize("fxOffsetScanLUpFlippedPhase03")] public Vec3d fxOffsetScanLUpFlippedPhase03;
		[Serialize("fxOffsetScanRUpFlippedPhase03")] public Vec3d fxOffsetScanRUpFlippedPhase03;
		[Serialize("fxOffsetDiamondGlow"          )] public Vec3d fxOffsetDiamondGlow;
		[Serialize("fxOffsetEyeGlowL"             )] public Vec3d fxOffsetEyeGlowL;
		[Serialize("fxOffsetEyeGlowR"             )] public Vec3d fxOffsetEyeGlowR;
		[Serialize("registerInCamEnabled"         )] public int registerInCamEnabled;
		[Serialize("registerInCamDelay"           )] public float registerInCamDelay;
		[Serialize("logoPath"                     )] public Path logoPath;
		[Serialize("deathSkelPart01Path"          )] public Path deathSkelPart01Path;
		[Serialize("deathSkelPart02Path"          )] public Path deathSkelPart02Path;
		[Serialize("deathSkelPart03Path"          )] public Path deathSkelPart03Path;
		[Serialize("deathSkelPartScale"           )] public Vec2d deathSkelPartScale;
		[Serialize("deathSkelBlendDuration"       )] public float deathSkelBlendDuration;
		[Serialize("fxDelayChargeUp"              )] public float fxDelayChargeUp;
		[Serialize("scanBrightAlphaCoef"          )] public float scanBrightAlphaCoef;
		[Serialize("scanBrightDuration"           )] public float scanBrightDuration;
		[Serialize("scanBlendDuration"            )] public float scanBlendDuration;
		[Serialize("scanLowAlphaCoef"             )] public float scanLowAlphaCoef;
		[Serialize("scanLowDuration"              )] public float scanLowDuration;
		[Serialize("scanFadeOutDuration"          )] public float scanFadeOutDuration;
		[Serialize("scanFadeInDuration"           )] public float scanFadeInDuration;
		[Serialize("snakeScaleCoefStart"          )] public float snakeScaleCoefStart;
		[Serialize("snakeScaleCoefMedium"         )] public float snakeScaleCoefMedium;
		[Serialize("snakeScaleCoefEnd"            )] public float snakeScaleCoefEnd;
		[Serialize("snakeScaleCoefMediumStart"    )] public float snakeScaleCoefMediumStart;
		[Serialize("snakeScaleCoefMediumEnd"      )] public float snakeScaleCoefMediumEnd;
		[Serialize("wakeUpDuration"               )] public float wakeUpDuration;
		[Serialize("headRotationAngleMax"         )] public Angle headRotationAngleMax;
		[Serialize("scanEyePosblend"              )] public float scanEyePosblend;
		[Serialize("laserFadeDuration"            )] public float laserFadeDuration;
		[Serialize("laserFadeAlphaMin"            )] public float laserFadeAlphaMin;
		[Serialize("moveSinusBlend"               )] public float moveSinusBlend;
		[Serialize("moveSinusAmplitude"           )] public float moveSinusAmplitude;
		[Serialize("moveSinusPeriod"              )] public float moveSinusPeriod;
		[Serialize("moveSinusOffset"              )] public float moveSinusOffset;
		[Serialize("changeColorBlendDuration"     )] public float changeColorBlendDuration;
		[Serialize("tailScaleFactor"              )] public float tailScaleFactor;
		[Serialize("scanMaxLength"                )] public float scanMaxLength;
		[Serialize("laserAlphaSinusPeriod"        )] public float laserAlphaSinusPeriod;
		[Serialize("laserAlphaSinusBlend"         )] public float laserAlphaSinusBlend;
		[Serialize("laserFadePart01Duration"      )] public float laserFadePart01Duration;
		[Serialize("laserFadePart02Duration"      )] public float laserFadePart02Duration;
		[Serialize("laserFadePart03Duration"      )] public float laserFadePart03Duration;
		[Serialize("laserFadePart04Duration"      )] public float laserFadePart04Duration;
		[Serialize("laserFadePart01StartTime"     )] public float laserFadePart01StartTime;
		[Serialize("laserFadePart02StartTime"     )] public float laserFadePart02StartTime;
		[Serialize("laserFadePart03StartTime"     )] public float laserFadePart03StartTime;
		[Serialize("laserFadePart04StartTime"     )] public float laserFadePart04StartTime;
		[Serialize("lastModuleScaleCoef"          )] public float lastModuleScaleCoef;
		[Serialize("headExplodeScale"             )] public Vec2d headExplodeScale;
		[Serialize("laserMiddleFadeAlphaMin"      )] public float laserMiddleFadeAlphaMin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DrawDebugHit));
			SerializeField(s, nameof(BodyPath));
			SerializeField(s, nameof(TailPath));
			SerializeField(s, nameof(modulesAnimOffset));
			SerializeField(s, nameof(vulnerabilityDuration));
			SerializeField(s, nameof(hitCooldownDuration));
			SerializeField(s, nameof(maxBashingHitcount));
			SerializeField(s, nameof(attackHitDuration));
			SerializeField(s, nameof(projectilesEnabled));
			SerializeField(s, nameof(projectilesPath));
			SerializeField(s, nameof(projectilesTrajectoryCount));
			SerializeField(s, nameof(projectilesTrajectoryAngleMax));
			SerializeField(s, nameof(projectileWaveCount));
			SerializeField(s, nameof(projectileWaveTime));
			SerializeField(s, nameof(projetileLaunchOffset));
			SerializeField(s, nameof(attackWaitDuration));
			SerializeField(s, nameof(laserShootDuration));
			SerializeField(s, nameof(laserMax));
			SerializeField(s, nameof(cameraSpeedFactorMin));
			SerializeField(s, nameof(cameraSpeedFactorMax));
			SerializeField(s, nameof(cameraSpeedBlendFactor));
			SerializeField(s, nameof(SlowDownDist));
			SerializeField(s, nameof(headRotationBlend));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(receivedHitType));
			SerializeField(s, nameof(laserMaxlength));
			SerializeField(s, nameof(laserHarmlessPath));
			SerializeField(s, nameof(laserHarmfullPart01Path));
			SerializeField(s, nameof(laserHarmfullPart02Path));
			SerializeField(s, nameof(laserHarmfullPart03Path));
			SerializeField(s, nameof(laserHarmfullPart04Path));
			SerializeField(s, nameof(laserHarmfullScaleX));
			SerializeField(s, nameof(laserHarmlessScaleX));
			SerializeField(s, nameof(laserLaunchOffset));
			SerializeField(s, nameof(laserShapeThickness));
			SerializeField(s, nameof(immuneHitDuration));
			SerializeField(s, nameof(hurtMaxPerPhase));
			SerializeField(s, nameof(moduleGap));
			SerializeField(s, nameof(headGap));
			SerializeField(s, nameof(diamondShape));
			SerializeField(s, nameof(jawUpShape));
			SerializeField(s, nameof(jawLowShape));
			SerializeField(s, nameof(laserShape));
			SerializeField(s, nameof(minTimeToSetPlayRate));
			SerializeField(s, nameof(wakeUpModuleDelay));
			SerializeField(s, nameof(hurtModuleDelay));
			SerializeField(s, nameof(explodePart01Path));
			SerializeField(s, nameof(explodePart02Path));
			SerializeField(s, nameof(explodePart03Path));
			SerializeField(s, nameof(explodePartLifeTime));
			SerializeField(s, nameof(explodePartPhaseModuleCount));
			SerializeField(s, nameof(biteMinTime));
			SerializeField(s, nameof(biteMaxTime));
			SerializeField(s, nameof(timeToReachMaxAcceleration));
			SerializeField(s, nameof(minDistToMove));
			SerializeField(s, nameof(minDistToStop));
			SerializeField(s, nameof(minDistToOrient));
			SerializeField(s, nameof(orientBlend));
			SerializeField(s, nameof(fxOffsetLaserStart));
			SerializeField(s, nameof(fxOffsetLaserImpact));
			SerializeField(s, nameof(fxOffsetGrowlSmokePhase01));
			SerializeField(s, nameof(fxOffsetGrowlSmokePhase02));
			SerializeField(s, nameof(fxOffsetGrowlSmokePhase03));
			SerializeField(s, nameof(fxOffsetEyeR));
			SerializeField(s, nameof(fxOffsetEyeL));
			SerializeField(s, nameof(fxOffsetDiamond));
			SerializeField(s, nameof(fxOffsetScanLPhase01));
			SerializeField(s, nameof(fxOffsetScanLPhase02));
			SerializeField(s, nameof(fxOffsetScanLPhase03));
			SerializeField(s, nameof(fxOffsetScanRPhase01));
			SerializeField(s, nameof(fxOffsetScanRPhase02));
			SerializeField(s, nameof(fxOffsetScanRPhase03));
			SerializeField(s, nameof(fxOffsetScanLFlippedPhase01));
			SerializeField(s, nameof(fxOffsetScanLFlippedPhase02));
			SerializeField(s, nameof(fxOffsetScanLFlippedPhase03));
			SerializeField(s, nameof(fxOffsetScanRFlippedPhase01));
			SerializeField(s, nameof(fxOffsetScanRFlippedPhase02));
			SerializeField(s, nameof(fxOffsetScanRFlippedPhase03));
			SerializeField(s, nameof(fxOffsetScanLUpFlippedPhase03));
			SerializeField(s, nameof(fxOffsetScanRUpFlippedPhase03));
			SerializeField(s, nameof(fxOffsetDiamondGlow));
			SerializeField(s, nameof(fxOffsetEyeGlowL));
			SerializeField(s, nameof(fxOffsetEyeGlowR));
			SerializeField(s, nameof(registerInCamEnabled));
			SerializeField(s, nameof(registerInCamDelay));
			SerializeField(s, nameof(logoPath));
			SerializeField(s, nameof(deathSkelPart01Path));
			SerializeField(s, nameof(deathSkelPart02Path));
			SerializeField(s, nameof(deathSkelPart03Path));
			SerializeField(s, nameof(deathSkelPartScale));
			SerializeField(s, nameof(deathSkelBlendDuration));
			SerializeField(s, nameof(fxDelayChargeUp));
			SerializeField(s, nameof(scanBrightAlphaCoef));
			SerializeField(s, nameof(scanBrightDuration));
			SerializeField(s, nameof(scanBlendDuration));
			SerializeField(s, nameof(scanLowAlphaCoef));
			SerializeField(s, nameof(scanLowDuration));
			SerializeField(s, nameof(scanFadeOutDuration));
			SerializeField(s, nameof(scanFadeInDuration));
			SerializeField(s, nameof(snakeScaleCoefStart));
			SerializeField(s, nameof(snakeScaleCoefMedium));
			SerializeField(s, nameof(snakeScaleCoefEnd));
			SerializeField(s, nameof(snakeScaleCoefMediumStart));
			SerializeField(s, nameof(snakeScaleCoefMediumEnd));
			SerializeField(s, nameof(wakeUpDuration));
			SerializeField(s, nameof(headRotationAngleMax));
			SerializeField(s, nameof(scanEyePosblend));
			SerializeField(s, nameof(laserFadeDuration));
			SerializeField(s, nameof(laserFadeAlphaMin));
			SerializeField(s, nameof(moveSinusBlend));
			SerializeField(s, nameof(moveSinusAmplitude));
			SerializeField(s, nameof(moveSinusPeriod));
			SerializeField(s, nameof(moveSinusOffset));
			SerializeField(s, nameof(changeColorBlendDuration));
			SerializeField(s, nameof(tailScaleFactor));
			SerializeField(s, nameof(scanMaxLength));
			SerializeField(s, nameof(laserAlphaSinusPeriod));
			SerializeField(s, nameof(laserAlphaSinusBlend));
			SerializeField(s, nameof(laserFadePart01Duration));
			SerializeField(s, nameof(laserFadePart02Duration));
			SerializeField(s, nameof(laserFadePart03Duration));
			SerializeField(s, nameof(laserFadePart04Duration));
			SerializeField(s, nameof(laserFadePart01StartTime));
			SerializeField(s, nameof(laserFadePart02StartTime));
			SerializeField(s, nameof(laserFadePart03StartTime));
			SerializeField(s, nameof(laserFadePart04StartTime));
			SerializeField(s, nameof(lastModuleScaleCoef));
			SerializeField(s, nameof(headExplodeScale));
			SerializeField(s, nameof(laserMiddleFadeAlphaMin));
		}
		public enum Enum_receivedHitType {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x78DF3D31;
	}
}

