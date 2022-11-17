namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PointsCollisionComponent_Template : ActorComponent_Template {
		public CListO<PolylineData> polylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			polylines = s.SerializeObject<CListO<PolylineData>>(polylines, name: "polylines");
		}
		public override uint? ClassCRC => 0x421AC687;
	}
}

