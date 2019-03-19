using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
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
		[Serialize("materialtype"      )] public GFX_MAT2 materialtype2;
		[Serialize("materialtype"      )] public GFX_MAT3 materialtype3;
		[Serialize("lightingType"      )] public GFX_MAT_SHADER lightingType;
		[Serialize("matParams"         )] public GFX_MaterialParams matParams;
		[Serialize("blendmode"         )] public GFX_BLEND blendmode;
		[Serialize("renderToTexture"   )] public int renderToTexture;
		[Serialize("renderGenerateBack")] public bool renderGenerateBack;
		[Serialize("Layer1"            )] public COL_GFXMaterialShader_Layer_Template Layer1;
		[Serialize("BlendLayer2"       )] public GFX_BLEND BlendLayer2;
		[Serialize("Layer2"            )] public COL_GFXMaterialShader_Layer_Template Layer2;
		[Serialize("BlendLayer3"       )] public GFX_BLEND BlendLayer3;
		[Serialize("Layer3"            )] public COL_GFXMaterialShader_Layer_Template Layer3;
		[Serialize("BlendLayer4"       )] public GFX_BLEND BlendLayer4;
		[Serialize("Layer4"            )] public COL_GFXMaterialShader_Layer_Template Layer4;
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
				SerializeField(s, nameof(materialtype2));
				SerializeField(s, nameof(lightingType));
				SerializeField(s, nameof(matParams));
				SerializeField(s, nameof(blendmode));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(flags));
				SerializeField(s, nameof(renderRegular), boolAsByte: true);
				SerializeField(s, nameof(renderGenerateBack), boolAsByte: true);
				SerializeField(s, nameof(renderFrontLight), boolAsByte: true);
				SerializeField(s, nameof(renderBackLight), boolAsByte: true);
				SerializeField(s, nameof(useAlphaTest), boolAsByte: true);
				SerializeField(s, nameof(alphaRef));
				SerializeField(s, nameof(separateAlpha), boolAsByte: true);
				SerializeField(s, nameof(textureBlend), boolAsByte: true);
				SerializeField(s, nameof(materialtype3));
				SerializeField(s, nameof(lightingType));
				SerializeField(s, nameof(blendmode));
				SerializeField(s, nameof(Layer1));
				SerializeField(s, nameof(BlendLayer2));
				SerializeField(s, nameof(Layer2));
				SerializeField(s, nameof(BlendLayer3));
				SerializeField(s, nameof(Layer3));
				SerializeField(s, nameof(BlendLayer4));
				SerializeField(s, nameof(Layer4));
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
		public enum GFX_MAT2 {
			[Serialize("GFX_MAT_DEFAULT"      )] DEFAULT = 0,
			[Serialize("GFX_MAT_REFRACTION"   )] REFRACTION = 1,
			[Serialize("GFX_MAT_PATCH"        )] PATCH = 2,
			[Serialize("GFX_MAT_FRIEZEANIM"   )] FRIEZEANIM = 3,
			[Serialize("GFX_MAT_GLOW"         )] GLOW = 4,
			[Serialize("GFX_MAT_ALPHAFADE"    )] ALPHAFADE = 5,
			[Serialize("GFX_MAT_FRIEZEOVERLAY")] FRIEZEOVERLAY = 6,
			[Serialize("GFX_MAT_REFLECTION"   )] REFLECTION = 7,
			[Serialize("Value_12")] Value_12 = 12,
		}
		public enum GFX_MAT3 {
			[Serialize("GFX_MAT_DEFAULT"      )] DEFAULT = 0,
			[Serialize("GFX_MAT_REFRACTION"   )] REFRACTION = 1,
			[Serialize("GFX_MAT_PATCH"        )] PATCH = 2,
			[Serialize("GFX_MAT_FRIEZEANIM"   )] FRIEZEANIM = 3,
			[Serialize("GFX_MAT_GLOW"         )] GLOW = 4,
			[Serialize("GFX_MAT_ALPHAFADE"    )] ALPHAFADE = 5,
			[Serialize("GFX_MAT_FRIEZEOVERLAY")] FRIEZEOVERLAY = 6,
			[Serialize("GFX_MAT_REFLECTION"   )] REFLECTION = 7,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
		}
		
		public override uint? ClassCRC => 0xE6A935E1;
	}
}

