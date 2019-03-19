using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBranchTransition_Template<T> : BlendTreeNodeBlend_Template<T> {
		[Serialize("blendTime")] public float blendTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(blendTime));
		}
		public override uint? ClassCRC => 0xB8CF072C;
	}
}

