using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimTree_Template : BlendTreeTemplate<AnimTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6A25A2FB;
	}
}

