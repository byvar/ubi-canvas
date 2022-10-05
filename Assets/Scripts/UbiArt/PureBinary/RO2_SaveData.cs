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
			header = s.SerializeBytes(header, 0x210);
			read = s.Serialize<bool>(read, name: "read");
			if (read) { // Read scene
				CONTENT = s.SerializeObject<RO2_PersistentGameData_Universe>(CONTENT);
			}
			footer = s.SerializeBytes(footer, 0x190);
			if (s.Length != null) {
				if (s.CurrentPointer != s.Length) {
					throw new Exception("File reading check failed. Position:" + s.CurrentPointer + " - Length:" + s.Length);
				} else if (s.CurrentPointer.File != null) {
					s.Context.SystemLog?.LogInfo("Finished reading file: " + s.CurrentPointer.File.DisplayName);
				}
			}
		}
	}
}
