namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class GFXPrimitiveParam : CSerializable {
		public GFX_GridFluidObjParam GridFluidParam;
		public Enum_GlobalScissor GlobalScissor = 0;
		public Color colorFactor = Color.White;
		public float FrontLightBrightness;
		public float FrontLightContrast = 1f;
		public float BackLightBrightness;
		public float BackLightContrast = 1f;
		public Color colorFog;
		public float DynamicFogFactor = 1f;
		public Color OutlineColor = new Color(1,1,1,0);
		public float OutlineWidth;
		public float OutlineGlow;
		public uint ViewportVisibility = 0xffff;
		public GFX_OCCLUDE_INFO gfxOccludeInfo = GFX_OCCLUDE_INFO.DEFAULT;
		public GFX_OCCLUDE_INFO2 gfxOccludeInfo2 = GFX_OCCLUDE_INFO2.DEFAULT;
		public Color colorForMask1 = Color.White;
		public Color colorForMask2 = Color.White;
		public Color colorForMask3 = Color.White;
		public float saturation;
		public float GridFluidEmitterIntensity = 1f;
		public uint GridFluidEmitterFilter;
		public float FrontLightFactor = 1f;
		public float BackLightFactor = 1f;
		public float FrontLightBlurFactor = 1f;
		public float BackLightBlurFactor = 1f;


		public bool useStaticFog = false;
		public bool RenderInReflections = true;
		public bool RenderToTexture;
		
		public bool UseGlobalLighting = true;
		public bool UseZInject;
		public bool RenderRegular = true;
		public bool RenderFrontLight;
		public bool RenderBackLight;
		public bool RenderFrontLightBlur;
		public bool RenderBackLightBlur;
		public bool RenderGF_Fluid;
		public bool RenderGF_Force;
		public bool RenderGF_Blocker;
		public bool UseColorRamp;
		public bool RenderMaskHole;
		public bool RenderMaskSilhouette;

		public Color Color__5;
		public float float__6;
		public bool bool__7;
		public bool bool__8;
		public bool bool__9;
		public bool bool__10;
		public Nullable<NormalLightingParam> NormalLightParam;
		public NormalLightingParam NormalLightParam2;
		public Color Color__12;
		public float float__13;
		public float float__14;
		public uint uint__15;
		public Enum_VH_0 Enum_VH_0__16;
		public Enum_VH_1 Enum_VH_1__17;
		public Color Color__18;
		public Color Color__19;
		public Color Color__20;
		public float float__21;


		public uint Vita_00 { get; set; }
		public byte Vita_01 { get; set; }
		public Color Vita_02 { get; set; }
		public byte Vita_03 { get; set; }
		public byte Vita_04 { get; set; }
		public byte Vita_05 { get; set; }
		public float Vita_06 { get; set; }
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				colorFactor = s.SerializeObject<Color>(colorFactor, name: "colorFactor");
				if (s.Settings.Platform == GamePlatform.Vita) {
					Vita_03 = s.Serialize<byte>(Vita_03, name: nameof(Vita_03));
					Vita_04 = s.Serialize<byte>(Vita_04, name: nameof(Vita_04));
					Vita_05 = s.Serialize<byte>(Vita_05, name: nameof(Vita_05));
					Vita_06 = s.Serialize<float>(Vita_06, name: nameof(Vita_06));
					Vita_02 = s.SerializeObject<Color>(Vita_02, name: nameof(Vita_02));
				}
				FrontLightBrightness = s.Serialize<float>(FrontLightBrightness, name: "FrontLightBrightness");
				FrontLightContrast = s.Serialize<float>(FrontLightContrast, name: "FrontLightContrast");
				BackLightBrightness = s.Serialize<float>(BackLightBrightness, name: "BackLightBrightness");
				BackLightContrast = s.Serialize<float>(BackLightContrast, name: "BackLightContrast");
				colorFog = s.SerializeObject<Color>(colorFog, name: "colorFog");
				DynamicFogFactor = s.Serialize<float>(DynamicFogFactor, name: "DynamicFogFactor");
				useStaticFog = s.Serialize<bool>(useStaticFog, name: "useStaticFog");
				RenderInReflections = s.Serialize<bool>(RenderInReflections, name: "RenderInReflections");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					RenderToTexture = s.Serialize<bool>(RenderToTexture, name: "RenderToTexture");
				}
				gfxOccludeInfo2 = s.Serialize<GFX_OCCLUDE_INFO2>(gfxOccludeInfo2, name: "gfxOccludeInfo");
				if (s.Settings.Platform == GamePlatform.Vita) {
					Vita_00 = s.Serialize<uint>(Vita_00, name: nameof(Vita_00));
					Vita_01 = s.Serialize<byte>(Vita_01, name: nameof(Vita_01));
				}
			} else if (s.Settings.Game == Game.COL) {
				colorFactor = s.SerializeObject<Color>(colorFactor, name: "colorFactor");
				FrontLightBrightness = s.Serialize<float>(FrontLightBrightness, name: "FrontLightBrightness");
				FrontLightContrast = s.Serialize<float>(FrontLightContrast, name: "FrontLightContrast");
				BackLightBrightness = s.Serialize<float>(BackLightBrightness, name: "BackLightBrightness");
				BackLightContrast = s.Serialize<float>(BackLightContrast, name: "BackLightContrast");
				colorFog = s.SerializeObject<Color>(colorFog, name: "colorFog");
				DynamicFogFactor = s.Serialize<float>(DynamicFogFactor, name: "DynamicFogFactor");
				useStaticFog = s.Serialize<bool>(useStaticFog, name: "useStaticFog", options: CSerializerObject.Options.BoolAsByte);
				RenderInReflections = s.Serialize<bool>(RenderInReflections, name: "RenderInReflections", options: CSerializerObject.Options.BoolAsByte);
				gfxOccludeInfo2 = s.Serialize<GFX_OCCLUDE_INFO2>(gfxOccludeInfo2, name: "gfxOccludeInfo");
			} else if (s.Settings.Game == Game.VH) {
				colorFactor = s.SerializeObject<Color>(colorFactor, name: "colorFactor");
				FrontLightBrightness = s.Serialize<float>(FrontLightBrightness, name: "FrontLightBrightness");
				FrontLightContrast = s.Serialize<float>(FrontLightContrast, name: "FrontLightContrast");
				BackLightBrightness = s.Serialize<float>(BackLightBrightness, name: "BackLightBrightness");
				BackLightContrast = s.Serialize<float>(BackLightContrast, name: "BackLightContrast");
				colorFog = s.SerializeObject<Color>(colorFog, name: "colorFog");
				DynamicFogFactor = s.Serialize<float>(DynamicFogFactor, name: "DynamicFogFactor");
				bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
				bool__8 = s.Serialize<bool>(bool__8, name: "bool__8");
				bool__9 = s.Serialize<bool>(bool__9, name: "bool__9");
				bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
				NormalLightParam = s.SerializeObject<Nullable<NormalLightingParam>>(NormalLightParam, name: "NormalLightParam");
				OutlineColor = s.SerializeObject<Color>(OutlineColor, name: "OutlineColor");
				OutlineWidth = s.Serialize<float>(OutlineWidth, name: "OutlineWidth");
				OutlineGlow = s.Serialize<float>(OutlineGlow, name: "OutlineGlow");
				ViewportVisibility = s.Serialize<uint>(ViewportVisibility, name: "ViewportVisibility");
				Enum_VH_0__16 = s.Serialize<Enum_VH_0>(Enum_VH_0__16, name: "Enum_VH_0__16");
				Enum_VH_1__17 = s.Serialize<Enum_VH_1>(Enum_VH_1__17, name: "Enum_VH_1__17");
				colorForMask1 = s.SerializeObject<Color>(colorForMask1, name: "colorForMask1");
				colorForMask2 = s.SerializeObject<Color>(colorForMask2, name: "colorForMask2");
				colorForMask3 = s.SerializeObject<Color>(colorForMask3, name: "colorForMask3");
				saturation = s.Serialize<float>(saturation, name: "saturation");
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					GridFluidParam = s.SerializeObject<GFX_GridFluidObjParam>(GridFluidParam, name: "GridFluidParam");
				}
				useStaticFog = s.Serialize<bool>(useStaticFog, name: "useStaticFog");
				UseGlobalLighting = s.Serialize<bool>(UseGlobalLighting, name: "UseGlobalLighting");
				RenderInReflections = s.Serialize<bool>(RenderInReflections, name: "RenderInReflections");
				UseZInject = s.Serialize<bool>(UseZInject, name: "UseZInject");
				RenderRegular = s.Serialize<bool>(RenderRegular, name: "RenderRegular");
				RenderFrontLight = s.Serialize<bool>(RenderFrontLight, name: "RenderFrontLight");
				RenderBackLight = s.Serialize<bool>(RenderBackLight, name: "RenderBackLight");
				RenderFrontLightBlur = s.Serialize<bool>(RenderFrontLightBlur, name: "RenderFrontLightBlur");
				RenderBackLightBlur = s.Serialize<bool>(RenderBackLightBlur, name: "RenderBackLightBlur");
				RenderGF_Fluid = s.Serialize<bool>(RenderGF_Fluid, name: "RenderGF_Fluid");
				RenderGF_Force = s.Serialize<bool>(RenderGF_Force, name: "RenderGF_Force");
				RenderGF_Blocker = s.Serialize<bool>(RenderGF_Blocker, name: "RenderGF_Blocker");
				UseColorRamp = s.Serialize<bool>(UseColorRamp, name: "UseColorRamp");
				RenderMaskHole = s.Serialize<bool>(RenderMaskHole, name: "RenderMaskHole");
				RenderMaskSilhouette = s.Serialize<bool>(RenderMaskSilhouette, name: "RenderMaskSilhouette");

				GlobalScissor = s.Serialize<Enum_GlobalScissor>(GlobalScissor, name: "GlobalScissor");
				colorFactor = s.SerializeObject<Color>(colorFactor, name: "colorFactor");
				FrontLightBrightness = s.Serialize<float>(FrontLightBrightness, name: "FrontLightBrightness");
				FrontLightContrast = s.Serialize<float>(FrontLightContrast, name: "FrontLightContrast");
				BackLightBrightness = s.Serialize<float>(BackLightBrightness, name: "BackLightBrightness");
				BackLightContrast = s.Serialize<float>(BackLightContrast, name: "BackLightContrast");
				colorFog = s.SerializeObject<Color>(colorFog, name: "colorFog");
				DynamicFogFactor = s.Serialize<float>(DynamicFogFactor, name: "DynamicFogFactor");

				if (s.Settings.Game == Game.RM) {
					NormalLightParam2 = s.SerializeObject<NormalLightingParam>(NormalLightParam2, name: "NormalLightParam");
				}

				OutlineColor = s.SerializeObject<Color>(OutlineColor, name: "OutlineColor");
				OutlineWidth = s.Serialize<float>(OutlineWidth, name: "OutlineWidth");
				OutlineGlow = s.Serialize<float>(OutlineGlow, name: "OutlineGlow");
				ViewportVisibility = s.Serialize<uint>(ViewportVisibility, name: "ViewportVisibility");
				gfxOccludeInfo = s.Serialize<GFX_OCCLUDE_INFO>(gfxOccludeInfo, name: "gfxOccludeInfo");
				colorForMask1 = s.SerializeObject<Color>(colorForMask1, name: "colorForMask1");
				colorForMask2 = s.SerializeObject<Color>(colorForMask2, name: "colorForMask2");
				colorForMask3 = s.SerializeObject<Color>(colorForMask3, name: "colorForMask3");
				saturation = s.Serialize<float>(saturation, name: "saturation");
				GridFluidEmitterIntensity = s.Serialize<float>(GridFluidEmitterIntensity, name: "GridFluidEmitterIntensity");
				if (s.Settings.Game == Game.RM) {
					GridFluidEmitterFilter = s.Serialize<uint>(GridFluidEmitterFilter, name: "GridFluidEmitterFilter");
				}
				FrontLightFactor = s.Serialize<float>(FrontLightFactor, name: "FrontLightFactor");
				BackLightFactor = s.Serialize<float>(BackLightFactor, name: "BackLightFactor");
				FrontLightBlurFactor = s.Serialize<float>(FrontLightBlurFactor, name: "FrontLightBlurFactor");
				BackLightBlurFactor = s.Serialize<float>(BackLightBlurFactor, name: "BackLightBlurFactor");
			}
		}
		public enum Enum_GlobalScissor {
			[Serialize("NONE"     )] NONE = 0,
			[Serialize("SCISSOR_1")] SCISSOR_1 = 1,
			[Serialize("SCISSOR_2")] SCISSOR_2 = 2,
			[Serialize("SCISSOR_3")] SCISSOR_3 = 3,
		}
		public enum GFX_OCCLUDE_INFO {
			[Serialize("GFX_OCCLUDE_INFO_DEFAULT"             )] DEFAULT = 0,
			[Serialize("GFX_OCCLUDE_INFO_BIG_OPAQUE"          )] BIG_OPAQUE = 1,
			[Serialize("GFX_OCCLUDE_INFO_SMALL_OR_TRANSPARENT")] SMALL_OR_TRANSPARENT = 2,
			[Serialize("GFX_OCCLUDE_INFO_ZPASS_ONLY"          )] ZPASS_ONLY = 3,
		}
		public enum GFX_OCCLUDE_INFO2 {
			[Serialize("GFX_OCCLUDE_INFO_DEFAULT"             )] DEFAULT = 0,
			[Serialize("GFX_OCCLUDE_INFO_BIG_OPAQUE"          )] BIG_OPAQUE = 1,
			[Serialize("GFX_OCCLUDE_INFO_SMALL_OR_TRANSPARENT")] SMALL_OR_TRANSPARENT = 2,
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
		}
	}
}

