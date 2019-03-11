using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierBranchRendererPass_Template : CSerializable {
		[Serialize("name"    )] public StringID name;
		[Serialize("renderer")] public BezierCurveRenderer_Template renderer;
		[Serialize("segments")] public CList<RO2_BezierBranchRendererSegment_Template> segments;
		[Serialize("zOffset" )] public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(renderer));
			SerializeField(s, nameof(segments));
			SerializeField(s, nameof(zOffset));
		}
	}
}

