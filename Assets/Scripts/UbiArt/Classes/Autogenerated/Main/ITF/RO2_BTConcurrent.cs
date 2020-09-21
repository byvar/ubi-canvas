using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTConcurrent : BTNode {
		public CArrayO<Generic<BTNode>> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CArrayO<Generic<BTNode>>>(nodes, name: "nodes");
		}
		public override uint? ClassCRC => 0xAD6A653C;
	}
}

