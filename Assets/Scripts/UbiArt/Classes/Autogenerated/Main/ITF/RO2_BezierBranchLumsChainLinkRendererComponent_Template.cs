using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BezierBranchLumsChainLinkRendererComponent_Template : RO2_BezierBranchBaseRendererComponent_Template {
		[Serialize("branchSpeed" )] public float branchSpeed;
		[Serialize("boundsOffset")] public float boundsOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(branchSpeed));
			SerializeField(s, nameof(boundsOffset));
		}
		public override uint? ClassCRC => 0xE63425E4;
	}
}

