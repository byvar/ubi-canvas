using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTSequence : BTNode {
		public CListO<BTNode> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.COL) {
			} else {
				nodes = s.SerializeObject<CListO<BTNode>>(nodes, name: "nodes");
			}
		}
		public override uint? ClassCRC => 0xA86D440E;
	}
}
