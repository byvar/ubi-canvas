using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimTreeNodeMarchBlend_Template : BlendTreeNodeChooseBranch_Template<AnimTreeResult> {
		public float animPosToBlend;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPosToBlend = s.Serialize<float>(animPosToBlend, name: "animPosToBlend");
		}
		public override uint? ClassCRC => 0x5160E0D8;
	}
}

