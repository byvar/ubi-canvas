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
		[Serialize("header")] public byte[] header = null;
		[Serialize("read"  )] public bool read = true;
		[Serialize("object")] public Ray_PersistentGameData_Universe CONTENT;
		[Serialize("footer")] public byte[] footer = null;

		public bool IsNull {
			get {
				return !read;
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			s.SerializeBytes(ref header, 0x210);
			s.Serialize(ref read, name: "read");
			if (read) { // Read scene
				s.Serialize(ref CONTENT);
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
