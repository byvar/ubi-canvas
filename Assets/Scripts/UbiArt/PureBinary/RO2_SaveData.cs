using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt.ITF;
using UnityEngine;

namespace UbiArt {
	public class RO2_SaveData : ICSerializable {
		public byte[] header = null;
		public bool read = true;
		public RO2_PersistentGameData_Universe CONTENT;
		public byte[] footer = null;

		public bool IsNull {
			get {
				return !read;
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			s.SerializeBytes(ref header, 0x210);
			read = s.Serialize<bool>(read, name: "read");
			if (read) { // Read scene
				CONTENT = s.SerializeObject<RO2_PersistentGameData_Universe>(CONTENT);
			}
			s.SerializeBytes(ref footer, 0x190);
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
