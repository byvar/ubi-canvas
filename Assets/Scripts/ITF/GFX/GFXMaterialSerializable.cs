using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class GFXMaterialSerializable : BaseObject {
		public GFXMaterialTexturePathSet textureSet;
		public Path shaderPath;
		public GFXMaterialSerializableParams materialParams;
		public bool stencilTest;
		public bool skipDepthTest;
		public uint alphaTest;
		public uint alphaRef;

		public GFXMaterialSerializable(Reader reader) : base(reader) {
			textureSet = new GFXMaterialTexturePathSet(reader);
			shaderPath = new Path(reader);
			materialParams = new GFXMaterialSerializableParams(reader);
			stencilTest = reader.ReadBoolean();
			skipDepthTest = reader.ReadBoolean();
			alphaTest = reader.ReadUInt32();
			alphaRef = reader.ReadUInt32();
		}
	}
}
