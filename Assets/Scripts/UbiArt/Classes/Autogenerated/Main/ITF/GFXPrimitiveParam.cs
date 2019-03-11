using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXPrimitiveParam : CSerializable {
		[Serialize("GridFluidParam"           )] public GFX_GridFluidObjParam GridFluidParam;
		[Serialize("GlobalScissor"            )] public Enum_GlobalScissor GlobalScissor;
		[Serialize("colorFactor"              )] public Color colorFactor;
		[Serialize("FrontLightBrightness"     )] public float FrontLightBrightness;
		[Serialize("FrontLightContrast"       )] public float FrontLightContrast;
		[Serialize("BackLightBrightness"      )] public float BackLightBrightness;
		[Serialize("BackLightContrast"        )] public float BackLightContrast;
		[Serialize("colorFog"                 )] public Color colorFog;
		[Serialize("DynamicFogFactor"         )] public float DynamicFogFactor;
		[Serialize("OutlineColor"             )] public Color OutlineColor;
		[Serialize("OutlineWidth"             )] public float OutlineWidth;
		[Serialize("OutlineGlow"              )] public float OutlineGlow;
		[Serialize("ViewportVisibility"       )] public uint ViewportVisibility;
		[Serialize("gfxOccludeInfo"           )] public GFX_OCCLUDE_INFO gfxOccludeInfo;
		[Serialize("colorForMask1"            )] public Color colorForMask1;
		[Serialize("colorForMask2"            )] public Color colorForMask2;
		[Serialize("colorForMask3"            )] public Color colorForMask3;
		[Serialize("saturation"               )] public float saturation;
		[Serialize("GridFluidEmitterIntensity")] public float GridFluidEmitterIntensity;
		[Serialize("FrontLightFactor"         )] public float FrontLightFactor;
		[Serialize("BackLightFactor"          )] public float BackLightFactor;
		[Serialize("FrontLightBlurFactor"     )] public float FrontLightBlurFactor;
		[Serialize("BackLightBlurFactor"      )] public float BackLightBlurFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
	}
}

