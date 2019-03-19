using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchFluidRendererComponent : BezierBranchBaseRendererComponent {
		[Serialize("startActivated")] public bool startActivated;
		[Serialize("branchSpeed"   )] public float branchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startActivated));
			SerializeField(s, nameof(branchSpeed));
		}
		public override uint? ClassCRC => 0x5D872999;
	}
}

