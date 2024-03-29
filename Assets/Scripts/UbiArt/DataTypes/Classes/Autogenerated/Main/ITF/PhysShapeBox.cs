namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PhysShapeBox : PhysShapePolygon {
		public Vec2d Extent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Extent = s.SerializeObject<Vec2d>(Extent, name: "Extent");
		}
		public override uint? ClassCRC => 0xD1DD9FA9;
	}
}

