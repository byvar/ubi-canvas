using UnityEngine;

namespace UbiArt.ITF {
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
		[Serialize("usePhasesColorAndSize"          )] public bool usePhasesColorAndSize;
		[Serialize("useActorTranslation"            )] public bool useActorTranslation;
		[Serialize("actorTranslationOffset"         )] public Vector2 actorTranslationOffset;
		[Serialize("disableLight"                   )] public bool disableLight;
		[Serialize("phases"                         )] public CList<ParPhase> phases;
		[Serialize("curvePosition"                  )] public ParLifeTimeCurve curvePosition;
		[Serialize("curveAngle"                     )] public ParLifeTimeCurve curveAngle;
		[Serialize("curveAngularSpeed"              )] public ParLifeTimeCurve curveAngularSpeed;
		[Serialize("curveVelocityMult"              )] public ParLifeTimeCurve curveVelocityMult;
		[Serialize("curveAccelX"                    )] public ParLifeTimeCurve curveAccelX;
		[Serialize("curveAccelY"                    )] public ParLifeTimeCurve curveAccelY;
		[Serialize("curveAccelZ"                    )] public ParLifeTimeCurve curveAccelZ;
		[Serialize("curveSize"                      )] public ParLifeTimeCurve curveSize;
		[Serialize("curveSizeY"                     )] public ParLifeTimeCurve curveSizeY;
		[Serialize("curveAlpha"                     )] public ParLifeTimeCurve curveAlpha;
		[Serialize("curveRGB"                       )] public ParLifeTimeCurve curveRGB;
		[Serialize("curveRGB1"                      )] public ParLifeTimeCurve curveRGB1;
		[Serialize("curveRGB2"                      )] public ParLifeTimeCurve curveRGB2;
		[Serialize("curveRGB3"                      )] public ParLifeTimeCurve curveRGB3;
		[Serialize("curveAnim"                      )] public ParLifeTimeCurve curveAnim;
		[Serialize("curveAttractor"                 )] public ParLifeTimeCurve curveAttractor;
		[Serialize("parEmitVelocity"                )] public EmitLifeTimeCurve parEmitVelocity;
		[Serialize("parEmitVelocityAngle"           )] public EmitLifeTimeCurve parEmitVelocityAngle;
		[Serialize("parEmitAngle"                   )] public EmitLifeTimeCurve parEmitAngle;
		[Serialize("parEmitAngularSpeed"            )] public EmitLifeTimeCurve parEmitAngularSpeed;
		[Serialize("curveFreq"                      )] public EmitLifeTimeCurve curveFreq;
		[Serialize("curveParLifeTime"               )] public EmitLifeTimeCurve curveParLifeTime;
		[Serialize("curveEmitAlpha"                 )] public EmitLifeTimeCurve curveEmitAlpha;
		[Serialize("curveEmitAlphaInit"             )] public EmitLifeTimeCurve curveEmitAlphaInit;
		[Serialize("curveEmitColorFactor"           )] public EmitLifeTimeCurve curveEmitColorFactor;
		[Serialize("curveEmitColorFactorInit"       )] public EmitLifeTimeCurve curveEmitColorFactorInit;
		[Serialize("curveEmitSizeXY"                )] public EmitLifeTimeCurve curveEmitSizeXY;
		[Serialize("curveEmitSizeXYInit"            )] public EmitLifeTimeCurve curveEmitSizeXYInit;
		[Serialize("curveEmitAcceleration"          )] public EmitLifeTimeCurve curveEmitAcceleration;
		[Serialize("curveEmitGravity"               )] public EmitLifeTimeCurve curveEmitGravity;
		[Serialize("curveEmitAnim"                  )] public EmitLifeTimeCurve curveEmitAnim;
		[Serialize("genGenType"                     )] public PARGEN_GEN genGenType;
		[Serialize("genMode"                        )] public PARGEN_MODE genMode;
		[Serialize("genEmitMode"                    )] public PARGEN_EMITMODE genEmitMode;
		[Serialize("GridFluidParam"                 )] public GFX_GridFluidObjParam GridFluidParam;
		[Serialize("PrimitiveParameters"            )] public GFXPrimitiveParam PrimitiveParameters;
		[Serialize("UseGenPrimitiveParam"           )] public bool UseGenPrimitiveParam;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
	}
}

