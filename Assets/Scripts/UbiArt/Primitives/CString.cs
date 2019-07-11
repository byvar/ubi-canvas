using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class CString : ICSerializable {
		public string str = "";

		public CString() { }
		public CString(string str) {
			this.str = str;
		}

		public void Serialize(CSerializerObject s, string name) {
			Debug.LogError(s.Position + ": CString here");
			throw new Exception(s.Position + ": CString here");
			s.Serialize<string>(ref str);
		}

		public override string ToString() {
			return "UnicodeString(\"" + str + "\")";
		}
	}
}
