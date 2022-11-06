using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_GameGlobalsClusterCondition : online.GameGlobalsCondition {
		public string clusterName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			clusterName = s.Serialize<string>(clusterName, name: "clusterName");
		}
		public override uint? ClassCRC => 0x2B1D6E8F;
	}
}

