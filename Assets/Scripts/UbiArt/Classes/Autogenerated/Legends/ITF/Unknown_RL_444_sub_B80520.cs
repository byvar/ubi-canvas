using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_444_sub_B80520 : CSerializable {
		[Serialize("minLocalSpeed"                      )] public float minLocalSpeed;
		[Serialize("maxLocalSpeed"                      )] public float maxLocalSpeed;
		[Serialize("vaccumMoveSpeedBlendFactor"         )] public float vaccumMoveSpeedBlendFactor;
		[Serialize("defaultMoveSpeedBlendFactor"        )] public float defaultMoveSpeedBlendFactor;
		[Serialize("defaultMoveSpeedInertialBlendFactor")] public float defaultMoveSpeedInertialBlendFactor;
		[Serialize("waterMoveSpeedInertialBlendFactor"  )] public float waterMoveSpeedInertialBlendFactor;
		[Serialize("waterMoveSpeedBlendFactor"          )] public float waterMoveSpeedBlendFactor;
		[Serialize("waterCheckRadius"                   )] public float waterCheckRadius;
		[Serialize("waterResistanceForce"               )] public float waterResistanceForce;
		[Serialize("ejectFromBorderForce"               )] public float ejectFromBorderForce;
		[Serialize("ejectFromHitForce"                  )] public float ejectFromHitForce;
		[Serialize("ejectFromFriendlyHitForce"          )] public float ejectFromFriendlyHitForce;
		[Serialize("ejectMarginX"                       )] public Vec2d ejectMarginX;
		[Serialize("ejectMarginY"                       )] public Vec2d ejectMarginY;
		[Serialize("deathMargin"                        )] public Vec2d deathMargin;
		[Serialize("outOfScreenDurationBeforeDeath"     )] public float outOfScreenDurationBeforeDeath;
		[Serialize("hurtInvincibleDuration"             )] public float hurtInvincibleDuration;
		[Serialize("reviveImmunityDuration"             )] public float reviveImmunityDuration;
		[Serialize("hurtBlinkCount"                     )] public uint hurtBlinkCount;
		[Serialize("hurtBlinkMinAlpha"                  )] public float hurtBlinkMinAlpha;
		[Serialize("hurtBlinkMaxAlpha"                  )] public float hurtBlinkMaxAlpha;
		[Serialize("gunBone"                            )] public StringID gunBone;
		[Serialize("swallowBone"                        )] public StringID swallowBone;
		[Serialize("invincibilityTime"                  )] public float invincibilityTime;
		[Serialize("vacuumSkill"                        )] public Placeholder vacuumSkill;
		[Serialize("spitObjSpeed"                       )] public Vec2d spitObjSpeed;
		[Serialize("baseSpawnBulletPath"                )] public Path baseSpawnBulletPath;
		[Serialize("deathSpawnFXPath"                   )] public Path deathSpawnFXPath;
		[Serialize("heartShield"                        )] public Placeholder heartShield;
		[Serialize("bubbleStateBlendFactor"             )] public float bubbleStateBlendFactor;
		[Serialize("bubbleStateLocalSpeedMax"           )] public float bubbleStateLocalSpeedMax;
		[Serialize("bubbleStatePhantomRadius"           )] public float bubbleStatePhantomRadius;
		[Serialize("djembeBounceForce"                  )] public float djembeBounceForce;
		[Serialize("bounceStimDefaultForce"             )] public float bounceStimDefaultForce;
		[Serialize("vacuumedResistanceDurationMin"      )] public float vacuumedResistanceDurationMin;
		[Serialize("vacuumedResistanceDurationMax"      )] public float vacuumedResistanceDurationMax;
		[Serialize("autoFireDelay"                      )] public float autoFireDelay;
		[Serialize("DBG_CanVaccumIfFull"                )] public int DBG_CanVaccumIfFull;
		[Serialize("DBG_VaccumAllowPressStop"           )] public int DBG_VaccumAllowPressStop;
		[Serialize("stateMachineTemplate"               )] public Placeholder stateMachineTemplate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minLocalSpeed));
			SerializeField(s, nameof(maxLocalSpeed));
			SerializeField(s, nameof(vaccumMoveSpeedBlendFactor));
			SerializeField(s, nameof(defaultMoveSpeedBlendFactor));
			SerializeField(s, nameof(defaultMoveSpeedInertialBlendFactor));
			SerializeField(s, nameof(waterMoveSpeedInertialBlendFactor));
			SerializeField(s, nameof(waterMoveSpeedBlendFactor));
			SerializeField(s, nameof(waterCheckRadius));
			SerializeField(s, nameof(waterResistanceForce));
			SerializeField(s, nameof(ejectFromBorderForce));
			SerializeField(s, nameof(ejectFromHitForce));
			SerializeField(s, nameof(ejectFromFriendlyHitForce));
			SerializeField(s, nameof(ejectMarginX));
			SerializeField(s, nameof(ejectMarginY));
			SerializeField(s, nameof(deathMargin));
			SerializeField(s, nameof(outOfScreenDurationBeforeDeath));
			SerializeField(s, nameof(hurtInvincibleDuration));
			SerializeField(s, nameof(reviveImmunityDuration));
			SerializeField(s, nameof(hurtBlinkCount));
			SerializeField(s, nameof(hurtBlinkMinAlpha));
			SerializeField(s, nameof(hurtBlinkMaxAlpha));
			SerializeField(s, nameof(gunBone));
			SerializeField(s, nameof(swallowBone));
			SerializeField(s, nameof(invincibilityTime));
			SerializeField(s, nameof(vacuumSkill));
			SerializeField(s, nameof(spitObjSpeed));
			SerializeField(s, nameof(baseSpawnBulletPath));
			SerializeField(s, nameof(deathSpawnFXPath));
			SerializeField(s, nameof(heartShield));
			SerializeField(s, nameof(bubbleStateBlendFactor));
			SerializeField(s, nameof(bubbleStateLocalSpeedMax));
			SerializeField(s, nameof(bubbleStatePhantomRadius));
			SerializeField(s, nameof(djembeBounceForce));
			SerializeField(s, nameof(bounceStimDefaultForce));
			SerializeField(s, nameof(vacuumedResistanceDurationMin));
			SerializeField(s, nameof(vacuumedResistanceDurationMax));
			SerializeField(s, nameof(autoFireDelay));
			SerializeField(s, nameof(DBG_CanVaccumIfFull));
			SerializeField(s, nameof(DBG_VaccumAllowPressStop));
			SerializeField(s, nameof(stateMachineTemplate));
		}
		public override uint? ClassCRC => 0x6B926F43;
	}
}

