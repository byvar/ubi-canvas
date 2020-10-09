using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class GFXMaterialSerializable : CSerializable {
		public GFXMaterialTexturePathSet textureSet;
		public Path shaderPath;
		public GFXMaterialSerializableParam materialParams;
		public bool stencilTest;
		public bool skipDepthTest;
		public bool isTwoSided;
		public uint alphaTest;
		public uint alphaRef;

		// Child of Light is vastly different
		public uint ATL_Channel;
		public char stencilRef;
		public Enum_stencilMode stencilMode;
		public float depthBias;
		public Vec2d generateBackBrightContrast;
		public uint backfaceModulation;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				textureSet = s.SerializeObject<GFXMaterialTexturePathSet>(textureSet, name: "textureSet");
				ATL_Channel = s.Serialize<uint>(ATL_Channel, name: "ATL_Channel");
				shaderPath = s.SerializeObject<Path>(shaderPath, name: "shaderPath");
				materialParams = s.SerializeObject<GFXMaterialSerializableParam>(materialParams, name: "materialParams");
				stencilTest = s.Serialize<bool>(stencilTest, name: "stencilTest", options: CSerializerObject.Options.BoolAsByte);
				skipDepthTest = s.Serialize<bool>(skipDepthTest, name: "skipDepthTest", options: CSerializerObject.Options.BoolAsByte);
				stencilRef = s.Serialize<char>(stencilRef, name: "stencilRef");
				stencilMode = s.Serialize<Enum_stencilMode>(stencilMode, name: "stencilMode");
				alphaTest = s.Serialize<uint>(alphaTest, name: "alphaTest");
				alphaRef = s.Serialize<uint>(alphaRef, name: "alphaRef");
				depthBias = s.Serialize<float>(depthBias, name: "depthBias");
				generateBackBrightContrast = s.SerializeObject<Vec2d>(generateBackBrightContrast, name: "generateBackBrightContrast");
				backfaceModulation = s.Serialize<uint>(backfaceModulation, name: "backfaceModulation");
			} else if (Settings.s.game == Settings.Game.RL) {
				textureSet = s.SerializeObject<GFXMaterialTexturePathSet>(textureSet, name: "textureSet");
				shaderPath = s.SerializeObject<Path>(shaderPath, name: "shaderPath");
				materialParams = s.SerializeObject<GFXMaterialSerializableParam>(materialParams, name: "materialParams");
				stencilTest = s.Serialize<bool>(stencilTest, name: "stencilTest");
				if (!Settings.s.isCatchThemAll) {
					skipDepthTest = s.Serialize<bool>(skipDepthTest, name: "skipDepthTest");
				}
				alphaTest = s.Serialize<uint>(alphaTest, name: "alphaTest");
				alphaRef = s.Serialize<uint>(alphaRef, name: "alphaRef");
			} else {
				textureSet = s.SerializeObject<GFXMaterialTexturePathSet>(textureSet, name: "textureSet");
				shaderPath = s.SerializeObject<Path>(shaderPath, name: "shaderPath");
				materialParams = s.SerializeObject<GFXMaterialSerializableParam>(materialParams, name: "materialParams");
				stencilTest = s.Serialize<bool>(stencilTest, name: "stencilTest");
				skipDepthTest = s.Serialize<bool>(skipDepthTest, name: "skipDepthTest");
				isTwoSided = s.Serialize<bool>(isTwoSided, name: "isTwoSided");
				alphaTest = s.Serialize<uint>(alphaTest, name: "alphaTest");
				alphaRef = s.Serialize<uint>(alphaRef, name: "alphaRef");
			}
		}
		public enum Enum_stencilMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

