namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_444_sub_B80520 : CSerializable {
		public float minLocalSpeed;
		public float maxLocalSpeed;
		public float vaccumMoveSpeedBlendFactor;
		public float defaultMoveSpeedBlendFactor;
		public float defaultMoveSpeedInertialBlendFactor;
		public float waterMoveSpeedInertialBlendFactor;
		public float waterMoveSpeedBlendFactor;
		public float waterCheckRadius;
		public float waterResistanceForce;
		public float ejectFromBorderForce;
		public float ejectFromHitForce;
		public float ejectFromFriendlyHitForce;
		public Vec2d ejectMarginX;
		public Vec2d ejectMarginY;
		public Vec2d deathMargin;
		public float outOfScreenDurationBeforeDeath;
		public float hurtInvincibleDuration;
		public float reviveImmunityDuration;
		public uint hurtBlinkCount;
		public float hurtBlinkMinAlpha;
		public float hurtBlinkMaxAlpha;
		public StringID gunBone;
		public StringID swallowBone;
		public float invincibilityTime;
		public Placeholder vacuumSkill;
		public Vec2d spitObjSpeed;
		public Path baseSpawnBulletPath;
		public Path deathSpawnFXPath;
		public Placeholder heartShield;
		public float bubbleStateBlendFactor;
		public float bubbleStateLocalSpeedMax;
		public float bubbleStatePhantomRadius;
		public float djembeBounceForce;
		public float bounceStimDefaultForce;
		public float vacuumedResistanceDurationMin;
		public float vacuumedResistanceDurationMax;
		public float autoFireDelay;
		public int DBG_CanVaccumIfFull;
		public int DBG_VaccumAllowPressStop;
		public Placeholder stateMachineTemplate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minLocalSpeed = s.Serialize<float>(minLocalSpeed, name: "minLocalSpeed");
			maxLocalSpeed = s.Serialize<float>(maxLocalSpeed, name: "maxLocalSpeed");
			vaccumMoveSpeedBlendFactor = s.Serialize<float>(vaccumMoveSpeedBlendFactor, name: "vaccumMoveSpeedBlendFactor");
			defaultMoveSpeedBlendFactor = s.Serialize<float>(defaultMoveSpeedBlendFactor, name: "defaultMoveSpeedBlendFactor");
			defaultMoveSpeedInertialBlendFactor = s.Serialize<float>(defaultMoveSpeedInertialBlendFactor, name: "defaultMoveSpeedInertialBlendFactor");
			waterMoveSpeedInertialBlendFactor = s.Serialize<float>(waterMoveSpeedInertialBlendFactor, name: "waterMoveSpeedInertialBlendFactor");
			waterMoveSpeedBlendFactor = s.Serialize<float>(waterMoveSpeedBlendFactor, name: "waterMoveSpeedBlendFactor");
			waterCheckRadius = s.Serialize<float>(waterCheckRadius, name: "waterCheckRadius");
			waterResistanceForce = s.Serialize<float>(waterResistanceForce, name: "waterResistanceForce");
			ejectFromBorderForce = s.Serialize<float>(ejectFromBorderForce, name: "ejectFromBorderForce");
			ejectFromHitForce = s.Serialize<float>(ejectFromHitForce, name: "ejectFromHitForce");
			ejectFromFriendlyHitForce = s.Serialize<float>(ejectFromFriendlyHitForce, name: "ejectFromFriendlyHitForce");
			ejectMarginX = s.SerializeObject<Vec2d>(ejectMarginX, name: "ejectMarginX");
			ejectMarginY = s.SerializeObject<Vec2d>(ejectMarginY, name: "ejectMarginY");
			deathMargin = s.SerializeObject<Vec2d>(deathMargin, name: "deathMargin");
			outOfScreenDurationBeforeDeath = s.Serialize<float>(outOfScreenDurationBeforeDeath, name: "outOfScreenDurationBeforeDeath");
			hurtInvincibleDuration = s.Serialize<float>(hurtInvincibleDuration, name: "hurtInvincibleDuration");
			reviveImmunityDuration = s.Serialize<float>(reviveImmunityDuration, name: "reviveImmunityDuration");
			hurtBlinkCount = s.Serialize<uint>(hurtBlinkCount, name: "hurtBlinkCount");
			hurtBlinkMinAlpha = s.Serialize<float>(hurtBlinkMinAlpha, name: "hurtBlinkMinAlpha");
			hurtBlinkMaxAlpha = s.Serialize<float>(hurtBlinkMaxAlpha, name: "hurtBlinkMaxAlpha");
			gunBone = s.SerializeObject<StringID>(gunBone, name: "gunBone");
			swallowBone = s.SerializeObject<StringID>(swallowBone, name: "swallowBone");
			invincibilityTime = s.Serialize<float>(invincibilityTime, name: "invincibilityTime");
			vacuumSkill = s.SerializeObject<Placeholder>(vacuumSkill, name: "vacuumSkill");
			spitObjSpeed = s.SerializeObject<Vec2d>(spitObjSpeed, name: "spitObjSpeed");
			baseSpawnBulletPath = s.SerializeObject<Path>(baseSpawnBulletPath, name: "baseSpawnBulletPath");
			deathSpawnFXPath = s.SerializeObject<Path>(deathSpawnFXPath, name: "deathSpawnFXPath");
			heartShield = s.SerializeObject<Placeholder>(heartShield, name: "heartShield");
			bubbleStateBlendFactor = s.Serialize<float>(bubbleStateBlendFactor, name: "bubbleStateBlendFactor");
			bubbleStateLocalSpeedMax = s.Serialize<float>(bubbleStateLocalSpeedMax, name: "bubbleStateLocalSpeedMax");
			bubbleStatePhantomRadius = s.Serialize<float>(bubbleStatePhantomRadius, name: "bubbleStatePhantomRadius");
			djembeBounceForce = s.Serialize<float>(djembeBounceForce, name: "djembeBounceForce");
			bounceStimDefaultForce = s.Serialize<float>(bounceStimDefaultForce, name: "bounceStimDefaultForce");
			vacuumedResistanceDurationMin = s.Serialize<float>(vacuumedResistanceDurationMin, name: "vacuumedResistanceDurationMin");
			vacuumedResistanceDurationMax = s.Serialize<float>(vacuumedResistanceDurationMax, name: "vacuumedResistanceDurationMax");
			autoFireDelay = s.Serialize<float>(autoFireDelay, name: "autoFireDelay");
			DBG_CanVaccumIfFull = s.Serialize<int>(DBG_CanVaccumIfFull, name: "DBG_CanVaccumIfFull");
			DBG_VaccumAllowPressStop = s.Serialize<int>(DBG_VaccumAllowPressStop, name: "DBG_VaccumAllowPressStop");
			stateMachineTemplate = s.SerializeObject<Placeholder>(stateMachineTemplate, name: "stateMachineTemplate");
		}
		public override uint? ClassCRC => 0x6B926F43;
	}
}

