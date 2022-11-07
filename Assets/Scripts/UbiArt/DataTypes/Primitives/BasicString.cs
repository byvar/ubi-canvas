using System;

namespace UbiArt {
	public class BasicString : ICSerializable {
		public string str;

		public BasicString() { }
		public BasicString(string str) {
			this.str = str;
		}

		public void Serialize(CSerializerObject s, string name) {
			s.Context.SystemLogger?.LogError(s.CurrentPointer + ": BasicString here");
			throw new Exception(s.CurrentPointer + ": BasicString here");
			//s.Serialize<string>(ref str);
		}
	}
}
