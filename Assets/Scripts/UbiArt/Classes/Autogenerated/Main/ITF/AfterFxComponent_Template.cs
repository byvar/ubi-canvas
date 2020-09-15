using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class AfterFxComponent_Template : ActorComponent_Template {
		[Serialize("afxtype"                    )] public AFX afxtype;
		[Serialize("finalblend"                 )] public GFX_BLEND finalblend;
		[Serialize("startRank"                  )] public float startRank;
		[Serialize("renderRank"                 )] public float renderRank;
		[Serialize("renderintarget"             )] public uint renderintarget;
		[Serialize("colorRTarget"               )] public Color colorRTarget;
		[Serialize("paramf"                     )] public CArray<float> paramf;
		[Serialize("parami"                     )] public CArray<int> parami;
		[Serialize("paramv"                     )] public CList<Vec3d> paramv;
		[Serialize("paramc"                     )] public CArray<Color> paramc;
		[Serialize("inputs"                     )] public CList<InputDesc> inputs;
		[Serialize("ParamfProceduralInput"      )] public CList<ProceduralInputData> ParamfProceduralInput;
		[Serialize("colorRTargetMin"            )] public Color colorRTargetMin;
		[Serialize("colorRTargetMax"            )] public Color colorRTargetMax;
		[Serialize("colorRTargetInputData"      )] public ProceduralInputData colorRTargetInputData;
		[Serialize("customTex0"                 )] public Path customTex0;
		[Serialize("alphaMode"                  )] public Enum_alphaMode alphaMode;
		[Serialize("alphaRadialProgressionSpeed")] public float alphaRadialProgressionSpeed;
		[Serialize("alphaFadeTime"              )] public float alphaFadeTime;
		[Serialize("alphaFadeIn"                )] public bool alphaFadeIn;
		[Serialize("alphaFadeTotalDuration"     )] public float alphaFadeTotalDuration;
		[Serialize("forcedAABB"                 )] public AABB forcedAABB;
		[Serialize("deactivateAfterFade"        )] public bool deactivateAfterFade;
		[Serialize("afxtype"                    )] public AFX2 afxtype2;
		[Serialize("finalblend"                 )] public GFX_BLEND2 finalblend2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(afxtype2));
				SerializeField(s, nameof(finalblend2));
				SerializeField(s, nameof(startRank));
				SerializeField(s, nameof(renderRank));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(colorRTarget));
				SerializeField(s, nameof(paramf));
				SerializeField(s, nameof(parami));
				SerializeField(s, nameof(paramv));
				SerializeField(s, nameof(paramc));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(ParamfProceduralInput));
				SerializeField(s, nameof(colorRTargetMin));
				SerializeField(s, nameof(colorRTargetMax));
				SerializeField(s, nameof(colorRTargetInputData));
				SerializeField(s, nameof(customTex0));
				SerializeField(s, nameof(alphaMode));
				SerializeField(s, nameof(alphaRadialProgressionSpeed));
				SerializeField(s, nameof(alphaFadeTime));
				SerializeField(s, nameof(alphaFadeIn));
				SerializeField(s, nameof(alphaFadeTotalDuration));
				SerializeField(s, nameof(forcedAABB));
				SerializeField(s, nameof(deactivateAfterFade));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(afxtype2));
				SerializeField(s, nameof(finalblend));
				SerializeField(s, nameof(startRank));
				SerializeField(s, nameof(renderRank));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(colorRTarget));
				SerializeField(s, nameof(paramf));
				SerializeField(s, nameof(parami));
				SerializeField(s, nameof(paramv));
				SerializeField(s, nameof(paramc));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(ParamfProceduralInput));
				SerializeField(s, nameof(colorRTargetMin));
				SerializeField(s, nameof(colorRTargetMax));
				SerializeField(s, nameof(colorRTargetInputData));
				SerializeField(s, nameof(customTex0));
				SerializeField(s, nameof(alphaMode));
				SerializeField(s, nameof(alphaRadialProgressionSpeed));
				SerializeField(s, nameof(alphaFadeTime));
				SerializeField(s, nameof(alphaFadeIn));
				SerializeField(s, nameof(alphaFadeTotalDuration));
				SerializeField(s, nameof(forcedAABB));
				SerializeField(s, nameof(deactivateAfterFade));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(afxtype2));
				SerializeField(s, nameof(finalblend));
				SerializeField(s, nameof(startRank));
				SerializeField(s, nameof(renderRank));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(colorRTarget));
				SerializeField(s, nameof(paramf));
				SerializeField(s, nameof(parami));
				SerializeField(s, nameof(paramv));
				SerializeField(s, nameof(colorRTargetMin));
				SerializeField(s, nameof(colorRTargetMax));
				SerializeField(s, nameof(colorRTargetInputData));
				SerializeField(s, nameof(customTex0));
				SerializeField(s, nameof(alphaMode));
				SerializeField(s, nameof(alphaRadialProgressionSpeed));
				SerializeField(s, nameof(alphaFadeTime));
				SerializeField(s, nameof(alphaFadeIn), boolAsByte: true);
				SerializeField(s, nameof(alphaFadeTotalDuration));
				SerializeField(s, nameof(forcedAABB));
				SerializeField(s, nameof(deactivateAfterFade), boolAsByte: true);
			} else {
				SerializeField(s, nameof(afxtype));
				SerializeField(s, nameof(finalblend));
				SerializeField(s, nameof(startRank));
				SerializeField(s, nameof(renderRank));
				SerializeField(s, nameof(renderintarget));
				SerializeField(s, nameof(colorRTarget));
				SerializeField(s, nameof(paramf));
				SerializeField(s, nameof(paramf));
				SerializeField(s, nameof(parami));
				SerializeField(s, nameof(parami));
				SerializeField(s, nameof(paramv));
				SerializeField(s, nameof(paramc));
				SerializeField(s, nameof(paramc));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(ParamfProceduralInput));
				SerializeField(s, nameof(colorRTargetMin));
				SerializeField(s, nameof(colorRTargetMax));
				SerializeField(s, nameof(colorRTargetInputData));
				SerializeField(s, nameof(customTex0));
				SerializeField(s, nameof(alphaMode));
				SerializeField(s, nameof(alphaRadialProgressionSpeed));
				SerializeField(s, nameof(alphaFadeTime));
				SerializeField(s, nameof(alphaFadeIn));
				SerializeField(s, nameof(alphaFadeTotalDuration));
				SerializeField(s, nameof(forcedAABB));
				SerializeField(s, nameof(deactivateAfterFade));
			}
		}
		public enum AFX {
			[Serialize("AFX_None"          )] None = 0,
			[Serialize("AFX_Blur"          )] Blur = 1,
			[Serialize("AFX_Glow"          )] Glow = 2,
			[Serialize("AFX_Remanence"     )] Remanence = 3,
			[Serialize("AFX_DOF"           )] DOF = 4,
			[Serialize("AFX_RayCenter"     )] RayCenter = 5,
			[Serialize("AFX_ColorSetting"  )] ColorSetting = 6,
			[Serialize("AFX_ColorRemap"    )] ColorRemap = 7,
			[Serialize("AFX_ColorLevels"   )] ColorLevels = 8,
			[Serialize("AFX_Fade"          )] Fade = 9,
			[Serialize("AFX_Bright"        )] Bright = 10,
			[Serialize("AFX_AddSceneAndMul")] AddSceneAndMul = 11,
			[Serialize("AFX_objectsGlow"   )] objectsGlow = 12,
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
			[Serialize("GFX_BLEND_ALPHATOCOLOR"     )] ALPHATOCOLOR = 18,
			[Serialize("GFX_BLEND_IALPHATOCOLOR"    )] IALPHATOCOLOR = 19,
			[Serialize("GFX_BLEND_SCREEN"           )] SCREEN = 21,
		}
		public enum Enum_alphaMode {
			[Serialize("NONE"   )] NONE = 0,
			[Serialize("UNIFORM")] UNIFORM = 1,
			[Serialize("RADIAL" )] RADIAL = 2,
		}
		public enum GFX_BLEND2 {
			[Serialize("GFX_BLEND_UNKNOWN")] UNKNOWN = 0,
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
			[Serialize("GFX_BLEND_ALPHATOCOLOR"     )] ALPHATOCOLOR = 18,
			[Serialize("GFX_BLEND_IALPHATOCOLOR"    )] IALPHATOCOLOR = 19,
		}
		public enum AFX2 {
			[Serialize("AFX_None")] None = 0,
			[Serialize("AFX_Blur")] Blur = 1,
			[Serialize("AFX_Glow")] Glow = 2,
			[Serialize("AFX_Remanence")] Remanence = 3,
			[Serialize("AFX_DOF")] DOF = 4,
			[Serialize("AFX_RayCenter")] RayCenter = 5,
			[Serialize("AFX_ColorSetting")] ColorSetting = 6,
			[Serialize("AFX_ColorRemap")] ColorRemap = 7,
			[Serialize("AFX_ColorLevels")] ColorLevels = 8,
			[Serialize("AFX_Fade")] Fade = 9,
			[Serialize("AFX_Bright")] Bright = 10,
			[Serialize("AFX_AddSceneAndMul")] AddSceneAndMul = 11,
			[Serialize("AFX_objectsGlow")] objectsGlow = 12,
			[Serialize("AFX_13")] Value_13 = 13,
		}
		public override uint? ClassCRC => 0x98781A09;
	}
}

