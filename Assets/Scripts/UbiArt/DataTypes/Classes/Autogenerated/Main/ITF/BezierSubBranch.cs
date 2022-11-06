using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierSubBranch : CSerializable {
		public float dist;
		public float offset;
		public BezierBranch branch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dist = s.Serialize<float>(dist, name: "dist");
			offset = s.Serialize<float>(offset, name: "offset");
			branch = s.SerializeObject<BezierBranch>(branch, name: "branch");
		}
	}
}

