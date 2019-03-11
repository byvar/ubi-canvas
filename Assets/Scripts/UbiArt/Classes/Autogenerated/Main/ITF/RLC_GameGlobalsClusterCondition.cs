using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GameGlobalsClusterCondition : online.GameGlobalsCondition {
		[Serialize("clusterName")] public string clusterName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(clusterName));
		}
		public override uint? ClassCRC => 0x2B1D6E8F;
	}
}

