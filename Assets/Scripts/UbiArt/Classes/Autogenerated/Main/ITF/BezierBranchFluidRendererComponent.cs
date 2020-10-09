using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class BezierBranchFluidRendererComponent : BezierBranchBaseRendererComponent {
		public bool startActivated;
		public float branchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startActivated = s.Serialize<bool>(startActivated, name: "startActivated");
			branchSpeed = s.Serialize<float>(branchSpeed, name: "branchSpeed");
		}
		public override uint? ClassCRC => 0x5D872999;
	}
}

