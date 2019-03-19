using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BezierBranchLightOrbChainLinkRendererComponent_Template : CSerializable {
		[Serialize("branchSpeed" )] public float branchSpeed;
		[Serialize("boundsOffset")] public float boundsOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(branchSpeed));
			SerializeField(s, nameof(boundsOffset));
		}
		public override uint? ClassCRC => 0xE17E5B9C;
	}
}

