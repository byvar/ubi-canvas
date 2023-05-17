using UbiArt.ITF;

namespace UbiArt {
	public class RLC_SaveData : ICSerializable {
		public byte[] header = null;
		public RO2_PersistentGameData_Universe CONTENT;

		public uint[] GetTeaKey(Context c) {
			var key = c.Loader.gameConfig.key;
			return new uint[] { key.Key1, key.Key2, key.Key3, key.Key4 };
		}

		public void Serialize(CSerializerObject s, string name) {
			if (s?.Context?.Loader?.gameConfig == null) {
				throw new System.Exception("GameConfig needs to be loaded to load save data!");
			}
			header = s.SerializeBytes(header, 0x120);
			s.DoEncrypted(GetTeaKey(s.Context), () => {
				s.DoCompressed(() => {
					CONTENT = s.SerializeObject<RO2_PersistentGameData_Universe>(CONTENT, name: "CONTENT");
				}, name: "CONTENT");
			}, name: "CONTENT");
		}
	}
}
