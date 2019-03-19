using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicTreeNodeSequence_Template : BlendTreeNodeBlend_Template<MusicTreeResult> {
		[Serialize("startingLeaf"     )] public uint startingLeaf;
		[Serialize("looping"          )] public int looping;
		[Serialize("useIntro"         )] public int useIntro;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startingLeaf));
			SerializeField(s, nameof(looping));
			SerializeField(s, nameof(useIntro));
		}
		public override uint? ClassCRC => 0xA7DEF63F;
	}
}

