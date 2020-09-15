using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_BezierSubBranch : CSerializable {
		public float dist;
		public float offset;
		public RO2_BezierBranch branch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dist = s.Serialize<float>(dist, name: "dist");
			offset = s.Serialize<float>(offset, name: "offset");
			branch = s.SerializeObject<RO2_BezierBranch>(branch, name: "branch");
		}
	}
}

