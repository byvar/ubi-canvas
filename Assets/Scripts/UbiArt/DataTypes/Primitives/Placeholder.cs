using System;

namespace UbiArt {
	public class Placeholder : ICSerializable {
		public void Serialize(CSerializerObject s, string name) {
			s.Context.SystemLogger?.LogError(s.CurrentPointer + ": Encountered placeholder with name " + name);
			throw new Exception(s.CurrentPointer + ": Encountered placeholder with name " + name);
		}
	}
}
