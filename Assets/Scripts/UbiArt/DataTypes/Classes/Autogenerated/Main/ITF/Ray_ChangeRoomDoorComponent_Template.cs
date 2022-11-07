namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChangeRoomDoorComponent_Template : CSerializable {
		public Placeholder shape;
		public Vec2d shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shape = s.SerializeObject<Placeholder>(shape, name: "shape");
			shapeOffset = s.SerializeObject<Vec2d>(shapeOffset, name: "shapeOffset");
		}
		public override uint? ClassCRC => 0x5B1595FB;
	}
}

