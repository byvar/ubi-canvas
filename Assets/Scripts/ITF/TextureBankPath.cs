using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class TextureBankPath : BaseObject {
		[Serialize(0, "id")] public StringID id;
		[Serialize(1, "patchBank")] public Path patchBank;
		//[Serialize(2, "texture")] public Path texture;
		[Serialize(3, "textureSet")] public GFXMaterialTexturePathSet textureSet;
		[Serialize(4, "materialShader")] public Path materialShader;

		public TextureBankPath(Reader reader) : base(reader) {
		}
	}
}
