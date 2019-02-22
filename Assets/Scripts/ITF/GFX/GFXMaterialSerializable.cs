using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class GFXMaterialSerializable : BaseObject {
		[Serialize(0, "textureSet")] public GFXMaterialTexturePathSet textureSet;
		[Serialize(1, "shaderPath")] public Path shaderPath;
		[Serialize(2, "materialParams")] public GFXMaterialSerializableParams materialParams;
		[Serialize(3, "stencilTest")] public bool stencilTest;
		[Serialize(4, "skipDepthTest")] public bool skipDepthTest;
		[Serialize(5, "alphaTest")] public uint alphaTest;
		[Serialize(6, "alphaRef")] public uint alphaRef;

		public GFXMaterialSerializable(Reader reader) : base(reader) {
		}
	}
}
