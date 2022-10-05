using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt.ITF;
using UnityEngine;

namespace UbiArt {
	public class ContainerFile<T> : ICSerializable, IObjectContainer where T : ICSerializable, new() {
		public bool read = true;
		public T obj;

		public bool IsNull {
			get {
				return !read;
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				read = s.Serialize<bool>(read, name: "read");
			}
			if (read) { // Read scene
				obj = s.SerializeObject<T>(obj);
				if (s.Length != null) {
					if (s.CurrentPointer != s.Length) {
						throw new Exception("File reading check failed. Position:" + s.CurrentPointer + " - Length:" + s.Length);
					} else if (s.CurrentPointer.File != null) {
						s.Context.SystemLog?.LogInfo($"Finished reading file: {s.CurrentPointer.File.DisplayName}");
					}
				}
			}
		}
	}
}
