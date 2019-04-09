using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ParticleGeneratorParameters : CSerializable {
		[Serialize("maxParticles"                   )] public uint maxParticles;
		[Serialize("defaultColor"                   )] public Color defaultColor;
		[Serialize("emitParticlesCount"             )] public uint emitParticlesCount;
		[Serialize("forceNoDynamicFog"              )] public bool forceNoDynamicFog;
		[Serialize("renderInReflection"             )] public bool renderInReflection;
		[Serialize("dieFadeTime"                    )] public float dieFadeTime;
		[Serialize("emitterMaxLifeTime"             )] public float emitterMaxLifeTime;
		[Serialize("behaviorOnEnd"                  )] public OnEnd behaviorOnEnd;
		[Serialize("pos"                            )] public Vector3 pos;
		[Serialize("pivot"                          )] public Vector2 pivot;
		[Serialize("velNorm"                        )] public float velNorm;
		[Serialize("velAngle"                       )] public float velAngle;
		[Serialize("velAngleDelta"                  )] public float velAngleDelta;
		[Serialize("grav"                           )] public Vector3 grav;
		[Serialize("acc"                            )] public Vector3 acc;
		[Serialize("depth"                          )] public float depth;
		[Serialize("useZAsDepth"                    )] public bool useZAsDepth;
		[Serialize("velocityVar"                    )] public float velocityVar;
		[Serialize("friction"                       )] public float friction;
		[Serialize("freq"                           )] public float freq;
		[Serialize("freqDelta"                      )] public float freqDelta;
		[Serialize("forceEmitAtStart"               )] public bool forceEmitAtStart;
		[Serialize("forceEmitAtStart"               )] public int forceEmitAtStart_int;
		[Serialize("emitBatchCount"                 )] public uint emitBatchCount;
		[Serialize("emitBatchCount_AAO"             )] public uint emitBatchCount_AAO;
		[Serialize("emitBatchCount_AAO_max"         )] public uint emitBatchCount_AAO_max;
		[Serialize("initAngle"                      )] public Angle initAngle;
		[Serialize("angleDelta"                     )] public Angle angleDelta;
		[Serialize("angularSpeed"                   )] public Angle angularSpeed;
		[Serialize("angularSpeedDelta"              )] public Angle angularSpeedDelta;
		[Serialize("timeTarget"                     )] public float timeTarget;
		[Serialize("nbPhase"                        )] public uint nbPhase;
		[Serialize("renderPrio"                     )] public float renderPrio;
		[Serialize("initLifeTime"                   )] public float initLifeTime;
		[Serialize("circleRadius"                   )] public float circleRadius;
		[Serialize("innerCircleRadius"              )] public float innerCircleRadius;
		[Serialize("scaleShape"                     )] public Vector3 scaleShape;
		[Serialize("rotateShape"                    )] public Vector3 rotateShape;
		[Serialize("randomizeDirection"             )] public bool randomizeDirection;
		[Serialize("followBezier"                   )] public int followBezier;
		[Serialize("getAtlasSize"                   )] public bool getAtlasSize;
		[Serialize("continuousColorRandom"          )] public bool continuousColorRandom;
		[Serialize("genBox"                         )] public AABB genBox;
		[Serialize("GenSize"                        )] public float GenSize;
		[Serialize("GenSide"                        )] public uint GenSide;
		[Serialize("GenPosMin"                      )] public float GenPosMin;
		[Serialize("GenPosMax"                      )] public float GenPosMax;
		[Serialize("GenDensity"                     )] public float GenDensity;
		[Serialize("boundingBox"                    )] public AABB boundingBox;
		[Serialize("orientDir"                      )] public uint orientDir;
		[Serialize("UVmode"                         )] public UV UVmode;
		[Serialize("UVmodeFlag"                     )] public UVF UVmodeFlag;
		[Serialize("uniformscale"                   )] public float uniformscale;
		[Serialize("genangmin"                      )] public Angle genangmin;
		[Serialize("genangmax"                      )] public Angle genangmax;
		[Serialize("useYMin"                        )] public bool useYMin;
		[Serialize("useYMinLocal"                   )] public bool useYMinLocal;
		[Serialize("yMin"                           )] public float yMin;
		[Serialize("yMinBouncinessMin"              )] public float yMinBouncinessMin;
		[Serialize("yMinBouncinessMax"              )] public float yMinBouncinessMax;
		[Serialize("yMinMinRebounds"                )] public uint yMinMinRebounds;
		[Serialize("yMinMaxRebounds"                )] public uint yMinMaxRebounds;
		[Serialize("yMinKillAfterMaxRebounds"       )] public bool yMinKillAfterMaxRebounds;
		[Serialize("bouncinessAffectsXSpeed"        )] public bool bouncinessAffectsXSpeed;
		[Serialize("bouncinessAffectsAngularSpeed"  )] public bool bouncinessAffectsAngularSpeed;
		[Serialize("useAttractors"                  )] public bool useAttractors;
		[Serialize("attractorPowerDependsOnDistance")] public bool attractorPowerDependsOnDistance;
		[Serialize("useAttractorMinDistance"        )] public bool useAttractorMinDistance;
		[Serialize("attractorMinDistance"           )] public float attractorMinDistance;
		[Serialize("attractorOffset"                )] public Vector3 attractorOffset;
		[Serialize("useImpulseSpeed"                )] public bool useImpulseSpeed;
		[Serialize("canFlipAngleOffset"             )] public bool canFlipAngleOffset;
		[Serialize("canFlipInitAngle"               )] public bool canFlipInitAngle;
		[Serialize("canFlipAngularSpeed"            )] public bool canFlipAngularSpeed;
		[Serialize("canFlipPivot"                   )] public bool canFlipPivot;
		[Serialize("canFlipPos"                     )] public bool canFlipPos;
		[Serialize("canFlipUV"                      )] public bool canFlipUV;
		[Serialize("canFlipAngleMin"                )] public bool canFlipAngleMin;
		[Serialize("canFlipAngleMax"                )] public bool canFlipAngleMax;
		[Serialize("canFlipAccel"                   )] public bool canFlipAccel;
		[Serialize("canFlipOrientDir"               )] public bool canFlipOrientDir;
		[Serialize("canFlipAttractorOffset"         )] public bool canFlipAttractorOffset;
		[Serialize("numberSplit"                    )] public uint numberSplit;
		[Serialize("splitDelta"                     )] public Angle splitDelta;
		[Serialize("useMatrix"                      )] public BOOL useMatrix;
		[Serialize("scaleGenBox"                    )] public BOOL scaleGenBox;
		[Serialize("scaleGenBox"                    )] public BOOL2 scaleGenBox2;
		[Serialize("usePhasesColorAndSize"          )] public bool usePhasesColorAndSize;
		[Serialize("useActorTranslation"            )] public bool useActorTranslation;
		[Serialize("actorTranslationOffset"         )] public Vector2 actorTranslationOffset;
		[Serialize("disableLight"                   )] public bool disableLight;
		[Serialize("phases"                         )] public CList<ParPhase> phases;

		[DisplayName("Position")]
		[SplineUsageMode(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.Y)]
		[SplineUsageModeExt(Spline.UsageMode.Z)]
		[SplineUsageModeExt(Spline.UsageMode.XYZ)]
		[Serialize("curvePosition"                  )] public ParLifeTimeCurve curvePosition;

		[DisplayName("Angle")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveAngle"                     )] public ParLifeTimeCurve curveAngle;
		[Serialize("curveAngularSpeed"              )] public ParLifeTimeCurve curveAngularSpeed;

		[DisplayName("Velocity (mult.)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveVelocityMult"              )] public ParLifeTimeCurve curveVelocityMult;

		[DisplayName("Acceleration (X)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveAccelX"                    )] public ParLifeTimeCurve curveAccelX;

		[DisplayName("Acceleration (Y)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveAccelY"                    )] public ParLifeTimeCurve curveAccelY;

		[DisplayName("Acceleration (Z)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveAccelZ"                    )] public ParLifeTimeCurve curveAccelZ;

		[DisplayName("Size (square)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveSize"                      )] public ParLifeTimeCurve curveSize;

		[DisplayName("Size (height)")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveSizeY"                     )] public ParLifeTimeCurve curveSizeY;

		[DisplayName("Alpha")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveAlpha"                     )] public ParLifeTimeCurve curveAlpha;

		[DisplayName("Color")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		[Serialize("curveRGB"                       )] public ParLifeTimeCurve curveRGB;

		[DisplayName("Color1")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		[Serialize("curveRGB1"                      )] public ParLifeTimeCurve curveRGB1;

		[DisplayName("Color2")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		[Serialize("curveRGB2"                      )] public ParLifeTimeCurve curveRGB2;

		[DisplayName("Color3")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		[Serialize("curveRGB3"                      )] public ParLifeTimeCurve curveRGB3;

		[DisplayName("Spreadsheet")]
		[SplineUsageMode(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[Serialize("curveAnim"                      )] public ParLifeTimeCurve curveAnim;
		[Serialize("curveAttractor"                 )] public ParLifeTimeCurve curveAttractor;

		[DisplayName("Velocity")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("parEmitVelocity"                )] public EmitLifeTimeCurve parEmitVelocity;

		[DisplayName("Velocity angle")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("parEmitVelocityAngle"           )] public EmitLifeTimeCurve parEmitVelocityAngle;

		[DisplayName("Angle")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("parEmitAngle"                   )] public EmitLifeTimeCurve parEmitAngle;

		[DisplayName("Angular speed")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("parEmitAngularSpeed"            )] public EmitLifeTimeCurve parEmitAngularSpeed;

		[DisplayName("Frequency")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveFreq"                      )] public EmitLifeTimeCurve curveFreq;

		[DisplayName("Particles lifetime")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveParLifeTime"               )] public EmitLifeTimeCurve curveParLifeTime;

		[DisplayName("Alpha factor")]
		[SplineUsageMode(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[Serialize("curveEmitAlpha"                 )] public EmitLifeTimeCurve curveEmitAlpha;
		[Serialize("curveEmitAlphaInit"             )] public EmitLifeTimeCurve curveEmitAlphaInit;

		[DisplayName("Color factor")]
		[SplineUsageMode(Spline.UsageMode.RGB)]
		[SplineUsageModeExt(Spline.UsageMode.RGB)]
		[Serialize("curveEmitColorFactor"           )] public EmitLifeTimeCurve curveEmitColorFactor;
		[Serialize("curveEmitColorFactorInit"       )] public EmitLifeTimeCurve curveEmitColorFactorInit;

		[DisplayName("Size factor")]
		[SplineUsageMode(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.Y)]
		[Serialize("curveEmitSizeXY"                )] public EmitLifeTimeCurve curveEmitSizeXY;
		[Serialize("curveEmitSizeXYInit"            )] public EmitLifeTimeCurve curveEmitSizeXYInit;

		[DisplayName("Acceleration")]
		[SplineUsageMode(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.Y)]
		[SplineUsageModeExt(Spline.UsageMode.Z)]
		[SplineUsageModeExt(Spline.UsageMode.XYZ)]
		[Serialize("curveEmitAcceleration"          )] public EmitLifeTimeCurve curveEmitAcceleration;


		[DisplayName("Gravity")]
		[SplineUsageMode(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.XY)]
		[SplineUsageModeExt(Spline.UsageMode.X)]
		[SplineUsageModeExt(Spline.UsageMode.Y)]
		[SplineUsageModeExt(Spline.UsageMode.Z)]
		[SplineUsageModeExt(Spline.UsageMode.XYZ)]
		[Serialize("curveEmitGravity"               )] public EmitLifeTimeCurve curveEmitGravity;

		[DisplayName("Spreadsheet init")]
		[SplineUsageMode(Spline.UsageMode.WZ)]
		[SplineUsageModeExt(Spline.UsageMode.WZ)]
		[Serialize("curveEmitAnim"                  )] public EmitLifeTimeCurve curveEmitAnim;

		[Serialize("genGenType"                     )] public PARGEN_GEN genGenType;
		[Serialize("genMode"                        )] public PARGEN_MODE genMode;
		[Serialize("genEmitMode"                    )] public PARGEN_EMITMODE genEmitMode;
		[Serialize("GridFluidParam"                 )] public GFX_GridFluidObjParam GridFluidParam;
		[Serialize("PrimitiveParameters"            )] public GFXPrimitiveParam PrimitiveParameters;
		[Serialize("UseGenPrimitiveParam"           )] public bool UseGenPrimitiveParam;
		
		// Origins mode (RJR and RFR too):
		[Serialize("vel"                   )] public Vector3 vel;
		[Serialize("emitInterval"          )] public float emitInterval;		
		[Serialize("uniformscale"          )] public int uniformscale2;
		[Serialize("cartoonrendering"      )] public int cartoonrendering;
		[Serialize("impostorrendering"     )] public bool impostorrendering;
		[Serialize("showimpostorrender"    )] public bool showimpostorrender;
		[Serialize("impostorTextureSizeX"  )] public uint impostorTextureSizeX;
		[Serialize("impostorTextureSizeY"  )] public uint impostorTextureSizeY;
		[Serialize("outlinesize"           )] public float outlinesize;
		[Serialize("randomoutline"         )] public uint randomoutline;
		[Serialize("texturemirroru"        )] public int texturemirroru;
		[Serialize("texturemirrorv"        )] public int texturemirrorv;
		[Serialize("useMatrix"             )] public int useMatrix2;
		[Serialize("blendMode"             )] public GFX_BLEND blendMode;
		[Serialize("genGenType"            )] public PARGEN_GEN2 genGenType2;

		// Child of Light
		[Serialize("fluidInfluenceScale"   )] public float fluidInfluenceScale;
		[Serialize("fluidRotate"           )] public float fluidRotate;
		[Serialize("pushFluidRadius"       )] public float pushFluidRadius;
		[Serialize("pushFluidScale"        )] public float pushFluidScale;
		[Serialize("pushFluidRadiusHair"   )] public float pushFluidRadiusHair;
		[Serialize("pushFluidScaleHair"    )] public float pushFluidScaleHair;
		[Serialize("useMatrixRotation"     )] public BOOL useMatrixRotation;
		[Serialize("useMatrixScale"        )] public BOOL useMatrixScale;

		[Description("Must be set to true to use the remap alpha feature.")]
		[Serialize("enableRemapAlpha"      )] public bool enableRemapAlpha;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(maxParticles));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(emitParticlesCount));
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(pivot));
				SerializeField(s, nameof(velNorm));
				SerializeField(s, nameof(vel));
				SerializeField(s, nameof(grav));
				SerializeField(s, nameof(acc));
				SerializeField(s, nameof(depth));
				SerializeField(s, nameof(useZAsDepth));
				SerializeField(s, nameof(velocityVar));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(freq));
				SerializeField(s, nameof(emitInterval));
				SerializeField(s, nameof(initAngle));
				SerializeField(s, nameof(angleDelta));
				SerializeField(s, nameof(angularSpeed));
				SerializeField(s, nameof(angularSpeedDelta));
				SerializeField(s, nameof(timeTarget));
				SerializeField(s, nameof(nbPhase));
				SerializeField(s, nameof(renderPrio));
				SerializeField(s, nameof(circleRadius));
				SerializeField(s, nameof(innerCircleRadius));
				SerializeField(s, nameof(scaleShape));
				SerializeField(s, nameof(rotateShape));
				SerializeField(s, nameof(randomizeDirection));
				SerializeField(s, nameof(genBox));
				SerializeField(s, nameof(boundingBox));
				SerializeField(s, nameof(orientDir));
				SerializeField(s, nameof(UVmode));
				SerializeField(s, nameof(uniformscale2));
				SerializeField(s, nameof(cartoonrendering));
				SerializeField(s, nameof(impostorrendering));
				SerializeField(s, nameof(showimpostorrender));
				SerializeField(s, nameof(impostorTextureSizeX));
				SerializeField(s, nameof(impostorTextureSizeY));
				SerializeField(s, nameof(outlinesize));
				SerializeField(s, nameof(randomoutline));
				SerializeField(s, nameof(texturemirroru));
				SerializeField(s, nameof(texturemirrorv));
				SerializeField(s, nameof(genangmin));
				SerializeField(s, nameof(genangmax));
				SerializeField(s, nameof(canFlipAngleOffset));
				SerializeField(s, nameof(canFlipInitAngle));
				SerializeField(s, nameof(canFlipAngularSpeed));
				SerializeField(s, nameof(canFlipPivot));
				SerializeField(s, nameof(canFlipUV));
				SerializeField(s, nameof(canFlipAngleMin));
				SerializeField(s, nameof(canFlipAngleMax));
				SerializeField(s, nameof(canFlipAccel));
				SerializeField(s, nameof(canFlipOrientDir));
				SerializeField(s, nameof(numberSplit));
				SerializeField(s, nameof(splitDelta));
				SerializeField(s, nameof(useMatrix2));
				SerializeField(s, nameof(usePhasesColorAndSize));
				SerializeField(s, nameof(useActorTranslation));
				SerializeField(s, nameof(actorTranslationOffset));
				SerializeField(s, nameof(disableLight));
				SerializeField(s, nameof(phases));
				SerializeField(s, nameof(blendMode));
				SerializeField(s, nameof(genGenType2));
				SerializeField(s, nameof(genMode));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(maxParticles));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(emitParticlesCount));
				SerializeField(s, nameof(forceNoDynamicFog));
				SerializeField(s, nameof(renderInReflection));
				SerializeField(s, nameof(dieFadeTime));
				SerializeField(s, nameof(emitterMaxLifeTime));
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(pivot));
				SerializeField(s, nameof(velNorm));
				SerializeField(s, nameof(velAngle));
				SerializeField(s, nameof(velAngleDelta));
				SerializeField(s, nameof(grav));
				SerializeField(s, nameof(acc));
				SerializeField(s, nameof(depth));
				SerializeField(s, nameof(useZAsDepth));
				SerializeField(s, nameof(velocityVar));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(freq));
				SerializeField(s, nameof(freqDelta));
				SerializeField(s, nameof(forceEmitAtStart_int));
				SerializeField(s, nameof(emitBatchCount));
				SerializeField(s, nameof(emitBatchCount_AAO));
				SerializeField(s, nameof(initAngle));
				SerializeField(s, nameof(angleDelta));
				SerializeField(s, nameof(angularSpeed));
				SerializeField(s, nameof(angularSpeedDelta));
				SerializeField(s, nameof(timeTarget));
				SerializeField(s, nameof(nbPhase));
				SerializeField(s, nameof(renderPrio));
				SerializeField(s, nameof(initLifeTime));
				SerializeField(s, nameof(circleRadius));
				SerializeField(s, nameof(innerCircleRadius));
				SerializeField(s, nameof(scaleShape));
				SerializeField(s, nameof(rotateShape));
				SerializeField(s, nameof(randomizeDirection));
				SerializeField(s, nameof(followBezier));
				SerializeField(s, nameof(getAtlasSize));
				SerializeField(s, nameof(genBox));
				SerializeField(s, nameof(GenSize));
				SerializeField(s, nameof(GenSide));
				SerializeField(s, nameof(GenPosMin));
				SerializeField(s, nameof(GenPosMax));
				SerializeField(s, nameof(GenDensity));
				SerializeField(s, nameof(boundingBox));
				SerializeField(s, nameof(orientDir));
				SerializeField(s, nameof(UVmode));
				SerializeField(s, nameof(uniformscale));
				SerializeField(s, nameof(impostorrendering));
				SerializeField(s, nameof(showimpostorrender));
				SerializeField(s, nameof(impostorTextureSizeX));
				SerializeField(s, nameof(impostorTextureSizeY));
				SerializeField(s, nameof(genangmin));
				SerializeField(s, nameof(genangmax));
				SerializeField(s, nameof(canFlipAngleOffset));
				SerializeField(s, nameof(canFlipInitAngle));
				SerializeField(s, nameof(canFlipAngularSpeed));
				SerializeField(s, nameof(canFlipPivot));
				SerializeField(s, nameof(canFlipPos));
				SerializeField(s, nameof(canFlipUV));
				SerializeField(s, nameof(canFlipAngleMin));
				SerializeField(s, nameof(canFlipAngleMax));
				SerializeField(s, nameof(canFlipAccel));
				SerializeField(s, nameof(canFlipOrientDir));
				SerializeField(s, nameof(numberSplit));
				SerializeField(s, nameof(splitDelta));
				SerializeField(s, nameof(useMatrix));
				SerializeField(s, nameof(usePhasesColorAndSize));
				SerializeField(s, nameof(useActorTranslation));
				SerializeField(s, nameof(actorTranslationOffset));
				SerializeField(s, nameof(disableLight));
				SerializeField(s, nameof(phases));
				SerializeField(s, nameof(curveSize));
				SerializeField(s, nameof(curveSizeY));
				SerializeField(s, nameof(curveAlpha));
				SerializeField(s, nameof(curveRGB));
				SerializeField(s, nameof(curveRGB1));
				SerializeField(s, nameof(curveRGB2));
				SerializeField(s, nameof(curveRGB3));
				SerializeField(s, nameof(curveAnim));
				SerializeField(s, nameof(parEmitVelocity));
				SerializeField(s, nameof(parEmitVelocityAngle));
				SerializeField(s, nameof(parEmitAngle));
				SerializeField(s, nameof(parEmitAngularSpeed));
				SerializeField(s, nameof(curveFreq));
				SerializeField(s, nameof(curveParLifeTime));
				SerializeField(s, nameof(curveEmitAlpha));
				SerializeField(s, nameof(curveEmitColorFactor));
				SerializeField(s, nameof(curveEmitSizeXY));
				SerializeField(s, nameof(curveEmitAcceleration));
				SerializeField(s, nameof(curveEmitGravity));
				SerializeField(s, nameof(genGenType));
				SerializeField(s, nameof(genMode));
				SerializeField(s, nameof(genEmitMode));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(maxParticles));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(emitParticlesCount));
				SerializeField(s, nameof(forceNoDynamicFog));
				SerializeField(s, nameof(renderInReflection));
				SerializeField(s, nameof(dieFadeTime));
				SerializeField(s, nameof(emitterMaxLifeTime));
				SerializeField(s, nameof(behaviorOnEnd));
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(pivot));
				SerializeField(s, nameof(velNorm));
				SerializeField(s, nameof(velAngle));
				SerializeField(s, nameof(velAngleDelta));
				SerializeField(s, nameof(grav));
				SerializeField(s, nameof(acc));
				SerializeField(s, nameof(depth));
				SerializeField(s, nameof(useZAsDepth));
				SerializeField(s, nameof(velocityVar));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(freq));
				SerializeField(s, nameof(freqDelta));
				SerializeField(s, nameof(forceEmitAtStart));
				SerializeField(s, nameof(emitBatchCount));
				SerializeField(s, nameof(emitBatchCount_AAO));
				SerializeField(s, nameof(emitBatchCount_AAO_max));
				SerializeField(s, nameof(initAngle));
				SerializeField(s, nameof(angleDelta));
				SerializeField(s, nameof(angularSpeed));
				SerializeField(s, nameof(angularSpeedDelta));
				SerializeField(s, nameof(timeTarget));
				SerializeField(s, nameof(nbPhase));
				SerializeField(s, nameof(renderPrio));
				SerializeField(s, nameof(initLifeTime));
				SerializeField(s, nameof(circleRadius));
				SerializeField(s, nameof(innerCircleRadius));
				SerializeField(s, nameof(scaleShape));
				SerializeField(s, nameof(rotateShape));
				SerializeField(s, nameof(randomizeDirection));
				SerializeField(s, nameof(followBezier));
				SerializeField(s, nameof(getAtlasSize));
				SerializeField(s, nameof(continuousColorRandom));
				SerializeField(s, nameof(genBox));
				SerializeField(s, nameof(GenSize));
				SerializeField(s, nameof(GenSide));
				SerializeField(s, nameof(GenPosMin));
				SerializeField(s, nameof(GenPosMax));
				SerializeField(s, nameof(GenDensity));
				SerializeField(s, nameof(boundingBox));
				SerializeField(s, nameof(orientDir));
				SerializeField(s, nameof(UVmode));
				SerializeField(s, nameof(UVmodeFlag));
				SerializeField(s, nameof(uniformscale));
				SerializeField(s, nameof(genangmin));
				SerializeField(s, nameof(genangmax));
				SerializeField(s, nameof(useYMin));
				SerializeField(s, nameof(useYMinLocal));
				SerializeField(s, nameof(yMin));
				SerializeField(s, nameof(yMinBouncinessMin));
				SerializeField(s, nameof(yMinBouncinessMax));
				SerializeField(s, nameof(yMinMinRebounds));
				SerializeField(s, nameof(yMinMaxRebounds));
				SerializeField(s, nameof(yMinKillAfterMaxRebounds));
				SerializeField(s, nameof(bouncinessAffectsXSpeed));
				SerializeField(s, nameof(bouncinessAffectsAngularSpeed));
				SerializeField(s, nameof(canFlipAngleOffset));
				SerializeField(s, nameof(canFlipInitAngle));
				SerializeField(s, nameof(canFlipAngularSpeed));
				SerializeField(s, nameof(canFlipPivot));
				SerializeField(s, nameof(canFlipPos));
				SerializeField(s, nameof(canFlipUV));
				SerializeField(s, nameof(canFlipAngleMin));
				SerializeField(s, nameof(canFlipAngleMax));
				SerializeField(s, nameof(canFlipAccel));
				SerializeField(s, nameof(canFlipOrientDir));
				SerializeField(s, nameof(numberSplit));
				SerializeField(s, nameof(splitDelta));
				SerializeField(s, nameof(useMatrix));
				SerializeField(s, nameof(scaleGenBox2));
				SerializeField(s, nameof(usePhasesColorAndSize));
				SerializeField(s, nameof(useActorTranslation));
				SerializeField(s, nameof(actorTranslationOffset));
				SerializeField(s, nameof(disableLight));
				SerializeField(s, nameof(phases));
				SerializeField(s, nameof(curvePosition));
				SerializeField(s, nameof(curveAngle));
				SerializeField(s, nameof(curveAngularSpeed));
				SerializeField(s, nameof(curveVelocityMult));
				SerializeField(s, nameof(curveAccelX));
				SerializeField(s, nameof(curveAccelY));
				SerializeField(s, nameof(curveAccelZ));
				SerializeField(s, nameof(curveSize));
				SerializeField(s, nameof(curveSizeY));
				SerializeField(s, nameof(curveAlpha));
				SerializeField(s, nameof(curveRGB));
				SerializeField(s, nameof(curveRGB1));
				SerializeField(s, nameof(curveRGB2));
				SerializeField(s, nameof(curveRGB3));
				SerializeField(s, nameof(curveAnim));
				SerializeField(s, nameof(parEmitVelocity));
				SerializeField(s, nameof(parEmitVelocityAngle));
				SerializeField(s, nameof(parEmitAngle));
				SerializeField(s, nameof(parEmitAngularSpeed));
				SerializeField(s, nameof(curveFreq));
				SerializeField(s, nameof(curveParLifeTime));
				SerializeField(s, nameof(curveEmitAlpha));
				SerializeField(s, nameof(curveEmitAlphaInit));
				SerializeField(s, nameof(curveEmitColorFactor));
				SerializeField(s, nameof(curveEmitColorFactorInit));
				SerializeField(s, nameof(curveEmitSizeXY));
				SerializeField(s, nameof(curveEmitSizeXYInit));
				SerializeField(s, nameof(curveEmitAcceleration));
				SerializeField(s, nameof(curveEmitGravity));
				SerializeField(s, nameof(curveEmitAnim));
				SerializeField(s, nameof(genGenType));
				SerializeField(s, nameof(genMode));
				SerializeField(s, nameof(genEmitMode));
			} else if(Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(maxParticles));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(emitParticlesCount));
				SerializeField(s, nameof(forceNoDynamicFog), boolAsByte: true);
				SerializeField(s, nameof(renderInReflection), boolAsByte: true);
				SerializeField(s, nameof(dieFadeTime));
				SerializeField(s, nameof(emitterMaxLifeTime));
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(pivot));
				SerializeField(s, nameof(velNorm));
				SerializeField(s, nameof(velAngle));
				SerializeField(s, nameof(velAngleDelta));
				SerializeField(s, nameof(grav));
				SerializeField(s, nameof(acc));
				SerializeField(s, nameof(depth));
				SerializeField(s, nameof(useZAsDepth), boolAsByte: true);
				SerializeField(s, nameof(velocityVar));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(fluidInfluenceScale));
				SerializeField(s, nameof(fluidRotate));
				SerializeField(s, nameof(pushFluidRadius));
				SerializeField(s, nameof(pushFluidScale));
				SerializeField(s, nameof(pushFluidRadiusHair));
				SerializeField(s, nameof(pushFluidScaleHair));
				SerializeField(s, nameof(freq));
				SerializeField(s, nameof(freqDelta));
				SerializeField(s, nameof(forceEmitAtStart), boolAsByte: true);
				SerializeField(s, nameof(emitBatchCount));
				SerializeField(s, nameof(emitBatchCount_AAO));
				SerializeField(s, nameof(emitBatchCount_AAO_max));
				SerializeField(s, nameof(initAngle));
				SerializeField(s, nameof(angleDelta));
				SerializeField(s, nameof(angularSpeed));
				SerializeField(s, nameof(angularSpeedDelta));
				SerializeField(s, nameof(timeTarget));
				SerializeField(s, nameof(nbPhase));
				SerializeField(s, nameof(renderPrio));
				SerializeField(s, nameof(initLifeTime));
				SerializeField(s, nameof(circleRadius));
				SerializeField(s, nameof(innerCircleRadius));
				SerializeField(s, nameof(scaleShape));
				SerializeField(s, nameof(rotateShape));
				SerializeField(s, nameof(randomizeDirection), boolAsByte: true);
				SerializeField(s, nameof(followBezier));
				SerializeField(s, nameof(getAtlasSize), boolAsByte: true);
				SerializeField(s, nameof(genBox));
				SerializeField(s, nameof(GenSize));
				SerializeField(s, nameof(GenSide));
				SerializeField(s, nameof(GenPosMin));
				SerializeField(s, nameof(GenPosMax));
				SerializeField(s, nameof(GenDensity));
				SerializeField(s, nameof(boundingBox));
				SerializeField(s, nameof(orientDir));
				SerializeField(s, nameof(UVmode));
				SerializeField(s, nameof(UVmodeFlag));
				SerializeField(s, nameof(uniformscale));
				SerializeField(s, nameof(impostorrendering), boolAsByte: true);
				SerializeField(s, nameof(showimpostorrender), boolAsByte: true);
				SerializeField(s, nameof(impostorTextureSizeX));
				SerializeField(s, nameof(impostorTextureSizeY));
				SerializeField(s, nameof(genangmin));
				SerializeField(s, nameof(genangmax));
				SerializeField(s, nameof(canFlipAngleOffset), boolAsByte: true);
				SerializeField(s, nameof(canFlipInitAngle), boolAsByte: true);
				SerializeField(s, nameof(canFlipAngularSpeed), boolAsByte: true);
				SerializeField(s, nameof(canFlipPivot), boolAsByte: true);
				SerializeField(s, nameof(canFlipPos), boolAsByte: true);
				SerializeField(s, nameof(canFlipUV), boolAsByte: true);
				SerializeField(s, nameof(canFlipAngleMin), boolAsByte: true);
				SerializeField(s, nameof(canFlipAngleMax), boolAsByte: true);
				SerializeField(s, nameof(canFlipAccel), boolAsByte: true);
				SerializeField(s, nameof(canFlipOrientDir), boolAsByte: true);
				SerializeField(s, nameof(numberSplit));
				SerializeField(s, nameof(splitDelta));
				SerializeField(s, nameof(useMatrix));
				SerializeField(s, nameof(useMatrixRotation));
				SerializeField(s, nameof(useMatrixScale));
				SerializeField(s, nameof(usePhasesColorAndSize), boolAsByte: true);
				SerializeField(s, nameof(useActorTranslation), boolAsByte: true);
				SerializeField(s, nameof(actorTranslationOffset));
				SerializeField(s, nameof(disableLight), boolAsByte: true);
				SerializeField(s, nameof(enableRemapAlpha), boolAsByte: true);
				SerializeField(s, nameof(phases));
				SerializeField(s, nameof(curvePosition));
				SerializeField(s, nameof(curveAngle));
				SerializeField(s, nameof(curveVelocityMult));
				SerializeField(s, nameof(curveAccelX));
				SerializeField(s, nameof(curveAccelY));
				SerializeField(s, nameof(curveAccelZ));
				SerializeField(s, nameof(curveSize));
				SerializeField(s, nameof(curveSizeY));
				SerializeField(s, nameof(curveAlpha));
				SerializeField(s, nameof(curveRGB));
				SerializeField(s, nameof(curveRGB1));
				SerializeField(s, nameof(curveRGB2));
				SerializeField(s, nameof(curveRGB3));
				SerializeField(s, nameof(curveAnim));
				SerializeField(s, nameof(parEmitVelocity));
				SerializeField(s, nameof(parEmitVelocityAngle));
				SerializeField(s, nameof(parEmitAngle));
				SerializeField(s, nameof(parEmitAngularSpeed));
				SerializeField(s, nameof(curveFreq));
				SerializeField(s, nameof(curveParLifeTime));
				SerializeField(s, nameof(curveEmitAlpha));
				SerializeField(s, nameof(curveEmitColorFactor));
				SerializeField(s, nameof(curveEmitSizeXY));
				SerializeField(s, nameof(curveEmitAcceleration));
				SerializeField(s, nameof(curveEmitGravity));
				SerializeField(s, nameof(curveEmitAnim));
				SerializeField(s, nameof(genGenType));
				SerializeField(s, nameof(genMode));
				SerializeField(s, nameof(genEmitMode));
			} else {
				SerializeField(s, nameof(maxParticles));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(emitParticlesCount));
				SerializeField(s, nameof(forceNoDynamicFog));
				SerializeField(s, nameof(renderInReflection));
				SerializeField(s, nameof(dieFadeTime));
				SerializeField(s, nameof(emitterMaxLifeTime));
				SerializeField(s, nameof(behaviorOnEnd));
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(pivot));
				SerializeField(s, nameof(velNorm));
				SerializeField(s, nameof(velAngle));
				SerializeField(s, nameof(velAngleDelta));
				SerializeField(s, nameof(grav));
				SerializeField(s, nameof(acc));
				SerializeField(s, nameof(depth));
				SerializeField(s, nameof(useZAsDepth));
				SerializeField(s, nameof(velocityVar));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(freq));
				SerializeField(s, nameof(freqDelta));
				SerializeField(s, nameof(forceEmitAtStart));
				SerializeField(s, nameof(emitBatchCount));
				SerializeField(s, nameof(emitBatchCount_AAO));
				SerializeField(s, nameof(emitBatchCount_AAO_max));
				SerializeField(s, nameof(initAngle));
				SerializeField(s, nameof(angleDelta));
				SerializeField(s, nameof(angularSpeed));
				SerializeField(s, nameof(angularSpeedDelta));
				SerializeField(s, nameof(timeTarget));
				SerializeField(s, nameof(nbPhase));
				SerializeField(s, nameof(renderPrio));
				SerializeField(s, nameof(initLifeTime));
				SerializeField(s, nameof(circleRadius));
				SerializeField(s, nameof(innerCircleRadius));
				SerializeField(s, nameof(scaleShape));
				SerializeField(s, nameof(rotateShape));
				SerializeField(s, nameof(randomizeDirection));
				SerializeField(s, nameof(followBezier));
				SerializeField(s, nameof(getAtlasSize));
				SerializeField(s, nameof(continuousColorRandom));
				SerializeField(s, nameof(genBox));
				SerializeField(s, nameof(GenSize));
				SerializeField(s, nameof(GenSide));
				SerializeField(s, nameof(GenPosMin));
				SerializeField(s, nameof(GenPosMax));
				SerializeField(s, nameof(GenDensity));
				SerializeField(s, nameof(boundingBox));
				SerializeField(s, nameof(orientDir));
				SerializeField(s, nameof(UVmode));
				SerializeField(s, nameof(UVmodeFlag));
				SerializeField(s, nameof(uniformscale));
				SerializeField(s, nameof(genangmin));
				SerializeField(s, nameof(genangmax));
				SerializeField(s, nameof(useYMin));
				SerializeField(s, nameof(useYMinLocal));
				SerializeField(s, nameof(yMin));
				SerializeField(s, nameof(yMinBouncinessMin));
				SerializeField(s, nameof(yMinBouncinessMax));
				SerializeField(s, nameof(yMinMinRebounds));
				SerializeField(s, nameof(yMinMaxRebounds));
				SerializeField(s, nameof(yMinKillAfterMaxRebounds));
				SerializeField(s, nameof(bouncinessAffectsXSpeed));
				SerializeField(s, nameof(bouncinessAffectsAngularSpeed));
				SerializeField(s, nameof(useAttractors));
				SerializeField(s, nameof(attractorPowerDependsOnDistance));
				SerializeField(s, nameof(useAttractorMinDistance));
				SerializeField(s, nameof(attractorMinDistance));
				SerializeField(s, nameof(attractorOffset));
				SerializeField(s, nameof(useImpulseSpeed));
				SerializeField(s, nameof(canFlipAngleOffset));
				SerializeField(s, nameof(canFlipInitAngle));
				SerializeField(s, nameof(canFlipAngularSpeed));
				SerializeField(s, nameof(canFlipPivot));
				SerializeField(s, nameof(canFlipPos));
				SerializeField(s, nameof(canFlipUV));
				SerializeField(s, nameof(canFlipAngleMin));
				SerializeField(s, nameof(canFlipAngleMax));
				SerializeField(s, nameof(canFlipAccel));
				SerializeField(s, nameof(canFlipOrientDir));
				SerializeField(s, nameof(canFlipAttractorOffset));
				SerializeField(s, nameof(numberSplit));
				SerializeField(s, nameof(splitDelta));
				SerializeField(s, nameof(useMatrix));
				SerializeField(s, nameof(scaleGenBox));
				SerializeField(s, nameof(usePhasesColorAndSize));
				SerializeField(s, nameof(useActorTranslation));
				SerializeField(s, nameof(actorTranslationOffset));
				SerializeField(s, nameof(disableLight));
				SerializeField(s, nameof(phases));
				SerializeField(s, nameof(curvePosition));
				SerializeField(s, nameof(curveAngle));
				SerializeField(s, nameof(curveAngularSpeed));
				SerializeField(s, nameof(curveVelocityMult));
				SerializeField(s, nameof(curveAccelX));
				SerializeField(s, nameof(curveAccelY));
				SerializeField(s, nameof(curveAccelZ));
				SerializeField(s, nameof(curveSize));
				SerializeField(s, nameof(curveSizeY));
				SerializeField(s, nameof(curveAlpha));
				SerializeField(s, nameof(curveRGB));
				SerializeField(s, nameof(curveRGB1));
				SerializeField(s, nameof(curveRGB2));
				SerializeField(s, nameof(curveRGB3));
				SerializeField(s, nameof(curveAnim));
				SerializeField(s, nameof(curveAttractor));
				SerializeField(s, nameof(parEmitVelocity));
				SerializeField(s, nameof(parEmitVelocityAngle));
				SerializeField(s, nameof(parEmitAngle));
				SerializeField(s, nameof(parEmitAngularSpeed));
				SerializeField(s, nameof(curveFreq));
				SerializeField(s, nameof(curveParLifeTime));
				SerializeField(s, nameof(curveEmitAlpha));
				SerializeField(s, nameof(curveEmitAlphaInit));
				SerializeField(s, nameof(curveEmitColorFactor));
				SerializeField(s, nameof(curveEmitColorFactorInit));
				SerializeField(s, nameof(curveEmitSizeXY));
				SerializeField(s, nameof(curveEmitSizeXYInit));
				SerializeField(s, nameof(curveEmitAcceleration));
				SerializeField(s, nameof(curveEmitGravity));
				SerializeField(s, nameof(curveEmitAnim));
				SerializeField(s, nameof(genGenType));
				SerializeField(s, nameof(genMode));
				SerializeField(s, nameof(genEmitMode));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(GridFluidParam));
				}
				SerializeField(s, nameof(PrimitiveParameters));
				SerializeField(s, nameof(UseGenPrimitiveParam));
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

