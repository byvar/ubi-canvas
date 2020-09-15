using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIFruitRoamingBehavior_Template : TemplateAIBehavior {
		public float apexTypicalHeight;
		public float normalGravityMultiplier;
		public float startToFloatTime;
		public float floatConstantForceDuration;
		public float floatMaxForce;
		public float speedThatTriggersFloating;
		public float floatTimeBeforeFalling;
		public Angle bounceOnCharacterAreaAngle;
		public Angle angleToBounceVerticallyOnCharacter;
		public Angle slantingBounceOnCharacterAngle;
		public float bounceXSpeedFactor;
		public float bounceYSpeedFactor;
		public float speedForMaxSquash;
		public float maxSquashDuration;
		public float maxSquashFactor;
		public float interFruitForce;
		public float maxBounceSpeed;
		public int canAttach;
		public float bounceSpeedAlongNormal;
		public float speedPerturbationWhenTooVertical;
		public Vec2d initialSpeed;
		public int canBounceOnHead;
		public float minBounceDuration;
		public float groundToVerticalBlendFactor;
		public float minSpeedForPerturbation;
		public int isStaticOnX;
		public float speedForMaxBounceDuration;
		public float maxBounceDuration;
		public float interreaction_maxBounceSpeedMultiplier;
		public float interreaction_addVerticalSpeed;
		public float massInfluenceOnBounce;
		public float fallDeformationReactivity;
		public float fallDeformation;
		public float speedForFallDeformation;
		public StringID standAnimationName;
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
		public override uint? ClassCRC => 0x9A293C58;
	}
}

