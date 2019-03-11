using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMaterialShader_Template : TemplateObj {
		[Serialize("flags"             )] public uint flags;
		[Serialize("renderRegular"     )] public bool renderRegular;
		[Serialize("renderFrontLight"  )] public bool renderFrontLight;
		[Serialize("renderBackLight"   )] public bool renderBackLight;
		[Serialize("renderInReflection")] public int renderInReflection;
		[Serialize("useAlphaTest"      )] public bool useAlphaTest;
		[Serialize("alphaRef"          )] public uint alphaRef;
		[Serialize("separateAlpha"     )] public bool separateAlpha;
		[Serialize("normalMapLighting" )] public bool normalMapLighting;
		[Serialize("textureBlend"      )] public bool textureBlend;
		[Serialize("animInTex"         )] public CList<GFXMatAnimImpostor> animInTex;
		[Serialize("materialtype"      )] public GFX_MAT materialtype;
		[Serialize("lightingType"      )] public GFX_MAT_SHADER lightingType;
		[Serialize("matParams"         )] public GFX_MaterialParams matParams;
		[Serialize("blendmode"         )] public GFX_BLEND blendmode;
		[Serialize("renderToTexture"   )] public bool renderToTexture;
		[Serialize("materialtype"      )] public Enum_materialtype materialtype;
		[Serialize("lightingType"      )] public Enum_lightingType lightingType;
		[Serialize("blendmode"         )] public Enum_blendmode blendmode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(flags));
				SerializeField(s, nameof(renderRegular));
				SerializeField(s, nameof(renderFrontLight));
				SerializeField(s, nameof(renderBackLight));
				SerializeField(s, nameof(useAlphaTest));
				SerializeField(s, nameof(alphaRef));
				SerializeField(s, nameof(separateAlpha));
				SerializeField(s, nameof(textureBlend));
				SerializeField(s, nameof(renderToTexture));
				SerializeField(s, nameof(animInTex));
				SerializeField(s, nameof(materialtype));
				SerializeField(s, nameof(lightingType));
				SerializeField(s, nameof(matParams));
				SerializeField(s, nameof(blendmode));
			} else {
				SerializeField(s, nameof(flags));
				SerializeField(s, nameof(renderRegular));
				SerializeField(s, nameof(renderFrontLight));
				SerializeField(s, nameof(renderBackLight));
				SerializeField(s, nameof(renderInReflection));
				SerializeField(s, nameof(useAlphaTest));
				SerializeField(s, nameof(alphaRef));
				SerializeField(s, nameof(separateAlpha));
				SerializeField(s, nameof(normalMapLighting));
				SerializeField(s, nameof(textureBlend));
				SerializeField(s, nameof(animInTex));
				SerializeField(s, nameof(materialtype));
				SerializeField(s, nameof(lightingType));
				SerializeField(s, nameof(matParams));
				SerializeField(s, nameof(blendmode));
			}
		}
		public enum GFX_MAT {
			[Serialize("GFX_MAT_DEFAULT"      )] DEFAULT = 0,
			[Serialize("GFX_MAT_REFRACTION"   )] REFRACTION = 1,
			[Serialize("GFX_MAT_PATCH"        )] PATCH = 2,
			[Serialize("GFX_MAT_FRIEZEANIM"   )] FRIEZEANIM = 3,
			[Serialize("GFX_MAT_GLOW"         )] GLOW = 4,
			[Serialize("GFX_MAT_ALPHAFADE"    )] ALPHAFADE = 5,
			[Serialize("GFX_MAT_FRIEZEOVERLAY")] FRIEZEOVERLAY = 6,
			[Serialize("GFX_MAT_REFLECTION"   )] REFLECTION = 7,
		}
		public enum GFX_MAT_SHADER {
			[Serialize("GFX_MAT_SHADER_DEFAULT"      )] DEFAULT = 0,
			[Serialize("GFX_MAT_SHADER_LIGHT_LAYERED")] LIGHT_LAYERED = 1,
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
		public enum Enum_materialtype {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_12")] Value_12 = 12,
		}
		public enum Enum_lightingType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_blendmode {
			[Serialize("Value_0" )] Value_0 = 0,
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
			[Serialize("Value_18")] Value_18 = 18,
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_21")] Value_21 = 21,
		}
		public override uint? ClassCRC => 0xE6A935E1;
	}
}

