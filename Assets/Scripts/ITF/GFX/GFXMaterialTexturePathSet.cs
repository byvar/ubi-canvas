using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class GFXMaterialTexturePathSet : BaseObject {
		public Path diffuse;
		public Path back_light;
		public Path normal;
		public Path separateAlpha;
		public Path diffuse_2;
		public Path back_light_2;
		public Path anim_impostor;

		public TextureCooked diffuseTex;

		public GFXMaterialTexturePathSet(Reader reader) : base(reader) {
			diffuse = new Path(reader);
			back_light = new Path(reader);
			normal = new Path(reader);
			separateAlpha = new Path(reader);
			diffuse_2 = new Path(reader);
			back_light_2 = new Path(reader);
			anim_impostor = new Path(reader);
			
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
