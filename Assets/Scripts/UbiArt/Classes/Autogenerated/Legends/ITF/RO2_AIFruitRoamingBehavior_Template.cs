using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIFruitRoamingBehavior_Template : TemplateAIBehavior {
		[Serialize("apexTypicalHeight"                     )] public float apexTypicalHeight;
		[Serialize("normalGravityMultiplier"               )] public float normalGravityMultiplier;
		[Serialize("startToFloatTime"                      )] public float startToFloatTime;
		[Serialize("floatConstantForceDuration"            )] public float floatConstantForceDuration;
		[Serialize("floatMaxForce"                         )] public float floatMaxForce;
		[Serialize("speedThatTriggersFloating"             )] public float speedThatTriggersFloating;
		[Serialize("floatTimeBeforeFalling"                )] public float floatTimeBeforeFalling;
		[Serialize("bounceOnCharacterAreaAngle"            )] public Angle bounceOnCharacterAreaAngle;
		[Serialize("angleToBounceVerticallyOnCharacter"    )] public Angle angleToBounceVerticallyOnCharacter;
		[Serialize("slantingBounceOnCharacterAngle"        )] public Angle slantingBounceOnCharacterAngle;
		[Serialize("bounceXSpeedFactor"                    )] public float bounceXSpeedFactor;
		[Serialize("bounceYSpeedFactor"                    )] public float bounceYSpeedFactor;
		[Serialize("speedForMaxSquash"                     )] public float speedForMaxSquash;
		[Serialize("maxSquashDuration"                     )] public float maxSquashDuration;
		[Serialize("maxSquashFactor"                       )] public float maxSquashFactor;
		[Serialize("interFruitForce"                       )] public float interFruitForce;
		[Serialize("maxBounceSpeed"                        )] public float maxBounceSpeed;
		[Serialize("canAttach"                             )] public int canAttach;
		[Serialize("bounceSpeedAlongNormal"                )] public float bounceSpeedAlongNormal;
		[Serialize("speedPerturbationWhenTooVertical"      )] public float speedPerturbationWhenTooVertical;
		[Serialize("initialSpeed"                          )] public Vector2 initialSpeed;
		[Serialize("canBounceOnHead"                       )] public int canBounceOnHead;
		[Serialize("minBounceDuration"                     )] public float minBounceDuration;
		[Serialize("groundToVerticalBlendFactor"           )] public float groundToVerticalBlendFactor;
		[Serialize("minSpeedForPerturbation"               )] public float minSpeedForPerturbation;
		[Serialize("isStaticOnX"                           )] public int isStaticOnX;
		[Serialize("speedForMaxBounceDuration"             )] public float speedForMaxBounceDuration;
		[Serialize("maxBounceDuration"                     )] public float maxBounceDuration;
		[Serialize("interreaction_maxBounceSpeedMultiplier")] public float interreaction_maxBounceSpeedMultiplier;
		[Serialize("interreaction_addVerticalSpeed"        )] public float interreaction_addVerticalSpeed;
		[Serialize("massInfluenceOnBounce"                 )] public float massInfluenceOnBounce;
		[Serialize("fallDeformationReactivity"             )] public float fallDeformationReactivity;
		[Serialize("fallDeformation"                       )] public float fallDeformation;
		[Serialize("speedForFallDeformation"               )] public float speedForFallDeformation;
		[Serialize("standAnimationName"                    )] public StringID standAnimationName;
		[Serialize("rotationSpeed"                         )] public Angle rotationSpeed;
		[Serialize("fxOnBounce"                            )] public StringID fxOnBounce;
		[Serialize("fxAfterFirstBounce"                    )] public StringID fxAfterFirstBounce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(apexTypicalHeight));
			SerializeField(s, nameof(normalGravityMultiplier));
			SerializeField(s, nameof(startToFloatTime));
			SerializeField(s, nameof(floatConstantForceDuration));
			SerializeField(s, nameof(floatMaxForce));
			SerializeField(s, nameof(speedThatTriggersFloating));
			SerializeField(s, nameof(floatTimeBeforeFalling));
			SerializeField(s, nameof(bounceOnCharacterAreaAngle));
			SerializeField(s, nameof(angleToBounceVerticallyOnCharacter));
			SerializeField(s, nameof(slantingBounceOnCharacterAngle));
			SerializeField(s, nameof(bounceXSpeedFactor));
			SerializeField(s, nameof(bounceYSpeedFactor));
			SerializeField(s, nameof(speedForMaxSquash));
			SerializeField(s, nameof(maxSquashDuration));
			SerializeField(s, nameof(maxSquashFactor));
			SerializeField(s, nameof(interFruitForce));
			SerializeField(s, nameof(maxBounceSpeed));
			SerializeField(s, nameof(canAttach));
			SerializeField(s, nameof(bounceSpeedAlongNormal));
			SerializeField(s, nameof(speedPerturbationWhenTooVertical));
			SerializeField(s, nameof(initialSpeed));
			SerializeField(s, nameof(canBounceOnHead));
			SerializeField(s, nameof(minBounceDuration));
			SerializeField(s, nameof(groundToVerticalBlendFactor));
			SerializeField(s, nameof(minSpeedForPerturbation));
			SerializeField(s, nameof(isStaticOnX));
			SerializeField(s, nameof(speedForMaxBounceDuration));
			SerializeField(s, nameof(maxBounceDuration));
			SerializeField(s, nameof(interreaction_maxBounceSpeedMultiplier));
			SerializeField(s, nameof(interreaction_addVerticalSpeed));
			SerializeField(s, nameof(massInfluenceOnBounce));
			SerializeField(s, nameof(fallDeformationReactivity));
			SerializeField(s, nameof(fallDeformation));
			SerializeField(s, nameof(speedForFallDeformation));
			SerializeField(s, nameof(standAnimationName));
			SerializeField(s, nameof(rotationSpeed));
			SerializeField(s, nameof(fxOnBounce));
			SerializeField(s, nameof(fxAfterFirstBounce));
		}
		public override uint? ClassCRC => 0xA02CA49E;
	}
}

