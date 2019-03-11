using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchRendererPass_Template : CSerializable {
		[Serialize("name"    )] public StringID name;
		[Serialize("renderer")] public BezierCurveRenderer_Template renderer;
		[Serialize("segments")] public CList<BezierBranchRendererSegment_Template> segments;
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

