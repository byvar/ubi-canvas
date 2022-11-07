namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class PackedObjectPath : CSerializable {
		public ObjectId id;
		public uint pathCode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<ObjectId>(id, name: "id");
			pathCode = s.Serialize<uint>(pathCode, name: "pathCode");
		}
	}
}
