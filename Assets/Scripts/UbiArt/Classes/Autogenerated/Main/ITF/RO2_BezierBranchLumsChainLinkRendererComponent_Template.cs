using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BezierBranchLumsChainLinkRendererComponent_Template : RO2_BezierBranchBaseRendererComponent_Template {
		public float branchSpeed;
		public float boundsOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			branchSpeed = s.Serialize<float>(branchSpeed, name: "branchSpeed");
			boundsOffset = s.Serialize<float>(boundsOffset, name: "boundsOffset");
		}
		public override uint? ClassCRC => 0xE63425E4;
	}
}

