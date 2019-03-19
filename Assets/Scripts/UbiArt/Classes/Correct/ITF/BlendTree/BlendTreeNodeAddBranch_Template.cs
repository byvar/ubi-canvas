using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeAddBranch_Template<T> : BlendTreeNodeBlend_Template<T> {
		[Serialize("weights")] public CList<BlendTreeBranchWeight> weights;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(weights));
		}
		public override uint? ClassCRC => 0x22462C85;
	}
}

