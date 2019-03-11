using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeAddBranch<AnimTreeResult> : BlendTreeNodeBlend<AnimTreeResult> {
		[Serialize("leafs"      )] public Placeholder leafs;
		[Serialize("prevWeights")] public Placeholder prevWeights;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(leafs));
				SerializeField(s, nameof(prevWeights));
			} else {
			}
		}
		public override uint? ClassCRC => 0x9CBF6243;
	}
}

