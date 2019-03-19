using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class GFXPrimitiveParam : CSerializable {
		[Serialize("GridFluidParam"                   )] public GFX_GridFluidObjParam GridFluidParam;
		[Serialize("GlobalScissor"                    )] public Enum_GlobalScissor GlobalScissor;
		[Serialize("colorFactor"                      )] public Color colorFactor;
		[Serialize("FrontLightBrightness"             )] public float FrontLightBrightness;
		[Serialize("FrontLightContrast"               )] public float FrontLightContrast;
		[Serialize("BackLightBrightness"              )] public float BackLightBrightness;
		[Serialize("BackLightContrast"                )] public float BackLightContrast;
		[Serialize("colorFog"                         )] public Color colorFog;
		[Serialize("DynamicFogFactor"                 )] public float DynamicFogFactor;
		[Serialize("OutlineColor"                     )] public Color OutlineColor;
		[Serialize("OutlineWidth"                     )] public float OutlineWidth;
		[Serialize("OutlineGlow"                      )] public float OutlineGlow;
		[Serialize("ViewportVisibility"               )] public uint ViewportVisibility;
		[Serialize("gfxOccludeInfo"                   )] public GFX_OCCLUDE_INFO gfxOccludeInfo;
		[Serialize("colorForMask1"                    )] public Color colorForMask1;
		[Serialize("colorForMask2"                    )] public Color colorForMask2;
		[Serialize("colorForMask3"                    )] public Color colorForMask3;
		[Serialize("saturation"                       )] public float saturation;
		[Serialize("GridFluidEmitterIntensity"        )] public float GridFluidEmitterIntensity;
		[Serialize("FrontLightFactor"                 )] public float FrontLightFactor;
		[Serialize("BackLightFactor"                  )] public float BackLightFactor;
		[Serialize("FrontLightBlurFactor"             )] public float FrontLightBlurFactor;
		[Serialize("BackLightBlurFactor"              )] public float BackLightBlurFactor;
		[Serialize("Color__0"                         )] public Color Color__0;
		[Serialize("float__1"                         )] public float float__1;
		[Serialize("float__2"                         )] public float float__2;
		[Serialize("float__3"                         )] public float float__3;
		[Serialize("float__4"                         )] public float float__4;
		[Serialize("Color__5"                         )] public Color Color__5;
		[Serialize("float__6"                         )] public float float__6;
		[Serialize("bool__7"                          )] public bool bool__7;
		[Serialize("bool__8"                          )] public bool bool__8;
		[Serialize("bool__9"                          )] public bool bool__9;
		[Serialize("bool__10"                         )] public bool bool__10;
		[Serialize("Nullable<NormalLightingParam>__11")] public Nullable<NormalLightingParam> Nullable_NormalLightingParam__11;
		[Serialize("Color__12"                        )] public Color Color__12;
		[Serialize("float__13"                        )] public float float__13;
		[Serialize("float__14"                        )] public float float__14;
		[Serialize("uint__15"                         )] public uint uint__15;
		[Serialize("Enum_VH_0__16"                    )] public Enum_VH_0 Enum_VH_0__16;
		[Serialize("Enum_VH_1__17"                    )] public Enum_VH_1 Enum_VH_1__17;
		[Serialize("Color__18"                        )] public Color Color__18;
		[Serialize("Color__19"                        )] public Color Color__19;
		[Serialize("Color__20"                        )] public Color Color__20;
		[Serialize("float__21"                        )] public float float__21;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Color__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(Color__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(bool__8));
				SerializeField(s, nameof(bool__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(Nullable_NormalLightingParam__11));
				SerializeField(s, nameof(Color__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(uint__15));
				SerializeField(s, nameof(Enum_VH_0__16));
				SerializeField(s, nameof(Enum_VH_1__17));
				SerializeField(s, nameof(Color__18));
				SerializeField(s, nameof(Color__19));
				SerializeField(s, nameof(Color__20));
				SerializeField(s, nameof(float__21));
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(GridFluidParam));
				}
				SerializeField(s, nameof(GlobalScissor));
				SerializeField(s, nameof(colorFactor));
				SerializeField(s, nameof(FrontLightBrightness));
				SerializeField(s, nameof(FrontLightContrast));
				SerializeField(s, nameof(BackLightBrightness));
				SerializeField(s, nameof(BackLightContrast));
				SerializeField(s, nameof(colorFog));
				SerializeField(s, nameof(DynamicFogFactor));
				SerializeField(s, nameof(OutlineColor));
				SerializeField(s, nameof(OutlineWidth));
				SerializeField(s, nameof(OutlineGlow));
				SerializeField(s, nameof(ViewportVisibility));
				SerializeField(s, nameof(gfxOccludeInfo));
				SerializeField(s, nameof(colorForMask1));
				SerializeField(s, nameof(colorForMask2));
				SerializeField(s, nameof(colorForMask3));
				SerializeField(s, nameof(saturation));
				SerializeField(s, nameof(GridFluidEmitterIntensity));
				SerializeField(s, nameof(FrontLightFactor));
				SerializeField(s, nameof(BackLightFactor));
				SerializeField(s, nameof(FrontLightBlurFactor));
				SerializeField(s, nameof(BackLightBlurFactor));
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

