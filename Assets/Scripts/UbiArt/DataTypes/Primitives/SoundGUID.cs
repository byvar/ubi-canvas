namespace UbiArt {
	public class SoundGUID : ICSerializable {
		public uint id;

		public void Serialize(CSerializerObject s, string name) {
			s.Context.SystemLogger?.LogError(s.CurrentPointer + ": Figure out SoundGUID format");
			id = s.Serialize<uint>(id);
		}

		public const int Invalid = -1;

		public bool IsNull => id == 0xFFFFFFFF;
	}
}
