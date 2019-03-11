using UnityEngine;

namespace UbiArt.ITF {
	public partial class RewardStatHandler : RuleStatHandler {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9D762C57;
	}
}

