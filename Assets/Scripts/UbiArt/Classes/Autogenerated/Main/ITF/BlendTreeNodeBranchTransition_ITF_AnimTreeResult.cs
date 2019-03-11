using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeBranchTransition<AnimTreeResult> : BlendTreeNodeBlend<AnimTreeResult> {
		[Serialize("leafs")] public Placeholder leafs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(leafs));
			} else {
			}
		}
		public override uint? ClassCRC => 0x9E5802A1;
	}
}

