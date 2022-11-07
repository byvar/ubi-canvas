namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class RO2_BezierBranchRendererPass_Template : CSerializable {
		public StringID name;
		public BezierCurveRenderer_Template renderer;
		public CListO<RO2_BezierBranchRendererSegment_Template> segments;
		public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			renderer = s.SerializeObject<BezierCurveRenderer_Template>(renderer, name: "renderer");
			segments = s.SerializeObject<CListO<RO2_BezierBranchRendererSegment_Template>>(segments, name: "segments");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
		}
	}
}

