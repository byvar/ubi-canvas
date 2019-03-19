using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicTreeNodeSequence : BlendTreeNodeBlend<MusicTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBDDE5D01;
	}
}

