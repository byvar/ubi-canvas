using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt.ITF;
using UnityEngine;

namespace UbiArt {
	public class ContainerFile<T> : ICSerializable, IObjectContainer where T : ICSerializable {
		public bool read = true;
		public T obj;

		public bool IsNull {
			get {
				return !read;
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				read = s.Serialize<bool>(read, name: "read");
			}
			if (read) { // Read scene
				obj = s.SerializeGeneric(obj);
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
