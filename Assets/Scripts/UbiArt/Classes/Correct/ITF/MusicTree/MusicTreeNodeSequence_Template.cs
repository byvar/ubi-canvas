using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class MusicTreeNodeSequence_Template : MusicTreeNode_Template {
		[Serialize("startingLeaf"     )] public uint startingLeaf;
		[Serialize("looping"          )] public bool looping;
		[Serialize("useIntro"         )] public bool useIntro;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(looping), boolAsByte: true);
				SerializeField(s, nameof(useIntro), boolAsByte: true);
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(looping));
				SerializeField(s, nameof(useIntro));
				SerializeField(s, nameof(pauseInsensitiveFlags));
			} else {
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(looping));
				SerializeField(s, nameof(useIntro));
			}
		}
		public override uint? ClassCRC => 0xA7DEF63F;
	}
}

