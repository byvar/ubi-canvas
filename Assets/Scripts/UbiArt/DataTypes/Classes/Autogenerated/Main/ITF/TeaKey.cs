namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class TeaKey : CSerializable {
		public uint Key1;
		public uint Key2;
		public uint Key3;
		public uint Key4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Key1 = s.Serialize<uint>(Key1, name: "Key1");
			Key2 = s.Serialize<uint>(Key2, name: "Key2");
			Key3 = s.Serialize<uint>(Key3, name: "Key3");
			Key4 = s.Serialize<uint>(Key4, name: "Key4");
		}
	}
}

