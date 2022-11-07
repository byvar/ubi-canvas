namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_20_sub_7CC7B0 : CSerializable {
		public Path clothPath;
		public Path collisionDataPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			clothPath = s.SerializeObject<Path>(clothPath, name: "clothPath");
			collisionDataPath = s.SerializeObject<Path>(collisionDataPath, name: "collisionDataPath");
		}
		public override uint? ClassCRC => 0x14560C3D;
	}
}

