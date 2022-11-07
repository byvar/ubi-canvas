namespace UbiArt {
	public class ObjectRef : ICSerializable {
		public uint objectRef;

		public void Serialize(CSerializerObject s, string name) {
			objectRef = s.Serialize<uint>(objectRef);
		}
		public static implicit operator uint(ObjectRef o) {
			return o?.objectRef ?? 0;
		}
		public static implicit operator ObjectRef(uint o) {
			return new ObjectRef { objectRef = o };
		}
	}
}
