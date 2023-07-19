using System;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIFruitRoamingBehavior_Template : TemplateAIBehavior {
		public float apexTypicalHeight = 1.1f;
		public float normalGravityMultiplier = 1f;
		public float startToFloatTime = 0.5f;
		public float floatConstantForceDuration = 0.5f;
		public float floatMaxForce = 100f;
		public float speedThatTriggersFloating = 2f;
		public float floatTimeBeforeFalling = 0.5f;
		public Angle bounceOnCharacterAreaAngle = 80 * (MathF.PI / 180f);
		public Angle angleToBounceVerticallyOnCharacter = 20 * (MathF.PI / 180f);
		public Angle slantingBounceOnCharacterAngle = 10 * (MathF.PI / 180f);
		public float bounceXSpeedFactor = 0.5f;
		public float bounceYSpeedFactor = 0.1f;
		public float speedForMaxSquash = 6f;
		public float maxSquashDuration = 1f;
		public float maxSquashFactor = 0.5f;
		public float interFruitForce = 50f;
		public float maxBounceSpeed = 1f;
		public int canAttach = 1;
		public float bounceSpeedAlongNormal = 1f;
		public float speedPerturbationWhenTooVertical;
		public Vec2d initialSpeed;
		public int canBounceOnHead = 1;
		public float minBounceDuration = 0.1f;
		public float groundToVerticalBlendFactor;
		public float minSpeedForPerturbation = 0.5f;
		public int isStaticOnX;
		public float speedForMaxBounceDuration = 1f;
		public float maxBounceDuration = 0.2f;
		public float interreaction_maxBounceSpeedMultiplier = 1.2f;
		public float interreaction_addVerticalSpeed = 2f;
		public float massInfluenceOnBounce = 0.5f;
		public float fallDeformationReactivity = 0.89999998f;
		public float fallDeformation = 1.1f;
		public float speedForFallDeformation = 6f;
		public StringID standAnimationName = new StringID("Idle");
		public Angle rotationSpeed;
		public StringID fxOnBounce;
		public StringID fxAfterFirstBounce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			apexTypicalHeight = s.Serialize<float>(apexTypicalHeight, name: "apexTypicalHeight");
			normalGravityMultiplier = s.Serialize<float>(normalGravityMultiplier, name: "normalGravityMultiplier");
			startToFloatTime = s.Serialize<float>(startToFloatTime, name: "startToFloatTime");
			floatConstantForceDuration = s.Serialize<float>(floatConstantForceDuration, name: "floatConstantForceDuration");
			floatMaxForce = s.Serialize<float>(floatMaxForce, name: "floatMaxForce");
			speedThatTriggersFloating = s.Serialize<float>(speedThatTriggersFloating, name: "speedThatTriggersFloating");
			floatTimeBeforeFalling = s.Serialize<float>(floatTimeBeforeFalling, name: "floatTimeBeforeFalling");
			bounceOnCharacterAreaAngle = s.SerializeObject<Angle>(bounceOnCharacterAreaAngle, name: "bounceOnCharacterAreaAngle");
			angleToBounceVerticallyOnCharacter = s.SerializeObject<Angle>(angleToBounceVerticallyOnCharacter, name: "angleToBounceVerticallyOnCharacter");
			slantingBounceOnCharacterAngle = s.SerializeObject<Angle>(slantingBounceOnCharacterAngle, name: "slantingBounceOnCharacterAngle");
			bounceXSpeedFactor = s.Serialize<float>(bounceXSpeedFactor, name: "bounceXSpeedFactor");
			bounceYSpeedFactor = s.Serialize<float>(bounceYSpeedFactor, name: "bounceYSpeedFactor");
			speedForMaxSquash = s.Serialize<float>(speedForMaxSquash, name: "speedForMaxSquash");
			maxSquashDuration = s.Serialize<float>(maxSquashDuration, name: "maxSquashDuration");
			maxSquashFactor = s.Serialize<float>(maxSquashFactor, name: "maxSquashFactor");
			interFruitForce = s.Serialize<float>(interFruitForce, name: "interFruitForce");
			maxBounceSpeed = s.Serialize<float>(maxBounceSpeed, name: "maxBounceSpeed");
			canAttach = s.Serialize<int>(canAttach, name: "canAttach");
			bounceSpeedAlongNormal = s.Serialize<float>(bounceSpeedAlongNormal, name: "bounceSpeedAlongNormal");
			speedPerturbationWhenTooVertical = s.Serialize<float>(speedPerturbationWhenTooVertical, name: "speedPerturbationWhenTooVertical");
			initialSpeed = s.SerializeObject<Vec2d>(initialSpeed, name: "initialSpeed");
			canBounceOnHead = s.Serialize<int>(canBounceOnHead, name: "canBounceOnHead");
			minBounceDuration = s.Serialize<float>(minBounceDuration, name: "minBounceDuration");
			groundToVerticalBlendFactor = s.Serialize<float>(groundToVerticalBlendFactor, name: "groundToVerticalBlendFactor");
			minSpeedForPerturbation = s.Serialize<float>(minSpeedForPerturbation, name: "minSpeedForPerturbation");
			isStaticOnX = s.Serialize<int>(isStaticOnX, name: "isStaticOnX");
			speedForMaxBounceDuration = s.Serialize<float>(speedForMaxBounceDuration, name: "speedForMaxBounceDuration");
			maxBounceDuration = s.Serialize<float>(maxBounceDuration, name: "maxBounceDuration");
			interreaction_maxBounceSpeedMultiplier = s.Serialize<float>(interreaction_maxBounceSpeedMultiplier, name: "interreaction_maxBounceSpeedMultiplier");
			interreaction_addVerticalSpeed = s.Serialize<float>(interreaction_addVerticalSpeed, name: "interreaction_addVerticalSpeed");
			massInfluenceOnBounce = s.Serialize<float>(massInfluenceOnBounce, name: "massInfluenceOnBounce");
			fallDeformationReactivity = s.Serialize<float>(fallDeformationReactivity, name: "fallDeformationReactivity");
			fallDeformation = s.Serialize<float>(fallDeformation, name: "fallDeformation");
			speedForFallDeformation = s.Serialize<float>(speedForFallDeformation, name: "speedForFallDeformation");
			standAnimationName = s.SerializeObject<StringID>(standAnimationName, name: "standAnimationName");
			rotationSpeed = s.SerializeObject<Angle>(rotationSpeed, name: "rotationSpeed");
			fxOnBounce = s.SerializeObject<StringID>(fxOnBounce, name: "fxOnBounce");
			fxAfterFirstBounce = s.SerializeObject<StringID>(fxAfterFirstBounce, name: "fxAfterFirstBounce");
		}
		public override uint? ClassCRC => 0xA02CA49E;
	}
}

