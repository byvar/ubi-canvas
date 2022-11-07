namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierBranchRendererPass_Template : CSerializable {
		public StringID name;
		public BezierCurveRenderer_Template renderer;
		public CListO<BezierBranchRendererSegment_Template> segments;
		public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			renderer = s.SerializeObject<BezierCurveRenderer_Template>(renderer, name: "renderer");
			segments = s.SerializeObject<CListO<BezierBranchRendererSegment_Template>>(segments, name: "segments");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
		}
	}
}

