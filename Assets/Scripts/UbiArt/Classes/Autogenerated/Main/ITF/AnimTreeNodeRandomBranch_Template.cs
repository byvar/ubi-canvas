using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodeRandomBranch_Template : BlendTreeNodeChooseBranch_Template<AnimTreeResult> {
		[Serialize("loop")] public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(loop));
		}
		public override uint? ClassCRC => 0x1C5654FE;
	}
}

