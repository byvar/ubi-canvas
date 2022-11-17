namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA | GameFlags.RJR | GameFlags.RFR)]
	public partial class PolylineData : CSerializable {
		public CArrayO<Vec2d> points;
		public Path gameMaterial;
		public StringID regionType;
		public bool loop;
		public bool movingPolyline;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			points = s.SerializeObject<CArrayO<Vec2d>>(points, name: "points");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			regionType = s.SerializeObject<StringID>(regionType, name: "regionType");
			loop = s.Serialize<bool>(loop, name: "loop");
			movingPolyline = s.Serialize<bool>(movingPolyline, name: "movingPolyline");
		}
	}
}

