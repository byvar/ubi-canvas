using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeBlendBranches<AnimTreeResult> : BlendTreeNodeBlend<AnimTreeResult> {
		[Serialize("leafs"   )] public Placeholder leafs;
		[Serialize("leafData")] public Placeholder leafData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(leafs));
				SerializeField(s, nameof(leafData));
			} else {
			}
		}
		public override uint? ClassCRC => 0x26E3AEE1;
	}
}

