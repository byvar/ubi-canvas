namespace UbiArt.ITF {
	public partial class PhysShapeBox {
		public void SetExtent(Vec2d vec) {
			Extent = vec;
			Points = new CListO<Vec2d>() {
				new Vec2d(-vec.x, -vec.y),
				new Vec2d(-vec.x, vec.y),
				new Vec2d(vec.x, vec.y),
				new Vec2d(vec.x, -vec.y)
			};
			BuildEdges();
		}

		public override void Reset() {
			SetExtent(Vec2d.One);
		}
	}
}
