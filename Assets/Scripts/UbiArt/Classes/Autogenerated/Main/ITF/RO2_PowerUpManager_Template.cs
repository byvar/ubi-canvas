using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PowerUpManager_Template : TemplateObj {
		[Serialize("superPunchBasicMaxAmmo"           )] public uint superPunchBasicMaxAmmo;
		[Serialize("superPunchSeekingMaxAmmo"         )] public uint superPunchSeekingMaxAmmo;
		[Serialize("swarmRepellerMaxAmmo"             )] public uint swarmRepellerMaxAmmo;
		[Serialize("petFollowerMaxAmmo"               )] public uint petFollowerMaxAmmo;
		[Serialize("magnetPhantomScaleMultiplier"     )] public CList<float> magnetPhantomScaleMultiplier;
		[Serialize("megaMagnetPhantomScaleMultiplier" )] public float megaMagnetPhantomScaleMultiplier;
		[Serialize("missileActiveCooldown"            )] public float missileActiveCooldown;
		[Serialize("tickleCooldown"                   )] public float tickleCooldown;
		[Serialize("autoAttackCooldown"               )] public float autoAttackCooldown;
		[Serialize("invincibilityCooldown"            )] public float invincibilityCooldown;
		[Serialize("polymorphCooldown"                )] public float polymorphCooldown;
		[Serialize("powerupFX"                        )] public Path powerupFX;
		[Serialize("foodDurationActor"                )] public Path foodDurationActor;
		[Serialize("invincibilityDuration"            )] public float invincibilityDuration;
		[Serialize("invincibilityCreatureOffset"      )] public float invincibilityCreatureOffset;
		[Serialize("invincibilityRitualTime"          )] public float invincibilityRitualTime;
		[Serialize("invincibilityTimeBuffer"          )] public float invincibilityTimeBuffer;
		[Serialize("magnetAutoActivationRange"        )] public float magnetAutoActivationRange;
		[Serialize("magnetMaxGrabbedLums"             )] public uint magnetMaxGrabbedLums;
		[Serialize("magnetCoinMaxAttractedRange"      )] public CList<float> magnetCoinMaxAttractedRange;
		[Serialize("magnetCoinInterpolatedSpeed"      )] public float magnetCoinInterpolatedSpeed;
		[Serialize("magnetFireflyCloudActivationRange")] public CList<float> magnetFireflyCloudActivationRange;
		[Serialize("magnetLumCageSlowCoef"            )] public float magnetLumCageSlowCoef;
		[Serialize("magnetRotationSpeed"              )] public CList<float> magnetRotationSpeed;
		[Serialize("magnetRotationTime"               )] public float magnetRotationTime;
		[Serialize("radarMaxDetectedTargets"          )] public uint radarMaxDetectedTargets;
		[Serialize("radarTeensieSelectionRange"       )] public uint radarTeensieSelectionRange;
		[Serialize("radarAnimStepRange"               )] public CList<float> radarAnimStepRange;
		[Serialize("slowMotionDuration"               )] public float slowMotionDuration;
		[Serialize("slowMotionBlendDuration"          )] public float slowMotionBlendDuration;
		[Serialize("slowMotionFactor"                 )] public float slowMotionFactor;
		[Serialize("slowMotionInvincibilityDelay"     )] public float slowMotionInvincibilityDelay;
		[Serialize("slowMotionMagnetDelay"            )] public float slowMotionMagnetDelay;
		[Serialize("slowMotionEnabled"                )] public bool slowMotionEnabled;
		[Serialize("radarMaxRange"                    )] public float radarMaxRange;
		[Serialize("radarRangeHysteresis"             )] public float radarRangeHysteresis;
		[Serialize("invincibilityWwiseEvent_Start"    )] public StringID invincibilityWwiseEvent_Start;
		[Serialize("invincibilityWwiseEvent_Stop"     )] public StringID invincibilityWwiseEvent_Stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(superPunchBasicMaxAmmo));
				SerializeField(s, nameof(superPunchSeekingMaxAmmo));
				SerializeField(s, nameof(swarmRepellerMaxAmmo));
				SerializeField(s, nameof(petFollowerMaxAmmo));
			} else {
				SerializeField(s, nameof(superPunchBasicMaxAmmo));
				SerializeField(s, nameof(superPunchSeekingMaxAmmo));
				SerializeField(s, nameof(swarmRepellerMaxAmmo));
				SerializeField(s, nameof(petFollowerMaxAmmo));
				SerializeField(s, nameof(magnetPhantomScaleMultiplier));
				SerializeField(s, nameof(megaMagnetPhantomScaleMultiplier));
				SerializeField(s, nameof(missileActiveCooldown));
				SerializeField(s, nameof(tickleCooldown));
				SerializeField(s, nameof(autoAttackCooldown));
				SerializeField(s, nameof(invincibilityCooldown));
				SerializeField(s, nameof(polymorphCooldown));
				SerializeField(s, nameof(powerupFX));
				SerializeField(s, nameof(foodDurationActor));
				SerializeField(s, nameof(invincibilityDuration));
				SerializeField(s, nameof(invincibilityCreatureOffset));
				SerializeField(s, nameof(invincibilityRitualTime));
				SerializeField(s, nameof(invincibilityTimeBuffer));
				SerializeField(s, nameof(magnetAutoActivationRange));
				SerializeField(s, nameof(magnetMaxGrabbedLums));
				SerializeField(s, nameof(magnetCoinMaxAttractedRange));
				SerializeField(s, nameof(magnetCoinInterpolatedSpeed));
				SerializeField(s, nameof(magnetFireflyCloudActivationRange));
				SerializeField(s, nameof(magnetLumCageSlowCoef));
				SerializeField(s, nameof(magnetRotationSpeed));
				SerializeField(s, nameof(magnetRotationTime));
				SerializeField(s, nameof(radarMaxDetectedTargets));
				SerializeField(s, nameof(radarTeensieSelectionRange));
				SerializeField(s, nameof(radarAnimStepRange));
				SerializeField(s, nameof(slowMotionDuration));
				SerializeField(s, nameof(slowMotionBlendDuration));
				SerializeField(s, nameof(slowMotionFactor));
				SerializeField(s, nameof(slowMotionInvincibilityDelay));
				SerializeField(s, nameof(slowMotionMagnetDelay));
				SerializeField(s, nameof(slowMotionEnabled));
				SerializeField(s, nameof(radarMaxRange));
				SerializeField(s, nameof(radarRangeHysteresis));
				SerializeField(s, nameof(invincibilityWwiseEvent_Start));
				SerializeField(s, nameof(invincibilityWwiseEvent_Stop));
			}
		}
		public override uint? ClassCRC => 0x782FCE80;
	}
}

