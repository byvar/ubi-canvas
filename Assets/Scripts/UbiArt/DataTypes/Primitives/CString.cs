using System;

namespace UbiArt {
	public class CString : ICSerializable {
		public string str = "";

		public CString() { }
		public CString(string str) {
			this.str = str;
		}

		public void Serialize(CSerializerObject s, string name) {
			s.Context.SystemLogger?.LogError(s.CurrentPointer + ": CString here");
			throw new Exception(s.CurrentPointer + ": CString here");
			//s.Serialize<string>(ref str);
		}

		public override string ToString() {
			return "UnicodeString(\"" + str + "\")";
		}

		// Casts
		public static implicit operator string(CString cstr) {
			return cstr.str;
		}
		public static implicit operator CString(string str) {
			return new CString(str);
		}
	}
}
