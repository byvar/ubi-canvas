using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BezierBranchFluidRendererComponent : RO2_BezierBranchBaseRendererComponent {
		[Serialize("startActivated")] public bool startActivated;
		[Serialize("branchSpeed"   )] public float branchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startActivated));
			SerializeField(s, nameof(branchSpeed));
		}
		public override uint? ClassCRC => 0x6F414625;
	}
}

