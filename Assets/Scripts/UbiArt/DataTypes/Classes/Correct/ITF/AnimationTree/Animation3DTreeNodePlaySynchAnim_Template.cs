using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Animation3DTreeNodePlaySynchAnim_Template : BlendTreeNodeTemplate<Animation3DTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC28D5E91;
	}
}

