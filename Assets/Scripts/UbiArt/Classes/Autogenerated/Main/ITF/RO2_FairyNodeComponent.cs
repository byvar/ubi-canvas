using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FairyNodeComponent : RO2_SnakeNetworkNodeComponent {
		public uint lumsCount;
		public float lumsDropMinDist;
		public float lumsDropStepDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumsCount = s.Serialize<uint>(lumsCount, name: "lumsCount");
			lumsDropMinDist = s.Serialize<float>(lumsDropMinDist, name: "lumsDropMinDist");
			lumsDropStepDist = s.Serialize<float>(lumsDropStepDist, name: "lumsDropStepDist");
		}
		public override uint? ClassCRC => 0x3B569C33;
	}
}

