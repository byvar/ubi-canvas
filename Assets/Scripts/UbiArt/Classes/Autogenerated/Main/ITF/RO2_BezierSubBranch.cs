using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierSubBranch : CSerializable {
		[Serialize("dist"  )] public float dist;
		[Serialize("offset")] public float offset;
		[Serialize("branch")] public RO2_BezierBranch branch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dist));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(branch));
		}
	}
}

