using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BehaviorTree : CSerializable {
		public Generic<BTNode> root;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			root = s.SerializeObject<Generic<BTNode>>(root, name: "root");
		}
	}
}

