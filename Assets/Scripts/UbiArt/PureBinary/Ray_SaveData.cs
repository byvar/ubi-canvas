using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt.ITF;
using UnityEngine;

namespace UbiArt {
	public class Ray_SaveData : ICSerializable {
		public byte[] header = null;
		public bool read = true;
		public Ray_PersistentGameData_Universe CONTENT;
		public byte[] footer = null;

		public bool IsNull {
			get {
				return !read;
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			header = s.SerializeBytes(header, 0x210);
			read = s.Serialize<bool>(read, name: "read");
			if (read) { // Read scene
				CONTENT = s.SerializeObject<Ray_PersistentGameData_Universe>(CONTENT);
			}
			footer = s.SerializeBytes(footer, 0x190);
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
