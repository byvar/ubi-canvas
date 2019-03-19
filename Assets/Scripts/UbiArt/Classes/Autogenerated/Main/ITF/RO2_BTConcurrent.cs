using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTConcurrent : BTNode {
		[Serialize("nodes")] public CArray<Generic<BTNode>> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
		}
		public override uint? ClassCRC => 0xAD6A653C;
	}
}

