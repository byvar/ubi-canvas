using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimTreeNodeRandomBranch_Template<T> : BlendTreeNodeChooseBranch_Template<T> where T : AnimTreeResult {
		[Serialize("loop")] public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(loop));
		}
		public override uint? ClassCRC => 0x1C5654FE;
	}
}

