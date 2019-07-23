using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class GFXMaterialSerializable : CSerializable {
		[Serialize("textureSet"    )] public GFXMaterialTexturePathSet textureSet;
		[Serialize("shaderPath"    )] public Path shaderPath;
		[Serialize("materialParams")] public GFXMaterialSerializableParam materialParams;
		[Serialize("stencilTest"   )] public bool stencilTest;
		[Serialize("skipDepthTest" )] public bool skipDepthTest;
		[Serialize("isTwoSided"    )] public bool isTwoSided;
		[Serialize("alphaTest"     )] public uint alphaTest;
		[Serialize("alphaRef"      )] public uint alphaRef;

		// Child of Light is vastly different
		[Serialize("ATL_Channel"               )] public uint ATL_Channel;
		[Serialize("stencilRef"                )] public char stencilRef;
		[Serialize("stencilMode"               )] public Enum_stencilMode stencilMode;
		[Serialize("depthBias"                 )] public float depthBias;
		[Serialize("generateBackBrightContrast")] public Vector2 generateBackBrightContrast;
		[Serialize("backfaceModulation"        )] public uint backfaceModulation;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(textureSet));
				SerializeField(s, nameof(ATL_Channel));
				SerializeField(s, nameof(shaderPath));
				SerializeField(s, nameof(materialParams));
				SerializeField(s, nameof(stencilTest), boolAsByte: true);
				SerializeField(s, nameof(skipDepthTest), boolAsByte: true);
				SerializeField(s, nameof(stencilRef));
				SerializeField(s, nameof(stencilMode));
				SerializeField(s, nameof(alphaTest));
				SerializeField(s, nameof(alphaRef));
				SerializeField(s, nameof(depthBias));
				SerializeField(s, nameof(generateBackBrightContrast));
				SerializeField(s, nameof(backfaceModulation));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(textureSet));
				SerializeField(s, nameof(shaderPath));
				SerializeField(s, nameof(materialParams));
				SerializeField(s, nameof(stencilTest));
				if (!Settings.s.isCatchThemAll) {
					SerializeField(s, nameof(skipDepthTest));
				}
				SerializeField(s, nameof(alphaTest));
				SerializeField(s, nameof(alphaRef));
			} else {
				SerializeField(s, nameof(textureSet));
				SerializeField(s, nameof(shaderPath));
				SerializeField(s, nameof(materialParams));
				SerializeField(s, nameof(stencilTest));
				SerializeField(s, nameof(skipDepthTest));
				SerializeField(s, nameof(isTwoSided));
				SerializeField(s, nameof(alphaTest));
				SerializeField(s, nameof(alphaRef));
			}
		}
		public enum Enum_stencilMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

