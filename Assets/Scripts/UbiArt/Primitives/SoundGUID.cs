using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class SoundGUID : ICSerializable {
		public uint id;

		public void Serialize(CSerializerObject s, string name) {
			Debug.LogError(s.Position + ": Figure out SoundGUID format");
			id = s.Serialize<uint>(id);
		}

		public const int Invalid = -1;

		public bool IsNull {
			get {
				return id == 0xFFFFFFFF;
			}
		}
	}
}
