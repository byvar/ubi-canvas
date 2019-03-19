using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierSubBranch : CSerializable {
		[Serialize("dist"  )] public float dist;
		[Serialize("offset")] public float offset;
		[Serialize("branch")] public BezierBranch branch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dist));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(branch));
		}
	}
}

