using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class MusicTreeNodeRandom_Template : MusicTreeNode_Template {
		[Serialize("looping"              )] public bool looping;
		[Serialize("startingLeaf"         )] public uint startingLeaf;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(looping), boolAsByte: true);
				SerializeField(s, nameof(startingLeaf));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(looping));
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(pauseInsensitiveFlags));
			} else {
				SerializeField(s, nameof(looping));
				SerializeField(s, nameof(startingLeaf));
			}
		}
		public override uint? ClassCRC => 0x4A769E62;
	}
}

