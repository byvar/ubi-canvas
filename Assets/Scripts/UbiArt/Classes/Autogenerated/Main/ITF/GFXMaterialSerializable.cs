using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMaterialSerializable : CSerializable {
		[Serialize("textureSet"    )] public GFXMaterialTexturePathSet textureSet;
		[Serialize("shaderPath"    )] public Path shaderPath;
		[Serialize("materialParams")] public GFXMaterialSerializableParam materialParams;
		[Serialize("stencilTest"   )] public bool stencilTest;
		[Serialize("skipDepthTest" )] public bool skipDepthTest;
		[Serialize("isTwoSided"    )] public bool isTwoSided;
		[Serialize("alphaTest"     )] public uint alphaTest;
		[Serialize("alphaRef"      )] public uint alphaRef;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
}

