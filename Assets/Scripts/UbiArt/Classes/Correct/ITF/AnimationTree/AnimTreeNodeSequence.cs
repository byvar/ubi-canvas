using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class AnimTreeNodeSequence : BlendTreeNodeBlend<AnimTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0753142E;
	}
}

