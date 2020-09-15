using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class BTSequence : BTNode {
		public CList<BTNode> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.COL) {
			} else {
				nodes = s.SerializeObject<CList<BTNode>>(nodes, name: "nodes");
			}
		}
		public override uint? ClassCRC => 0xA86D440E;
	}
}

