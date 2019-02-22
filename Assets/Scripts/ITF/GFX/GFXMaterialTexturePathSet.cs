using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class GFXMaterialTexturePathSet : BaseObject {
		[Serialize(0, "diffuse")] public Path diffuse;
		[Serialize(1, "back_light")] public Path back_light;
		[Serialize(2, "normal")] public Path normal;
		[Serialize(3, "separateAlpha")] public Path separateAlpha;
		[Serialize(4, "diffuse_2")] public Path diffuse_2;
		[Serialize(5, "back_light_2")] public Path back_light_2;
		[Serialize(6, "anim_impostor")] public Path anim_impostor;

		public TextureCooked diffuseTex;

		public GFXMaterialTexturePathSet(Reader reader) : base(reader) {			
			MapLoader.Loader.Load(diffuse, (extReader) => {
				if (MapLoader.Loader.tex.ContainsKey(diffuse.stringID)) {
					diffuseTex = MapLoader.Loader.tex[diffuse.stringID];
				} else {
					diffuseTex = new TextureCooked(extReader);
					MapLoader.Loader.tex[diffuse.stringID] = diffuseTex;
					MapLoader.Loader.print("Read:" + extReader.BaseStream.Position.ToString("X8") + " - Length:" + extReader.BaseStream.Length.ToString("X8") + " - " + (extReader.BaseStream.Position == extReader.BaseStream.Length ? "good!" : "bad!"));
				}
			});
		}
	}
}
