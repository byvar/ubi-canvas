using System;
namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ParticleGeneratorParameters : CSerializable {
		public uint maxParticles = 1;
		public Color defaultColor = Color.White;
		public uint emitParticlesCount = uint.MaxValue;
		public bool forceNoDynamicFog;
		public bool renderInReflection = true;
		public float dieFadeTime = -1f;
		public float emitterMaxLifeTime = -1f;
		public OnEnd behaviorOnEnd;
		public Vec3d pos;
		public Vec2d pivot;
		public float velNorm = 1f;
		public float velAngle;
		public float velAngleDelta;
		public Vec3d grav;
		public Vec3d acc;
		public float depth;
		public bool useZAsDepth = true;
		public float velocityVar = 1f;
		public float friction = 1f;
		public float freq = 0.05f;
		public float freqDelta;
		public bool forceEmitAtStart;
		public int forceEmitAtStart_int;
		public uint emitBatchCount = 1;
		public uint emitBatchCount_AAO = 1;
		public uint emitBatchCount_AAO_max = uint.MaxValue;
		public Angle initAngle;
		public Angle angleDelta;
		public Angle angularSpeed;
		public Angle angularSpeedDelta;
		public float timeTarget;
		public uint nbPhase = 1;
		public float renderPrio;
		public float initLifeTime;
		public float circleRadius = 1f;
		public float innerCircleRadius;
		public Vec3d scaleShape = Vec3d.One;
		public Vec3d rotateShape;
		public bool randomizeDirection = true;
		public int followBezier = 1;
		public bool getAtlasSize;
		public bool continuousColorRandom;
		public AABB genBox;
		public float GenSize;
		public uint GenSide;
		public float GenPosMin;
		public float GenPosMax = 1f;
		public float GenDensity = -1f;
		public AABB boundingBox;
		public uint orientDir;
		public UV UVmode;
		public UVF UVmodeFlag;
		public float uniformscale;
		public Angle genangmin = -3.141593f;
		public Angle genangmax = 3.141593f;
		public bool useYMin;
		public bool useYMinLocal = true;
		public float yMin;
		public float yMinBouncinessMin;
		public float yMinBouncinessMax;
		public uint yMinMinRebounds;
		public uint yMinMaxRebounds;
		public bool yMinKillAfterMaxRebounds = true;
		public bool bouncinessAffectsXSpeed = true;
		public bool bouncinessAffectsAngularSpeed = true;
		public bool useAttractors;
		public bool attractorPowerDependsOnDistance = true;
		public bool useAttractorMinDistance;
		public float attractorMinDistance;
		public Vec3d attractorOffset;
		public bool useImpulseSpeed;
		public bool canFlipAngleOffset;
		public bool canFlipInitAngle;
		public bool canFlipAngularSpeed;
		public bool canFlipPivot;
		public bool canFlipPos;
		public bool canFlipUV;
		public bool canFlipAngleMin;
		public bool canFlipAngleMax;
		public bool canFlipAccel;
		public bool canFlipOrientDir;
		public bool canFlipAttractorOffset;
		public uint numberSplit;
		public Angle splitDelta;
		public BOOL useMatrix;
		public BOOL scaleGenBox = BOOL.cond;
		public BOOL2 scaleGenBox2 = (BOOL2)2;
		public bool usePhasesColorAndSize = true;
		public bool useActorTranslation;
		public Vec2d actorTranslationOffset;
		public bool disableLight;
		public CListO<ParPhase> phases;

		[DisplayName("Position")]
		[SplineUsageMode(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.Y)]
		[SplineUsageModeExt(Spline.UsageMode.Z)]
		[SplineUsageModeExt(Spline.UsageMode.XYZ)]
		public ParLifeTimeCurve curvePosition;

		[DisplayName("Angle")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public ParLifeTimeCurve curveAngle;
		public ParLifeTimeCurve curveAngularSpeed;

		[DisplayName("Velocity (mult.)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public ParLifeTimeCurve curveVelocityMult;

		[DisplayName("Acceleration (X)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public ParLifeTimeCurve curveAccelX;

		[DisplayName("Acceleration (Y)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public ParLifeTimeCurve curveAccelY;

		[DisplayName("Acceleration (Z)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public ParLifeTimeCurve curveAccelZ;

		[DisplayName("Size (square)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public ParLifeTimeCurve curveSize;

		[DisplayName("Size (height)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public ParLifeTimeCurve curveSizeY;

		[DisplayName("Alpha")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public ParLifeTimeCurve curveAlpha;

		[DisplayName("Color")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		public ParLifeTimeCurve curveRGB;

		[DisplayName("Color1")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		public ParLifeTimeCurve curveRGB1;

		[DisplayName("Color2")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		public ParLifeTimeCurve curveRGB2;

		[DisplayName("Color3")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		public ParLifeTimeCurve curveRGB3;

		[DisplayName("Spreadsheet")]
		[SplineUsageMode(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		public ParLifeTimeCurve curveAnim;
		public ParLifeTimeCurve curveAttractor;

		[DisplayName("Velocity")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public EmitLifeTimeCurve parEmitVelocity;

		[DisplayName("Velocity angle")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public EmitLifeTimeCurve parEmitVelocityAngle;

		[DisplayName("Angle")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public EmitLifeTimeCurve parEmitAngle;

		[DisplayName("Angular speed")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public EmitLifeTimeCurve parEmitAngularSpeed;

		[DisplayName("Frequency")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public EmitLifeTimeCurve curveFreq;

		[DisplayName("Particles lifetime")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public EmitLifeTimeCurve curveParLifeTime;

		[DisplayName("Alpha factor")]
		[SplineUsageMode(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		public EmitLifeTimeCurve curveEmitAlpha;
		public EmitLifeTimeCurve curveEmitAlphaInit;

		[DisplayName("Color factor")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		public EmitLifeTimeCurve curveEmitColorFactor;
		public EmitLifeTimeCurve curveEmitColorFactorInit;

		[DisplayName("Size factor")]
		[SplineUsageMode(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.Y)]
		public EmitLifeTimeCurve curveEmitSizeXY;
		public EmitLifeTimeCurve curveEmitSizeXYInit;

		[DisplayName("Acceleration")]
		[SplineUsageMode(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.Y)]
		[SplineUsageModeExt(Spline.UsageMode.Z)]
		[SplineUsageModeExt(Spline.UsageMode.XYZ)]
		public EmitLifeTimeCurve curveEmitAcceleration;


		[DisplayName("Gravity")]
		[SplineUsageMode(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.Y)]
		[SplineUsageModeExt(Spline.UsageMode.Z)]
		[SplineUsageModeExt(Spline.UsageMode.XYZ)]
		public EmitLifeTimeCurve curveEmitGravity;

		[DisplayName("Spreadsheet init")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		public EmitLifeTimeCurve curveEmitAnim;

		public PARGEN_GEN genGenType;
		public PARGEN_MODE genMode = PARGEN_MODE.COMPLEX;
		public PARGEN_EMITMODE genEmitMode;
		public GFX_GridFluidObjParam GridFluidParam;
		public GFXPrimitiveParam PrimitiveParameters;
		public bool UseGenPrimitiveParam;
		
		// Origins mode (RJR and RFR too):
		public Vec3d vel;
		public float emitInterval;		
		public int uniformscale2;
		public int cartoonrendering;
		public bool impostorrendering;
		public bool showimpostorrender;
		public uint impostorTextureSizeX;
		public uint impostorTextureSizeY;
		public float outlinesize;
		public uint randomoutline;
		public int texturemirroru;
		public int texturemirrorv;
		public int useMatrix2;
		public GFX_BLEND blendMode;
		public PARGEN_GEN2 genGenType2;

		// Child of Light
		public float fluidInfluenceScale;
		public float fluidRotate;
		public float pushFluidRadius;
		public float pushFluidScale;
		public float pushFluidRadiusHair;
		public float pushFluidScaleHair;
		public BOOL useMatrixRotation;
		public BOOL useMatrixScale;

		[Description("Must be set to true to use the remap alpha feature.")]
		public bool enableRemapAlpha;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				maxParticles = s.Serialize<uint>(maxParticles, name: "maxParticles");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				emitParticlesCount = s.Serialize<uint>(emitParticlesCount, name: "emitParticlesCount");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				pivot = s.SerializeObject<Vec2d>(pivot, name: "pivot");
				velNorm = s.Serialize<float>(velNorm, name: "velNorm");
				vel = s.SerializeObject<Vec3d>(vel, name: "vel");
				grav = s.SerializeObject<Vec3d>(grav, name: "grav");
				acc = s.SerializeObject<Vec3d>(acc, name: "acc");
				depth = s.Serialize<float>(depth, name: "depth");
				useZAsDepth = s.Serialize<bool>(useZAsDepth, name: "useZAsDepth");
				velocityVar = s.Serialize<float>(velocityVar, name: "velocityVar");
				friction = s.Serialize<float>(friction, name: "friction");
				freq = s.Serialize<float>(freq, name: "freq");
				emitInterval = s.Serialize<float>(emitInterval, name: "emitInterval");
				initAngle = s.SerializeObject<Angle>(initAngle, name: "initAngle");
				angleDelta = s.SerializeObject<Angle>(angleDelta, name: "angleDelta");
				angularSpeed = s.SerializeObject<Angle>(angularSpeed, name: "angularSpeed");
				angularSpeedDelta = s.SerializeObject<Angle>(angularSpeedDelta, name: "angularSpeedDelta");
				timeTarget = s.Serialize<float>(timeTarget, name: "timeTarget");
				nbPhase = s.Serialize<uint>(nbPhase, name: "nbPhase");
				renderPrio = s.Serialize<float>(renderPrio, name: "renderPrio");
				circleRadius = s.Serialize<float>(circleRadius, name: "circleRadius");
				innerCircleRadius = s.Serialize<float>(innerCircleRadius, name: "innerCircleRadius");
				scaleShape = s.SerializeObject<Vec3d>(scaleShape, name: "scaleShape");
				rotateShape = s.SerializeObject<Vec3d>(rotateShape, name: "rotateShape");
				randomizeDirection = s.Serialize<bool>(randomizeDirection, name: "randomizeDirection");
				genBox = s.SerializeObject<AABB>(genBox, name: "genBox");
				boundingBox = s.SerializeObject<AABB>(boundingBox, name: "boundingBox");
				orientDir = s.Serialize<uint>(orientDir, name: "orientDir");
				UVmode = s.Serialize<UV>(UVmode, name: "UVmode");
				uniformscale2 = s.Serialize<int>(uniformscale2, name: "uniformscale");
				cartoonrendering = s.Serialize<int>(cartoonrendering, name: "cartoonrendering");
				impostorrendering = s.Serialize<bool>(impostorrendering, name: "impostorrendering");
				showimpostorrender = s.Serialize<bool>(showimpostorrender, name: "showimpostorrender");
				impostorTextureSizeX = s.Serialize<uint>(impostorTextureSizeX, name: "impostorTextureSizeX");
				impostorTextureSizeY = s.Serialize<uint>(impostorTextureSizeY, name: "impostorTextureSizeY");
				outlinesize = s.Serialize<float>(outlinesize, name: "outlinesize");
				randomoutline = s.Serialize<uint>(randomoutline, name: "randomoutline");
				texturemirroru = s.Serialize<int>(texturemirroru, name: "texturemirroru");
				texturemirrorv = s.Serialize<int>(texturemirrorv, name: "texturemirrorv");
				genangmin = s.SerializeObject<Angle>(genangmin, name: "genangmin");
				genangmax = s.SerializeObject<Angle>(genangmax, name: "genangmax");
				canFlipAngleOffset = s.Serialize<bool>(canFlipAngleOffset, name: "canFlipAngleOffset");
				canFlipInitAngle = s.Serialize<bool>(canFlipInitAngle, name: "canFlipInitAngle");
				canFlipAngularSpeed = s.Serialize<bool>(canFlipAngularSpeed, name: "canFlipAngularSpeed");
				canFlipPivot = s.Serialize<bool>(canFlipPivot, name: "canFlipPivot");
				canFlipUV = s.Serialize<bool>(canFlipUV, name: "canFlipUV");
				canFlipAngleMin = s.Serialize<bool>(canFlipAngleMin, name: "canFlipAngleMin");
				canFlipAngleMax = s.Serialize<bool>(canFlipAngleMax, name: "canFlipAngleMax");
				canFlipAccel = s.Serialize<bool>(canFlipAccel, name: "canFlipAccel");
				canFlipOrientDir = s.Serialize<bool>(canFlipOrientDir, name: "canFlipOrientDir");
				numberSplit = s.Serialize<uint>(numberSplit, name: "numberSplit");
				splitDelta = s.SerializeObject<Angle>(splitDelta, name: "splitDelta");
				useMatrix2 = s.Serialize<int>(useMatrix2, name: "useMatrix");
				usePhasesColorAndSize = s.Serialize<bool>(usePhasesColorAndSize, name: "usePhasesColorAndSize");
				useActorTranslation = s.Serialize<bool>(useActorTranslation, name: "useActorTranslation");
				actorTranslationOffset = s.SerializeObject<Vec2d>(actorTranslationOffset, name: "actorTranslationOffset");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight");
				phases = s.SerializeObject<CListO<ParPhase>>(phases, name: "phases");
				blendMode = s.Serialize<GFX_BLEND>(blendMode, name: "blendMode");
				genGenType2 = s.Serialize<PARGEN_GEN2>(genGenType2, name: "genGenType");
				genMode = s.Serialize<PARGEN_MODE>(genMode, name: "genMode");
			} else if (s.Settings.game == Settings.Game.RL) {
				maxParticles = s.Serialize<uint>(maxParticles, name: "maxParticles");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				emitParticlesCount = s.Serialize<uint>(emitParticlesCount, name: "emitParticlesCount");
				forceNoDynamicFog = s.Serialize<bool>(forceNoDynamicFog, name: "forceNoDynamicFog");
				renderInReflection = s.Serialize<bool>(renderInReflection, name: "renderInReflection");
				dieFadeTime = s.Serialize<float>(dieFadeTime, name: "dieFadeTime");
				emitterMaxLifeTime = s.Serialize<float>(emitterMaxLifeTime, name: "emitterMaxLifeTime");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				pivot = s.SerializeObject<Vec2d>(pivot, name: "pivot");
				velNorm = s.Serialize<float>(velNorm, name: "velNorm");
				velAngle = s.Serialize<float>(velAngle, name: "velAngle");
				velAngleDelta = s.Serialize<float>(velAngleDelta, name: "velAngleDelta");
				grav = s.SerializeObject<Vec3d>(grav, name: "grav");
				acc = s.SerializeObject<Vec3d>(acc, name: "acc");
				depth = s.Serialize<float>(depth, name: "depth");
				useZAsDepth = s.Serialize<bool>(useZAsDepth, name: "useZAsDepth");
				velocityVar = s.Serialize<float>(velocityVar, name: "velocityVar");
				friction = s.Serialize<float>(friction, name: "friction");
				freq = s.Serialize<float>(freq, name: "freq");
				freqDelta = s.Serialize<float>(freqDelta, name: "freqDelta");
				forceEmitAtStart_int = s.Serialize<int>(forceEmitAtStart_int, name: "forceEmitAtStart");
				emitBatchCount = s.Serialize<uint>(emitBatchCount, name: "emitBatchCount");
				emitBatchCount_AAO = s.Serialize<uint>(emitBatchCount_AAO, name: "emitBatchCount_AAO");
				initAngle = s.SerializeObject<Angle>(initAngle, name: "initAngle");
				angleDelta = s.SerializeObject<Angle>(angleDelta, name: "angleDelta");
				angularSpeed = s.SerializeObject<Angle>(angularSpeed, name: "angularSpeed");
				angularSpeedDelta = s.SerializeObject<Angle>(angularSpeedDelta, name: "angularSpeedDelta");
				timeTarget = s.Serialize<float>(timeTarget, name: "timeTarget");
				nbPhase = s.Serialize<uint>(nbPhase, name: "nbPhase");
				renderPrio = s.Serialize<float>(renderPrio, name: "renderPrio");
				initLifeTime = s.Serialize<float>(initLifeTime, name: "initLifeTime");
				circleRadius = s.Serialize<float>(circleRadius, name: "circleRadius");
				innerCircleRadius = s.Serialize<float>(innerCircleRadius, name: "innerCircleRadius");
				scaleShape = s.SerializeObject<Vec3d>(scaleShape, name: "scaleShape");
				rotateShape = s.SerializeObject<Vec3d>(rotateShape, name: "rotateShape");
				randomizeDirection = s.Serialize<bool>(randomizeDirection, name: "randomizeDirection");
				followBezier = s.Serialize<int>(followBezier, name: "followBezier");
				getAtlasSize = s.Serialize<bool>(getAtlasSize, name: "getAtlasSize");
				genBox = s.SerializeObject<AABB>(genBox, name: "genBox");
				GenSize = s.Serialize<float>(GenSize, name: "GenSize");
				GenSide = s.Serialize<uint>(GenSide, name: "GenSide");
				GenPosMin = s.Serialize<float>(GenPosMin, name: "GenPosMin");
				GenPosMax = s.Serialize<float>(GenPosMax, name: "GenPosMax");
				GenDensity = s.Serialize<float>(GenDensity, name: "GenDensity");
				boundingBox = s.SerializeObject<AABB>(boundingBox, name: "boundingBox");
				orientDir = s.Serialize<uint>(orientDir, name: "orientDir");
				UVmode = s.Serialize<UV>(UVmode, name: "UVmode");
				uniformscale = s.Serialize<float>(uniformscale, name: "uniformscale");
				impostorrendering = s.Serialize<bool>(impostorrendering, name: "impostorrendering");
				showimpostorrender = s.Serialize<bool>(showimpostorrender, name: "showimpostorrender");
				impostorTextureSizeX = s.Serialize<uint>(impostorTextureSizeX, name: "impostorTextureSizeX");
				impostorTextureSizeY = s.Serialize<uint>(impostorTextureSizeY, name: "impostorTextureSizeY");
				genangmin = s.SerializeObject<Angle>(genangmin, name: "genangmin");
				genangmax = s.SerializeObject<Angle>(genangmax, name: "genangmax");
				canFlipAngleOffset = s.Serialize<bool>(canFlipAngleOffset, name: "canFlipAngleOffset");
				canFlipInitAngle = s.Serialize<bool>(canFlipInitAngle, name: "canFlipInitAngle");
				canFlipAngularSpeed = s.Serialize<bool>(canFlipAngularSpeed, name: "canFlipAngularSpeed");
				canFlipPivot = s.Serialize<bool>(canFlipPivot, name: "canFlipPivot");
				canFlipPos = s.Serialize<bool>(canFlipPos, name: "canFlipPos");
				canFlipUV = s.Serialize<bool>(canFlipUV, name: "canFlipUV");
				canFlipAngleMin = s.Serialize<bool>(canFlipAngleMin, name: "canFlipAngleMin");
				canFlipAngleMax = s.Serialize<bool>(canFlipAngleMax, name: "canFlipAngleMax");
				canFlipAccel = s.Serialize<bool>(canFlipAccel, name: "canFlipAccel");
				canFlipOrientDir = s.Serialize<bool>(canFlipOrientDir, name: "canFlipOrientDir");
				numberSplit = s.Serialize<uint>(numberSplit, name: "numberSplit");
				splitDelta = s.SerializeObject<Angle>(splitDelta, name: "splitDelta");
				useMatrix = s.Serialize<BOOL>(useMatrix, name: "useMatrix");
				usePhasesColorAndSize = s.Serialize<bool>(usePhasesColorAndSize, name: "usePhasesColorAndSize");
				useActorTranslation = s.Serialize<bool>(useActorTranslation, name: "useActorTranslation");
				actorTranslationOffset = s.SerializeObject<Vec2d>(actorTranslationOffset, name: "actorTranslationOffset");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight");
				phases = s.SerializeObject<CListO<ParPhase>>(phases, name: "phases");
				curveSize = s.SerializeObject<ParLifeTimeCurve>(curveSize, name: "curveSize");
				curveSizeY = s.SerializeObject<ParLifeTimeCurve>(curveSizeY, name: "curveSizeY");
				curveAlpha = s.SerializeObject<ParLifeTimeCurve>(curveAlpha, name: "curveAlpha");
				curveRGB = s.SerializeObject<ParLifeTimeCurve>(curveRGB, name: "curveRGB");
				curveRGB1 = s.SerializeObject<ParLifeTimeCurve>(curveRGB1, name: "curveRGB1");
				curveRGB2 = s.SerializeObject<ParLifeTimeCurve>(curveRGB2, name: "curveRGB2");
				curveRGB3 = s.SerializeObject<ParLifeTimeCurve>(curveRGB3, name: "curveRGB3");
				curveAnim = s.SerializeObject<ParLifeTimeCurve>(curveAnim, name: "curveAnim");
				parEmitVelocity = s.SerializeObject<EmitLifeTimeCurve>(parEmitVelocity, name: "parEmitVelocity");
				parEmitVelocityAngle = s.SerializeObject<EmitLifeTimeCurve>(parEmitVelocityAngle, name: "parEmitVelocityAngle");
				parEmitAngle = s.SerializeObject<EmitLifeTimeCurve>(parEmitAngle, name: "parEmitAngle");
				parEmitAngularSpeed = s.SerializeObject<EmitLifeTimeCurve>(parEmitAngularSpeed, name: "parEmitAngularSpeed");
				curveFreq = s.SerializeObject<EmitLifeTimeCurve>(curveFreq, name: "curveFreq");
				curveParLifeTime = s.SerializeObject<EmitLifeTimeCurve>(curveParLifeTime, name: "curveParLifeTime");
				curveEmitAlpha = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAlpha, name: "curveEmitAlpha");
				curveEmitColorFactor = s.SerializeObject<EmitLifeTimeCurve>(curveEmitColorFactor, name: "curveEmitColorFactor");
				curveEmitSizeXY = s.SerializeObject<EmitLifeTimeCurve>(curveEmitSizeXY, name: "curveEmitSizeXY");
				curveEmitAcceleration = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAcceleration, name: "curveEmitAcceleration");
				curveEmitGravity = s.SerializeObject<EmitLifeTimeCurve>(curveEmitGravity, name: "curveEmitGravity");
				genGenType = s.Serialize<PARGEN_GEN>(genGenType, name: "genGenType");
				genMode = s.Serialize<PARGEN_MODE>(genMode, name: "genMode");
				genEmitMode = s.Serialize<PARGEN_EMITMODE>(genEmitMode, name: "genEmitMode");
			} else if (s.Settings.game == Settings.Game.VH) {
				maxParticles = s.Serialize<uint>(maxParticles, name: "maxParticles");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				emitParticlesCount = s.Serialize<uint>(emitParticlesCount, name: "emitParticlesCount");
				forceNoDynamicFog = s.Serialize<bool>(forceNoDynamicFog, name: "forceNoDynamicFog");
				renderInReflection = s.Serialize<bool>(renderInReflection, name: "renderInReflection");
				dieFadeTime = s.Serialize<float>(dieFadeTime, name: "dieFadeTime");
				emitterMaxLifeTime = s.Serialize<float>(emitterMaxLifeTime, name: "emitterMaxLifeTime");
				behaviorOnEnd = s.Serialize<OnEnd>(behaviorOnEnd, name: "behaviorOnEnd");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				pivot = s.SerializeObject<Vec2d>(pivot, name: "pivot");
				velNorm = s.Serialize<float>(velNorm, name: "velNorm");
				velAngle = s.Serialize<float>(velAngle, name: "velAngle");
				velAngleDelta = s.Serialize<float>(velAngleDelta, name: "velAngleDelta");
				grav = s.SerializeObject<Vec3d>(grav, name: "grav");
				acc = s.SerializeObject<Vec3d>(acc, name: "acc");
				depth = s.Serialize<float>(depth, name: "depth");
				useZAsDepth = s.Serialize<bool>(useZAsDepth, name: "useZAsDepth");
				velocityVar = s.Serialize<float>(velocityVar, name: "velocityVar");
				friction = s.Serialize<float>(friction, name: "friction");
				freq = s.Serialize<float>(freq, name: "freq");
				freqDelta = s.Serialize<float>(freqDelta, name: "freqDelta");
				forceEmitAtStart = s.Serialize<bool>(forceEmitAtStart, name: "forceEmitAtStart");
				emitBatchCount = s.Serialize<uint>(emitBatchCount, name: "emitBatchCount");
				emitBatchCount_AAO = s.Serialize<uint>(emitBatchCount_AAO, name: "emitBatchCount_AAO");
				emitBatchCount_AAO_max = s.Serialize<uint>(emitBatchCount_AAO_max, name: "emitBatchCount_AAO_max");
				initAngle = s.SerializeObject<Angle>(initAngle, name: "initAngle");
				angleDelta = s.SerializeObject<Angle>(angleDelta, name: "angleDelta");
				angularSpeed = s.SerializeObject<Angle>(angularSpeed, name: "angularSpeed");
				angularSpeedDelta = s.SerializeObject<Angle>(angularSpeedDelta, name: "angularSpeedDelta");
				timeTarget = s.Serialize<float>(timeTarget, name: "timeTarget");
				nbPhase = s.Serialize<uint>(nbPhase, name: "nbPhase");
				renderPrio = s.Serialize<float>(renderPrio, name: "renderPrio");
				initLifeTime = s.Serialize<float>(initLifeTime, name: "initLifeTime");
				circleRadius = s.Serialize<float>(circleRadius, name: "circleRadius");
				innerCircleRadius = s.Serialize<float>(innerCircleRadius, name: "innerCircleRadius");
				scaleShape = s.SerializeObject<Vec3d>(scaleShape, name: "scaleShape");
				rotateShape = s.SerializeObject<Vec3d>(rotateShape, name: "rotateShape");
				randomizeDirection = s.Serialize<bool>(randomizeDirection, name: "randomizeDirection");
				followBezier = s.Serialize<int>(followBezier, name: "followBezier");
				getAtlasSize = s.Serialize<bool>(getAtlasSize, name: "getAtlasSize");
				continuousColorRandom = s.Serialize<bool>(continuousColorRandom, name: "continuousColorRandom");
				genBox = s.SerializeObject<AABB>(genBox, name: "genBox");
				GenSize = s.Serialize<float>(GenSize, name: "GenSize");
				GenSide = s.Serialize<uint>(GenSide, name: "GenSide");
				GenPosMin = s.Serialize<float>(GenPosMin, name: "GenPosMin");
				GenPosMax = s.Serialize<float>(GenPosMax, name: "GenPosMax");
				GenDensity = s.Serialize<float>(GenDensity, name: "GenDensity");
				boundingBox = s.SerializeObject<AABB>(boundingBox, name: "boundingBox");
				orientDir = s.Serialize<uint>(orientDir, name: "orientDir");
				UVmode = s.Serialize<UV>(UVmode, name: "UVmode");
				UVmodeFlag = s.Serialize<UVF>(UVmodeFlag, name: "UVmodeFlag");
				uniformscale = s.Serialize<float>(uniformscale, name: "uniformscale");
				genangmin = s.SerializeObject<Angle>(genangmin, name: "genangmin");
				genangmax = s.SerializeObject<Angle>(genangmax, name: "genangmax");
				useYMin = s.Serialize<bool>(useYMin, name: "useYMin");
				useYMinLocal = s.Serialize<bool>(useYMinLocal, name: "useYMinLocal");
				yMin = s.Serialize<float>(yMin, name: "yMin");
				yMinBouncinessMin = s.Serialize<float>(yMinBouncinessMin, name: "yMinBouncinessMin");
				yMinBouncinessMax = s.Serialize<float>(yMinBouncinessMax, name: "yMinBouncinessMax");
				yMinMinRebounds = s.Serialize<uint>(yMinMinRebounds, name: "yMinMinRebounds");
				yMinMaxRebounds = s.Serialize<uint>(yMinMaxRebounds, name: "yMinMaxRebounds");
				yMinKillAfterMaxRebounds = s.Serialize<bool>(yMinKillAfterMaxRebounds, name: "yMinKillAfterMaxRebounds");
				bouncinessAffectsXSpeed = s.Serialize<bool>(bouncinessAffectsXSpeed, name: "bouncinessAffectsXSpeed");
				bouncinessAffectsAngularSpeed = s.Serialize<bool>(bouncinessAffectsAngularSpeed, name: "bouncinessAffectsAngularSpeed");
				canFlipAngleOffset = s.Serialize<bool>(canFlipAngleOffset, name: "canFlipAngleOffset");
				canFlipInitAngle = s.Serialize<bool>(canFlipInitAngle, name: "canFlipInitAngle");
				canFlipAngularSpeed = s.Serialize<bool>(canFlipAngularSpeed, name: "canFlipAngularSpeed");
				canFlipPivot = s.Serialize<bool>(canFlipPivot, name: "canFlipPivot");
				canFlipPos = s.Serialize<bool>(canFlipPos, name: "canFlipPos");
				canFlipUV = s.Serialize<bool>(canFlipUV, name: "canFlipUV");
				canFlipAngleMin = s.Serialize<bool>(canFlipAngleMin, name: "canFlipAngleMin");
				canFlipAngleMax = s.Serialize<bool>(canFlipAngleMax, name: "canFlipAngleMax");
				canFlipAccel = s.Serialize<bool>(canFlipAccel, name: "canFlipAccel");
				canFlipOrientDir = s.Serialize<bool>(canFlipOrientDir, name: "canFlipOrientDir");
				numberSplit = s.Serialize<uint>(numberSplit, name: "numberSplit");
				splitDelta = s.SerializeObject<Angle>(splitDelta, name: "splitDelta");
				useMatrix = s.Serialize<BOOL>(useMatrix, name: "useMatrix");
				scaleGenBox2 = s.Serialize<BOOL2>(scaleGenBox2, name: "scaleGenBox");
				usePhasesColorAndSize = s.Serialize<bool>(usePhasesColorAndSize, name: "usePhasesColorAndSize");
				useActorTranslation = s.Serialize<bool>(useActorTranslation, name: "useActorTranslation");
				actorTranslationOffset = s.SerializeObject<Vec2d>(actorTranslationOffset, name: "actorTranslationOffset");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight");
				phases = s.SerializeObject<CListO<ParPhase>>(phases, name: "phases");
				curvePosition = s.SerializeObject<ParLifeTimeCurve>(curvePosition, name: "curvePosition");
				curveAngle = s.SerializeObject<ParLifeTimeCurve>(curveAngle, name: "curveAngle");
				curveAngularSpeed = s.SerializeObject<ParLifeTimeCurve>(curveAngularSpeed, name: "curveAngularSpeed");
				curveVelocityMult = s.SerializeObject<ParLifeTimeCurve>(curveVelocityMult, name: "curveVelocityMult");
				curveAccelX = s.SerializeObject<ParLifeTimeCurve>(curveAccelX, name: "curveAccelX");
				curveAccelY = s.SerializeObject<ParLifeTimeCurve>(curveAccelY, name: "curveAccelY");
				curveAccelZ = s.SerializeObject<ParLifeTimeCurve>(curveAccelZ, name: "curveAccelZ");
				curveSize = s.SerializeObject<ParLifeTimeCurve>(curveSize, name: "curveSize");
				curveSizeY = s.SerializeObject<ParLifeTimeCurve>(curveSizeY, name: "curveSizeY");
				curveAlpha = s.SerializeObject<ParLifeTimeCurve>(curveAlpha, name: "curveAlpha");
				curveRGB = s.SerializeObject<ParLifeTimeCurve>(curveRGB, name: "curveRGB");
				curveRGB1 = s.SerializeObject<ParLifeTimeCurve>(curveRGB1, name: "curveRGB1");
				curveRGB2 = s.SerializeObject<ParLifeTimeCurve>(curveRGB2, name: "curveRGB2");
				curveRGB3 = s.SerializeObject<ParLifeTimeCurve>(curveRGB3, name: "curveRGB3");
				curveAnim = s.SerializeObject<ParLifeTimeCurve>(curveAnim, name: "curveAnim");
				parEmitVelocity = s.SerializeObject<EmitLifeTimeCurve>(parEmitVelocity, name: "parEmitVelocity");
				parEmitVelocityAngle = s.SerializeObject<EmitLifeTimeCurve>(parEmitVelocityAngle, name: "parEmitVelocityAngle");
				parEmitAngle = s.SerializeObject<EmitLifeTimeCurve>(parEmitAngle, name: "parEmitAngle");
				parEmitAngularSpeed = s.SerializeObject<EmitLifeTimeCurve>(parEmitAngularSpeed, name: "parEmitAngularSpeed");
				curveFreq = s.SerializeObject<EmitLifeTimeCurve>(curveFreq, name: "curveFreq");
				curveParLifeTime = s.SerializeObject<EmitLifeTimeCurve>(curveParLifeTime, name: "curveParLifeTime");
				curveEmitAlpha = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAlpha, name: "curveEmitAlpha");
				curveEmitAlphaInit = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAlphaInit, name: "curveEmitAlphaInit");
				curveEmitColorFactor = s.SerializeObject<EmitLifeTimeCurve>(curveEmitColorFactor, name: "curveEmitColorFactor");
				curveEmitColorFactorInit = s.SerializeObject<EmitLifeTimeCurve>(curveEmitColorFactorInit, name: "curveEmitColorFactorInit");
				curveEmitSizeXY = s.SerializeObject<EmitLifeTimeCurve>(curveEmitSizeXY, name: "curveEmitSizeXY");
				curveEmitSizeXYInit = s.SerializeObject<EmitLifeTimeCurve>(curveEmitSizeXYInit, name: "curveEmitSizeXYInit");
				curveEmitAcceleration = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAcceleration, name: "curveEmitAcceleration");
				curveEmitGravity = s.SerializeObject<EmitLifeTimeCurve>(curveEmitGravity, name: "curveEmitGravity");
				curveEmitAnim = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAnim, name: "curveEmitAnim");
				genGenType = s.Serialize<PARGEN_GEN>(genGenType, name: "genGenType");
				genMode = s.Serialize<PARGEN_MODE>(genMode, name: "genMode");
				genEmitMode = s.Serialize<PARGEN_EMITMODE>(genEmitMode, name: "genEmitMode");
			} else if(s.Settings.game == Settings.Game.COL) {
				maxParticles = s.Serialize<uint>(maxParticles, name: "maxParticles");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				emitParticlesCount = s.Serialize<uint>(emitParticlesCount, name: "emitParticlesCount");
				forceNoDynamicFog = s.Serialize<bool>(forceNoDynamicFog, name: "forceNoDynamicFog", options: CSerializerObject.Options.BoolAsByte);
				renderInReflection = s.Serialize<bool>(renderInReflection, name: "renderInReflection", options: CSerializerObject.Options.BoolAsByte);
				dieFadeTime = s.Serialize<float>(dieFadeTime, name: "dieFadeTime");
				emitterMaxLifeTime = s.Serialize<float>(emitterMaxLifeTime, name: "emitterMaxLifeTime");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				pivot = s.SerializeObject<Vec2d>(pivot, name: "pivot");
				velNorm = s.Serialize<float>(velNorm, name: "velNorm");
				velAngle = s.Serialize<float>(velAngle, name: "velAngle");
				velAngleDelta = s.Serialize<float>(velAngleDelta, name: "velAngleDelta");
				grav = s.SerializeObject<Vec3d>(grav, name: "grav");
				acc = s.SerializeObject<Vec3d>(acc, name: "acc");
				depth = s.Serialize<float>(depth, name: "depth");
				useZAsDepth = s.Serialize<bool>(useZAsDepth, name: "useZAsDepth", options: CSerializerObject.Options.BoolAsByte);
				velocityVar = s.Serialize<float>(velocityVar, name: "velocityVar");
				friction = s.Serialize<float>(friction, name: "friction");
				fluidInfluenceScale = s.Serialize<float>(fluidInfluenceScale, name: "fluidInfluenceScale");
				fluidRotate = s.Serialize<float>(fluidRotate, name: "fluidRotate");
				pushFluidRadius = s.Serialize<float>(pushFluidRadius, name: "pushFluidRadius");
				pushFluidScale = s.Serialize<float>(pushFluidScale, name: "pushFluidScale");
				pushFluidRadiusHair = s.Serialize<float>(pushFluidRadiusHair, name: "pushFluidRadiusHair");
				pushFluidScaleHair = s.Serialize<float>(pushFluidScaleHair, name: "pushFluidScaleHair");
				freq = s.Serialize<float>(freq, name: "freq");
				freqDelta = s.Serialize<float>(freqDelta, name: "freqDelta");
				forceEmitAtStart = s.Serialize<bool>(forceEmitAtStart, name: "forceEmitAtStart", options: CSerializerObject.Options.BoolAsByte);
				emitBatchCount = s.Serialize<uint>(emitBatchCount, name: "emitBatchCount");
				emitBatchCount_AAO = s.Serialize<uint>(emitBatchCount_AAO, name: "emitBatchCount_AAO");
				emitBatchCount_AAO_max = s.Serialize<uint>(emitBatchCount_AAO_max, name: "emitBatchCount_AAO_max");
				initAngle = s.SerializeObject<Angle>(initAngle, name: "initAngle");
				angleDelta = s.SerializeObject<Angle>(angleDelta, name: "angleDelta");
				angularSpeed = s.SerializeObject<Angle>(angularSpeed, name: "angularSpeed");
				angularSpeedDelta = s.SerializeObject<Angle>(angularSpeedDelta, name: "angularSpeedDelta");
				timeTarget = s.Serialize<float>(timeTarget, name: "timeTarget");
				nbPhase = s.Serialize<uint>(nbPhase, name: "nbPhase");
				renderPrio = s.Serialize<float>(renderPrio, name: "renderPrio");
				initLifeTime = s.Serialize<float>(initLifeTime, name: "initLifeTime");
				circleRadius = s.Serialize<float>(circleRadius, name: "circleRadius");
				innerCircleRadius = s.Serialize<float>(innerCircleRadius, name: "innerCircleRadius");
				scaleShape = s.SerializeObject<Vec3d>(scaleShape, name: "scaleShape");
				rotateShape = s.SerializeObject<Vec3d>(rotateShape, name: "rotateShape");
				randomizeDirection = s.Serialize<bool>(randomizeDirection, name: "randomizeDirection", options: CSerializerObject.Options.BoolAsByte);
				followBezier = s.Serialize<int>(followBezier, name: "followBezier");
				getAtlasSize = s.Serialize<bool>(getAtlasSize, name: "getAtlasSize", options: CSerializerObject.Options.BoolAsByte);
				genBox = s.SerializeObject<AABB>(genBox, name: "genBox");
				GenSize = s.Serialize<float>(GenSize, name: "GenSize");
				GenSide = s.Serialize<uint>(GenSide, name: "GenSide");
				GenPosMin = s.Serialize<float>(GenPosMin, name: "GenPosMin");
				GenPosMax = s.Serialize<float>(GenPosMax, name: "GenPosMax");
				GenDensity = s.Serialize<float>(GenDensity, name: "GenDensity");
				boundingBox = s.SerializeObject<AABB>(boundingBox, name: "boundingBox");
				orientDir = s.Serialize<uint>(orientDir, name: "orientDir");
				UVmode = s.Serialize<UV>(UVmode, name: "UVmode");
				UVmodeFlag = s.Serialize<UVF>(UVmodeFlag, name: "UVmodeFlag");
				uniformscale = s.Serialize<float>(uniformscale, name: "uniformscale");
				impostorrendering = s.Serialize<bool>(impostorrendering, name: "impostorrendering", options: CSerializerObject.Options.BoolAsByte);
				showimpostorrender = s.Serialize<bool>(showimpostorrender, name: "showimpostorrender", options: CSerializerObject.Options.BoolAsByte);
				impostorTextureSizeX = s.Serialize<uint>(impostorTextureSizeX, name: "impostorTextureSizeX");
				impostorTextureSizeY = s.Serialize<uint>(impostorTextureSizeY, name: "impostorTextureSizeY");
				genangmin = s.SerializeObject<Angle>(genangmin, name: "genangmin");
				genangmax = s.SerializeObject<Angle>(genangmax, name: "genangmax");
				canFlipAngleOffset = s.Serialize<bool>(canFlipAngleOffset, name: "canFlipAngleOffset", options: CSerializerObject.Options.BoolAsByte);
				canFlipInitAngle = s.Serialize<bool>(canFlipInitAngle, name: "canFlipInitAngle", options: CSerializerObject.Options.BoolAsByte);
				canFlipAngularSpeed = s.Serialize<bool>(canFlipAngularSpeed, name: "canFlipAngularSpeed", options: CSerializerObject.Options.BoolAsByte);
				canFlipPivot = s.Serialize<bool>(canFlipPivot, name: "canFlipPivot", options: CSerializerObject.Options.BoolAsByte);
				canFlipPos = s.Serialize<bool>(canFlipPos, name: "canFlipPos", options: CSerializerObject.Options.BoolAsByte);
				canFlipUV = s.Serialize<bool>(canFlipUV, name: "canFlipUV", options: CSerializerObject.Options.BoolAsByte);
				canFlipAngleMin = s.Serialize<bool>(canFlipAngleMin, name: "canFlipAngleMin", options: CSerializerObject.Options.BoolAsByte);
				canFlipAngleMax = s.Serialize<bool>(canFlipAngleMax, name: "canFlipAngleMax", options: CSerializerObject.Options.BoolAsByte);
				canFlipAccel = s.Serialize<bool>(canFlipAccel, name: "canFlipAccel", options: CSerializerObject.Options.BoolAsByte);
				canFlipOrientDir = s.Serialize<bool>(canFlipOrientDir, name: "canFlipOrientDir", options: CSerializerObject.Options.BoolAsByte);
				numberSplit = s.Serialize<uint>(numberSplit, name: "numberSplit");
				splitDelta = s.SerializeObject<Angle>(splitDelta, name: "splitDelta");
				useMatrix = s.Serialize<BOOL>(useMatrix, name: "useMatrix");
				useMatrixRotation = s.Serialize<BOOL>(useMatrixRotation, name: "useMatrixRotation");
				useMatrixScale = s.Serialize<BOOL>(useMatrixScale, name: "useMatrixScale");
				usePhasesColorAndSize = s.Serialize<bool>(usePhasesColorAndSize, name: "usePhasesColorAndSize", options: CSerializerObject.Options.BoolAsByte);
				useActorTranslation = s.Serialize<bool>(useActorTranslation, name: "useActorTranslation", options: CSerializerObject.Options.BoolAsByte);
				actorTranslationOffset = s.SerializeObject<Vec2d>(actorTranslationOffset, name: "actorTranslationOffset");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight", options: CSerializerObject.Options.BoolAsByte);
				enableRemapAlpha = s.Serialize<bool>(enableRemapAlpha, name: "enableRemapAlpha", options: CSerializerObject.Options.BoolAsByte);
				phases = s.SerializeObject<CListO<ParPhase>>(phases, name: "phases");
				curvePosition = s.SerializeObject<ParLifeTimeCurve>(curvePosition, name: "curvePosition");
				curveAngle = s.SerializeObject<ParLifeTimeCurve>(curveAngle, name: "curveAngle");
				curveVelocityMult = s.SerializeObject<ParLifeTimeCurve>(curveVelocityMult, name: "curveVelocityMult");
				curveAccelX = s.SerializeObject<ParLifeTimeCurve>(curveAccelX, name: "curveAccelX");
				curveAccelY = s.SerializeObject<ParLifeTimeCurve>(curveAccelY, name: "curveAccelY");
				curveAccelZ = s.SerializeObject<ParLifeTimeCurve>(curveAccelZ, name: "curveAccelZ");
				curveSize = s.SerializeObject<ParLifeTimeCurve>(curveSize, name: "curveSize");
				curveSizeY = s.SerializeObject<ParLifeTimeCurve>(curveSizeY, name: "curveSizeY");
				curveAlpha = s.SerializeObject<ParLifeTimeCurve>(curveAlpha, name: "curveAlpha");
				curveRGB = s.SerializeObject<ParLifeTimeCurve>(curveRGB, name: "curveRGB");
				curveRGB1 = s.SerializeObject<ParLifeTimeCurve>(curveRGB1, name: "curveRGB1");
				curveRGB2 = s.SerializeObject<ParLifeTimeCurve>(curveRGB2, name: "curveRGB2");
				curveRGB3 = s.SerializeObject<ParLifeTimeCurve>(curveRGB3, name: "curveRGB3");
				curveAnim = s.SerializeObject<ParLifeTimeCurve>(curveAnim, name: "curveAnim");
				parEmitVelocity = s.SerializeObject<EmitLifeTimeCurve>(parEmitVelocity, name: "parEmitVelocity");
				parEmitVelocityAngle = s.SerializeObject<EmitLifeTimeCurve>(parEmitVelocityAngle, name: "parEmitVelocityAngle");
				parEmitAngle = s.SerializeObject<EmitLifeTimeCurve>(parEmitAngle, name: "parEmitAngle");
				parEmitAngularSpeed = s.SerializeObject<EmitLifeTimeCurve>(parEmitAngularSpeed, name: "parEmitAngularSpeed");
				curveFreq = s.SerializeObject<EmitLifeTimeCurve>(curveFreq, name: "curveFreq");
				curveParLifeTime = s.SerializeObject<EmitLifeTimeCurve>(curveParLifeTime, name: "curveParLifeTime");
				curveEmitAlpha = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAlpha, name: "curveEmitAlpha");
				curveEmitColorFactor = s.SerializeObject<EmitLifeTimeCurve>(curveEmitColorFactor, name: "curveEmitColorFactor");
				curveEmitSizeXY = s.SerializeObject<EmitLifeTimeCurve>(curveEmitSizeXY, name: "curveEmitSizeXY");
				curveEmitAcceleration = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAcceleration, name: "curveEmitAcceleration");
				curveEmitGravity = s.SerializeObject<EmitLifeTimeCurve>(curveEmitGravity, name: "curveEmitGravity");
				curveEmitAnim = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAnim, name: "curveEmitAnim");
				genGenType = s.Serialize<PARGEN_GEN>(genGenType, name: "genGenType");
				genMode = s.Serialize<PARGEN_MODE>(genMode, name: "genMode");
				genEmitMode = s.Serialize<PARGEN_EMITMODE>(genEmitMode, name: "genEmitMode");
			} else {
				maxParticles = s.Serialize<uint>(maxParticles, name: "maxParticles");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				emitParticlesCount = s.Serialize<uint>(emitParticlesCount, name: "emitParticlesCount");
				forceNoDynamicFog = s.Serialize<bool>(forceNoDynamicFog, name: "forceNoDynamicFog");
				renderInReflection = s.Serialize<bool>(renderInReflection, name: "renderInReflection");
				dieFadeTime = s.Serialize<float>(dieFadeTime, name: "dieFadeTime");
				emitterMaxLifeTime = s.Serialize<float>(emitterMaxLifeTime, name: "emitterMaxLifeTime");
				behaviorOnEnd = s.Serialize<OnEnd>(behaviorOnEnd, name: "behaviorOnEnd");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				pivot = s.SerializeObject<Vec2d>(pivot, name: "pivot");
				velNorm = s.Serialize<float>(velNorm, name: "velNorm");
				velAngle = s.Serialize<float>(velAngle, name: "velAngle");
				velAngleDelta = s.Serialize<float>(velAngleDelta, name: "velAngleDelta");
				grav = s.SerializeObject<Vec3d>(grav, name: "grav");
				acc = s.SerializeObject<Vec3d>(acc, name: "acc");
				depth = s.Serialize<float>(depth, name: "depth");
				useZAsDepth = s.Serialize<bool>(useZAsDepth, name: "useZAsDepth");
				velocityVar = s.Serialize<float>(velocityVar, name: "velocityVar");
				friction = s.Serialize<float>(friction, name: "friction");
				freq = s.Serialize<float>(freq, name: "freq");
				freqDelta = s.Serialize<float>(freqDelta, name: "freqDelta");
				forceEmitAtStart = s.Serialize<bool>(forceEmitAtStart, name: "forceEmitAtStart");
				emitBatchCount = s.Serialize<uint>(emitBatchCount, name: "emitBatchCount");
				emitBatchCount_AAO = s.Serialize<uint>(emitBatchCount_AAO, name: "emitBatchCount_AAO");
				emitBatchCount_AAO_max = s.Serialize<uint>(emitBatchCount_AAO_max, name: "emitBatchCount_AAO_max");
				initAngle = s.SerializeObject<Angle>(initAngle, name: "initAngle");
				angleDelta = s.SerializeObject<Angle>(angleDelta, name: "angleDelta");
				angularSpeed = s.SerializeObject<Angle>(angularSpeed, name: "angularSpeed");
				angularSpeedDelta = s.SerializeObject<Angle>(angularSpeedDelta, name: "angularSpeedDelta");
				timeTarget = s.Serialize<float>(timeTarget, name: "timeTarget");
				nbPhase = s.Serialize<uint>(nbPhase, name: "nbPhase");
				renderPrio = s.Serialize<float>(renderPrio, name: "renderPrio");
				initLifeTime = s.Serialize<float>(initLifeTime, name: "initLifeTime");
				circleRadius = s.Serialize<float>(circleRadius, name: "circleRadius");
				innerCircleRadius = s.Serialize<float>(innerCircleRadius, name: "innerCircleRadius");
				scaleShape = s.SerializeObject<Vec3d>(scaleShape, name: "scaleShape");
				rotateShape = s.SerializeObject<Vec3d>(rotateShape, name: "rotateShape");
				randomizeDirection = s.Serialize<bool>(randomizeDirection, name: "randomizeDirection");
				followBezier = s.Serialize<int>(followBezier, name: "followBezier");
				getAtlasSize = s.Serialize<bool>(getAtlasSize, name: "getAtlasSize");
				continuousColorRandom = s.Serialize<bool>(continuousColorRandom, name: "continuousColorRandom");
				genBox = s.SerializeObject<AABB>(genBox, name: "genBox");
				GenSize = s.Serialize<float>(GenSize, name: "GenSize");
				GenSide = s.Serialize<uint>(GenSide, name: "GenSide");
				GenPosMin = s.Serialize<float>(GenPosMin, name: "GenPosMin");
				GenPosMax = s.Serialize<float>(GenPosMax, name: "GenPosMax");
				GenDensity = s.Serialize<float>(GenDensity, name: "GenDensity");
				boundingBox = s.SerializeObject<AABB>(boundingBox, name: "boundingBox");
				orientDir = s.Serialize<uint>(orientDir, name: "orientDir");
				UVmode = s.Serialize<UV>(UVmode, name: "UVmode");
				UVmodeFlag = s.Serialize<UVF>(UVmodeFlag, name: "UVmodeFlag");
				uniformscale = s.Serialize<float>(uniformscale, name: "uniformscale");
				genangmin = s.SerializeObject<Angle>(genangmin, name: "genangmin");
				genangmax = s.SerializeObject<Angle>(genangmax, name: "genangmax");
				useYMin = s.Serialize<bool>(useYMin, name: "useYMin");
				useYMinLocal = s.Serialize<bool>(useYMinLocal, name: "useYMinLocal");
				yMin = s.Serialize<float>(yMin, name: "yMin");
				yMinBouncinessMin = s.Serialize<float>(yMinBouncinessMin, name: "yMinBouncinessMin");
				yMinBouncinessMax = s.Serialize<float>(yMinBouncinessMax, name: "yMinBouncinessMax");
				yMinMinRebounds = s.Serialize<uint>(yMinMinRebounds, name: "yMinMinRebounds");
				yMinMaxRebounds = s.Serialize<uint>(yMinMaxRebounds, name: "yMinMaxRebounds");
				yMinKillAfterMaxRebounds = s.Serialize<bool>(yMinKillAfterMaxRebounds, name: "yMinKillAfterMaxRebounds");
				bouncinessAffectsXSpeed = s.Serialize<bool>(bouncinessAffectsXSpeed, name: "bouncinessAffectsXSpeed");
				bouncinessAffectsAngularSpeed = s.Serialize<bool>(bouncinessAffectsAngularSpeed, name: "bouncinessAffectsAngularSpeed");
				useAttractors = s.Serialize<bool>(useAttractors, name: "useAttractors");
				attractorPowerDependsOnDistance = s.Serialize<bool>(attractorPowerDependsOnDistance, name: "attractorPowerDependsOnDistance");
				useAttractorMinDistance = s.Serialize<bool>(useAttractorMinDistance, name: "useAttractorMinDistance");
				attractorMinDistance = s.Serialize<float>(attractorMinDistance, name: "attractorMinDistance");
				attractorOffset = s.SerializeObject<Vec3d>(attractorOffset, name: "attractorOffset");
				useImpulseSpeed = s.Serialize<bool>(useImpulseSpeed, name: "useImpulseSpeed");
				canFlipAngleOffset = s.Serialize<bool>(canFlipAngleOffset, name: "canFlipAngleOffset");
				canFlipInitAngle = s.Serialize<bool>(canFlipInitAngle, name: "canFlipInitAngle");
				canFlipAngularSpeed = s.Serialize<bool>(canFlipAngularSpeed, name: "canFlipAngularSpeed");
				canFlipPivot = s.Serialize<bool>(canFlipPivot, name: "canFlipPivot");
				canFlipPos = s.Serialize<bool>(canFlipPos, name: "canFlipPos");
				canFlipUV = s.Serialize<bool>(canFlipUV, name: "canFlipUV");
				canFlipAngleMin = s.Serialize<bool>(canFlipAngleMin, name: "canFlipAngleMin");
				canFlipAngleMax = s.Serialize<bool>(canFlipAngleMax, name: "canFlipAngleMax");
				canFlipAccel = s.Serialize<bool>(canFlipAccel, name: "canFlipAccel");
				canFlipOrientDir = s.Serialize<bool>(canFlipOrientDir, name: "canFlipOrientDir");
				canFlipAttractorOffset = s.Serialize<bool>(canFlipAttractorOffset, name: "canFlipAttractorOffset");
				numberSplit = s.Serialize<uint>(numberSplit, name: "numberSplit");
				splitDelta = s.SerializeObject<Angle>(splitDelta, name: "splitDelta");
				useMatrix = s.Serialize<BOOL>(useMatrix, name: "useMatrix");
				scaleGenBox = s.Serialize<BOOL>(scaleGenBox, name: "scaleGenBox");
				usePhasesColorAndSize = s.Serialize<bool>(usePhasesColorAndSize, name: "usePhasesColorAndSize");
				useActorTranslation = s.Serialize<bool>(useActorTranslation, name: "useActorTranslation");
				actorTranslationOffset = s.SerializeObject<Vec2d>(actorTranslationOffset, name: "actorTranslationOffset");
				disableLight = s.Serialize<bool>(disableLight, name: "disableLight");
				phases = s.SerializeObject<CListO<ParPhase>>(phases, name: "phases");
				curvePosition = s.SerializeObject<ParLifeTimeCurve>(curvePosition, name: "curvePosition");
				curveAngle = s.SerializeObject<ParLifeTimeCurve>(curveAngle, name: "curveAngle");
				curveAngularSpeed = s.SerializeObject<ParLifeTimeCurve>(curveAngularSpeed, name: "curveAngularSpeed");
				curveVelocityMult = s.SerializeObject<ParLifeTimeCurve>(curveVelocityMult, name: "curveVelocityMult");
				curveAccelX = s.SerializeObject<ParLifeTimeCurve>(curveAccelX, name: "curveAccelX");
				curveAccelY = s.SerializeObject<ParLifeTimeCurve>(curveAccelY, name: "curveAccelY");
				curveAccelZ = s.SerializeObject<ParLifeTimeCurve>(curveAccelZ, name: "curveAccelZ");
				curveSize = s.SerializeObject<ParLifeTimeCurve>(curveSize, name: "curveSize");
				curveSizeY = s.SerializeObject<ParLifeTimeCurve>(curveSizeY, name: "curveSizeY");
				curveAlpha = s.SerializeObject<ParLifeTimeCurve>(curveAlpha, name: "curveAlpha");
				curveRGB = s.SerializeObject<ParLifeTimeCurve>(curveRGB, name: "curveRGB");
				curveRGB1 = s.SerializeObject<ParLifeTimeCurve>(curveRGB1, name: "curveRGB1");
				curveRGB2 = s.SerializeObject<ParLifeTimeCurve>(curveRGB2, name: "curveRGB2");
				curveRGB3 = s.SerializeObject<ParLifeTimeCurve>(curveRGB3, name: "curveRGB3");
				curveAnim = s.SerializeObject<ParLifeTimeCurve>(curveAnim, name: "curveAnim");
				curveAttractor = s.SerializeObject<ParLifeTimeCurve>(curveAttractor, name: "curveAttractor");
				parEmitVelocity = s.SerializeObject<EmitLifeTimeCurve>(parEmitVelocity, name: "parEmitVelocity");
				parEmitVelocityAngle = s.SerializeObject<EmitLifeTimeCurve>(parEmitVelocityAngle, name: "parEmitVelocityAngle");
				parEmitAngle = s.SerializeObject<EmitLifeTimeCurve>(parEmitAngle, name: "parEmitAngle");
				parEmitAngularSpeed = s.SerializeObject<EmitLifeTimeCurve>(parEmitAngularSpeed, name: "parEmitAngularSpeed");
				curveFreq = s.SerializeObject<EmitLifeTimeCurve>(curveFreq, name: "curveFreq");
				curveParLifeTime = s.SerializeObject<EmitLifeTimeCurve>(curveParLifeTime, name: "curveParLifeTime");
				curveEmitAlpha = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAlpha, name: "curveEmitAlpha");
				curveEmitAlphaInit = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAlphaInit, name: "curveEmitAlphaInit");
				curveEmitColorFactor = s.SerializeObject<EmitLifeTimeCurve>(curveEmitColorFactor, name: "curveEmitColorFactor");
				curveEmitColorFactorInit = s.SerializeObject<EmitLifeTimeCurve>(curveEmitColorFactorInit, name: "curveEmitColorFactorInit");
				curveEmitSizeXY = s.SerializeObject<EmitLifeTimeCurve>(curveEmitSizeXY, name: "curveEmitSizeXY");
				curveEmitSizeXYInit = s.SerializeObject<EmitLifeTimeCurve>(curveEmitSizeXYInit, name: "curveEmitSizeXYInit");
				curveEmitAcceleration = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAcceleration, name: "curveEmitAcceleration");
				curveEmitGravity = s.SerializeObject<EmitLifeTimeCurve>(curveEmitGravity, name: "curveEmitGravity");
				curveEmitAnim = s.SerializeObject<EmitLifeTimeCurve>(curveEmitAnim, name: "curveEmitAnim");
				genGenType = s.Serialize<PARGEN_GEN>(genGenType, name: "genGenType");
				genMode = s.Serialize<PARGEN_MODE>(genMode, name: "genMode");
				genEmitMode = s.Serialize<PARGEN_EMITMODE>(genEmitMode, name: "genEmitMode");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					GridFluidParam = s.SerializeObject<GFX_GridFluidObjParam>(GridFluidParam, name: "GridFluidParam");
				}
				PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
				UseGenPrimitiveParam = s.Serialize<bool>(UseGenPrimitiveParam, name: "UseGenPrimitiveParam");
			}
		}
		public enum OnEnd {
			[Serialize("OnEnd_Destroy")] Destroy = 0,
			[Serialize("OnEnd_Keep"   )] Keep = 1,
			[Serialize("OnEnd_Loop"   )] Loop = 2,
			[Serialize("OnEnd_Freeze" )] Freeze = 3,
		}
		public enum UV {
			[Serialize("UV_Default"      )] Default = 0,
			[Serialize("UV_FlipX"        )] FlipX = 1,
			[Serialize("UV_FlipY"        )] FlipY = 2,
			[Serialize("UV_FlipXY"       )] FlipXY = 3,
			[Serialize("UV_FlipXtoDirX"  )] FlipXtoDirX = 4,
			[Serialize("UV_FlipYtoDirY"  )] FlipYtoDirY = 5,
			[Serialize("UV_FlipXYtoDirXY")] FlipXYtoDirXY = 6,
		}
		[Flags]
		public enum UVF {
			[Serialize("UVF_Default"    )] Default = 0,
			[Serialize("UVF_FlipX"      )] FlipX = 1,
			[Serialize("UVF_FlipY"      )] FlipY = 2,
			[Serialize("UVF_FlipXtoDirX")] FlipXtoDirX = 4,
			[Serialize("UVF_FlipYtoDirY")] FlipYtoDirY = 8,
			[Serialize("UVF_FlipXRandom")] FlipXRandom = 16,
			[Serialize("UVF_FlipYRandom")] FlipYRandom = 32,
		}
		public enum BOOL {
			[Serialize("BOOL_false")] _false = 0,
			[Serialize("BOOL_true" )] _true = 1,
			[Serialize("BOOL_cond" )] cond = 2,
		}
		public enum BOOL2 {
			[Serialize("BOOL_false")] _false = 0,
			[Serialize("BOOL_true" )] _true = 1,
		}
		public enum PARGEN_GEN {
			[Serialize("PARGEN_GEN_POINTS"   )] POINTS = 0,
			[Serialize("PARGEN_GEN_RECTANGLE")] RECTANGLE = 1,
			[Serialize("PARGEN_GEN_CIRCLE"   )] CIRCLE = 2,
			[Serialize("PARGEN_GEN_BEZIER"   )] BEZIER = 3,
		}
		public enum PARGEN_MODE {
			[Serialize("PARGEN_MODE_FOLLOW" )] FOLLOW = 0,
			[Serialize("PARGEN_MODE_COMPLEX")] COMPLEX = 1,
		}
		public enum PARGEN_EMITMODE {
			[Serialize("PARGEN_EMITMODE_OVERTIME"    )] OVERTIME = 0,
			[Serialize("PARGEN_EMITMODE_ALLATONCE"   )] ALLATONCE = 1,
			[Serialize("PARGEN_EMITMODE_OVERDISTANCE")] OVERDISTANCE = 2,
		}

		public enum GFX_BLEND {
			[Serialize("GFX_BLEND_UNKNOWN"          )] UNKNOWN = 0,
			[Serialize("GFX_BLEND_COPY"             )] COPY = 1,
			[Serialize("GFX_BLEND_ALPHA"            )] ALPHA = 2,
			[Serialize("GFX_BLEND_ALPHAPREMULT"     )] ALPHAPREMULT = 3,
			[Serialize("GFX_BLEND_ALPHADEST"        )] ALPHADEST = 4,
			[Serialize("GFX_BLEND_ALPHADESTPREMULT" )] ALPHADESTPREMULT = 5,
			[Serialize("GFX_BLEND_ADD"              )] ADD = 6,
			[Serialize("GFX_BLEND_ADDALPHA"         )] ADDALPHA = 7,
			[Serialize("GFX_BLEND_SUBALPHA"         )] SUBALPHA = 8,
			[Serialize("GFX_BLEND_SUB"              )] SUB = 9,
			[Serialize("GFX_BLEND_MUL"              )] MUL = 10,
			[Serialize("GFX_BLEND_ALPHAMUL"         )] ALPHAMUL = 11,
			[Serialize("GFX_BLEND_IALPHAMUL"        )] IALPHAMUL = 12,
			[Serialize("GFX_BLEND_IALPHA"           )] IALPHA = 13,
			[Serialize("GFX_BLEND_IALPHAPREMULT"    )] IALPHAPREMULT = 14,
			[Serialize("GFX_BLEND_IALPHADEST"       )] IALPHADEST = 15,
			[Serialize("GFX_BLEND_IALPHADESTPREMULT")] IALPHADESTPREMULT = 16,
			[Serialize("GFX_BLEND_MUL2X"            )] MUL2X = 17,
			[Serialize("GFX_BLEND_NUMBER"           )] NUMBER = 21,
		}
		public enum PARGEN_GEN2 {
			[Serialize("PARGEN_GEN_POINTS"   )] POINTS = 0,
			[Serialize("PARGEN_GEN_RECTANGLE")] RECTANGLE = 1,
			[Serialize("PARGEN_GEN_CIRCLE"   )] CIRCLE = 2,
		}
	}
}

