using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt.ITF;
using UnityEngine;

namespace UbiArt {
	public class SceneFile : ICSerializable, IObjectContainer {
		[Serialize("read" )] public bool read;
		[Serialize("scene")] public Scene scene;

		public bool IsNull {
			get {
				return !read;
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref read, name: "read");
			if (read) { // Read scene
				s.Serialize(ref scene);
				if (s.Length != null) {
					if (s.Position != s.Length) {
						throw new Exception("File reading check failed. Position:" + s.Position + " - Length:" + s.Length);
					} else if (s.Position.file != null) {
						MapLoader.Loader.print("Finished reading file: " + s.Position.file.name);
					}
				}
			}
		}
	}
}
