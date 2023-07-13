namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PhysShapePolygon : PhysShape {
		public CListO<Vec2d> Points;
		public CListO<Vec2d> normals;
		public CListO<Vec2d> edge;
		public CArrayP<float> distances;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.engineVersion <= Settings.EngineVersion.RO) {
				if (this is PhysShapeBox) return;
				Points = s.SerializeObject<CListO<Vec2d>>(Points, name: "Points");
			} else {
				if (s.Settings.platform == Settings.Platform.Vita && (this is PhysShapeBox)) return;
				Points = s.SerializeObject<CListO<Vec2d>>(Points, name: "Points");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					normals = s.SerializeObject<CListO<Vec2d>>(normals, name: "normals");
					edge = s.SerializeObject<CListO<Vec2d>>(edge, name: "edge");
					distances = s.SerializeObject<CArrayP<float>>(distances, name: "distances");
				}
			}
		}
		public override uint? ClassCRC => 0xC262C210;
	}
}

