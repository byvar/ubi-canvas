namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class matrix2d : CSerializable {
		public Vec2d Col1 = new Vec2d(1f, 0f);
		public Vec2d Col2 = new Vec2d(0f, 1f);
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Col1 = s.SerializeObject<Vec2d>(Col1, name: "Col1");
			Col2 = s.SerializeObject<Vec2d>(Col2, name: "Col2");
		}
	}
}

