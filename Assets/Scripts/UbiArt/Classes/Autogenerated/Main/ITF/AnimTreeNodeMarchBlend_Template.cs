using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodeMarchBlend_Template : BlendTreeNodeChooseBranch_Template<AnimTreeResult> {
		[Serialize("animPosToBlend")] public float animPosToBlend;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPosToBlend));
		}
		public override uint? ClassCRC => 0x5160E0D8;
	}
}

