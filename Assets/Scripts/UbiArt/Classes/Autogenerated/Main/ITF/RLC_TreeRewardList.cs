using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_TreeRewardList : CSerializable {
		[Serialize("TreeRewards")] public CList<RLC_TreeReward> TreeRewards;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TreeRewards));
		}
		public override uint? ClassCRC => 0x79CEE39A;
	}
}

