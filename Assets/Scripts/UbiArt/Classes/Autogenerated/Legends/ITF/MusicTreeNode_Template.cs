using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class MusicTreeNode_Template : BlendTreeNodeBlend_Template<MusicTreeResult> {
		[Serialize("pauseInsensitiveFlags")] public uint pauseInsensitiveFlags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pauseInsensitiveFlags));
		}
		public override uint? ClassCRC => 0xFE2667F1;
	}
}

