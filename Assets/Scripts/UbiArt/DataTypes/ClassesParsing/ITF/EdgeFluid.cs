namespace UbiArt.ITF {
	public partial class EdgeFluid {
		public EdgeFluid() {
			LocalAABB = new AABB() {
				MIN = new Vec2d(float.MinValue, float.MinValue),
				MAX = new Vec2d(float.MaxValue, float.MaxValue)
			};
			CollisionProcesses = new CListO<EdgeProcessData>();
			for(int i = 0; i < 2; i++) CollisionProcesses.Add(new EdgeProcessData());
		}
	}
}
