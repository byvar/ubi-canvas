using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTree_Template : BlendTreeTemplate<AnimTreeResult> {
		[Serialize("nodes"          )] public Placeholder nodes;
		[Serialize("nodeTransitions")] public Placeholder nodeTransitions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(nodes));
				SerializeField(s, nameof(nodeTransitions));
			} else {
			}
		}
		public override uint? ClassCRC => 0x6A25A2FB;
	}
}

