namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_GeyserPlatformAIComponent_Template : GraphicComponent_Template {
		public StringID attachBone;
		public int ignoreActorScale;
		public float length;
		public int lockLength;
		public int lockAngle;
		public float growTargetSmoothFactor;
		public float growSmoothFactor;
		public float shrinkTargetSmoothFactor;
		public float shrinkSmoothFactor;
		public float lengthVariationAmplitude;
		public float lengthVariationFrequency;
		public float jumpThreshold;
		public int triggerOnHit;
		public float triggerOnHitDelay;
		public float autoCloseDelay;
		public int startOpen;
		public int changeStateOnTrigger;
		public Path texture;
		public float patchStartOffset;
		public float patchLengthOffset;
		public float patchLengthMultiplier;
		public float patchWidthBottom;
		public float patchWidthTop;
		public int patchSwapXY;
		public float tileLength;
		public float tileWidth;
		public Vec2d uvScrollSpeed;
		public UV_MODE uvMode;
		public float patchFadeInLength;
		public float patchFadeOutLength;
		public float zOffset;
		public float tessellationLength;
		public PhysForceModifier forceModifier;
		public Vec2d forceDirection;
		public float forceLengthOffset;
		public float forceLengthMultiplier;
		public float forceWidthBottom;
		public float forceWidthTop;
		public float forceFadeOutLength;
		public int usePlatform;
		public Path platformMaterial;
		public float platformWidth;
		public StringID platformBone;
		public StringID platformPolyline;
		public float platformLengthMultiplier;
		public float platformLengthOffset;
		public float platformHeightSink;
		public StringID fx;
		public int fxUseTransform;
		public GeneratorType fxGeneratorType;
		public CArrayO<StringID> fxGenerators;
		public float fxLengthOffset;
		public float fxLengthMultiplier;
		public float fxWidth;
		public float fxLifetimeOffset;
		public float fxLifetimeMultiplier;
		public StringID fxCollision;
		public StringID fxOnClose;
		public float fxOnCloseThreshold;
		public StringID animOpened;
		public StringID animClosed;
		public int useStim;
		public int jumpToPlatform;
		public uint faction;
		public uint windTunnelLevel;
		public CListO<Ray_GeyserPlatformAIComponent_Template.RegionData> regions;
		public int isGeyserBehavior;
		public int registerToAIManager;
		public Angle minAngle;
		public Angle maxAngle;
		public int debugForce;
		public int debugPatch;
		public int debugFx;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
			ignoreActorScale = s.Serialize<int>(ignoreActorScale, name: "ignoreActorScale");
			length = s.Serialize<float>(length, name: "length");
			lockLength = s.Serialize<int>(lockLength, name: "lockLength");
			lockAngle = s.Serialize<int>(lockAngle, name: "lockAngle");
			growTargetSmoothFactor = s.Serialize<float>(growTargetSmoothFactor, name: "growTargetSmoothFactor");
			growSmoothFactor = s.Serialize<float>(growSmoothFactor, name: "growSmoothFactor");
			shrinkTargetSmoothFactor = s.Serialize<float>(shrinkTargetSmoothFactor, name: "shrinkTargetSmoothFactor");
			shrinkSmoothFactor = s.Serialize<float>(shrinkSmoothFactor, name: "shrinkSmoothFactor");
			lengthVariationAmplitude = s.Serialize<float>(lengthVariationAmplitude, name: "lengthVariationAmplitude");
			lengthVariationFrequency = s.Serialize<float>(lengthVariationFrequency, name: "lengthVariationFrequency");
			jumpThreshold = s.Serialize<float>(jumpThreshold, name: "jumpThreshold");
			triggerOnHit = s.Serialize<int>(triggerOnHit, name: "triggerOnHit");
			triggerOnHitDelay = s.Serialize<float>(triggerOnHitDelay, name: "triggerOnHitDelay");
			autoCloseDelay = s.Serialize<float>(autoCloseDelay, name: "autoCloseDelay");
			startOpen = s.Serialize<int>(startOpen, name: "startOpen");
			changeStateOnTrigger = s.Serialize<int>(changeStateOnTrigger, name: "changeStateOnTrigger");
			texture = s.SerializeObject<Path>(texture, name: "texture");
			patchStartOffset = s.Serialize<float>(patchStartOffset, name: "patchStartOffset");
			patchLengthOffset = s.Serialize<float>(patchLengthOffset, name: "patchLengthOffset");
			patchLengthMultiplier = s.Serialize<float>(patchLengthMultiplier, name: "patchLengthMultiplier");
			patchWidthBottom = s.Serialize<float>(patchWidthBottom, name: "patchWidthBottom");
			patchWidthTop = s.Serialize<float>(patchWidthTop, name: "patchWidthTop");
			patchSwapXY = s.Serialize<int>(patchSwapXY, name: "patchSwapXY");
			tileLength = s.Serialize<float>(tileLength, name: "tileLength");
			tileWidth = s.Serialize<float>(tileWidth, name: "tileWidth");
			uvScrollSpeed = s.SerializeObject<Vec2d>(uvScrollSpeed, name: "uvScrollSpeed");
			uvMode = s.Serialize<UV_MODE>(uvMode, name: "uvMode");
			patchFadeInLength = s.Serialize<float>(patchFadeInLength, name: "patchFadeInLength");
			patchFadeOutLength = s.Serialize<float>(patchFadeOutLength, name: "patchFadeOutLength");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
			forceModifier = s.SerializeObject<PhysForceModifier>(forceModifier, name: "forceModifier");
			forceDirection = s.SerializeObject<Vec2d>(forceDirection, name: "forceDirection");
			forceLengthOffset = s.Serialize<float>(forceLengthOffset, name: "forceLengthOffset");
			forceLengthMultiplier = s.Serialize<float>(forceLengthMultiplier, name: "forceLengthMultiplier");
			forceWidthBottom = s.Serialize<float>(forceWidthBottom, name: "forceWidthBottom");
			forceWidthTop = s.Serialize<float>(forceWidthTop, name: "forceWidthTop");
			forceFadeOutLength = s.Serialize<float>(forceFadeOutLength, name: "forceFadeOutLength");
			usePlatform = s.Serialize<int>(usePlatform, name: "usePlatform");
			platformMaterial = s.SerializeObject<Path>(platformMaterial, name: "platformMaterial");
			platformWidth = s.Serialize<float>(platformWidth, name: "platformWidth");
			platformBone = s.SerializeObject<StringID>(platformBone, name: "platformBone");
			platformPolyline = s.SerializeObject<StringID>(platformPolyline, name: "platformPolyline");
			platformLengthMultiplier = s.Serialize<float>(platformLengthMultiplier, name: "platformLengthMultiplier");
			platformLengthOffset = s.Serialize<float>(platformLengthOffset, name: "platformLengthOffset");
			platformHeightSink = s.Serialize<float>(platformHeightSink, name: "platformHeightSink");
			fx = s.SerializeObject<StringID>(fx, name: "fx");
			fxUseTransform = s.Serialize<int>(fxUseTransform, name: "fxUseTransform");
			fxGeneratorType = s.Serialize<GeneratorType>(fxGeneratorType, name: "fxGeneratorType");
			fxGenerators = s.SerializeObject<CArrayO<StringID>>(fxGenerators, name: "fxGenerators");
			fxLengthOffset = s.Serialize<float>(fxLengthOffset, name: "fxLengthOffset");
			fxLengthMultiplier = s.Serialize<float>(fxLengthMultiplier, name: "fxLengthMultiplier");
			fxWidth = s.Serialize<float>(fxWidth, name: "fxWidth");
			fxLifetimeOffset = s.Serialize<float>(fxLifetimeOffset, name: "fxLifetimeOffset");
			fxLifetimeMultiplier = s.Serialize<float>(fxLifetimeMultiplier, name: "fxLifetimeMultiplier");
			fxCollision = s.SerializeObject<StringID>(fxCollision, name: "fxCollision");
			fxOnClose = s.SerializeObject<StringID>(fxOnClose, name: "fxOnClose");
			fxOnCloseThreshold = s.Serialize<float>(fxOnCloseThreshold, name: "fxOnCloseThreshold");
			animOpened = s.SerializeObject<StringID>(animOpened, name: "animOpened");
			animClosed = s.SerializeObject<StringID>(animClosed, name: "animClosed");
			useStim = s.Serialize<int>(useStim, name: "useStim");
			jumpToPlatform = s.Serialize<int>(jumpToPlatform, name: "jumpToPlatform");
			faction = s.Serialize<uint>(faction, name: "faction");
			windTunnelLevel = s.Serialize<uint>(windTunnelLevel, name: "windTunnelLevel");
			regions = s.SerializeObject<CListO<Ray_GeyserPlatformAIComponent_Template.RegionData>>(regions, name: "regions");
			isGeyserBehavior = s.Serialize<int>(isGeyserBehavior, name: "isGeyserBehavior");
			registerToAIManager = s.Serialize<int>(registerToAIManager, name: "registerToAIManager");
			if (s.Settings.game == Settings.Game.RO && !s.HasSerializerFlags(CSerializerObject.Flags.Flags0) && s.HasFlags(SerializeFlags.Flags_xC0)) {
				minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
				maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
				debugForce = s.Serialize<int>(debugForce, name: "debugForce");
				debugPatch = s.Serialize<int>(debugPatch, name: "debugPatch");
				debugFx = s.Serialize<int>(debugFx, name: "debugFx");
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class RegionData : CSerializable {
			public float widthOffset;
			public float heightOffset;
			public StringID id;
			public Path gameMaterial;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				widthOffset = s.Serialize<float>(widthOffset, name: "widthOffset");
				heightOffset = s.Serialize<float>(heightOffset, name: "heightOffset");
				id = s.SerializeObject<StringID>(id, name: "id");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
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

