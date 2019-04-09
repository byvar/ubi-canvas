using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Animation3DTreeNodeRandomBranch_Template<T> : BlendTreeNodeChooseBranch_Template<T> where T : Animation3DTreeResult {
		[Serialize("loop")] public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(loop));
		}
		public override uint? ClassCRC => 0x4F51D4BC;
	}
}

