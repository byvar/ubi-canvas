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

		public Container<Generic<GFXMaterialShader_Template>> shader;

		public GFXMaterialSerializable(Reader reader) : base(reader) {
			MapLoader.Loader.Load(shaderPath, (extReader) => {
				if (MapLoader.Loader.msh.ContainsKey(shaderPath.stringID)) {
					shader = MapLoader.Loader.msh[shaderPath.stringID];
				} else {
					extReader.flags |= Reader.Flags.AddObjectSizes;
					shader = new Container<Generic<GFXMaterialShader_Template>>(extReader);
					MapLoader.Loader.msh[shaderPath.stringID] = shader;
					MapLoader.Loader.print("Read:" + extReader.BaseStream.Position.ToString("X8") + " - Length:" + extReader.BaseStream.Length.ToString("X8") + " - " + (extReader.BaseStream.Position == extReader.BaseStream.Length ? "good!" : "bad!"));
				}
			});
		}
	}
}
