namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class AfterFxComponent_Template : ActorComponent_Template {
		public AFX afxtype;
		public GFX_BLEND finalblend = GFX_BLEND.ALPHA;
		public float startRank = -1000f;
		public float renderRank = 1000f;
		public uint renderintarget;
		public Color colorRTarget = Color.Black;
		public CArrayP<float> paramf;
		public CArrayP<int> parami;
		public CListO<Vec3d> paramv;
		public CArrayO<Color> paramc;
		public CListO<InputDesc> inputs;
		public CListO<ProceduralInputData> ParamfProceduralInput;
		public Color colorRTargetMin = Color.Black;
		public Color colorRTargetMax = Color.Black;
		public ProceduralInputData colorRTargetInputData;
		public Path customTex0;
		public Enum_alphaMode alphaMode;
		public float alphaRadialProgressionSpeed = 1f;
		public float alphaFadeTime = 1f;
		public bool alphaFadeIn;
		public float alphaFadeTotalDuration = 5f;
		public AABB forcedAABB;
		public bool deactivateAfterFade;
		public AFX2 afxtype2;
		public GFX_BLEND2 finalblend2 = GFX_BLEND2.ALPHA;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.VH) {
				afxtype2 = s.Serialize<AFX2>(afxtype2, name: "afxtype");
				finalblend2 = s.Serialize<GFX_BLEND2>(finalblend2, name: "finalblend");
				startRank = s.Serialize<float>(startRank, name: "startRank");
				renderRank = s.Serialize<float>(renderRank, name: "renderRank");
				renderintarget = s.Serialize<uint>(renderintarget, name: "renderintarget");
				colorRTarget = s.SerializeObject<Color>(colorRTarget, name: "colorRTarget");
				paramf = s.SerializeObject<CArrayP<float>>(paramf, name: "paramf");
				parami = s.SerializeObject<CArrayP<int>>(parami, name: "parami");
				paramv = s.SerializeObject<CListO<Vec3d>>(paramv, name: "paramv");
				paramc = s.SerializeObject<CArrayO<Color>>(paramc, name: "paramc");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				ParamfProceduralInput = s.SerializeObject<CListO<ProceduralInputData>>(ParamfProceduralInput, name: "ParamfProceduralInput");
				colorRTargetMin = s.SerializeObject<Color>(colorRTargetMin, name: "colorRTargetMin");
				colorRTargetMax = s.SerializeObject<Color>(colorRTargetMax, name: "colorRTargetMax");
				colorRTargetInputData = s.SerializeObject<ProceduralInputData>(colorRTargetInputData, name: "colorRTargetInputData");
				customTex0 = s.SerializeObject<Path>(customTex0, name: "customTex0");
				alphaMode = s.Serialize<Enum_alphaMode>(alphaMode, name: "alphaMode");
				alphaRadialProgressionSpeed = s.Serialize<float>(alphaRadialProgressionSpeed, name: "alphaRadialProgressionSpeed");
				alphaFadeTime = s.Serialize<float>(alphaFadeTime, name: "alphaFadeTime");
				alphaFadeIn = s.Serialize<bool>(alphaFadeIn, name: "alphaFadeIn");
				alphaFadeTotalDuration = s.Serialize<float>(alphaFadeTotalDuration, name: "alphaFadeTotalDuration");
				forcedAABB = s.SerializeObject<AABB>(forcedAABB, name: "forcedAABB");
				deactivateAfterFade = s.Serialize<bool>(deactivateAfterFade, name: "deactivateAfterFade");
			} else if (s.Settings.game == Settings.Game.RL) {
				afxtype2 = s.Serialize<AFX2>(afxtype2, name: "afxtype");
				finalblend = s.Serialize<GFX_BLEND>(finalblend, name: "finalblend");
				startRank = s.Serialize<float>(startRank, name: "startRank");
				renderRank = s.Serialize<float>(renderRank, name: "renderRank");
				renderintarget = s.Serialize<uint>(renderintarget, name: "renderintarget");
				colorRTarget = s.SerializeObject<Color>(colorRTarget, name: "colorRTarget");
				paramf = s.SerializeObject<CArrayP<float>>(paramf, name: "paramf");
				parami = s.SerializeObject<CArrayP<int>>(parami, name: "parami");
				paramv = s.SerializeObject<CListO<Vec3d>>(paramv, name: "paramv");
				paramc = s.SerializeObject<CArrayO<Color>>(paramc, name: "paramc");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				ParamfProceduralInput = s.SerializeObject<CListO<ProceduralInputData>>(ParamfProceduralInput, name: "ParamfProceduralInput");
				colorRTargetMin = s.SerializeObject<Color>(colorRTargetMin, name: "colorRTargetMin");
				colorRTargetMax = s.SerializeObject<Color>(colorRTargetMax, name: "colorRTargetMax");
				colorRTargetInputData = s.SerializeObject<ProceduralInputData>(colorRTargetInputData, name: "colorRTargetInputData");
				customTex0 = s.SerializeObject<Path>(customTex0, name: "customTex0");
				alphaMode = s.Serialize<Enum_alphaMode>(alphaMode, name: "alphaMode");
				alphaRadialProgressionSpeed = s.Serialize<float>(alphaRadialProgressionSpeed, name: "alphaRadialProgressionSpeed");
				alphaFadeTime = s.Serialize<float>(alphaFadeTime, name: "alphaFadeTime");
				alphaFadeIn = s.Serialize<bool>(alphaFadeIn, name: "alphaFadeIn");
				alphaFadeTotalDuration = s.Serialize<float>(alphaFadeTotalDuration, name: "alphaFadeTotalDuration");
				forcedAABB = s.SerializeObject<AABB>(forcedAABB, name: "forcedAABB");
				deactivateAfterFade = s.Serialize<bool>(deactivateAfterFade, name: "deactivateAfterFade");
			} else if (s.Settings.game == Settings.Game.COL) {
				afxtype2 = s.Serialize<AFX2>(afxtype2, name: "afxtype");
				finalblend = s.Serialize<GFX_BLEND>(finalblend, name: "finalblend");
				startRank = s.Serialize<float>(startRank, name: "startRank");
				renderRank = s.Serialize<float>(renderRank, name: "renderRank");
				renderintarget = s.Serialize<uint>(renderintarget, name: "renderintarget");
				colorRTarget = s.SerializeObject<Color>(colorRTarget, name: "colorRTarget");
				paramf = s.SerializeObject<CArrayP<float>>(paramf, name: "paramf");
				parami = s.SerializeObject<CArrayP<int>>(parami, name: "parami");
				paramv = s.SerializeObject<CListO<Vec3d>>(paramv, name: "paramv");
				colorRTargetMin = s.SerializeObject<Color>(colorRTargetMin, name: "colorRTargetMin");
				colorRTargetMax = s.SerializeObject<Color>(colorRTargetMax, name: "colorRTargetMax");
				colorRTargetInputData = s.SerializeObject<ProceduralInputData>(colorRTargetInputData, name: "colorRTargetInputData");
				customTex0 = s.SerializeObject<Path>(customTex0, name: "customTex0");
				alphaMode = s.Serialize<Enum_alphaMode>(alphaMode, name: "alphaMode");
				alphaRadialProgressionSpeed = s.Serialize<float>(alphaRadialProgressionSpeed, name: "alphaRadialProgressionSpeed");
				alphaFadeTime = s.Serialize<float>(alphaFadeTime, name: "alphaFadeTime");
				alphaFadeIn = s.Serialize<bool>(alphaFadeIn, name: "alphaFadeIn", options: CSerializerObject.Options.BoolAsByte);
				alphaFadeTotalDuration = s.Serialize<float>(alphaFadeTotalDuration, name: "alphaFadeTotalDuration");
				forcedAABB = s.SerializeObject<AABB>(forcedAABB, name: "forcedAABB");
				deactivateAfterFade = s.Serialize<bool>(deactivateAfterFade, name: "deactivateAfterFade", options: CSerializerObject.Options.BoolAsByte);
			} else {
				afxtype = s.Serialize<AFX>(afxtype, name: "afxtype");
				finalblend = s.Serialize<GFX_BLEND>(finalblend, name: "finalblend");
				startRank = s.Serialize<float>(startRank, name: "startRank");
				renderRank = s.Serialize<float>(renderRank, name: "renderRank");
				renderintarget = s.Serialize<uint>(renderintarget, name: "renderintarget");
				colorRTarget = s.SerializeObject<Color>(colorRTarget, name: "colorRTarget");
				paramf = s.SerializeObject<CArrayP<float>>(paramf, name: "paramf");
				parami = s.SerializeObject<CArrayP<int>>(parami, name: "parami");
				paramv = s.SerializeObject<CListO<Vec3d>>(paramv, name: "paramv");
				paramc = s.SerializeObject<CArrayO<Color>>(paramc, name: "paramc");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				ParamfProceduralInput = s.SerializeObject<CListO<ProceduralInputData>>(ParamfProceduralInput, name: "ParamfProceduralInput");
				colorRTargetMin = s.SerializeObject<Color>(colorRTargetMin, name: "colorRTargetMin");
				colorRTargetMax = s.SerializeObject<Color>(colorRTargetMax, name: "colorRTargetMax");
				colorRTargetInputData = s.SerializeObject<ProceduralInputData>(colorRTargetInputData, name: "colorRTargetInputData");
				customTex0 = s.SerializeObject<Path>(customTex0, name: "customTex0");
				alphaMode = s.Serialize<Enum_alphaMode>(alphaMode, name: "alphaMode");
				alphaRadialProgressionSpeed = s.Serialize<float>(alphaRadialProgressionSpeed, name: "alphaRadialProgressionSpeed");
				alphaFadeTime = s.Serialize<float>(alphaFadeTime, name: "alphaFadeTime");
				alphaFadeIn = s.Serialize<bool>(alphaFadeIn, name: "alphaFadeIn");
				alphaFadeTotalDuration = s.Serialize<float>(alphaFadeTotalDuration, name: "alphaFadeTotalDuration");
				forcedAABB = s.SerializeObject<AABB>(forcedAABB, name: "forcedAABB");
				deactivateAfterFade = s.Serialize<bool>(deactivateAfterFade, name: "deactivateAfterFade");
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

