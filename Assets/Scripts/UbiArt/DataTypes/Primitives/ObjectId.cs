namespace UbiArt {
	public class ObjectId : ICSerializable {
		public long id;

		public void Serialize(CSerializerObject s, string name) {
			if (s.Settings.Game == Game.COL) {
				id = s.Serialize<int>((int)id);
			} else {
				id = s.Serialize<long>(id);
			}
		}

		public const int Invalid = -1;

		public bool IsNull => id == Invalid;
	}
}
