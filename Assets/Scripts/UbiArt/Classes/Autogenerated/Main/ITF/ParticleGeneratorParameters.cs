using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
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
		[Serialize("uint__0"                        )] public uint uint__0;
		[Serialize("Color__1"                       )] public Color Color__1;
		[Serialize("uint__2"                        )] public uint uint__2;
		[Serialize("Vector3__3"                     )] public Vector3 Vector3__3;
		[Serialize("Vector2__4"                     )] public Vector2 Vector2__4;
		[Serialize("float__5"                       )] public float float__5;
		[Serialize("Vector3__6"                     )] public Vector3 Vector3__6;
		[Serialize("Vector3__7"                     )] public Vector3 Vector3__7;
		[Serialize("Vector3__8"                     )] public Vector3 Vector3__8;
		[Serialize("float__9"                       )] public float float__9;
		[Serialize("int__10"                        )] public int int__10;
		[Serialize("float__11"                      )] public float float__11;
		[Serialize("float__12"                      )] public float float__12;
		[Serialize("float__13"                      )] public float float__13;
		[Serialize("float__14"                      )] public float float__14;
		[Serialize("Angle__15"                      )] public Angle Angle__15;
		[Serialize("Angle__16"                      )] public Angle Angle__16;
		[Serialize("Angle__17"                      )] public Angle Angle__17;
		[Serialize("Angle__18"                      )] public Angle Angle__18;
		[Serialize("float__19"                      )] public float float__19;
		[Serialize("uint__20"                       )] public uint uint__20;
		[Serialize("float__21"                      )] public float float__21;
		[Serialize("float__22"                      )] public float float__22;
		[Serialize("float__23"                      )] public float float__23;
		[Serialize("Vector3__24"                    )] public Vector3 Vector3__24;
		[Serialize("Vector3__25"                    )] public Vector3 Vector3__25;
		[Serialize("int__26"                        )] public int int__26;
		[Serialize("AABB__27"                       )] public AABB AABB__27;
		[Serialize("AABB__28"                       )] public AABB AABB__28;
		[Serialize("uint__29"                       )] public uint uint__29;
		[Serialize("Enum_RJR_0__30"                 )] public Enum_RJR_0 Enum_RJR_0__30;
		[Serialize("int__31"                        )] public int int__31;
		[Serialize("int__32"                        )] public int int__32;
		[Serialize("int__33"                        )] public int int__33;
		[Serialize("int__34"                        )] public int int__34;
		[Serialize("uint__35"                       )] public uint uint__35;
		[Serialize("uint__36"                       )] public uint uint__36;
		[Serialize("float__37"                      )] public float float__37;
		[Serialize("uint__38"                       )] public uint uint__38;
		[Serialize("int__39"                        )] public int int__39;
		[Serialize("int__40"                        )] public int int__40;
		[Serialize("Angle__41"                      )] public Angle Angle__41;
		[Serialize("Angle__42"                      )] public Angle Angle__42;
		[Serialize("int__43"                        )] public int int__43;
		[Serialize("int__44"                        )] public int int__44;
		[Serialize("int__45"                        )] public int int__45;
		[Serialize("int__46"                        )] public int int__46;
		[Serialize("int__47"                        )] public int int__47;
		[Serialize("int__48"                        )] public int int__48;
		[Serialize("int__49"                        )] public int int__49;
		[Serialize("int__50"                        )] public int int__50;
		[Serialize("int__51"                        )] public int int__51;
		[Serialize("uint__52"                       )] public uint uint__52;
		[Serialize("Angle__53"                      )] public Angle Angle__53;
		[Serialize("int__54"                        )] public int int__54;
		[Serialize("int__55"                        )] public int int__55;
		[Serialize("int__56"                        )] public int int__56;
		[Serialize("Vector2__57"                    )] public Vector2 Vector2__57;
		[Serialize("int__58"                        )] public int int__58;
		[Serialize("CList<ParPhase>__59"            )] public CList<ParPhase> CList_ParPhase__59;
		[Serialize("Enum_RJR_1__60"                 )] public Enum_RJR_1 Enum_RJR_1__60;
		[Serialize("Enum_RJR_2__61"                 )] public Enum_RJR_2 Enum_RJR_2__61;
		[Serialize("Enum_RJR_3__62"                 )] public Enum_RJR_3 Enum_RJR_3__62;
		[Serialize("uint__63"                       )] public uint uint__63;
		[Serialize("Color__64"                      )] public Color Color__64;
		[Serialize("uint__65"                       )] public uint uint__65;
		[Serialize("Vector3__66"                    )] public Vector3 Vector3__66;
		[Serialize("Vector2__67"                    )] public Vector2 Vector2__67;
		[Serialize("float__68"                      )] public float float__68;
		[Serialize("Vector3__69"                    )] public Vector3 Vector3__69;
		[Serialize("Vector3__70"                    )] public Vector3 Vector3__70;
		[Serialize("Vector3__71"                    )] public Vector3 Vector3__71;
		[Serialize("float__72"                      )] public float float__72;
		[Serialize("int__73"                        )] public int int__73;
		[Serialize("float__74"                      )] public float float__74;
		[Serialize("float__75"                      )] public float float__75;
		[Serialize("float__76"                      )] public float float__76;
		[Serialize("float__77"                      )] public float float__77;
		[Serialize("Angle__78"                      )] public Angle Angle__78;
		[Serialize("Angle__79"                      )] public Angle Angle__79;
		[Serialize("Angle__80"                      )] public Angle Angle__80;
		[Serialize("Angle__81"                      )] public Angle Angle__81;
		[Serialize("float__82"                      )] public float float__82;
		[Serialize("uint__83"                       )] public uint uint__83;
		[Serialize("float__84"                      )] public float float__84;
		[Serialize("float__85"                      )] public float float__85;
		[Serialize("float__86"                      )] public float float__86;
		[Serialize("Vector3__87"                    )] public Vector3 Vector3__87;
		[Serialize("Vector3__88"                    )] public Vector3 Vector3__88;
		[Serialize("int__89"                        )] public int int__89;
		[Serialize("AABB__90"                       )] public AABB AABB__90;
		[Serialize("AABB__91"                       )] public AABB AABB__91;
		[Serialize("uint__92"                       )] public uint uint__92;
		[Serialize("Enum_RFR_0__93"                 )] public Enum_RFR_0 Enum_RFR_0__93;
		[Serialize("int__94"                        )] public int int__94;
		[Serialize("int__95"                        )] public int int__95;
		[Serialize("int__96"                        )] public int int__96;
		[Serialize("int__97"                        )] public int int__97;
		[Serialize("uint__98"                       )] public uint uint__98;
		[Serialize("uint__99"                       )] public uint uint__99;
		[Serialize("float__100"                     )] public float float__100;
		[Serialize("uint__101"                      )] public uint uint__101;
		[Serialize("int__102"                       )] public int int__102;
		[Serialize("int__103"                       )] public int int__103;
		[Serialize("Angle__104"                     )] public Angle Angle__104;
		[Serialize("Angle__105"                     )] public Angle Angle__105;
		[Serialize("int__106"                       )] public int int__106;
		[Serialize("int__107"                       )] public int int__107;
		[Serialize("int__108"                       )] public int int__108;
		[Serialize("int__109"                       )] public int int__109;
		[Serialize("int__110"                       )] public int int__110;
		[Serialize("int__111"                       )] public int int__111;
		[Serialize("int__112"                       )] public int int__112;
		[Serialize("int__113"                       )] public int int__113;
		[Serialize("int__114"                       )] public int int__114;
		[Serialize("uint__115"                      )] public uint uint__115;
		[Serialize("Angle__116"                     )] public Angle Angle__116;
		[Serialize("int__117"                       )] public int int__117;
		[Serialize("int__118"                       )] public int int__118;
		[Serialize("int__119"                       )] public int int__119;
		[Serialize("Vector2__120"                   )] public Vector2 Vector2__120;
		[Serialize("int__121"                       )] public int int__121;
		[Serialize("CList<ParPhase>__122"           )] public CList<ParPhase> CList_ParPhase__122;
		[Serialize("Enum_RFR_1__123"                )] public Enum_RFR_1 Enum_RFR_1__123;
		[Serialize("Enum_RFR_2__124"                )] public Enum_RFR_2 Enum_RFR_2__124;
		[Serialize("Enum_RFR_3__125"                )] public Enum_RFR_3 Enum_RFR_3__125;
		[Serialize("uint__126"                      )] public uint uint__126;
		[Serialize("Color__127"                     )] public Color Color__127;
		[Serialize("uint__128"                      )] public uint uint__128;
		[Serialize("bool__129"                      )] public bool bool__129;
		[Serialize("bool__130"                      )] public bool bool__130;
		[Serialize("float__131"                     )] public float float__131;
		[Serialize("float__132"                     )] public float float__132;
		[Serialize("Enum_VH_0__133"                 )] public Enum_VH_0 Enum_VH_0__133;
		[Serialize("Vector3__134"                   )] public Vector3 Vector3__134;
		[Serialize("Vector2__135"                   )] public Vector2 Vector2__135;
		[Serialize("float__136"                     )] public float float__136;
		[Serialize("float__137"                     )] public float float__137;
		[Serialize("float__138"                     )] public float float__138;
		[Serialize("Vector3__139"                   )] public Vector3 Vector3__139;
		[Serialize("Vector3__140"                   )] public Vector3 Vector3__140;
		[Serialize("float__141"                     )] public float float__141;
		[Serialize("bool__142"                      )] public bool bool__142;
		[Serialize("float__143"                     )] public float float__143;
		[Serialize("float__144"                     )] public float float__144;
		[Serialize("float__145"                     )] public float float__145;
		[Serialize("float__146"                     )] public float float__146;
		[Serialize("bool__147"                      )] public bool bool__147;
		[Serialize("uint__148"                      )] public uint uint__148;
		[Serialize("uint__149"                      )] public uint uint__149;
		[Serialize("uint__150"                      )] public uint uint__150;
		[Serialize("Angle__151"                     )] public Angle Angle__151;
		[Serialize("Angle__152"                     )] public Angle Angle__152;
		[Serialize("Angle__153"                     )] public Angle Angle__153;
		[Serialize("Angle__154"                     )] public Angle Angle__154;
		[Serialize("float__155"                     )] public float float__155;
		[Serialize("uint__156"                      )] public uint uint__156;
		[Serialize("float__157"                     )] public float float__157;
		[Serialize("float__158"                     )] public float float__158;
		[Serialize("float__159"                     )] public float float__159;
		[Serialize("float__160"                     )] public float float__160;
		[Serialize("Vector3__161"                   )] public Vector3 Vector3__161;
		[Serialize("Vector3__162"                   )] public Vector3 Vector3__162;
		[Serialize("bool__163"                      )] public bool bool__163;
		[Serialize("int__164"                       )] public int int__164;
		[Serialize("bool__165"                      )] public bool bool__165;
		[Serialize("bool__166"                      )] public bool bool__166;
		[Serialize("AABB__167"                      )] public AABB AABB__167;
		[Serialize("float__168"                     )] public float float__168;
		[Serialize("uint__169"                      )] public uint uint__169;
		[Serialize("float__170"                     )] public float float__170;
		[Serialize("float__171"                     )] public float float__171;
		[Serialize("float__172"                     )] public float float__172;
		[Serialize("AABB__173"                      )] public AABB AABB__173;
		[Serialize("uint__174"                      )] public uint uint__174;
		[Serialize("Enum_VH_1__175"                 )] public Enum_VH_1 Enum_VH_1__175;
		[Serialize("Enum_VH_2__176"                 )] public Enum_VH_2 Enum_VH_2__176;
		[Serialize("float__177"                     )] public float float__177;
		[Serialize("Angle__178"                     )] public Angle Angle__178;
		[Serialize("Angle__179"                     )] public Angle Angle__179;
		[Serialize("bool__180"                      )] public bool bool__180;
		[Serialize("bool__181"                      )] public bool bool__181;
		[Serialize("float__182"                     )] public float float__182;
		[Serialize("float__183"                     )] public float float__183;
		[Serialize("float__184"                     )] public float float__184;
		[Serialize("uint__185"                      )] public uint uint__185;
		[Serialize("uint__186"                      )] public uint uint__186;
		[Serialize("bool__187"                      )] public bool bool__187;
		[Serialize("bool__188"                      )] public bool bool__188;
		[Serialize("bool__189"                      )] public bool bool__189;
		[Serialize("bool__190"                      )] public bool bool__190;
		[Serialize("bool__191"                      )] public bool bool__191;
		[Serialize("bool__192"                      )] public bool bool__192;
		[Serialize("bool__193"                      )] public bool bool__193;
		[Serialize("bool__194"                      )] public bool bool__194;
		[Serialize("bool__195"                      )] public bool bool__195;
		[Serialize("bool__196"                      )] public bool bool__196;
		[Serialize("bool__197"                      )] public bool bool__197;
		[Serialize("bool__198"                      )] public bool bool__198;
		[Serialize("bool__199"                      )] public bool bool__199;
		[Serialize("uint__200"                      )] public uint uint__200;
		[Serialize("Angle__201"                     )] public Angle Angle__201;
		[Serialize("Enum_VH_3__202"                 )] public Enum_VH_3 Enum_VH_3__202;
		[Serialize("Enum_VH_4__203"                 )] public Enum_VH_4 Enum_VH_4__203;
		[Serialize("bool__204"                      )] public bool bool__204;
		[Serialize("bool__205"                      )] public bool bool__205;
		[Serialize("Vector2__206"                   )] public Vector2 Vector2__206;
		[Serialize("bool__207"                      )] public bool bool__207;
		[Serialize("CArray<ParPhase>__208"          )] public CArray<ParPhase> CArray_ParPhase__208;
		[Serialize("ParLifeTimeCurve__209"          )] public ParLifeTimeCurve ParLifeTimeCurve__209;
		[Serialize("ParLifeTimeCurve__210"          )] public ParLifeTimeCurve ParLifeTimeCurve__210;
		[Serialize("ParLifeTimeCurve__211"          )] public ParLifeTimeCurve ParLifeTimeCurve__211;
		[Serialize("ParLifeTimeCurve__212"          )] public ParLifeTimeCurve ParLifeTimeCurve__212;
		[Serialize("ParLifeTimeCurve__213"          )] public ParLifeTimeCurve ParLifeTimeCurve__213;
		[Serialize("ParLifeTimeCurve__214"          )] public ParLifeTimeCurve ParLifeTimeCurve__214;
		[Serialize("ParLifeTimeCurve__215"          )] public ParLifeTimeCurve ParLifeTimeCurve__215;
		[Serialize("ParLifeTimeCurve__216"          )] public ParLifeTimeCurve ParLifeTimeCurve__216;
		[Serialize("ParLifeTimeCurve__217"          )] public ParLifeTimeCurve ParLifeTimeCurve__217;
		[Serialize("ParLifeTimeCurve__218"          )] public ParLifeTimeCurve ParLifeTimeCurve__218;
		[Serialize("ParLifeTimeCurve__219"          )] public ParLifeTimeCurve ParLifeTimeCurve__219;
		[Serialize("ParLifeTimeCurve__220"          )] public ParLifeTimeCurve ParLifeTimeCurve__220;
		[Serialize("ParLifeTimeCurve__221"          )] public ParLifeTimeCurve ParLifeTimeCurve__221;
		[Serialize("ParLifeTimeCurve__222"          )] public ParLifeTimeCurve ParLifeTimeCurve__222;
		[Serialize("ParLifeTimeCurve__223"          )] public ParLifeTimeCurve ParLifeTimeCurve__223;
		[Serialize("EmitLifeTimeCurve__224"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__224;
		[Serialize("EmitLifeTimeCurve__225"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__225;
		[Serialize("EmitLifeTimeCurve__226"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__226;
		[Serialize("EmitLifeTimeCurve__227"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__227;
		[Serialize("EmitLifeTimeCurve__228"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__228;
		[Serialize("EmitLifeTimeCurve__229"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__229;
		[Serialize("EmitLifeTimeCurve__230"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__230;
		[Serialize("EmitLifeTimeCurve__231"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__231;
		[Serialize("EmitLifeTimeCurve__232"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__232;
		[Serialize("EmitLifeTimeCurve__233"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__233;
		[Serialize("EmitLifeTimeCurve__234"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__234;
		[Serialize("EmitLifeTimeCurve__235"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__235;
		[Serialize("EmitLifeTimeCurve__236"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__236;
		[Serialize("EmitLifeTimeCurve__237"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__237;
		[Serialize("EmitLifeTimeCurve__238"         )] public EmitLifeTimeCurve EmitLifeTimeCurve__238;
		[Serialize("Enum_VH_4__239"                 )] public Enum_VH_4 Enum_VH_4__239;
		[Serialize("Enum_VH_4__240"                 )] public Enum_VH_4 Enum_VH_4__240;
		[Serialize("Enum_VH_5__241"                 )] public Enum_VH_5 Enum_VH_5__241;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(Color__1));
				SerializeField(s, nameof(uint__2));
				SerializeField(s, nameof(Vector3__3));
				SerializeField(s, nameof(Vector2__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(Vector3__6));
				SerializeField(s, nameof(Vector3__7));
				SerializeField(s, nameof(Vector3__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(int__10));
				SerializeField(s, nameof(float__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(Angle__15));
				SerializeField(s, nameof(Angle__16));
				SerializeField(s, nameof(Angle__17));
				SerializeField(s, nameof(Angle__18));
				SerializeField(s, nameof(float__19));
				SerializeField(s, nameof(uint__20));
				SerializeField(s, nameof(float__21));
				SerializeField(s, nameof(float__22));
				SerializeField(s, nameof(float__23));
				SerializeField(s, nameof(Vector3__24));
				SerializeField(s, nameof(Vector3__25));
				SerializeField(s, nameof(int__26));
				SerializeField(s, nameof(AABB__27));
				SerializeField(s, nameof(AABB__28));
				SerializeField(s, nameof(uint__29));
				SerializeField(s, nameof(Enum_RJR_0__30));
				SerializeField(s, nameof(int__31));
				SerializeField(s, nameof(int__32));
				SerializeField(s, nameof(int__33));
				SerializeField(s, nameof(int__34));
				SerializeField(s, nameof(uint__35));
				SerializeField(s, nameof(uint__36));
				SerializeField(s, nameof(float__37));
				SerializeField(s, nameof(uint__38));
				SerializeField(s, nameof(int__39));
				SerializeField(s, nameof(int__40));
				SerializeField(s, nameof(Angle__41));
				SerializeField(s, nameof(Angle__42));
				SerializeField(s, nameof(int__43));
				SerializeField(s, nameof(int__44));
				SerializeField(s, nameof(int__45));
				SerializeField(s, nameof(int__46));
				SerializeField(s, nameof(int__47));
				SerializeField(s, nameof(int__48));
				SerializeField(s, nameof(int__49));
				SerializeField(s, nameof(int__50));
				SerializeField(s, nameof(int__51));
				SerializeField(s, nameof(uint__52));
				SerializeField(s, nameof(Angle__53));
				SerializeField(s, nameof(int__54));
				SerializeField(s, nameof(int__55));
				SerializeField(s, nameof(int__56));
				SerializeField(s, nameof(Vector2__57));
				SerializeField(s, nameof(int__58));
				SerializeField(s, nameof(CList_ParPhase__59));
				SerializeField(s, nameof(Enum_RJR_1__60));
				SerializeField(s, nameof(Enum_RJR_2__61));
				SerializeField(s, nameof(Enum_RJR_3__62));
			} else if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(uint__63));
				SerializeField(s, nameof(Color__64));
				SerializeField(s, nameof(uint__65));
				SerializeField(s, nameof(Vector3__66));
				SerializeField(s, nameof(Vector2__67));
				SerializeField(s, nameof(float__68));
				SerializeField(s, nameof(Vector3__69));
				SerializeField(s, nameof(Vector3__70));
				SerializeField(s, nameof(Vector3__71));
				SerializeField(s, nameof(float__72));
				SerializeField(s, nameof(int__73));
				SerializeField(s, nameof(float__74));
				SerializeField(s, nameof(float__75));
				SerializeField(s, nameof(float__76));
				SerializeField(s, nameof(float__77));
				SerializeField(s, nameof(Angle__78));
				SerializeField(s, nameof(Angle__79));
				SerializeField(s, nameof(Angle__80));
				SerializeField(s, nameof(Angle__81));
				SerializeField(s, nameof(float__82));
				SerializeField(s, nameof(uint__83));
				SerializeField(s, nameof(float__84));
				SerializeField(s, nameof(float__85));
				SerializeField(s, nameof(float__86));
				SerializeField(s, nameof(Vector3__87));
				SerializeField(s, nameof(Vector3__88));
				SerializeField(s, nameof(int__89));
				SerializeField(s, nameof(AABB__90));
				SerializeField(s, nameof(AABB__91));
				SerializeField(s, nameof(uint__92));
				SerializeField(s, nameof(Enum_RFR_0__93));
				SerializeField(s, nameof(int__94));
				SerializeField(s, nameof(int__95));
				SerializeField(s, nameof(int__96));
				SerializeField(s, nameof(int__97));
				SerializeField(s, nameof(uint__98));
				SerializeField(s, nameof(uint__99));
				SerializeField(s, nameof(float__100));
				SerializeField(s, nameof(uint__101));
				SerializeField(s, nameof(int__102));
				SerializeField(s, nameof(int__103));
				SerializeField(s, nameof(Angle__104));
				SerializeField(s, nameof(Angle__105));
				SerializeField(s, nameof(int__106));
				SerializeField(s, nameof(int__107));
				SerializeField(s, nameof(int__108));
				SerializeField(s, nameof(int__109));
				SerializeField(s, nameof(int__110));
				SerializeField(s, nameof(int__111));
				SerializeField(s, nameof(int__112));
				SerializeField(s, nameof(int__113));
				SerializeField(s, nameof(int__114));
				SerializeField(s, nameof(uint__115));
				SerializeField(s, nameof(Angle__116));
				SerializeField(s, nameof(int__117));
				SerializeField(s, nameof(int__118));
				SerializeField(s, nameof(int__119));
				SerializeField(s, nameof(Vector2__120));
				SerializeField(s, nameof(int__121));
				SerializeField(s, nameof(CList_ParPhase__122));
				SerializeField(s, nameof(Enum_RFR_1__123));
				SerializeField(s, nameof(Enum_RFR_2__124));
				SerializeField(s, nameof(Enum_RFR_3__125));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(uint__126));
				SerializeField(s, nameof(Color__127));
				SerializeField(s, nameof(uint__128));
				SerializeField(s, nameof(bool__129));
				SerializeField(s, nameof(bool__130));
				SerializeField(s, nameof(float__131));
				SerializeField(s, nameof(float__132));
				SerializeField(s, nameof(Enum_VH_0__133));
				SerializeField(s, nameof(Vector3__134));
				SerializeField(s, nameof(Vector2__135));
				SerializeField(s, nameof(float__136));
				SerializeField(s, nameof(float__137));
				SerializeField(s, nameof(float__138));
				SerializeField(s, nameof(Vector3__139));
				SerializeField(s, nameof(Vector3__140));
				SerializeField(s, nameof(float__141));
				SerializeField(s, nameof(bool__142));
				SerializeField(s, nameof(float__143));
				SerializeField(s, nameof(float__144));
				SerializeField(s, nameof(float__145));
				SerializeField(s, nameof(float__146));
				SerializeField(s, nameof(bool__147));
				SerializeField(s, nameof(uint__148));
				SerializeField(s, nameof(uint__149));
				SerializeField(s, nameof(uint__150));
				SerializeField(s, nameof(Angle__151));
				SerializeField(s, nameof(Angle__152));
				SerializeField(s, nameof(Angle__153));
				SerializeField(s, nameof(Angle__154));
				SerializeField(s, nameof(float__155));
				SerializeField(s, nameof(uint__156));
				SerializeField(s, nameof(float__157));
				SerializeField(s, nameof(float__158));
				SerializeField(s, nameof(float__159));
				SerializeField(s, nameof(float__160));
				SerializeField(s, nameof(Vector3__161));
				SerializeField(s, nameof(Vector3__162));
				SerializeField(s, nameof(bool__163));
				SerializeField(s, nameof(int__164));
				SerializeField(s, nameof(bool__165));
				SerializeField(s, nameof(bool__166));
				SerializeField(s, nameof(AABB__167));
				SerializeField(s, nameof(float__168));
				SerializeField(s, nameof(uint__169));
				SerializeField(s, nameof(float__170));
				SerializeField(s, nameof(float__171));
				SerializeField(s, nameof(float__172));
				SerializeField(s, nameof(AABB__173));
				SerializeField(s, nameof(uint__174));
				SerializeField(s, nameof(Enum_VH_1__175));
				SerializeField(s, nameof(Enum_VH_2__176));
				SerializeField(s, nameof(float__177));
				SerializeField(s, nameof(Angle__178));
				SerializeField(s, nameof(Angle__179));
				SerializeField(s, nameof(bool__180));
				SerializeField(s, nameof(bool__181));
				SerializeField(s, nameof(float__182));
				SerializeField(s, nameof(float__183));
				SerializeField(s, nameof(float__184));
				SerializeField(s, nameof(uint__185));
				SerializeField(s, nameof(uint__186));
				SerializeField(s, nameof(bool__187));
				SerializeField(s, nameof(bool__188));
				SerializeField(s, nameof(bool__189));
				SerializeField(s, nameof(bool__190));
				SerializeField(s, nameof(bool__191));
				SerializeField(s, nameof(bool__192));
				SerializeField(s, nameof(bool__193));
				SerializeField(s, nameof(bool__194));
				SerializeField(s, nameof(bool__195));
				SerializeField(s, nameof(bool__196));
				SerializeField(s, nameof(bool__197));
				SerializeField(s, nameof(bool__198));
				SerializeField(s, nameof(bool__199));
				SerializeField(s, nameof(uint__200));
				SerializeField(s, nameof(Angle__201));
				SerializeField(s, nameof(Enum_VH_3__202));
				SerializeField(s, nameof(Enum_VH_4__203));
				SerializeField(s, nameof(bool__204));
				SerializeField(s, nameof(bool__205));
				SerializeField(s, nameof(Vector2__206));
				SerializeField(s, nameof(bool__207));
				SerializeField(s, nameof(CArray_ParPhase__208));
				SerializeField(s, nameof(ParLifeTimeCurve__209));
				SerializeField(s, nameof(ParLifeTimeCurve__210));
				SerializeField(s, nameof(ParLifeTimeCurve__211));
				SerializeField(s, nameof(ParLifeTimeCurve__212));
				SerializeField(s, nameof(ParLifeTimeCurve__213));
				SerializeField(s, nameof(ParLifeTimeCurve__214));
				SerializeField(s, nameof(ParLifeTimeCurve__215));
				SerializeField(s, nameof(ParLifeTimeCurve__216));
				SerializeField(s, nameof(ParLifeTimeCurve__217));
				SerializeField(s, nameof(ParLifeTimeCurve__218));
				SerializeField(s, nameof(ParLifeTimeCurve__219));
				SerializeField(s, nameof(ParLifeTimeCurve__220));
				SerializeField(s, nameof(ParLifeTimeCurve__221));
				SerializeField(s, nameof(ParLifeTimeCurve__222));
				SerializeField(s, nameof(ParLifeTimeCurve__223));
				SerializeField(s, nameof(EmitLifeTimeCurve__224));
				SerializeField(s, nameof(EmitLifeTimeCurve__225));
				SerializeField(s, nameof(EmitLifeTimeCurve__226));
				SerializeField(s, nameof(EmitLifeTimeCurve__227));
				SerializeField(s, nameof(EmitLifeTimeCurve__228));
				SerializeField(s, nameof(EmitLifeTimeCurve__229));
				SerializeField(s, nameof(EmitLifeTimeCurve__230));
				SerializeField(s, nameof(EmitLifeTimeCurve__231));
				SerializeField(s, nameof(EmitLifeTimeCurve__232));
				SerializeField(s, nameof(EmitLifeTimeCurve__233));
				SerializeField(s, nameof(EmitLifeTimeCurve__234));
				SerializeField(s, nameof(EmitLifeTimeCurve__235));
				SerializeField(s, nameof(EmitLifeTimeCurve__236));
				SerializeField(s, nameof(EmitLifeTimeCurve__237));
				SerializeField(s, nameof(EmitLifeTimeCurve__238));
				SerializeField(s, nameof(Enum_VH_4__239));
				SerializeField(s, nameof(Enum_VH_4__240));
				SerializeField(s, nameof(Enum_VH_5__241));
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
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
		}
		public enum Enum_RJR_1 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_21")] Value_21 = 21,
		}
		public enum Enum_RJR_2 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_RJR_3 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
		}
		public enum Enum_RFR_1 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_21")] Value_21 = 21,
		}
		public enum Enum_RFR_2 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_RFR_3 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
		}
		public enum Enum_VH_2 {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_32")] Value_32 = 32,
		}
		public enum Enum_VH_3 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_VH_4 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
	}
}

