using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_GeyserPlatformAIComponent_Template : GraphicComponent_Template {
		[Serialize("attachBone"              )] public StringID attachBone;
		[Serialize("ignoreActorScale"        )] public int ignoreActorScale;
		[Serialize("length"                  )] public float length;
		[Serialize("lockLength"              )] public int lockLength;
		[Serialize("lockAngle"               )] public int lockAngle;
		[Serialize("growTargetSmoothFactor"  )] public float growTargetSmoothFactor;
		[Serialize("growSmoothFactor"        )] public float growSmoothFactor;
		[Serialize("shrinkTargetSmoothFactor")] public float shrinkTargetSmoothFactor;
		[Serialize("shrinkSmoothFactor"      )] public float shrinkSmoothFactor;
		[Serialize("lengthVariationAmplitude")] public float lengthVariationAmplitude;
		[Serialize("lengthVariationFrequency")] public float lengthVariationFrequency;
		[Serialize("jumpThreshold"           )] public float jumpThreshold;
		[Serialize("triggerOnHit"            )] public int triggerOnHit;
		[Serialize("triggerOnHitDelay"       )] public float triggerOnHitDelay;
		[Serialize("autoCloseDelay"          )] public float autoCloseDelay;
		[Serialize("startOpen"               )] public int startOpen;
		[Serialize("changeStateOnTrigger"    )] public int changeStateOnTrigger;
		[Serialize("texture"                 )] public Path texture;
		[Serialize("patchStartOffset"        )] public float patchStartOffset;
		[Serialize("patchLengthOffset"       )] public float patchLengthOffset;
		[Serialize("patchLengthMultiplier"   )] public float patchLengthMultiplier;
		[Serialize("patchWidthBottom"        )] public float patchWidthBottom;
		[Serialize("patchWidthTop"           )] public float patchWidthTop;
		[Serialize("patchSwapXY"             )] public int patchSwapXY;
		[Serialize("tileLength"              )] public float tileLength;
		[Serialize("tileWidth"               )] public float tileWidth;
		[Serialize("uvScrollSpeed"           )] public Vector2 uvScrollSpeed;
		[Serialize("uvMode"                  )] public UV_MODE uvMode;
		[Serialize("patchFadeInLength"       )] public float patchFadeInLength;
		[Serialize("patchFadeOutLength"      )] public float patchFadeOutLength;
		[Serialize("zOffset"                 )] public float zOffset;
		[Serialize("tessellationLength"      )] public float tessellationLength;
		[Serialize("forceModifier"           )] public PhysForceModifier forceModifier;
		[Serialize("forceDirection"          )] public Vector2 forceDirection;
		[Serialize("forceLengthOffset"       )] public float forceLengthOffset;
		[Serialize("forceLengthMultiplier"   )] public float forceLengthMultiplier;
		[Serialize("forceWidthBottom"        )] public float forceWidthBottom;
		[Serialize("forceWidthTop"           )] public float forceWidthTop;
		[Serialize("forceFadeOutLength"      )] public float forceFadeOutLength;
		[Serialize("usePlatform"             )] public int usePlatform;
		[Serialize("platformMaterial"        )] public Path platformMaterial;
		[Serialize("platformWidth"           )] public float platformWidth;
		[Serialize("platformBone"            )] public StringID platformBone;
		[Serialize("platformPolyline"        )] public StringID platformPolyline;
		[Serialize("platformLengthMultiplier")] public float platformLengthMultiplier;
		[Serialize("platformLengthOffset"    )] public float platformLengthOffset;
		[Serialize("platformHeightSink"      )] public float platformHeightSink;
		[Serialize("fx"                      )] public StringID fx;
		[Serialize("fxUseTransform"          )] public int fxUseTransform;
		[Serialize("fxGeneratorType"         )] public GeneratorType fxGeneratorType;
		[Serialize("fxGenerators"            )] public CArray<StringID> fxGenerators;
		[Serialize("fxLengthOffset"          )] public float fxLengthOffset;
		[Serialize("fxLengthMultiplier"      )] public float fxLengthMultiplier;
		[Serialize("fxWidth"                 )] public float fxWidth;
		[Serialize("fxLifetimeOffset"        )] public float fxLifetimeOffset;
		[Serialize("fxLifetimeMultiplier"    )] public float fxLifetimeMultiplier;
		[Serialize("fxCollision"             )] public StringID fxCollision;
		[Serialize("fxOnClose"               )] public StringID fxOnClose;
		[Serialize("fxOnCloseThreshold"      )] public float fxOnCloseThreshold;
		[Serialize("animOpened"              )] public StringID animOpened;
		[Serialize("animClosed"              )] public StringID animClosed;
		[Serialize("useStim"                 )] public int useStim;
		[Serialize("jumpToPlatform"          )] public int jumpToPlatform;
		[Serialize("faction"                 )] public uint faction;
		[Serialize("windTunnelLevel"         )] public uint windTunnelLevel;
		[Serialize("regions"                 )] public CList<Ray_GeyserPlatformAIComponent_Template.RegionData> regions;
		[Serialize("isGeyserBehavior"        )] public int isGeyserBehavior;
		[Serialize("registerToAIManager"     )] public int registerToAIManager;
		[Serialize("minAngle"                )] public Angle minAngle;
		[Serialize("maxAngle"                )] public Angle maxAngle;
		[Serialize("debugForce"              )] public int debugForce;
		[Serialize("debugPatch"              )] public int debugPatch;
		[Serialize("debugFx"                 )] public int debugFx;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(attachBone));
			SerializeField(s, nameof(ignoreActorScale));
			SerializeField(s, nameof(length));
			SerializeField(s, nameof(lockLength));
			SerializeField(s, nameof(lockAngle));
			SerializeField(s, nameof(growTargetSmoothFactor));
			SerializeField(s, nameof(growSmoothFactor));
			SerializeField(s, nameof(shrinkTargetSmoothFactor));
			SerializeField(s, nameof(shrinkSmoothFactor));
			SerializeField(s, nameof(lengthVariationAmplitude));
			SerializeField(s, nameof(lengthVariationFrequency));
			SerializeField(s, nameof(jumpThreshold));
			SerializeField(s, nameof(triggerOnHit));
			SerializeField(s, nameof(triggerOnHitDelay));
			SerializeField(s, nameof(autoCloseDelay));
			SerializeField(s, nameof(startOpen));
			SerializeField(s, nameof(changeStateOnTrigger));
			SerializeField(s, nameof(texture));
			SerializeField(s, nameof(patchStartOffset));
			SerializeField(s, nameof(patchLengthOffset));
			SerializeField(s, nameof(patchLengthMultiplier));
			SerializeField(s, nameof(patchWidthBottom));
			SerializeField(s, nameof(patchWidthTop));
			SerializeField(s, nameof(patchSwapXY));
			SerializeField(s, nameof(tileLength));
			SerializeField(s, nameof(tileWidth));
			SerializeField(s, nameof(uvScrollSpeed));
			SerializeField(s, nameof(uvMode));
			SerializeField(s, nameof(patchFadeInLength));
			SerializeField(s, nameof(patchFadeOutLength));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(tessellationLength));
			SerializeField(s, nameof(forceModifier));
			SerializeField(s, nameof(forceDirection));
			SerializeField(s, nameof(forceLengthOffset));
			SerializeField(s, nameof(forceLengthMultiplier));
			SerializeField(s, nameof(forceWidthBottom));
			SerializeField(s, nameof(forceWidthTop));
			SerializeField(s, nameof(forceFadeOutLength));
			SerializeField(s, nameof(usePlatform));
			SerializeField(s, nameof(platformMaterial));
			SerializeField(s, nameof(platformWidth));
			SerializeField(s, nameof(platformBone));
			SerializeField(s, nameof(platformPolyline));
			SerializeField(s, nameof(platformLengthMultiplier));
			SerializeField(s, nameof(platformLengthOffset));
			SerializeField(s, nameof(platformHeightSink));
			SerializeField(s, nameof(fx));
			SerializeField(s, nameof(fxUseTransform));
			SerializeField(s, nameof(fxGeneratorType));
			SerializeField(s, nameof(fxGenerators));
			SerializeField(s, nameof(fxLengthOffset));
			SerializeField(s, nameof(fxLengthMultiplier));
			SerializeField(s, nameof(fxWidth));
			SerializeField(s, nameof(fxLifetimeOffset));
			SerializeField(s, nameof(fxLifetimeMultiplier));
			SerializeField(s, nameof(fxCollision));
			SerializeField(s, nameof(fxOnClose));
			SerializeField(s, nameof(fxOnCloseThreshold));
			SerializeField(s, nameof(animOpened));
			SerializeField(s, nameof(animClosed));
			SerializeField(s, nameof(useStim));
			SerializeField(s, nameof(jumpToPlatform));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(windTunnelLevel));
			SerializeField(s, nameof(regions));
			SerializeField(s, nameof(isGeyserBehavior));
			SerializeField(s, nameof(registerToAIManager));
			if (Settings.s.game == Settings.Game.RO && !s.HasSerializerFlags(CSerializerObject.Flags.Flags0) && s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(minAngle));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(debugForce));
				SerializeField(s, nameof(debugPatch));
				SerializeField(s, nameof(debugFx));
			}
		}
		[Games(GameFlags.RO | GameFlags.RJR | GameFlags.RFR)]
		public partial class RegionData : CSerializable {
			[Serialize("widthOffset" )] public float widthOffset;
			[Serialize("heightOffset")] public float heightOffset;
			[Serialize("id"          )] public StringID id;
			[Serialize("gameMaterial")] public Path gameMaterial;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(widthOffset));
				SerializeField(s, nameof(heightOffset));
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(gameMaterial));
			}
		}
		public enum UV_MODE {
			[Serialize("UV_MODE_OPTIMUM")] OPTIMUM = 0,
			[Serialize("UV_MODE_SPEED"  )] SPEED = 1,
		}
		public enum GeneratorType {
			[Serialize("GeneratorType_Ballistic")] Ballistic = 0,
			[Serialize("GeneratorType_Box"      )] Box = 1,
		}
		public override uint? ClassCRC => 0xB2522A72;
	}
}

