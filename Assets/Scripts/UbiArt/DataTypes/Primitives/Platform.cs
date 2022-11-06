using System;

namespace UbiArt {
	public class Platform : ICSerializable {
		public uint platform;

		public void Serialize(CSerializerObject s, string name) {
			s.Context.SystemLogger?.LogError(s.CurrentPointer + ": Encountered Platform with name " + name);
			throw new Exception(s.CurrentPointer + ": Encountered Platform with name " + name);
			//s.Serialize<uint>(ref platform);
		}
	}
}
