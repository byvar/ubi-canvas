namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class SolidPolylineComponent_Template : PolylineComponent_Template {
		public CListO<SolidPolylineComponent_Template.SolidEdgeData> solidEdges;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			solidEdges = s.SerializeObject<CListO<SolidPolylineComponent_Template.SolidEdgeData>>(solidEdges, name: "solidEdges");
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class SolidEdgeData : CSerializable {
			public StringID bone;
			public float minDelta;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				bone = s.SerializeObject<StringID>(bone, name: "bone");
				minDelta = s.Serialize<float>(minDelta, name: "minDelta");
			}
		}
		public override uint? ClassCRC => 0xDEC09000;
	}
}

