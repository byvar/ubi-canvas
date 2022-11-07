using UbiArt.ITF;

namespace UbiArt {
	public class Ray_SaveData : ICSerializable {
		public byte[] header = null;
		public bool read = true;
		public Ray_PersistentGameData_Universe CONTENT;
		public byte[] footer = null;

		public bool IsNull {
			get {
				return !read;
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			header = s.SerializeBytes(header, 0x210);
			read = s.Serialize<bool>(read, name: "read");
			if (read) { // Read scene
				CONTENT = s.SerializeObject<Ray_PersistentGameData_Universe>(CONTENT);
			}
			footer = s.SerializeBytes(footer, 0x190);
		}
	}
}
