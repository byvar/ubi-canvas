using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PowerUpManager_Template : TemplateObj {
		public uint superPunchBasicMaxAmmo;
		public uint superPunchSeekingMaxAmmo;
		public uint swarmRepellerMaxAmmo;
		public uint petFollowerMaxAmmo;
		public CListP<float> magnetPhantomScaleMultiplier;
		public float megaMagnetPhantomScaleMultiplier;
		public float missileActiveCooldown;
		public float tickleCooldown;
		public float autoAttackCooldown;
		public float invincibilityCooldown;
		public float polymorphCooldown;
		public Path powerupFX;
		public Path foodDurationActor;
		public float invincibilityDuration;
		public float invincibilityCreatureOffset;
		public float invincibilityRitualTime;
		public float invincibilityTimeBuffer;
		public float magnetAutoActivationRange;
		public uint magnetMaxGrabbedLums;
		public CListP<float> magnetCoinMaxAttractedRange;
		public float magnetCoinInterpolatedSpeed;
		public CListP<float> magnetFireflyCloudActivationRange;
		public float magnetLumCageSlowCoef;
		public CListP<float> magnetRotationSpeed;
		public float magnetRotationTime;
		public uint radarMaxDetectedTargets;
		public uint radarTeensieSelectionRange;
		public CListP<float> radarAnimStepRange;
		public float slowMotionDuration;
		public float slowMotionBlendDuration;
		public float slowMotionFactor;
		public float slowMotionInvincibilityDelay;
		public float slowMotionMagnetDelay;
		public bool slowMotionEnabled;
		public float radarMaxRange;
		public float radarRangeHysteresis;
		public StringID invincibilityWwiseEvent_Start;
		public StringID invincibilityWwiseEvent_Stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				superPunchBasicMaxAmmo = s.Serialize<uint>(superPunchBasicMaxAmmo, name: "superPunchBasicMaxAmmo");
				superPunchSeekingMaxAmmo = s.Serialize<uint>(superPunchSeekingMaxAmmo, name: "superPunchSeekingMaxAmmo");
				swarmRepellerMaxAmmo = s.Serialize<uint>(swarmRepellerMaxAmmo, name: "swarmRepellerMaxAmmo");
				petFollowerMaxAmmo = s.Serialize<uint>(petFollowerMaxAmmo, name: "petFollowerMaxAmmo");
			} else {
				superPunchBasicMaxAmmo = s.Serialize<uint>(superPunchBasicMaxAmmo, name: "superPunchBasicMaxAmmo");
				superPunchSeekingMaxAmmo = s.Serialize<uint>(superPunchSeekingMaxAmmo, name: "superPunchSeekingMaxAmmo");
				swarmRepellerMaxAmmo = s.Serialize<uint>(swarmRepellerMaxAmmo, name: "swarmRepellerMaxAmmo");
				petFollowerMaxAmmo = s.Serialize<uint>(petFollowerMaxAmmo, name: "petFollowerMaxAmmo");
				magnetPhantomScaleMultiplier = s.SerializeObject<CListP<float>>(magnetPhantomScaleMultiplier, name: "magnetPhantomScaleMultiplier");
				megaMagnetPhantomScaleMultiplier = s.Serialize<float>(megaMagnetPhantomScaleMultiplier, name: "megaMagnetPhantomScaleMultiplier");
				missileActiveCooldown = s.Serialize<float>(missileActiveCooldown, name: "missileActiveCooldown");
				tickleCooldown = s.Serialize<float>(tickleCooldown, name: "tickleCooldown");
				autoAttackCooldown = s.Serialize<float>(autoAttackCooldown, name: "autoAttackCooldown");
				invincibilityCooldown = s.Serialize<float>(invincibilityCooldown, name: "invincibilityCooldown");
				polymorphCooldown = s.Serialize<float>(polymorphCooldown, name: "polymorphCooldown");
				powerupFX = s.SerializeObject<Path>(powerupFX, name: "powerupFX");
				foodDurationActor = s.SerializeObject<Path>(foodDurationActor, name: "foodDurationActor");
				invincibilityDuration = s.Serialize<float>(invincibilityDuration, name: "invincibilityDuration");
				invincibilityCreatureOffset = s.Serialize<float>(invincibilityCreatureOffset, name: "invincibilityCreatureOffset");
				invincibilityRitualTime = s.Serialize<float>(invincibilityRitualTime, name: "invincibilityRitualTime");
				invincibilityTimeBuffer = s.Serialize<float>(invincibilityTimeBuffer, name: "invincibilityTimeBuffer");
				magnetAutoActivationRange = s.Serialize<float>(magnetAutoActivationRange, name: "magnetAutoActivationRange");
				magnetMaxGrabbedLums = s.Serialize<uint>(magnetMaxGrabbedLums, name: "magnetMaxGrabbedLums");
				magnetCoinMaxAttractedRange = s.SerializeObject<CListP<float>>(magnetCoinMaxAttractedRange, name: "magnetCoinMaxAttractedRange");
				magnetCoinInterpolatedSpeed = s.Serialize<float>(magnetCoinInterpolatedSpeed, name: "magnetCoinInterpolatedSpeed");
				magnetFireflyCloudActivationRange = s.SerializeObject<CListP<float>>(magnetFireflyCloudActivationRange, name: "magnetFireflyCloudActivationRange");
				magnetLumCageSlowCoef = s.Serialize<float>(magnetLumCageSlowCoef, name: "magnetLumCageSlowCoef");
				magnetRotationSpeed = s.SerializeObject<CListP<float>>(magnetRotationSpeed, name: "magnetRotationSpeed");
				magnetRotationTime = s.Serialize<float>(magnetRotationTime, name: "magnetRotationTime");
				radarMaxDetectedTargets = s.Serialize<uint>(radarMaxDetectedTargets, name: "radarMaxDetectedTargets");
				radarTeensieSelectionRange = s.Serialize<uint>(radarTeensieSelectionRange, name: "radarTeensieSelectionRange");
				radarAnimStepRange = s.SerializeObject<CListP<float>>(radarAnimStepRange, name: "radarAnimStepRange");
				slowMotionDuration = s.Serialize<float>(slowMotionDuration, name: "slowMotionDuration");
				slowMotionBlendDuration = s.Serialize<float>(slowMotionBlendDuration, name: "slowMotionBlendDuration");
				slowMotionFactor = s.Serialize<float>(slowMotionFactor, name: "slowMotionFactor");
				slowMotionInvincibilityDelay = s.Serialize<float>(slowMotionInvincibilityDelay, name: "slowMotionInvincibilityDelay");
				slowMotionMagnetDelay = s.Serialize<float>(slowMotionMagnetDelay, name: "slowMotionMagnetDelay");
				slowMotionEnabled = s.Serialize<bool>(slowMotionEnabled, name: "slowMotionEnabled");
				radarMaxRange = s.Serialize<float>(radarMaxRange, name: "radarMaxRange");
				radarRangeHysteresis = s.Serialize<float>(radarRangeHysteresis, name: "radarRangeHysteresis");
				invincibilityWwiseEvent_Start = s.SerializeObject<StringID>(invincibilityWwiseEvent_Start, name: "invincibilityWwiseEvent_Start");
				invincibilityWwiseEvent_Stop = s.SerializeObject<StringID>(invincibilityWwiseEvent_Stop, name: "invincibilityWwiseEvent_Stop");
			}
		}
		public override uint? ClassCRC => 0x782FCE80;
	}
}

