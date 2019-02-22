using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class GFXMaterialShader_Template : BaseObject {
		[Serialize(0, "flags")] public uint flags;
		[Serialize(1, "renderRegular")] public bool renderRegular;
		[Serialize(2, "renderFrontLight")] public bool renderFrontLight;
		[Serialize(3, "renderBackLight")] public bool renderBackLight;
		[Serialize(4, "renderInReflection", game = Settings.Game.RA)] public int renderInReflection;
		[Serialize(5, "useAlphaTest")] public bool useAlphaTest;
		[Serialize(6, "alphaRef")] public uint alphaRef;
		[Serialize(7, "separateAlpha")] public bool separateAlpha;
		[Serialize(8, "normalMapLighting", game = Settings.Game.RA)] public bool normalMapLighting;
		[Serialize(9, "textureBlend")] public bool textureBlend;
		[Serialize(10, "renderToTexture", game = Settings.Game.RL)] public bool renderToTexture;
		[Serialize(11, "animInTex")] public Container<GFXMatAnimImpostor> animInTex;
		[Serialize(12, "materialtype")] public GFXMat materialtype;
		[Serialize(13, "lightingType")] public GFXMat lightingType;
		[Serialize(14, "matParams")] public GFX_MaterialParams matParams;
		[Serialize(15, "blendmode")] public GFXBlend blendmode;

		public GFXMaterialShader_Template(Reader reader) : base(reader) {
		}

		public enum GFXMat {
			Default = 0,
			Refraction,
			Patch,
			FriezeAnim,
			Glow,
			AlphaFade,
			FriezeOverlay,
			Reflection,
			LegendsOnlyType12 = 12
		}
		public enum GFXMatShader {
			Default = 0,
			LightLayered
		}

		public enum GFXBlend {
			Unknown = 0,
			Copy,
			Alpha,
			AlphaPremult,
			AlphaDest,
			AlphaDestPremult,
			Add,
			AddAlpha,
			SubAlpha,
			Sub,
			Mul,
			AlphaMul,
			IAlphaMul,
			IAlpha,
			IAlphaPremult,
			IAlphaDest,
			IAlphaDestPremult,
			Mul2x,
			AlphaToColor,
			IAlphaToColor,
			Screen = 21
		}
	}
}
