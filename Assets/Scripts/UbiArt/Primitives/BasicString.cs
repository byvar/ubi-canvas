using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class BasicString : ICSerializable {
		public string str;

		public BasicString() { }
		public BasicString(string str) {
			this.str = str;
		}

		public void Serialize(CSerializerObject s, string name) {
			Debug.LogError(s.Position + ": BasicString here");
			throw new Exception(s.Position + ": BasicString here");
			//s.Serialize<string>(ref str);
		}
	}
}
