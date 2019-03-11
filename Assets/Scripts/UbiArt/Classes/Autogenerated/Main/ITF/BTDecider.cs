using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDecider : BTNode {
		[Serialize("nodes")] public CList<BTNode> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
			} else {
				SerializeField(s, nameof(nodes));
			}
		}
		public override uint? ClassCRC => 0x9948D399;
	}
}

