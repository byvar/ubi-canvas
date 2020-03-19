using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Platform : ICSerializable {
		public uint platform;

		public void Serialize(CSerializerObject s, string name) {
			Debug.LogError(s.Position + ": Encountered Platform with name " + name);
			throw new Exception(s.Position + ": Encountered Platform with name " + name);
			//s.Serialize<uint>(ref platform);
		}
	}
}
