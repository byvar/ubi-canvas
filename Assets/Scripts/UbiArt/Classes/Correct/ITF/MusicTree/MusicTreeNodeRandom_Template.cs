using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicTreeNodeRandom_Template : BlendTreeNodeBlend_Template<MusicTreeResult> {
		[Serialize("looping"          )] public int looping;
		[Serialize("startingLeaf"     )] public uint startingLeaf;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(looping));
			SerializeField(s, nameof(startingLeaf));
		}
		public override uint? ClassCRC => 0x4A769E62;
	}
}

