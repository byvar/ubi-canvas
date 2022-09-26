using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Placeholder : ICSerializable {
		public void Serialize(CSerializerObject s, string name) {
			Debug.LogError(s.CurrentPointer + ": Encountered placeholder with name " + name);
			throw new Exception(s.CurrentPointer + ": Encountered placeholder with name " + name);
		}
	}
}
